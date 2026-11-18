using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace Pagkaliwangan_FinalProject
{
    public partial class Form1 : Form
    {
        private readonly String XMLFilePath = Path.Combine(Application.StartupPath, "word_guess.xml");

        // Word
        private ArrayList randomWordsList = new ArrayList();
        private ArrayList randomWordsUsed = new ArrayList();
        private string targetWord;

        // Randomizer
        private Random rand = new Random();

        // Attempts made or Current row
        private int attemptsMade = 0;

        // Label/Boxes UI
        private Label[,] gridOfLabels;
        private readonly Color colorGreen = Color.Green;
        private readonly Color colorYellow = Color.Yellow;
        private readonly Color colorGray = Color.Gray;
        private readonly Color defaultColor = Color.Gainsboro;

        public Form1()
        {
            InitializeComponent();
            gridOfLabels = new Label[6, 5];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfXMLExists();
            SetUpRowUI();
            GenerateRandomWords();
            targetWord = SelectWordToGuess();
            txtGuessInput_Focus(sender, e);
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
            txtGuessInput.Text = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    gridOfLabels[i, j].BackColor = defaultColor;
                    gridOfLabels[i, j].Text = "";
                }
            }

            lblHelperStatus.Text = "Type 5 letters and press or click ENTER";
            txtGuessInput.ReadOnly = false;
            txtGuessInput_Focus(sender, e);
        }

        private void txtGuessInput_Focus(object sender, EventArgs e)
        {
            txtGuessInput.Focus();
        }

        private void txtGuessInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (attemptsMade >= 6) return;

            if (txtGuessInput.ReadOnly == true) return;

            string wordInput = txtGuessInput.Text;

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (txtGuessInput.TextLength == 5)
                {
                    EvaluateGuess(wordInput);
                }
                else
                {
                    lblHelperStatus.Text = $"Not Enough Letters! You only wrote down {txtGuessInput.TextLength} letter/s. You are missing {5 - txtGuessInput.TextLength} letter/s.";
                }
            }
        }

        private void txtGuessInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (attemptsMade >= 6)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGuessInput_TextChanged(object sender, EventArgs e)
        {
            if (attemptsMade >= 6) return;

            UpdateRowUI();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string wordInput = txtGuessInput.Text;
            if (wordInput.Length < 5)
            {
                lblHelperStatus.Text = $"Not Enough Letters!  You only wrote down {txtGuessInput.TextLength} letter/s. You are missing {5 - txtGuessInput.TextLength} letter/s.";
                txtGuessInput_Focus(sender, e);
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

                // Check for exact letter matches (set to green)
                for (int i = 0; i < 5; i++)
                {
                    if (guessWordChars[i] == targetWordChars[i])
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
                        if (targetWordChars[j] == guessWordChars[i])
                        {
                            rowResult[i] = 'Y';
                            targetWordChars[i] = '\0';
                            found = true;
                            break;
                        }
                    }
                    // If not found in targetWord, set to X
                    if (!found) rowResult[i] = 'X';
                }

                // Colors
                int currentRow = attemptsMade;
                for (int i = 0; i < 5; i++)
                {
                    switch (rowResult[i])
                    {
                        case 'G':
                            gridOfLabels[currentRow, i].BackColor = colorGreen;
                            break;
                        case 'Y':
                            gridOfLabels[currentRow, i].BackColor = colorYellow;
                            break;
                        case 'X':
                            gridOfLabels[currentRow, i].BackColor = colorGray;
                            break;
                    }
                }

                // Check Win or Loss
                if (guess == targetWord)
                {
                    lblHelperStatus.Text = "You won! Game saved in word_guess.XML. Click the \"RESET/New Game\" to play again!";
                    txtGuessInput.ReadOnly = true;

                    CheckIfXMLExists();
                    // XML File Saving
                }
                else
                {
                    attemptsMade++;
                    txtGuessInput.Text = "";

                    if (attemptsMade == 6)
                    {
                        lblHelperStatus.Text = $"Game Over! The word was: {targetWord}. Click  the \"RESET/New Game\" to play again!";
                        txtGuessInput.ReadOnly = true;

                        CheckIfXMLExists();
                        // XML File Saving
                    }
                    else
                    {
                        UpdateRowUI();
                    }
                }
            }
            else
            {
                lblHelperStatus.Text = "You haven't written anything down!";
                txtGuessInput.Focus();
                return;
            }
        }

        private void SetUpRowUI()
        {   // Row 1
            gridOfLabels[0, 0] = lblR1C1;
            gridOfLabels[0, 1] = lblR1C2;
            gridOfLabels[0, 2] = lblR1C3;
            gridOfLabels[0, 3] = lblR1C4;
            gridOfLabels[0, 4] = lblR1C5;

            // Row 2
            gridOfLabels[1, 0] = lblR2C1;
            gridOfLabels[1, 1] = lblR2C2;
            gridOfLabels[1, 2] = lblR2C3;
            gridOfLabels[1, 3] = lblR2C4;
            gridOfLabels[1, 4] = lblR2C5;

            //Row 3
            gridOfLabels[2, 0] = lblR3C1;
            gridOfLabels[2, 1] = lblR3C2;
            gridOfLabels[2, 2] = lblR3C3;
            gridOfLabels[2, 3] = lblR3C4;
            gridOfLabels[2, 4] = lblR3C5;

            //Row 4
            gridOfLabels[3, 0] = lblR4C1;
            gridOfLabels[3, 1] = lblR4C2;
            gridOfLabels[3, 2] = lblR4C3;
            gridOfLabels[3, 3] = lblR4C4;
            gridOfLabels[3, 4] = lblR4C5;

            //Row 5
            gridOfLabels[4, 0] = lblR5C1;
            gridOfLabels[4, 1] = lblR5C2;
            gridOfLabels[4, 2] = lblR5C3;
            gridOfLabels[4, 3] = lblR5C4;
            gridOfLabels[4, 4] = lblR5C5;

            //Row 6
            gridOfLabels[5, 0] = lblR6C1;
            gridOfLabels[5, 1] = lblR6C2;
            gridOfLabels[5, 2] = lblR6C3;
            gridOfLabels[5, 3] = lblR6C4;
            gridOfLabels[5, 4] = lblR6C5;
        }

        // Update Rows UI when being receiving input.
        private void UpdateRowUI()
        {
            int currentRow = attemptsMade;
            string wordInput = txtGuessInput.Text;
            for (int column = 0; column < 5; column++)
            {
                if (column < wordInput.Length)
                {
                    gridOfLabels[currentRow, column].Text = wordInput[column].ToString();
                }
                else
                {
                    gridOfLabels[currentRow, column].Text = "";
                }
            }
        }
    }
}
