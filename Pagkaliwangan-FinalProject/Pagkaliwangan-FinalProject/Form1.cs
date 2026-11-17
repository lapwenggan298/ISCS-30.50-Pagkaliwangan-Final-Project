using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Pagkaliwangan_FinalProject
{
    public partial class Form1 : Form
    {
        private readonly String XMLFilePath = Path.Combine(Application.StartupPath, "word_guess.xml");

        public ArrayList randomWordsList = new ArrayList();
        public ArrayList randomWordsUsed = new ArrayList();
        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfXMLExists();
            GenerateRandomWords();
        }

        private void CheckIfXMLExists()
        {
            if (!File.Exists(XMLFilePath))
            {
                XDocument newDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    // Games as Root node
                    //https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xdocument?view=net-10.0
                    new XElement("Games")
                );
                newDoc.Save(XMLFilePath);
            }
        }

        // Set up randomWordsList with 30 words.
        private void GenerateRandomWords()
        {
            //0-9
            randomWordsList.Add("CYCLE");
            randomWordsList.Add("BOTOX");
            randomWordsList.Add("CREAM");
            randomWordsList.Add("FIGHT");
            randomWordsList.Add("DONUT");
            randomWordsList.Add("POUND");
            randomWordsList.Add("MOTOR");
            randomWordsList.Add("TROUT");
            randomWordsList.Add("ALPHA");
            randomWordsList.Add("OREOS");
            //10-19
            randomWordsList.Add("FUNNY");
            randomWordsList.Add("TRUNK");
            randomWordsList.Add("CLOWN");
            randomWordsList.Add("APPLE");
            randomWordsList.Add("LINIS");
            randomWordsList.Add("TOOTH");
            randomWordsList.Add("DILAG");
            randomWordsList.Add("PIECE");
            randomWordsList.Add("PEACE");
            randomWordsList.Add("BANAL");
            //20-29
            randomWordsList.Add("UMAGA");
            randomWordsList.Add("SIGLO");
            randomWordsList.Add("TRAIN");
            randomWordsList.Add("JEEPS");
            randomWordsList.Add("STARS");
            randomWordsList.Add("BUWAN");
            randomWordsList.Add("SIKLO");
            randomWordsList.Add("USWAG");
            randomWordsList.Add("SAPAT");
            randomWordsList.Add("GAMOT");
        }

        private String SelectWordToGuess()
        {
            if (randomWordsList.Count > 0)
            {
                int chosenIndex = rand.Next(randomWordsList.Count);

                string wordToGuess = (string) randomWordsList[chosenIndex];

                randomWordsUsed.Add(wordToGuess);
                randomWordsList.RemoveAt(chosenIndex);

                return wordToGuess;
            }
            else
            {
                // Reset/Regenerate randomWordsList
                GenerateRandomWords();
                
                return SelectWordToGuess();
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
    }
}
