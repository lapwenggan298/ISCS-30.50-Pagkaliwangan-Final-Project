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
            btnEnter = new Button();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(860, 566);
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
            txtGuessInput.Location = new Point(523, 766);
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
            lblGuessCaption.Location = new Point(481, 729);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 926);
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
    }
}

