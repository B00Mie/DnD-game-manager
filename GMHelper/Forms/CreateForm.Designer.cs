using Common.Base;
using Common.Enums;

namespace GMHelper.Forms
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cbRace = new ComboBox();
            label3 = new Label();
            txtCharacterName = new TextBox();
            lblCharacterName = new Label();
            lblRace = new Label();
            label5 = new Label();
            lblStrength = new Label();
            lblAgility = new Label();
            lblIntelligence = new Label();
            lblUtility = new Label();
            lblStrengthVal = new Label();
            lblIntelligenceVal = new Label();
            lblAgilityVal = new Label();
            lblUtilityVal = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 0;
            label1.Text = "Create Character";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 68);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Select Race:";
            // 
            // cbRace
            // 
            cbRace.FormattingEnabled = true;
            cbRace.Location = new Point(30, 92);
            cbRace.Name = "cbRace";
            cbRace.Size = new Size(121, 23);
            cbRace.TabIndex = 2;
            cbRace.SelectedIndexChanged += cbRace_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 3;
            label3.Text = "Character Name:";
            // 
            // txtCharacterName
            // 
            txtCharacterName.Location = new Point(30, 153);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.Size = new Size(121, 23);
            txtCharacterName.TabIndex = 4;
            txtCharacterName.TextChanged += txtCharacterName_TextChanged;
            // 
            // lblCharacterName
            // 
            lblCharacterName.AutoSize = true;
            lblCharacterName.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblCharacterName.Location = new Point(511, 11);
            lblCharacterName.Name = "lblCharacterName";
            lblCharacterName.Size = new Size(167, 45);
            lblCharacterName.TabIndex = 5;
            lblCharacterName.Text = "No Name";
            lblCharacterName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRace
            // 
            lblRace.AutoSize = true;
            lblRace.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRace.Location = new Point(511, 68);
            lblRace.Name = "lblRace";
            lblRace.Size = new Size(79, 40);
            lblRace.TabIndex = 6;
            lblRace.Text = "Race";
            lblRace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(339, 129);
            label5.Name = "label5";
            label5.Size = new Size(216, 40);
            label5.TabIndex = 7;
            label5.Text = "Characteristics:";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStrength.Location = new Point(340, 186);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(100, 30);
            lblStrength.TabIndex = 8;
            lblStrength.Text = "Strength:";
            // 
            // lblAgility
            // 
            lblAgility.AutoSize = true;
            lblAgility.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgility.Location = new Point(340, 227);
            lblAgility.Name = "lblAgility";
            lblAgility.Size = new Size(79, 30);
            lblAgility.TabIndex = 9;
            lblAgility.Text = "Agility:";
            // 
            // lblIntelligence
            // 
            lblIntelligence.AutoSize = true;
            lblIntelligence.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntelligence.Location = new Point(340, 270);
            lblIntelligence.Name = "lblIntelligence";
            lblIntelligence.Size = new Size(127, 30);
            lblIntelligence.TabIndex = 10;
            lblIntelligence.Text = "Intelligence:";
            // 
            // lblUtility
            // 
            lblUtility.AutoSize = true;
            lblUtility.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUtility.Location = new Point(339, 312);
            lblUtility.Name = "lblUtility";
            lblUtility.Size = new Size(75, 30);
            lblUtility.TabIndex = 11;
            lblUtility.Text = "Utility:";
            // 
            // lblStrengthVal
            // 
            lblStrengthVal.AutoSize = true;
            lblStrengthVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStrengthVal.Location = new Point(468, 186);
            lblStrengthVal.Name = "lblStrengthVal";
            lblStrengthVal.Size = new Size(25, 30);
            lblStrengthVal.TabIndex = 12;
            lblStrengthVal.Text = "0";
            // 
            // lblIntelligenceVal
            // 
            lblIntelligenceVal.AutoSize = true;
            lblIntelligenceVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntelligenceVal.Location = new Point(468, 270);
            lblIntelligenceVal.Name = "lblIntelligenceVal";
            lblIntelligenceVal.Size = new Size(25, 30);
            lblIntelligenceVal.TabIndex = 13;
            lblIntelligenceVal.Text = "0";
            // 
            // lblAgilityVal
            // 
            lblAgilityVal.AutoSize = true;
            lblAgilityVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgilityVal.Location = new Point(468, 227);
            lblAgilityVal.Name = "lblAgilityVal";
            lblAgilityVal.Size = new Size(25, 30);
            lblAgilityVal.TabIndex = 14;
            lblAgilityVal.Text = "0";
            // 
            // lblUtilityVal
            // 
            lblUtilityVal.AutoSize = true;
            lblUtilityVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUtilityVal.Location = new Point(468, 312);
            lblUtilityVal.Name = "lblUtilityVal";
            lblUtilityVal.Size = new Size(25, 30);
            lblUtilityVal.TabIndex = 15;
            lblUtilityVal.Text = "0";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(713, 415);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(lblUtilityVal);
            Controls.Add(lblAgilityVal);
            Controls.Add(lblIntelligenceVal);
            Controls.Add(lblStrengthVal);
            Controls.Add(lblUtility);
            Controls.Add(lblIntelligence);
            Controls.Add(lblAgility);
            Controls.Add(lblStrength);
            Controls.Add(label5);
            Controls.Add(lblRace);
            Controls.Add(lblCharacterName);
            Controls.Add(txtCharacterName);
            Controls.Add(label3);
            Controls.Add(cbRace);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateForm";
            Text = "CreateForm";
            Load += CreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbRace;
        private Label label3;
        private TextBox txtCharacterName;
        private Label lblCharacterName;
        private Label lblRace;
        private Label label5;
        private Label lblStrength;
        private Label lblAgility;
        private Label lblIntelligence;
        private Label lblUtility;
        private Label lblStrengthVal;
        private Label lblIntelligenceVal;
        private Label lblAgilityVal;
        private Label lblUtilityVal;
        private Button btnCreate;
    }
}