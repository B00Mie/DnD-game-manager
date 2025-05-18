namespace GMHelper
{
    partial class TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            lblName = new Label();
            button1 = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(265, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(321, 45);
            lblName.TabIndex = 0;
            lblName.Text = "Character Manager";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(353, 116);
            button1.Name = "button1";
            button1.Size = new Size(118, 44);
            button1.TabIndex = 1;
            button1.Text = "Create new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnCreate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(353, 166);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(118, 44);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(button1);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TitleScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button button1;
        private Button btnLoad;
    }
}