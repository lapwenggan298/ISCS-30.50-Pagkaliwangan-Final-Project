using System.Xml.Linq;

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
            CheckIfXMLExists();
        }

        private void CheckIfXMLExists()
        {
            if (!File.Exists(XMLFilePath))
            {
                XDocument newDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    //Calcuulations as Root node
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

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
