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
            tabCtrl1 = new TabControl();
            tabPgBMICalculator = new TabPage();
            tabPgUnitConverter = new TabPage();
            lblAppInfo = new Label();
            lblAppHeading = new Label();
            tabCtrl1.SuspendLayout();
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
            // tabCtrl1
            // 
            tabCtrl1.Controls.Add(tabPgBMICalculator);
            tabCtrl1.Controls.Add(tabPgUnitConverter);
            tabCtrl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCtrl1.Location = new Point(49, 121);
            tabCtrl1.Name = "tabCtrl1";
            tabCtrl1.RightToLeft = RightToLeft.No;
            tabCtrl1.SelectedIndex = 0;
            tabCtrl1.Size = new Size(1146, 710);
            tabCtrl1.TabIndex = 1;
            // 
            // tabPgBMICalculator
            // 
            tabPgBMICalculator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPgBMICalculator.Location = new Point(4, 34);
            tabPgBMICalculator.Name = "tabPgBMICalculator";
            tabPgBMICalculator.Padding = new Padding(3);
            tabPgBMICalculator.Size = new Size(1138, 672);
            tabPgBMICalculator.TabIndex = 0;
            tabPgBMICalculator.Text = "BMI Calculator";
            tabPgBMICalculator.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 926);
            Controls.Add(lblAppHeading);
            Controls.Add(lblAppInfo);
            Controls.Add(tabCtrl1);
            Controls.Add(btnQuitApp);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabCtrl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuitApp;
        private TabControl tabCtrl1;
        private TabPage tabPgBMICalculator;
        private TabPage tabPgUnitConverter;
        private Label lblAppInfo;
        private Label lblAppHeading;
    }
}
