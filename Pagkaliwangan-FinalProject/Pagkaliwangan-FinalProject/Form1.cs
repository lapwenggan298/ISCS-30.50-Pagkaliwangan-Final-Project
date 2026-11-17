using System.Xml.Linq;
using System.Text.RegularExpressions;

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
            
            {

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
