using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Security.Policy;

namespace Pagkaliwangan_FinalProject
{
    public partial class Form1 : Form
    {
        private readonly String XMLFilePath = Path.Combine(Application.StartupPath, "calculations.xml");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Default Units to Metric (i.e., cm and kg)
            cboWeightUnitBMI.SelectedIndex = 0;
            cboHeightUnitBMI.SelectedIndex = 0;

            cboWeightUnitConverter.SelectedIndex = 0;
            cboHeightUnitConverter.SelectedIndex = 0;

            CheckIfXMLExists();

        }

        private void CheckIfXMLExists()
        {
            if (!File.Exists(XMLFilePath))
            {
                XDocument newDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    //Calculations as Root node
                    //https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xdocument?view=net-10.0
                    new XElement("Calculations")
                );
                newDoc.Save(XMLFilePath);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var optionChosen = MessageBox.Show(
                "Are you sure you wish to quit the application?",
                "Quit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
            );

            if (optionChosen == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weightInput = (double) nudWeightBMI.Value;
            int selectedWeightUnit = cboWeightUnitBMI.SelectedIndex;

            int selectedHeightUnit = cboHeightUnitBMI.SelectedIndex;

            double heightToUse;
            double weightToUse;

            double BMI;

            string heightElement;
            string weightElement;

            string BMICategory;

            // Handle Height first.
            // If height unit is cm or inches
            if (selectedHeightUnit == 0 || selectedHeightUnit == 1)
            {
                if (!double.TryParse(txtHeightBMI.Text.Trim(), out double heightInput))
                {
                    MessageBox.Show("Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeightBMI.Focus();
                    return;
                }

                if (selectedHeightUnit == 0)
                {
                    heightElement = $"{heightInput:F2} centimeters";
                }
                else
                {
                    heightElement = $"{heightInput:F2} inches";
                }

                heightToUse = heightInput;
            }
            // If height unit is Feet and Inches
            else if(selectedHeightUnit == 2)
            {
                string heightInputString = txtHeightBMI.Text.Trim();

                //Find all numbers in the string (including decimals)
                MatchCollection numbers = Regex.Matches(heightInputString, @"\d+(\.\d+)?");

                if (numbers.Count == 0)
                {
                    MessageBox.Show("Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeightBMI.Focus();
                    return;
                }

                double feet = double.Parse(numbers[0].Value);
                // Set default value for inches
                double inches = 0;

                // If there is a 2nd number in the given Numbers[], the 2nd element is the inches.
                if (numbers.Count > 1)
                {
                    inches = double.Parse(numbers[1].Value);
                }

                double totalInches = (feet * 12) + inches;

                heightElement = $"{feet:F2} feet, {inches:F2} inches";

                heightToUse = totalInches;
            }
            else
            {
                MessageBox.Show("Please select a unit that is from the dropdown.", "Height Unit Index Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHeightUnitBMI.Focus();
                return;
            }

            // Convert height to centimeters from inches
            if (selectedHeightUnit == 1 || selectedHeightUnit == 2)
            {
                heightToUse = heightToUse * 2.54;
            }

            // Convert to meters for use in BMI formula.
            heightToUse = heightToUse * 0.01;

            // Weight Handling
            // If unit is kg
            if (selectedWeightUnit == 0)
            {
                weightToUse = weightInput;
                weightElement = $"{weightInput} kilograms";
            }
            // If unit is lbs
            else if (selectedWeightUnit == 1)
            {
                weightToUse = weightInput * 0.45359237;
                weightElement = $"{weightInput} pounds";
            }
            else
            {
                MessageBox.Show("Please select a unit that is from the dropdown.", "Weight Unit Index Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWeightUnitBMI.Focus();
                return;
            }

            // BMI Calculation
            BMI = ((weightToUse)/(Math.Pow(heightToUse, 2)));

            lblBMIValue.Text = $"Given the values you have inputted. Your calculated BMI is: {BMI}";

            // BMI categorization
            // Underweight
            if (BMI < 18.5)
            {
                lblBMICategory.Text = $"With a BMI of {BMI:F2}, you are considered underweight.";
                BMICategory = "Underweight";
            }
            // Healthy weight
            else if (18.5 <= BMI && BMI < 25)
            {
                lblBMICategory.Text = $"With a BMI of {BMI:F2}, you are considered to have a healthy weight.";
                BMICategory = "Healthy Weight";
            }
            // Overweight
            else if (25 <= BMI && BMI < 30)
            {
                lblBMICategory.Text = $"With a BMI of {BMI:F2}, you are considered overweight.";
                BMICategory = "Overweight";
            }
            // Obese
            else if (30 <= BMI)
            {
                lblBMICategory.Text = $"With a BMI of {BMI:F2}, you are considered obese";
                BMICategory = "Obese";
            }
            // Default or Invalid
            else
            {
                lblBMICategory.Text = $"Invalid BMI, or you do not fit the categories/cutoffs by WHO.";
                return;
            }            
            
            // Write Calculation to calculations.xml
            CheckIfXMLExists();
            XDocument doc = XDocument.Load(XMLFilePath);
            int calculationID = 1;
            var existingCalculations = doc.Root.Elements("Calculation").ToList();

            if (existingCalculations.Count > 0)
            {
                int maxID = 0;
                foreach (XElement element in existingCalculations)
                {
                    int currentID = (int) element.Attribute("Id");
                    if (currentID > maxID)
                    {
                        maxID = currentID;
                    }
                }
                calculationID = maxID + 1;
            }

            // Inside Calculations Root Node
            XElement calculationElement = new XElement("Calculation",
                new XAttribute("Id", calculationID),
                new XAttribute("Date", DateTime.Now.ToString("G"))
            );

            //Add Element inside Calculation node.
            calculationElement.Add( new XElement("BMI_Category", BMICategory,
                new XElement("BMI", BMI, 
                    new XElement("Height", heightElement),
                    new XElement("Weight", weightElement)
                )));

            doc.Root.Add( calculationElement );
            doc.Save(XMLFilePath);

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
