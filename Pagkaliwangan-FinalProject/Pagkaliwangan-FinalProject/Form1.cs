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
            }
            // If unit is lbs
            else if (selectedWeightUnit == 1)
            {
                weightToUse = weightInput * 0.45359237;
            }
            else
            {
                MessageBox.Show("Please select a unit that is from the dropdown.", "Weight Unit Index Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWeightUnitBMI.Focus();
                return;
            }

            // BMI Calculation
            BMI = ((weightToUse)/(Math.Pow(heightToUse, 2)));

            lblBMIValue.Text = $"Your calculated BMI is: {BMI}";

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
