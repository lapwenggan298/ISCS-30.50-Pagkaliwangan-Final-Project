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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnQuitApp = new Button();
            tabApp = new TabControl();
            tabPgBMICalculator = new TabPage();
            lblDisclaimer = new Label();
            lblHeightHintBMI = new Label();
            btnCalculate = new Button();
            lblBMICategory = new Label();
            lblBMICategoryCaption = new Label();
            lblBMIValue = new Label();
            lblBMIValueCaption = new Label();
            lblHeightUnitGuideBMI = new Label();
            cboHeightUnitBMI = new ComboBox();
            txtHeightBMI = new TextBox();
            lblHeightBMI = new Label();
            lblWeightGuideBMI = new Label();
            cboWeightUnitBMI = new ComboBox();
            lblWeightBMI = new Label();
            nudWeightBMI = new NumericUpDown();
            tabPgUnitConverter = new TabPage();
            lblHeightHintConverter = new Label();
            btnConvert = new Button();
            lblConvertedHeightValue = new Label();
            lblConvertedWeightValue = new Label();
            lblConvertedHeightCaption = new Label();
            lblConvertedWeightCaption = new Label();
            lblHeightUnitGuideConverter = new Label();
            cboHeightUnitConverter = new ComboBox();
            txtHeightConverter = new TextBox();
            lblHeightConverter = new Label();
            lblWeightGuideConverter = new Label();
            cboWeightUnitConverter = new ComboBox();
            lblWeightConverter = new Label();
            nudWeightConverter = new NumericUpDown();
            lblAppInfo = new Label();
            lblAppHeading = new Label();
            lblConverterNote = new Label();
            tabApp.SuspendLayout();
            tabPgBMICalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeightBMI).BeginInit();
            tabPgUnitConverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeightConverter).BeginInit();
            SuspendLayout();
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
            // tabApp
            // 
            tabApp.Controls.Add(tabPgBMICalculator);
            tabApp.Controls.Add(tabPgUnitConverter);
            tabApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabApp.Location = new Point(49, 121);
            tabApp.Name = "tabApp";
            tabApp.RightToLeft = RightToLeft.No;
            tabApp.SelectedIndex = 0;
            tabApp.Size = new Size(1146, 710);
            tabApp.TabIndex = 1;
            // 
            // tabPgBMICalculator
            // 
            tabPgBMICalculator.Controls.Add(lblDisclaimer);
            tabPgBMICalculator.Controls.Add(lblHeightHintBMI);
            tabPgBMICalculator.Controls.Add(btnCalculate);
            tabPgBMICalculator.Controls.Add(lblBMICategory);
            tabPgBMICalculator.Controls.Add(lblBMICategoryCaption);
            tabPgBMICalculator.Controls.Add(lblBMIValue);
            tabPgBMICalculator.Controls.Add(lblBMIValueCaption);
            tabPgBMICalculator.Controls.Add(lblHeightUnitGuideBMI);
            tabPgBMICalculator.Controls.Add(cboHeightUnitBMI);
            tabPgBMICalculator.Controls.Add(txtHeightBMI);
            tabPgBMICalculator.Controls.Add(lblHeightBMI);
            tabPgBMICalculator.Controls.Add(lblWeightGuideBMI);
            tabPgBMICalculator.Controls.Add(cboWeightUnitBMI);
            tabPgBMICalculator.Controls.Add(lblWeightBMI);
            tabPgBMICalculator.Controls.Add(nudWeightBMI);
            tabPgBMICalculator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPgBMICalculator.Location = new Point(4, 34);
            tabPgBMICalculator.Name = "tabPgBMICalculator";
            tabPgBMICalculator.Padding = new Padding(3);
            tabPgBMICalculator.Size = new Size(1138, 672);
            tabPgBMICalculator.TabIndex = 0;
            tabPgBMICalculator.Text = "BMI Calculator";
            tabPgBMICalculator.UseVisualStyleBackColor = true;
            // 
            // lblDisclaimer
            // 
            lblDisclaimer.AutoSize = true;
            lblDisclaimer.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisclaimer.Location = new Point(32, 561);
            lblDisclaimer.Name = "lblDisclaimer";
            lblDisclaimer.Size = new Size(929, 84);
            lblDisclaimer.TabIndex = 14;
            lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text");
            // 
            // lblHeightHintBMI
            // 
            lblHeightHintBMI.AutoSize = true;
            lblHeightHintBMI.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeightHintBMI.Location = new Point(645, 202);
            lblHeightHintBMI.Name = "lblHeightHintBMI";
            lblHeightHintBMI.Size = new Size(446, 50);
            lblHeightHintBMI.TabIndex = 13;
            lblHeightHintBMI.Text = "Format for Feet and Inches: 5 8 or 5' 8\"; \r\nFor others (i.e. inches, centimeters), just put the number.";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(951, 454);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 45);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblBMICategory
            // 
            lblBMICategory.AutoSize = true;
            lblBMICategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBMICategory.Location = new Point(84, 462);
            lblBMICategory.Name = "lblBMICategory";
            lblBMICategory.Size = new Size(177, 28);
            lblBMICategory.TabIndex = 11;
            lblBMICategory.Text = "Not Calculated Yet.";
            // 
            // lblBMICategoryCaption
            // 
            lblBMICategoryCaption.AutoSize = true;
            lblBMICategoryCaption.Location = new Point(32, 419);
            lblBMICategoryCaption.Name = "lblBMICategoryCaption";
            lblBMICategoryCaption.Size = new Size(178, 32);
            lblBMICategoryCaption.TabIndex = 10;
            lblBMICategoryCaption.Text = "BMI Category:";
            // 
            // lblBMIValue
            // 
            lblBMIValue.AutoSize = true;
            lblBMIValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBMIValue.Location = new Point(84, 380);
            lblBMIValue.Name = "lblBMIValue";
            lblBMIValue.Size = new Size(177, 28);
            lblBMIValue.TabIndex = 9;
            lblBMIValue.Text = "Not Calculated Yet.";
            // 
            // lblBMIValueCaption
            // 
            lblBMIValueCaption.AutoSize = true;
            lblBMIValueCaption.Location = new Point(32, 338);
            lblBMIValueCaption.Name = "lblBMIValueCaption";
            lblBMIValueCaption.Size = new Size(193, 32);
            lblBMIValueCaption.TabIndex = 8;
            lblBMIValueCaption.Text = "Calculated BMI:";
            // 
            // lblHeightUnitGuideBMI
            // 
            lblHeightUnitGuideBMI.AutoSize = true;
            lblHeightUnitGuideBMI.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeightUnitGuideBMI.Location = new Point(847, 123);
            lblHeightUnitGuideBMI.Name = "lblHeightUnitGuideBMI";
            lblHeightUnitGuideBMI.Size = new Size(66, 25);
            lblHeightUnitGuideBMI.TabIndex = 7;
            lblHeightUnitGuideBMI.Text = "Unit(s):";
            // 
            // cboHeightUnitBMI
            // 
            cboHeightUnitBMI.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeightUnitBMI.Font = new Font("Segoe UI", 11F);
            cboHeightUnitBMI.FormattingEnabled = true;
            cboHeightUnitBMI.Items.AddRange(new object[] { "Centimeters (cm)", "Inches (in)", "Feet & Inches (ft ' in\")" });
            cboHeightUnitBMI.Location = new Point(847, 158);
            cboHeightUnitBMI.Name = "cboHeightUnitBMI";
            cboHeightUnitBMI.Size = new Size(216, 38);
            cboHeightUnitBMI.TabIndex = 6;
            // 
            // txtHeightBMI
            // 
            txtHeightBMI.Font = new Font("Segoe UI", 11F);
            txtHeightBMI.Location = new Point(678, 160);
            txtHeightBMI.Name = "txtHeightBMI";
            txtHeightBMI.Size = new Size(150, 37);
            txtHeightBMI.TabIndex = 5;
            txtHeightBMI.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHeightBMI
            // 
            lblHeightBMI.AutoSize = true;
            lblHeightBMI.Location = new Point(645, 91);
            lblHeightBMI.Name = "lblHeightBMI";
            lblHeightBMI.Size = new Size(222, 32);
            lblHeightBMI.TabIndex = 4;
            lblHeightBMI.Text = "Input your height:";
            // 
            // lblWeightGuideBMI
            // 
            lblWeightGuideBMI.AutoSize = true;
            lblWeightGuideBMI.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWeightGuideBMI.Location = new Point(67, 123);
            lblWeightGuideBMI.Name = "lblWeightGuideBMI";
            lblWeightGuideBMI.Size = new Size(240, 25);
            lblWeightGuideBMI.TabIndex = 3;
            lblWeightGuideBMI.Text = "kg = kilograms; lbs = pounds";
            // 
            // cboWeightUnitBMI
            // 
            cboWeightUnitBMI.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWeightUnitBMI.Font = new Font("Segoe UI", 11F);
            cboWeightUnitBMI.FormattingEnabled = true;
            cboWeightUnitBMI.Items.AddRange(new object[] { "kg", "lbs" });
            cboWeightUnitBMI.Location = new Point(217, 159);
            cboWeightUnitBMI.Name = "cboWeightUnitBMI";
            cboWeightUnitBMI.Size = new Size(78, 38);
            cboWeightUnitBMI.TabIndex = 2;
            // 
            // lblWeightBMI
            // 
            lblWeightBMI.AutoSize = true;
            lblWeightBMI.Location = new Point(32, 91);
            lblWeightBMI.Name = "lblWeightBMI";
            lblWeightBMI.Size = new Size(227, 32);
            lblWeightBMI.TabIndex = 1;
            lblWeightBMI.Text = "Input your weight:";
            // 
            // nudWeightBMI
            // 
            nudWeightBMI.Font = new Font("Segoe UI", 11F);
            nudWeightBMI.Location = new Point(67, 160);
            nudWeightBMI.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWeightBMI.Name = "nudWeightBMI";
            nudWeightBMI.Size = new Size(131, 37);
            nudWeightBMI.TabIndex = 0;
            nudWeightBMI.TextAlign = HorizontalAlignment.Right;
            // 
            // tabPgUnitConverter
            // 
            tabPgUnitConverter.Controls.Add(lblConverterNote);
            tabPgUnitConverter.Controls.Add(lblHeightHintConverter);
            tabPgUnitConverter.Controls.Add(btnConvert);
            tabPgUnitConverter.Controls.Add(lblConvertedHeightValue);
            tabPgUnitConverter.Controls.Add(lblConvertedWeightValue);
            tabPgUnitConverter.Controls.Add(lblConvertedHeightCaption);
            tabPgUnitConverter.Controls.Add(lblConvertedWeightCaption);
            tabPgUnitConverter.Controls.Add(lblHeightUnitGuideConverter);
            tabPgUnitConverter.Controls.Add(cboHeightUnitConverter);
            tabPgUnitConverter.Controls.Add(txtHeightConverter);
            tabPgUnitConverter.Controls.Add(lblHeightConverter);
            tabPgUnitConverter.Controls.Add(lblWeightGuideConverter);
            tabPgUnitConverter.Controls.Add(cboWeightUnitConverter);
            tabPgUnitConverter.Controls.Add(lblWeightConverter);
            tabPgUnitConverter.Controls.Add(nudWeightConverter);
            tabPgUnitConverter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPgUnitConverter.Location = new Point(4, 34);
            tabPgUnitConverter.Name = "tabPgUnitConverter";
            tabPgUnitConverter.Padding = new Padding(3);
            tabPgUnitConverter.Size = new Size(1138, 672);
            tabPgUnitConverter.TabIndex = 1;
            tabPgUnitConverter.Text = "Unit Converter";
            tabPgUnitConverter.UseVisualStyleBackColor = true;
            // 
            // lblHeightHintConverter
            // 
            lblHeightHintConverter.AutoSize = true;
            lblHeightHintConverter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeightHintConverter.Location = new Point(662, 192);
            lblHeightHintConverter.Name = "lblHeightHintConverter";
            lblHeightHintConverter.Size = new Size(446, 50);
            lblHeightHintConverter.TabIndex = 21;
            lblHeightHintConverter.Text = "Format for Feet and Inches: 5 8 or 5' 8\"; \r\nFor others (i.e. inches, centimeters), just put the number.\r\n";
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(488, 537);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 45);
            btnConvert.TabIndex = 20;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblConvertedHeightValue
            // 
            lblConvertedHeightValue.AutoSize = true;
            lblConvertedHeightValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConvertedHeightValue.Location = new Point(771, 292);
            lblConvertedHeightValue.Name = "lblConvertedHeightValue";
            lblConvertedHeightValue.Size = new Size(134, 28);
            lblConvertedHeightValue.TabIndex = 19;
            lblConvertedHeightValue.Text = "No inputs yet.";
            // 
            // lblConvertedWeightValue
            // 
            lblConvertedWeightValue.AutoSize = true;
            lblConvertedWeightValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConvertedWeightValue.Location = new Point(128, 292);
            lblConvertedWeightValue.Name = "lblConvertedWeightValue";
            lblConvertedWeightValue.Size = new Size(134, 28);
            lblConvertedWeightValue.TabIndex = 18;
            lblConvertedWeightValue.Text = "No inputs yet.";
            // 
            // lblConvertedHeightCaption
            // 
            lblConvertedHeightCaption.AutoSize = true;
            lblConvertedHeightCaption.Location = new Point(723, 249);
            lblConvertedHeightCaption.Name = "lblConvertedHeightCaption";
            lblConvertedHeightCaption.Size = new Size(223, 32);
            lblConvertedHeightCaption.TabIndex = 17;
            lblConvertedHeightCaption.Text = "Converted Height:";
            // 
            // lblConvertedWeightCaption
            // 
            lblConvertedWeightCaption.AutoSize = true;
            lblConvertedWeightCaption.Location = new Point(79, 249);
            lblConvertedWeightCaption.Name = "lblConvertedWeightCaption";
            lblConvertedWeightCaption.Size = new Size(228, 32);
            lblConvertedWeightCaption.TabIndex = 16;
            lblConvertedWeightCaption.Text = "Converted Weight:";
            // 
            // lblHeightUnitGuideConverter
            // 
            lblHeightUnitGuideConverter.AutoSize = true;
            lblHeightUnitGuideConverter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeightUnitGuideConverter.Location = new Point(856, 114);
            lblHeightUnitGuideConverter.Name = "lblHeightUnitGuideConverter";
            lblHeightUnitGuideConverter.Size = new Size(66, 25);
            lblHeightUnitGuideConverter.TabIndex = 15;
            lblHeightUnitGuideConverter.Text = "Unit(s):";
            // 
            // cboHeightUnitConverter
            // 
            cboHeightUnitConverter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeightUnitConverter.Font = new Font("Segoe UI", 11F);
            cboHeightUnitConverter.FormattingEnabled = true;
            cboHeightUnitConverter.Items.AddRange(new object[] { "Centimeters (cm)", "Inches (in)", "Feet & Inches (ft ' in\")" });
            cboHeightUnitConverter.Location = new Point(856, 149);
            cboHeightUnitConverter.Name = "cboHeightUnitConverter";
            cboHeightUnitConverter.Size = new Size(219, 38);
            cboHeightUnitConverter.TabIndex = 14;
            // 
            // txtHeightConverter
            // 
            txtHeightConverter.Font = new Font("Segoe UI", 11F);
            txtHeightConverter.Location = new Point(690, 149);
            txtHeightConverter.Name = "txtHeightConverter";
            txtHeightConverter.Size = new Size(150, 37);
            txtHeightConverter.TabIndex = 13;
            txtHeightConverter.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHeightConverter
            // 
            lblHeightConverter.AutoSize = true;
            lblHeightConverter.Location = new Point(662, 82);
            lblHeightConverter.Name = "lblHeightConverter";
            lblHeightConverter.Size = new Size(162, 32);
            lblHeightConverter.TabIndex = 12;
            lblHeightConverter.Text = "Input height:";
            // 
            // lblWeightGuideConverter
            // 
            lblWeightGuideConverter.AutoSize = true;
            lblWeightGuideConverter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWeightGuideConverter.Location = new Point(79, 114);
            lblWeightGuideConverter.Name = "lblWeightGuideConverter";
            lblWeightGuideConverter.Size = new Size(240, 25);
            lblWeightGuideConverter.TabIndex = 11;
            lblWeightGuideConverter.Text = "kg = kilograms; lbs = pounds";
            // 
            // cboWeightUnitConverter
            // 
            cboWeightUnitConverter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWeightUnitConverter.Font = new Font("Segoe UI", 11F);
            cboWeightUnitConverter.FormattingEnabled = true;
            cboWeightUnitConverter.Items.AddRange(new object[] { "kg", "lbs" });
            cboWeightUnitConverter.Location = new Point(229, 150);
            cboWeightUnitConverter.Name = "cboWeightUnitConverter";
            cboWeightUnitConverter.Size = new Size(78, 38);
            cboWeightUnitConverter.TabIndex = 10;
            // 
            // lblWeightConverter
            // 
            lblWeightConverter.AutoSize = true;
            lblWeightConverter.Location = new Point(44, 82);
            lblWeightConverter.Name = "lblWeightConverter";
            lblWeightConverter.Size = new Size(167, 32);
            lblWeightConverter.TabIndex = 9;
            lblWeightConverter.Text = "Input weight:";
            // 
            // nudWeightConverter
            // 
            nudWeightConverter.Font = new Font("Segoe UI", 11F);
            nudWeightConverter.Location = new Point(79, 151);
            nudWeightConverter.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWeightConverter.Name = "nudWeightConverter";
            nudWeightConverter.Size = new Size(131, 37);
            nudWeightConverter.TabIndex = 8;
            nudWeightConverter.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAppInfo
            // 
            lblAppInfo.AutoSize = true;
            lblAppInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppInfo.Location = new Point(53, 90);
            lblAppInfo.Name = "lblAppInfo";
            lblAppInfo.Size = new Size(790, 28);
            lblAppInfo.TabIndex = 2;
            lblAppInfo.Text = "This application has a BMI Calculator, and a separate unit converter for weight and height.";
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
            // lblConverterNote
            // 
            lblConverterNote.AutoSize = true;
            lblConverterNote.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConverterNote.Location = new Point(30, 618);
            lblConverterNote.Name = "lblConverterNote";
            lblConverterNote.Size = new Size(977, 28);
            lblConverterNote.TabIndex = 22;
            lblConverterNote.Text = "NOTE: If you wish to just convert one (i.e., weight or height only), input 0 on the one you do not wish to convert.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 926);
            Controls.Add(lblAppHeading);
            Controls.Add(lblAppInfo);
            Controls.Add(tabApp);
            Controls.Add(btnQuitApp);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabApp.ResumeLayout(false);
            tabPgBMICalculator.ResumeLayout(false);
            tabPgBMICalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeightBMI).EndInit();
            tabPgUnitConverter.ResumeLayout(false);
            tabPgUnitConverter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeightConverter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuitApp;
        private TabControl tabApp;
        private TabPage tabPgBMICalculator;
        private TabPage tabPgUnitConverter;
        private Label lblAppInfo;
        private Label lblAppHeading;
        private Label lblWeightBMI;
        private NumericUpDown nudWeightBMI;
        private Label lblWeightGuideBMI;
        private ComboBox cboWeightUnitBMI;
        private Label lblHeightBMI;
        private TextBox txtHeightBMI;
        private ComboBox cboHeightUnitBMI;
        private Label lblHeightUnitGuideBMI;
        private Label lblBMIValueCaption;
        private Label lblBMICategoryCaption;
        private Label lblBMIValue;
        private Label lblBMICategory;
        private Button btnCalculate;
        private Label lblConvertedHeightCaption;
        private Label lblConvertedWeightCaption;
        private Label lblHeightUnitGuideConverter;
        private ComboBox cboHeightUnitConverter;
        private TextBox txtHeightConverter;
        private Label lblHeightConverter;
        private Label lblWeightGuideConverter;
        private ComboBox cboWeightUnitConverter;
        private Label lblWeightConverter;
        private NumericUpDown nudWeightConverter;
        private Label lblConvertedWeightValue;
        private Label lblConvertedHeightValue;
        private Button btnConvert;
        private Label lblHeightHintBMI;
        private Label lblHeightHintConverter;
        private Label lblDisclaimer;
        private Label lblConverterNote;
    }
}
