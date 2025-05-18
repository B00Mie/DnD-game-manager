namespace CharacterManager.UserControls
{
    partial class PropertyControll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPropertyVal = new Label();
            lblPropertyName = new Label();
            btnIncrease = new Button();
            btnDecrease = new Button();
            SuspendLayout();
            // 
            // lblPropertyVal
            // 
            lblPropertyVal.AutoSize = true;
            lblPropertyVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPropertyVal.Location = new Point(164, 0);
            lblPropertyVal.Name = "lblPropertyVal";
            lblPropertyVal.Size = new Size(25, 30);
            lblPropertyVal.TabIndex = 14;
            lblPropertyVal.Text = "0";
            // 
            // lblPropertyName
            // 
            lblPropertyName.AutoSize = true;
            lblPropertyName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPropertyName.Location = new Point(3, 0);
            lblPropertyName.Name = "lblPropertyName";
            lblPropertyName.Size = new Size(124, 30);
            lblPropertyName.TabIndex = 13;
            lblPropertyName.Text = "Placeholder";
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(195, 5);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(25, 25);
            btnIncrease.TabIndex = 15;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Enabled = false;
            btnDecrease.Location = new Point(133, 5);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(25, 25);
            btnDecrease.TabIndex = 16;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // PropertyControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(btnDecrease);
            Controls.Add(btnIncrease);
            Controls.Add(lblPropertyVal);
            Controls.Add(lblPropertyName);
            Name = "PropertyControll";
            Size = new Size(223, 33);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPropertyVal;
        private Label lblPropertyName;
        private Button btnIncrease;
        private Button btnDecrease;
    }
}
