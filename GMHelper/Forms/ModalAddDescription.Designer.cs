namespace GMHelper.Forms
{
    partial class ModalAddDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalAddDescription));
            rtbDescription = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(12, 12);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(294, 96);
            rtbDescription.TabIndex = 0;
            rtbDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(231, 123);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 123);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ModalAddDescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 158);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtbDescription);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "ModalAddDescription";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Description";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}