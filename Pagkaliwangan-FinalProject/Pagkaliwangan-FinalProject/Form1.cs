using System.Collections;
using System.Xml.Linq;

namespace Pagkaliwangan_FinalProject
{
    public partial class Form1 : Form
    {
        private readonly String XMLFilePath = Path.Combine(Application.StartupPath, "word_guess.xml");

        public ArrayList randomWordsList = new ArrayList();
        public ArrayList randomWordsUsed = new ArrayList();
        public Random rand = new Random();
        public string targetWord;
        public int attemptsMade = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfXMLExists();
            GenerateRandomWords();
            targetWord = SelectWordToGuess();
            txtGuessInput.Focus();
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

                string wordToGuess = (string)randomWordsList[chosenIndex];

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            targetWord = SelectWordToGuess();
            attemptsMade = 0;
            lblHelperStatus.Text = "Type 5 letters and press or click ENTER";
            txtGuessInput.Focus();
        }

        private void txtGuessInput_KeyDown(object sender, KeyEventArgs e)
        {
            string wordInput = txtGuessInput.Text;
            if (e.KeyCode == Keys.Back)
            { 
            }
            if (e.KeyCode == Keys.Enter) 
            {
                if (txtGuessInput.TextLength == 5)
                {
                    EvaluateGuess(wordInput);
                }
                else
                {
                    lblHelperStatus.Text = "Not Enough Letters";
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string wordInput = txtGuessInput.Text;
            if (wordInput.Length < 5)
            {
                lblHelperStatus.Text = "Not Enough Letters";
                txtGuessInput.Focus();
                return;
            }
            EvaluateGuess(wordInput);
        }

        private void EvaluateGuess(String guess)
        {
            if (!string.IsNullOrEmpty(guess))
            {
                char[] targetWordChars = targetWord.ToCharArray();
                char[] guessWordChars = guess.ToCharArray();
                char[] rowResult = new char[5]; // For Row of squares to be set to G for green, Y/O for yellow/orange, X for gray

                CheckIfXMLExists();

                // Check for exact letter matches (set to green)
                for (int i = 0; i < 5; i++)
                {
                    if(guessWordChars[i] == targetWordChars[i])
                    {
                        rowResult[i] = 'G';
                        targetWordChars[i] = '\0';
                    }
                }

                // Check for misplaced letters (set to yellow or orange) and wrong letters (set to gray)
                for (int i = 0; i < 5; i++)
                {
                    if (rowResult[i] == 'G') continue;

                    bool found = false;
                    for (int j = 0; j < 5; j++)
                    {
                        rowResult[i] = 'Y';
                        targetWordChars[i] = '\0';
                        found = true;
                        break;
                    }
                    // If not found in targetWord, set to X
                    if (!found) rowResult[i] = 'X';
                }

                // Check Win or Loss
                if (guess == targetWord)
                {
                    lblHelperStatus.Text = "You won! Game saved in word_guess.XML. Click the \"RESET/New Game\" to play again!";
                }
                else
                {
                    attemptsMade++;
                    txtGuessInput.Text = "";

                    if (attemptsMade == 6)
                    {
                        lblHelperStatus.Text = $"Game Over! The word was: {targetWord}. Click  the \"RESET/New Game\" to play again!";
                    }
                    else
                    {

                    }
                }

                // XML File Saving
            }
        }

        // Update Rows UI
        private void UpdateRowUI()
        {
            int currentRow = attemptsMade;
            for (int column = 0; column < 5; column++)
            {

            }
        }
    }
}
