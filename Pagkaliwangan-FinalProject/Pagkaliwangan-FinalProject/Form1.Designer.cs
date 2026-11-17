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
            btnQuitApp = new Button();
            tabApp = new TabControl();
            tabPgBMICalculator = new TabPage();
            cboHeightBMI = new ComboBox();
            txtHeightBMI = new TextBox();
            lblHeightBMI = new Label();
            lblWeightGuideBMI = new Label();
            cboWeightUnitBMI = new ComboBox();
            lblWeightBMI = new Label();
            nudWeightBMI = new NumericUpDown();
            tabPgUnitConverter = new TabPage();
            lblAppInfo = new Label();
            lblAppHeading = new Label();
            lblHeightUnitGuideBMI = new Label();
            lblBMIValueCaption = new Label();
            lblBMIValue = new Label();
            lblBMICategoryCaption = new Label();
            lblBMICategory = new Label();
            btnCalculate = new Button();
            tabApp.SuspendLayout();
            tabPgBMICalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeightBMI).BeginInit();
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
            tabPgBMICalculator.Controls.Add(btnCalculate);
            tabPgBMICalculator.Controls.Add(lblBMICategory);
            tabPgBMICalculator.Controls.Add(lblBMICategoryCaption);
            tabPgBMICalculator.Controls.Add(lblBMIValue);
            tabPgBMICalculator.Controls.Add(lblBMIValueCaption);
            tabPgBMICalculator.Controls.Add(lblHeightUnitGuideBMI);
            tabPgBMICalculator.Controls.Add(cboHeightBMI);
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
            // cboHeightBMI
            // 
            cboHeightBMI.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeightBMI.FormattingEnabled = true;
            cboHeightBMI.Items.AddRange(new object[] { "Centimeters (cm)", "Inches (in)", "Feet & Inches (ft ' in\")" });
            cboHeightBMI.Location = new Point(881, 158);
            cboHeightBMI.Name = "cboHeightBMI";
            cboHeightBMI.Size = new Size(182, 40);
            cboHeightBMI.TabIndex = 6;
            // 
            // txtHeightBMI
            // 
            txtHeightBMI.Location = new Point(711, 159);
            txtHeightBMI.Name = "txtHeightBMI";
            txtHeightBMI.Size = new Size(150, 39);
            txtHeightBMI.TabIndex = 5;
            txtHeightBMI.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHeightBMI
            // 
            lblHeightBMI.AutoSize = true;
            lblHeightBMI.Location = new Point(678, 91);
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
            cboWeightUnitBMI.FormattingEnabled = true;
            cboWeightUnitBMI.Items.AddRange(new object[] { "Kilograms (Kg)", "Pounds (lbs)" });
            cboWeightUnitBMI.Location = new Point(217, 159);
            cboWeightUnitBMI.Name = "cboWeightUnitBMI";
            cboWeightUnitBMI.Size = new Size(78, 40);
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
            nudWeightBMI.Location = new Point(67, 160);
            nudWeightBMI.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWeightBMI.Name = "nudWeightBMI";
            nudWeightBMI.Size = new Size(131, 39);
            nudWeightBMI.TabIndex = 0;
            nudWeightBMI.TextAlign = HorizontalAlignment.Right;
            // 
            // tabPgUnitConverter
            // 
            tabPgUnitConverter.Location = new Point(4, 34);
            tabPgUnitConverter.Name = "tabPgUnitConverter";
            tabPgUnitConverter.Padding = new Padding(3);
            tabPgUnitConverter.Size = new Size(1138, 672);
            tabPgUnitConverter.TabIndex = 1;
            tabPgUnitConverter.Text = "Unit Converter";
            tabPgUnitConverter.UseVisualStyleBackColor = true;
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
            // lblHeightUnitGuideBMI
            // 
            lblHeightUnitGuideBMI.AutoSize = true;
            lblHeightUnitGuideBMI.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeightUnitGuideBMI.Location = new Point(881, 123);
            lblHeightUnitGuideBMI.Name = "lblHeightUnitGuideBMI";
            lblHeightUnitGuideBMI.Size = new Size(66, 25);
            lblHeightUnitGuideBMI.TabIndex = 7;
            lblHeightUnitGuideBMI.Text = "Unit(s):";
            // 
            // lblBMIValueCaption
            // 
            lblBMIValueCaption.AutoSize = true;
            lblBMIValueCaption.Location = new Point(360, 325);
            lblBMIValueCaption.Name = "lblBMIValueCaption";
            lblBMIValueCaption.Size = new Size(193, 32);
            lblBMIValueCaption.TabIndex = 8;
            lblBMIValueCaption.Text = "Calculated BMI:";
            // 
            // lblBMIValue
            // 
            lblBMIValue.AutoSize = true;
            lblBMIValue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBMIValue.Location = new Point(412, 367);
            lblBMIValue.Name = "lblBMIValue";
            lblBMIValue.Size = new Size(177, 28);
            lblBMIValue.TabIndex = 9;
            lblBMIValue.Text = "Not Calculated Yet.";
            // 
            // lblBMICategoryCaption
            // 
            lblBMICategoryCaption.AutoSize = true;
            lblBMICategoryCaption.Location = new Point(360, 406);
            lblBMICategoryCaption.Name = "lblBMICategoryCaption";
            lblBMICategoryCaption.Size = new Size(178, 32);
            lblBMICategoryCaption.TabIndex = 10;
            lblBMICategoryCaption.Text = "BMI Category:";
            // 
            // lblBMICategory
            // 
            lblBMICategory.AutoSize = true;
            lblBMICategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBMICategory.Location = new Point(412, 449);
            lblBMICategory.Name = "lblBMICategory";
            lblBMICategory.Size = new Size(177, 28);
            lblBMICategory.TabIndex = 11;
            lblBMICategory.Text = "Not Calculated Yet.";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(981, 600);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 45);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
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
        private ComboBox cboHeightBMI;
        private Label lblHeightUnitGuideBMI;
        private Label lblBMIValueCaption;
        private Label lblBMICategoryCaption;
        private Label lblBMIValue;
        private Label lblBMICategory;
        private Button btnCalculate;
    }
}
