namespace Pagkaliwangan_FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnEnter;
            btnQuitApp = new Button();
            lblAppInfo = new Label();
            lblAppHeading = new Label();
            lblWordleTitle = new Label();
            lblHelperStatus = new Label();
            txtGuessInput = new TextBox();
            lblGuessCaption = new Label();
            btnReset = new Button();
            lblResetHelp = new Label();
            lblR1C1 = new Label();
            lblR1C2 = new Label();
            lblR1C4 = new Label();
            lblR1C3 = new Label();
            lblR1C5 = new Label();
            lblR2C5 = new Label();
            lblR2C4 = new Label();
            lblR2C3 = new Label();
            lblR2C2 = new Label();
            lblR2C1 = new Label();
            lblR4C5 = new Label();
            lblR4C4 = new Label();
            lblR4C3 = new Label();
            lblR4C2 = new Label();
            lblR4C1 = new Label();
            lblR3C5 = new Label();
            lblR3C4 = new Label();
            lblR3C3 = new Label();
            lblR3C2 = new Label();
            lblR3C1 = new Label();
            lblR5C5 = new Label();
            lblR5C4 = new Label();
            lblR5C3 = new Label();
            lblR5C2 = new Label();
            lblR5C1 = new Label();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(756, 572);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(87, 34);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnQuitApp
            // 
            btnQuitApp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitApp.Location = new Point(988, 851);
            btnQuitApp.Name = "btnQuitApp";
            btnQuitApp.Size = new Size(207, 41);
            btnQuitApp.TabIndex = 0;
            btnQuitApp.Text = "Quit Application";
            btnQuitApp.UseVisualStyleBackColor = true;
            btnQuitApp.Click += btnQuitApp_Click;
            // 
            // lblAppInfo
            // 
            lblAppInfo.AutoSize = true;
            lblAppInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppInfo.Location = new Point(63, 81);
            lblAppInfo.Name = "lblAppInfo";
            lblAppInfo.Size = new Size(1123, 28);
            lblAppInfo.TabIndex = 2;
            lblAppInfo.Text = "This application is a Wordle-like game, where you have 6 attempts to guess a 5 letter word. There are English and Filipino words.";
            // 
            // lblAppHeading
            // 
            lblAppHeading.AutoSize = true;
            lblAppHeading.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppHeading.Location = new Point(413, 33);
            lblAppHeading.Name = "lblAppHeading";
            lblAppHeading.Size = new Size(430, 28);
            lblAppHeading.TabIndex = 3;
            lblAppHeading.Text = "PAGKALIWANGAN - ISCS 30.50 Final Project";
            // 
            // lblWordleTitle
            // 
            lblWordleTitle.AutoSize = true;
            lblWordleTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWordleTitle.Location = new Point(493, 122);
            lblWordleTitle.Name = "lblWordleTitle";
            lblWordleTitle.Size = new Size(255, 32);
            lblWordleTitle.TabIndex = 5;
            lblWordleTitle.Text = "Fil-Eng Wordle Clone";
            // 
            // lblHelperStatus
            // 
            lblHelperStatus.AutoSize = true;
            lblHelperStatus.Location = new Point(63, 159);
            lblHelperStatus.Name = "lblHelperStatus";
            lblHelperStatus.Size = new Size(315, 25);
            lblHelperStatus.TabIndex = 6;
            lblHelperStatus.Text = "Type 5 letters and press or click ENTER";
            // 
            // txtGuessInput
            // 
            txtGuessInput.CharacterCasing = CharacterCasing.Upper;
            txtGuessInput.Location = new Point(538, 669);
            txtGuessInput.MaxLength = 5;
            txtGuessInput.Name = "txtGuessInput";
            txtGuessInput.Size = new Size(169, 31);
            txtGuessInput.TabIndex = 7;
            txtGuessInput.TextAlign = HorizontalAlignment.Center;
            txtGuessInput.KeyDown += txtGuessInput_KeyDown;
            // 
            // lblGuessCaption
            // 
            lblGuessCaption.AutoSize = true;
            lblGuessCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuessCaption.Location = new Point(482, 627);
            lblGuessCaption.Name = "lblGuessCaption";
            lblGuessCaption.Size = new Size(73, 25);
            lblGuessCaption.TabIndex = 8;
            lblGuessCaption.Text = "GUESS:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(131, 813);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(207, 34);
            btnReset.TabIndex = 9;
            btnReset.Text = "RESET/New Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblResetHelp
            // 
            lblResetHelp.AutoSize = true;
            lblResetHelp.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResetHelp.Location = new Point(63, 850);
            lblResetHelp.Name = "lblResetHelp";
            lblResetHelp.Size = new Size(376, 42);
            lblResetHelp.TabIndex = 10;
            lblResetHelp.Text = "NOTE: Your game will be saved \r\n(if you have run out of attempts or solved the puzzle)";
            // 
            // lblR1C1
            // 
            lblR1C1.AutoSize = true;
            lblR1C1.BackColor = Color.Gainsboro;
            lblR1C1.BorderStyle = BorderStyle.FixedSingle;
            lblR1C1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR1C1.ForeColor = Color.Black;
            lblR1C1.Location = new Point(451, 197);
            lblR1C1.MaximumSize = new Size(55, 55);
            lblR1C1.MinimumSize = new Size(55, 55);
            lblR1C1.Name = "lblR1C1";
            lblR1C1.Padding = new Padding(5);
            lblR1C1.Size = new Size(55, 55);
            lblR1C1.TabIndex = 11;
            lblR1C1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR1C2
            // 
            lblR1C2.AutoSize = true;
            lblR1C2.BackColor = Color.Gainsboro;
            lblR1C2.BorderStyle = BorderStyle.FixedSingle;
            lblR1C2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR1C2.ForeColor = Color.Black;
            lblR1C2.Location = new Point(524, 197);
            lblR1C2.MaximumSize = new Size(55, 55);
            lblR1C2.MinimumSize = new Size(55, 55);
            lblR1C2.Name = "lblR1C2";
            lblR1C2.Padding = new Padding(5);
            lblR1C2.Size = new Size(55, 55);
            lblR1C2.TabIndex = 12;
            lblR1C2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR1C4
            // 
            lblR1C4.AutoSize = true;
            lblR1C4.BackColor = Color.Gainsboro;
            lblR1C4.BorderStyle = BorderStyle.FixedSingle;
            lblR1C4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR1C4.ForeColor = Color.Black;
            lblR1C4.Location = new Point(669, 197);
            lblR1C4.MaximumSize = new Size(55, 55);
            lblR1C4.MinimumSize = new Size(55, 55);
            lblR1C4.Name = "lblR1C4";
            lblR1C4.Padding = new Padding(5);
            lblR1C4.Size = new Size(55, 55);
            lblR1C4.TabIndex = 14;
            lblR1C4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR1C3
            // 
            lblR1C3.AutoSize = true;
            lblR1C3.BackColor = Color.Gainsboro;
            lblR1C3.BorderStyle = BorderStyle.FixedSingle;
            lblR1C3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR1C3.ForeColor = Color.Black;
            lblR1C3.Location = new Point(598, 197);
            lblR1C3.MaximumSize = new Size(55, 55);
            lblR1C3.MinimumSize = new Size(55, 55);
            lblR1C3.Name = "lblR1C3";
            lblR1C3.Padding = new Padding(5);
            lblR1C3.Size = new Size(55, 55);
            lblR1C3.TabIndex = 13;
            lblR1C3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR1C5
            // 
            lblR1C5.AutoSize = true;
            lblR1C5.BackColor = Color.Gainsboro;
            lblR1C5.BorderStyle = BorderStyle.FixedSingle;
            lblR1C5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR1C5.ForeColor = Color.Black;
            lblR1C5.Location = new Point(741, 197);
            lblR1C5.MaximumSize = new Size(55, 55);
            lblR1C5.MinimumSize = new Size(55, 55);
            lblR1C5.Name = "lblR1C5";
            lblR1C5.Padding = new Padding(5);
            lblR1C5.Size = new Size(55, 55);
            lblR1C5.TabIndex = 15;
            lblR1C5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR2C5
            // 
            lblR2C5.AutoSize = true;
            lblR2C5.BackColor = Color.Gainsboro;
            lblR2C5.BorderStyle = BorderStyle.FixedSingle;
            lblR2C5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR2C5.ForeColor = Color.Black;
            lblR2C5.Location = new Point(741, 267);
            lblR2C5.MaximumSize = new Size(55, 55);
            lblR2C5.MinimumSize = new Size(55, 55);
            lblR2C5.Name = "lblR2C5";
            lblR2C5.Padding = new Padding(5);
            lblR2C5.Size = new Size(55, 55);
            lblR2C5.TabIndex = 20;
            lblR2C5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR2C4
            // 
            lblR2C4.AutoSize = true;
            lblR2C4.BackColor = Color.Gainsboro;
            lblR2C4.BorderStyle = BorderStyle.FixedSingle;
            lblR2C4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR2C4.ForeColor = Color.Black;
            lblR2C4.Location = new Point(669, 267);
            lblR2C4.MaximumSize = new Size(55, 55);
            lblR2C4.MinimumSize = new Size(55, 55);
            lblR2C4.Name = "lblR2C4";
            lblR2C4.Padding = new Padding(5);
            lblR2C4.Size = new Size(55, 55);
            lblR2C4.TabIndex = 19;
            lblR2C4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR2C3
            // 
            lblR2C3.AutoSize = true;
            lblR2C3.BackColor = Color.Gainsboro;
            lblR2C3.BorderStyle = BorderStyle.FixedSingle;
            lblR2C3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR2C3.ForeColor = Color.Black;
            lblR2C3.Location = new Point(598, 267);
            lblR2C3.MaximumSize = new Size(55, 55);
            lblR2C3.MinimumSize = new Size(55, 55);
            lblR2C3.Name = "lblR2C3";
            lblR2C3.Padding = new Padding(5);
            lblR2C3.Size = new Size(55, 55);
            lblR2C3.TabIndex = 18;
            lblR2C3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR2C2
            // 
            lblR2C2.AutoSize = true;
            lblR2C2.BackColor = Color.Gainsboro;
            lblR2C2.BorderStyle = BorderStyle.FixedSingle;
            lblR2C2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR2C2.ForeColor = Color.Black;
            lblR2C2.Location = new Point(524, 267);
            lblR2C2.MaximumSize = new Size(55, 55);
            lblR2C2.MinimumSize = new Size(55, 55);
            lblR2C2.Name = "lblR2C2";
            lblR2C2.Padding = new Padding(5);
            lblR2C2.Size = new Size(55, 55);
            lblR2C2.TabIndex = 17;
            lblR2C2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR2C1
            // 
            lblR2C1.AutoSize = true;
            lblR2C1.BackColor = Color.Gainsboro;
            lblR2C1.BorderStyle = BorderStyle.FixedSingle;
            lblR2C1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR2C1.ForeColor = Color.Black;
            lblR2C1.Location = new Point(451, 267);
            lblR2C1.MaximumSize = new Size(55, 55);
            lblR2C1.MinimumSize = new Size(55, 55);
            lblR2C1.Name = "lblR2C1";
            lblR2C1.Padding = new Padding(5);
            lblR2C1.Size = new Size(55, 55);
            lblR2C1.TabIndex = 16;
            lblR2C1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR4C5
            // 
            lblR4C5.AutoSize = true;
            lblR4C5.BackColor = Color.Gainsboro;
            lblR4C5.BorderStyle = BorderStyle.FixedSingle;
            lblR4C5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR4C5.ForeColor = Color.Black;
            lblR4C5.Location = new Point(741, 409);
            lblR4C5.MaximumSize = new Size(55, 55);
            lblR4C5.MinimumSize = new Size(55, 55);
            lblR4C5.Name = "lblR4C5";
            lblR4C5.Padding = new Padding(5);
            lblR4C5.Size = new Size(55, 55);
            lblR4C5.TabIndex = 30;
            lblR4C5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR4C4
            // 
            lblR4C4.AutoSize = true;
            lblR4C4.BackColor = Color.Gainsboro;
            lblR4C4.BorderStyle = BorderStyle.FixedSingle;
            lblR4C4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR4C4.ForeColor = Color.Black;
            lblR4C4.Location = new Point(669, 409);
            lblR4C4.MaximumSize = new Size(55, 55);
            lblR4C4.MinimumSize = new Size(55, 55);
            lblR4C4.Name = "lblR4C4";
            lblR4C4.Padding = new Padding(5);
            lblR4C4.Size = new Size(55, 55);
            lblR4C4.TabIndex = 29;
            lblR4C4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR4C3
            // 
            lblR4C3.AutoSize = true;
            lblR4C3.BackColor = Color.Gainsboro;
            lblR4C3.BorderStyle = BorderStyle.FixedSingle;
            lblR4C3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR4C3.ForeColor = Color.Black;
            lblR4C3.Location = new Point(598, 409);
            lblR4C3.MaximumSize = new Size(55, 55);
            lblR4C3.MinimumSize = new Size(55, 55);
            lblR4C3.Name = "lblR4C3";
            lblR4C3.Padding = new Padding(5);
            lblR4C3.Size = new Size(55, 55);
            lblR4C3.TabIndex = 28;
            lblR4C3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR4C2
            // 
            lblR4C2.AutoSize = true;
            lblR4C2.BackColor = Color.Gainsboro;
            lblR4C2.BorderStyle = BorderStyle.FixedSingle;
            lblR4C2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR4C2.ForeColor = Color.Black;
            lblR4C2.Location = new Point(524, 409);
            lblR4C2.MaximumSize = new Size(55, 55);
            lblR4C2.MinimumSize = new Size(55, 55);
            lblR4C2.Name = "lblR4C2";
            lblR4C2.Padding = new Padding(5);
            lblR4C2.Size = new Size(55, 55);
            lblR4C2.TabIndex = 27;
            lblR4C2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR4C1
            // 
            lblR4C1.AutoSize = true;
            lblR4C1.BackColor = Color.Gainsboro;
            lblR4C1.BorderStyle = BorderStyle.FixedSingle;
            lblR4C1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR4C1.ForeColor = Color.Black;
            lblR4C1.Location = new Point(451, 409);
            lblR4C1.MaximumSize = new Size(55, 55);
            lblR4C1.MinimumSize = new Size(55, 55);
            lblR4C1.Name = "lblR4C1";
            lblR4C1.Padding = new Padding(5);
            lblR4C1.Size = new Size(55, 55);
            lblR4C1.TabIndex = 26;
            lblR4C1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR3C5
            // 
            lblR3C5.AutoSize = true;
            lblR3C5.BackColor = Color.Gainsboro;
            lblR3C5.BorderStyle = BorderStyle.FixedSingle;
            lblR3C5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR3C5.ForeColor = Color.Black;
            lblR3C5.Location = new Point(741, 339);
            lblR3C5.MaximumSize = new Size(55, 55);
            lblR3C5.MinimumSize = new Size(55, 55);
            lblR3C5.Name = "lblR3C5";
            lblR3C5.Padding = new Padding(5);
            lblR3C5.Size = new Size(55, 55);
            lblR3C5.TabIndex = 25;
            lblR3C5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR3C4
            // 
            lblR3C4.AutoSize = true;
            lblR3C4.BackColor = Color.Gainsboro;
            lblR3C4.BorderStyle = BorderStyle.FixedSingle;
            lblR3C4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR3C4.ForeColor = Color.Black;
            lblR3C4.Location = new Point(669, 339);
            lblR3C4.MaximumSize = new Size(55, 55);
            lblR3C4.MinimumSize = new Size(55, 55);
            lblR3C4.Name = "lblR3C4";
            lblR3C4.Padding = new Padding(5);
            lblR3C4.Size = new Size(55, 55);
            lblR3C4.TabIndex = 24;
            lblR3C4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR3C3
            // 
            lblR3C3.AutoSize = true;
            lblR3C3.BackColor = Color.Gainsboro;
            lblR3C3.BorderStyle = BorderStyle.FixedSingle;
            lblR3C3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR3C3.ForeColor = Color.Black;
            lblR3C3.Location = new Point(598, 339);
            lblR3C3.MaximumSize = new Size(55, 55);
            lblR3C3.MinimumSize = new Size(55, 55);
            lblR3C3.Name = "lblR3C3";
            lblR3C3.Padding = new Padding(5);
            lblR3C3.Size = new Size(55, 55);
            lblR3C3.TabIndex = 23;
            lblR3C3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR3C2
            // 
            lblR3C2.AutoSize = true;
            lblR3C2.BackColor = Color.Gainsboro;
            lblR3C2.BorderStyle = BorderStyle.FixedSingle;
            lblR3C2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR3C2.ForeColor = Color.Black;
            lblR3C2.Location = new Point(524, 339);
            lblR3C2.MaximumSize = new Size(55, 55);
            lblR3C2.MinimumSize = new Size(55, 55);
            lblR3C2.Name = "lblR3C2";
            lblR3C2.Padding = new Padding(5);
            lblR3C2.Size = new Size(55, 55);
            lblR3C2.TabIndex = 22;
            lblR3C2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR3C1
            // 
            lblR3C1.AutoSize = true;
            lblR3C1.BackColor = Color.Gainsboro;
            lblR3C1.BorderStyle = BorderStyle.FixedSingle;
            lblR3C1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR3C1.ForeColor = Color.Black;
            lblR3C1.Location = new Point(451, 339);
            lblR3C1.MaximumSize = new Size(55, 55);
            lblR3C1.MinimumSize = new Size(55, 55);
            lblR3C1.Name = "lblR3C1";
            lblR3C1.Padding = new Padding(5);
            lblR3C1.Size = new Size(55, 55);
            lblR3C1.TabIndex = 21;
            lblR3C1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR5C5
            // 
            lblR5C5.AutoSize = true;
            lblR5C5.BackColor = Color.Gainsboro;
            lblR5C5.BorderStyle = BorderStyle.FixedSingle;
            lblR5C5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR5C5.ForeColor = Color.Black;
            lblR5C5.Location = new Point(741, 480);
            lblR5C5.MaximumSize = new Size(55, 55);
            lblR5C5.MinimumSize = new Size(55, 55);
            lblR5C5.Name = "lblR5C5";
            lblR5C5.Padding = new Padding(5);
            lblR5C5.Size = new Size(55, 55);
            lblR5C5.TabIndex = 35;
            lblR5C5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR5C4
            // 
            lblR5C4.AutoSize = true;
            lblR5C4.BackColor = Color.Gainsboro;
            lblR5C4.BorderStyle = BorderStyle.FixedSingle;
            lblR5C4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR5C4.ForeColor = Color.Black;
            lblR5C4.Location = new Point(669, 480);
            lblR5C4.MaximumSize = new Size(55, 55);
            lblR5C4.MinimumSize = new Size(55, 55);
            lblR5C4.Name = "lblR5C4";
            lblR5C4.Padding = new Padding(5);
            lblR5C4.Size = new Size(55, 55);
            lblR5C4.TabIndex = 34;
            lblR5C4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR5C3
            // 
            lblR5C3.AutoSize = true;
            lblR5C3.BackColor = Color.Gainsboro;
            lblR5C3.BorderStyle = BorderStyle.FixedSingle;
            lblR5C3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR5C3.ForeColor = Color.Black;
            lblR5C3.Location = new Point(598, 480);
            lblR5C3.MaximumSize = new Size(55, 55);
            lblR5C3.MinimumSize = new Size(55, 55);
            lblR5C3.Name = "lblR5C3";
            lblR5C3.Padding = new Padding(5);
            lblR5C3.Size = new Size(55, 55);
            lblR5C3.TabIndex = 33;
            lblR5C3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR5C2
            // 
            lblR5C2.AutoSize = true;
            lblR5C2.BackColor = Color.Gainsboro;
            lblR5C2.BorderStyle = BorderStyle.FixedSingle;
            lblR5C2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR5C2.ForeColor = Color.Black;
            lblR5C2.Location = new Point(524, 480);
            lblR5C2.MaximumSize = new Size(55, 55);
            lblR5C2.MinimumSize = new Size(55, 55);
            lblR5C2.Name = "lblR5C2";
            lblR5C2.Padding = new Padding(5);
            lblR5C2.Size = new Size(55, 55);
            lblR5C2.TabIndex = 32;
            lblR5C2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblR5C1
            // 
            lblR5C1.AutoSize = true;
            lblR5C1.BackColor = Color.Gainsboro;
            lblR5C1.BorderStyle = BorderStyle.FixedSingle;
            lblR5C1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblR5C1.ForeColor = Color.Black;
            lblR5C1.Location = new Point(451, 480);
            lblR5C1.MaximumSize = new Size(55, 55);
            lblR5C1.MinimumSize = new Size(55, 55);
            lblR5C1.Name = "lblR5C1";
            lblR5C1.Padding = new Padding(5);
            lblR5C1.Size = new Size(55, 55);
            lblR5C1.TabIndex = 31;
            lblR5C1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 926);
            Controls.Add(lblR5C5);
            Controls.Add(lblR5C4);
            Controls.Add(lblR5C3);
            Controls.Add(lblR5C2);
            Controls.Add(lblR5C1);
            Controls.Add(lblR4C5);
            Controls.Add(lblR4C4);
            Controls.Add(lblR4C3);
            Controls.Add(lblR4C2);
            Controls.Add(lblR4C1);
            Controls.Add(lblR3C5);
            Controls.Add(lblR3C4);
            Controls.Add(lblR3C3);
            Controls.Add(lblR3C2);
            Controls.Add(lblR3C1);
            Controls.Add(lblR2C5);
            Controls.Add(lblR2C4);
            Controls.Add(lblR2C3);
            Controls.Add(lblR2C2);
            Controls.Add(lblR2C1);
            Controls.Add(lblR1C5);
            Controls.Add(lblR1C4);
            Controls.Add(lblR1C3);
            Controls.Add(lblR1C2);
            Controls.Add(lblR1C1);
            Controls.Add(lblResetHelp);
            Controls.Add(btnReset);
            Controls.Add(lblGuessCaption);
            Controls.Add(txtGuessInput);
            Controls.Add(lblHelperStatus);
            Controls.Add(lblWordleTitle);
            Controls.Add(btnEnter);
            Controls.Add(lblAppHeading);
            Controls.Add(lblAppInfo);
            Controls.Add(btnQuitApp);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += txtGuessInput_Focus;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuitApp;
        private Label lblAppInfo;
        private Label lblAppHeading;
        private Button btnEnter;
        private Label lblWordleTitle;
        private Label lblHelperStatus;
        private TextBox txtGuessInput;
        private Label lblGuessCaption;
        private Button btnReset;
        private Label lblResetHelp;
        private Label lblR1C1;
        private Label lblR1C2;
        private Label lblR1C4;
        private Label lblR1C3;
        private Label lblR1C5;
        private Label lblR2C5;
        private Label lblR2C4;
        private Label lblR2C3;
        private Label lblR2C2;
        private Label lblR2C1;
        private Label lblR4C5;
        private Label lblR4C4;
        private Label lblR4C3;
        private Label lblR4C2;
        private Label lblR4C1;
        private Label lblR3C5;
        private Label lblR3C4;
        private Label lblR3C3;
        private Label lblR3C2;
        private Label lblR3C1;
        private Label lblR5C5;
        private Label lblR5C4;
        private Label lblR5C3;
        private Label lblR5C2;
        private Label lblR5C1;
    }
}

