namespace GMHelper.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblCharacterName = new Label();
            lblCharacterSubtitle = new Label();
            lblUtilityVal = new Label();
            lblAgilityVal = new Label();
            lblIntelligenceVal = new Label();
            lblStrengthVal = new Label();
            lblUtility = new Label();
            lblIntelligence = new Label();
            lblAgility = new Label();
            lblStrength = new Label();
            lbInventory = new ListBox();
            cmsInventory = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            addDescriptionToolStripMenuItem = new ToolStripMenuItem();
            moveItemToolStripMenuItem = new ToolStripMenuItem();
            toTopToolStripMenuItem = new ToolStripMenuItem();
            toBottomToolStripMenuItem = new ToolStripMenuItem();
            upToolStripMenuItem = new ToolStripMenuItem();
            downToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnAddItem = new Button();
            txtInventoryItem = new TextBox();
            lblHealthVal = new Label();
            lblHealth = new Label();
            lblMannaVal = new Label();
            lblManna = new Label();
            menuStrip1 = new MenuStrip();
            characterToolStripMenuItem = new ToolStripMenuItem();
            tsLevelUp = new ToolStripMenuItem();
            tsAddSkills = new ToolStripMenuItem();
            gbCharacteristics = new GroupBox();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lsGeneralSkills = new ListBox();
            tabPage2 = new TabPage();
            lsWeaponSkills = new ListBox();
            tabPage3 = new TabPage();
            lsMagicSkills = new ListBox();
            cmsInventory.SuspendLayout();
            menuStrip1.SuspendLayout();
            gbCharacteristics.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // lblCharacterName
            // 
            lblCharacterName.AutoSize = true;
            lblCharacterName.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblCharacterName.Location = new Point(12, 24);
            lblCharacterName.Name = "lblCharacterName";
            lblCharacterName.Size = new Size(257, 45);
            lblCharacterName.TabIndex = 0;
            lblCharacterName.Text = "Character Name";
            // 
            // lblCharacterSubtitle
            // 
            lblCharacterSubtitle.AutoSize = true;
            lblCharacterSubtitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCharacterSubtitle.Location = new Point(13, 69);
            lblCharacterSubtitle.Name = "lblCharacterSubtitle";
            lblCharacterSubtitle.Size = new Size(146, 37);
            lblCharacterSubtitle.TabIndex = 1;
            lblCharacterSubtitle.Text = "Class, Race";
            // 
            // lblUtilityVal
            // 
            lblUtilityVal.AutoSize = true;
            lblUtilityVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUtilityVal.Location = new Point(133, 121);
            lblUtilityVal.Name = "lblUtilityVal";
            lblUtilityVal.Size = new Size(25, 30);
            lblUtilityVal.TabIndex = 24;
            lblUtilityVal.Text = "0";
            // 
            // lblAgilityVal
            // 
            lblAgilityVal.AutoSize = true;
            lblAgilityVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgilityVal.Location = new Point(133, 61);
            lblAgilityVal.Name = "lblAgilityVal";
            lblAgilityVal.Size = new Size(25, 30);
            lblAgilityVal.TabIndex = 23;
            lblAgilityVal.Text = "0";
            // 
            // lblIntelligenceVal
            // 
            lblIntelligenceVal.AutoSize = true;
            lblIntelligenceVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntelligenceVal.Location = new Point(133, 91);
            lblIntelligenceVal.Name = "lblIntelligenceVal";
            lblIntelligenceVal.Size = new Size(25, 30);
            lblIntelligenceVal.TabIndex = 22;
            lblIntelligenceVal.Text = "0";
            // 
            // lblStrengthVal
            // 
            lblStrengthVal.AutoSize = true;
            lblStrengthVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStrengthVal.Location = new Point(133, 31);
            lblStrengthVal.Name = "lblStrengthVal";
            lblStrengthVal.Size = new Size(25, 30);
            lblStrengthVal.TabIndex = 21;
            lblStrengthVal.Text = "0";
            // 
            // lblUtility
            // 
            lblUtility.AutoSize = true;
            lblUtility.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUtility.Location = new Point(5, 121);
            lblUtility.Name = "lblUtility";
            lblUtility.Size = new Size(75, 30);
            lblUtility.TabIndex = 20;
            lblUtility.Text = "Utility:";
            // 
            // lblIntelligence
            // 
            lblIntelligence.AutoSize = true;
            lblIntelligence.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntelligence.Location = new Point(6, 91);
            lblIntelligence.Name = "lblIntelligence";
            lblIntelligence.Size = new Size(127, 30);
            lblIntelligence.TabIndex = 19;
            lblIntelligence.Text = "Intelligence:";
            // 
            // lblAgility
            // 
            lblAgility.AutoSize = true;
            lblAgility.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgility.Location = new Point(5, 61);
            lblAgility.Name = "lblAgility";
            lblAgility.Size = new Size(79, 30);
            lblAgility.TabIndex = 18;
            lblAgility.Text = "Agility:";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStrength.Location = new Point(5, 31);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(100, 30);
            lblStrength.TabIndex = 17;
            lblStrength.Text = "Strength:";
            // 
            // lbInventory
            // 
            lbInventory.AllowDrop = true;
            lbInventory.ContextMenuStrip = cmsInventory;
            lbInventory.FormattingEnabled = true;
            lbInventory.ItemHeight = 15;
            lbInventory.Location = new Point(503, 177);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(285, 169);
            lbInventory.TabIndex = 25;
            lbInventory.MouseDown += lbInventory_MouseDown;
            lbInventory.MouseEnter += lbInventory_MouseEnter;
            lbInventory.MouseLeave += lbInventory_MouseLeave;
            lbInventory.MouseHover += lbInventory_MouseHover;
            lbInventory.MouseMove += lbInventory_MouseMove;
            lbInventory.MouseUp += lbInventory_MouseUp;
            // 
            // cmsInventory
            // 
            cmsInventory.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, addDescriptionToolStripMenuItem, moveItemToolStripMenuItem, deleteToolStripMenuItem });
            cmsInventory.Name = "cmsInventory";
            cmsInventory.Size = new Size(185, 92);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(184, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // addDescriptionToolStripMenuItem
            // 
            addDescriptionToolStripMenuItem.Name = "addDescriptionToolStripMenuItem";
            addDescriptionToolStripMenuItem.Size = new Size(184, 22);
            addDescriptionToolStripMenuItem.Text = "Add\\Edit Description";
            addDescriptionToolStripMenuItem.Click += addDescriptionToolStripMenuItem_Click;
            // 
            // moveItemToolStripMenuItem
            // 
            moveItemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toTopToolStripMenuItem, toBottomToolStripMenuItem, upToolStripMenuItem, downToolStripMenuItem });
            moveItemToolStripMenuItem.Name = "moveItemToolStripMenuItem";
            moveItemToolStripMenuItem.Size = new Size(184, 22);
            moveItemToolStripMenuItem.Text = "Move Item";
            // 
            // toTopToolStripMenuItem
            // 
            toTopToolStripMenuItem.Name = "toTopToolStripMenuItem";
            toTopToolStripMenuItem.Size = new Size(129, 22);
            toTopToolStripMenuItem.Text = "To Top";
            toTopToolStripMenuItem.Click += toTopToolStripMenuItem_Click;
            // 
            // toBottomToolStripMenuItem
            // 
            toBottomToolStripMenuItem.Name = "toBottomToolStripMenuItem";
            toBottomToolStripMenuItem.Size = new Size(129, 22);
            toBottomToolStripMenuItem.Text = "To Bottom";
            toBottomToolStripMenuItem.Click += toBottomToolStripMenuItem_Click;
            // 
            // upToolStripMenuItem
            // 
            upToolStripMenuItem.Name = "upToolStripMenuItem";
            upToolStripMenuItem.Size = new Size(129, 22);
            upToolStripMenuItem.Text = "Up";
            upToolStripMenuItem.Click += upToolStripMenuItem_Click;
            // 
            // downToolStripMenuItem
            // 
            downToolStripMenuItem.Name = "downToolStripMenuItem";
            downToolStripMenuItem.Size = new Size(129, 22);
            downToolStripMenuItem.Text = "Down";
            downToolStripMenuItem.Click += downToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(184, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(503, 134);
            label1.Name = "label1";
            label1.Size = new Size(150, 40);
            label1.TabIndex = 26;
            label1.Text = "Inventory:";
            // 
            // btnAddItem
            // 
            btnAddItem.Enabled = false;
            btnAddItem.Location = new Point(713, 352);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 27;
            btnAddItem.Text = "Add item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtInventoryItem
            // 
            txtInventoryItem.Location = new Point(503, 352);
            txtInventoryItem.Name = "txtInventoryItem";
            txtInventoryItem.Size = new Size(204, 23);
            txtInventoryItem.TabIndex = 28;
            txtInventoryItem.TextChanged += txtInventoryItem_TextChanged;
            // 
            // lblHealthVal
            // 
            lblHealthVal.AutoSize = true;
            lblHealthVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHealthVal.Location = new Point(141, 362);
            lblHealthVal.Name = "lblHealthVal";
            lblHealthVal.Size = new Size(25, 30);
            lblHealthVal.TabIndex = 30;
            lblHealthVal.Text = "0";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHealth.Location = new Point(17, 362);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(80, 30);
            lblHealth.TabIndex = 29;
            lblHealth.Text = "Health:";
            // 
            // lblMannaVal
            // 
            lblMannaVal.AutoSize = true;
            lblMannaVal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMannaVal.Location = new Point(141, 392);
            lblMannaVal.Name = "lblMannaVal";
            lblMannaVal.Size = new Size(25, 30);
            lblMannaVal.TabIndex = 32;
            lblMannaVal.Text = "0";
            // 
            // lblManna
            // 
            lblManna.AutoSize = true;
            lblManna.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblManna.Location = new Point(17, 392);
            lblManna.Name = "lblManna";
            lblManna.Size = new Size(83, 30);
            lblManna.TabIndex = 31;
            lblManna.Text = "Manna:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { characterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsLevelUp, tsAddSkills });
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new Size(70, 20);
            characterToolStripMenuItem.Text = "Character";
            // 
            // tsLevelUp
            // 
            tsLevelUp.Name = "tsLevelUp";
            tsLevelUp.Size = new Size(147, 22);
            tsLevelUp.Text = "Level Up!";
            tsLevelUp.Click += tsLevelUp_Click;
            // 
            // tsAddSkills
            // 
            tsAddSkills.Name = "tsAddSkills";
            tsAddSkills.Size = new Size(147, 22);
            tsAddSkills.Text = "Improve Skills";
            tsAddSkills.Click += tsAddSkills_Click;
            // 
            // gbCharacteristics
            // 
            gbCharacteristics.Controls.Add(lblAgility);
            gbCharacteristics.Controls.Add(lblStrength);
            gbCharacteristics.Controls.Add(lblIntelligence);
            gbCharacteristics.Controls.Add(lblUtility);
            gbCharacteristics.Controls.Add(lblStrengthVal);
            gbCharacteristics.Controls.Add(lblIntelligenceVal);
            gbCharacteristics.Controls.Add(lblAgilityVal);
            gbCharacteristics.Controls.Add(lblUtilityVal);
            gbCharacteristics.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbCharacteristics.Location = new Point(12, 120);
            gbCharacteristics.Name = "gbCharacteristics";
            gbCharacteristics.Size = new Size(181, 155);
            gbCharacteristics.TabIndex = 34;
            gbCharacteristics.TabStop = false;
            gbCharacteristics.Text = "Characteristics:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(199, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 155);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Skills:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(6, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(286, 118);
            tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lsGeneralSkills);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(278, 90);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsGeneralSkills
            // 
            lsGeneralSkills.FormattingEnabled = true;
            lsGeneralSkills.ItemHeight = 15;
            lsGeneralSkills.Location = new Point(0, 0);
            lsGeneralSkills.Name = "lsGeneralSkills";
            lsGeneralSkills.Size = new Size(278, 94);
            lsGeneralSkills.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lsWeaponSkills);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(278, 90);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Weapon";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsWeaponSkills
            // 
            lsWeaponSkills.FormattingEnabled = true;
            lsWeaponSkills.ItemHeight = 15;
            lsWeaponSkills.Location = new Point(0, 0);
            lsWeaponSkills.Name = "lsWeaponSkills";
            lsWeaponSkills.Size = new Size(278, 94);
            lsWeaponSkills.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lsMagicSkills);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(278, 90);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Magick";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lsMagicSkills
            // 
            lsMagicSkills.FormattingEnabled = true;
            lsMagicSkills.ItemHeight = 15;
            lsMagicSkills.Location = new Point(0, 0);
            lsMagicSkills.Name = "lsMagicSkills";
            lsMagicSkills.Size = new Size(278, 94);
            lsMagicSkills.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(gbCharacteristics);
            Controls.Add(menuStrip1);
            Controls.Add(lblMannaVal);
            Controls.Add(lblManna);
            Controls.Add(lblHealthVal);
            Controls.Add(lblHealth);
            Controls.Add(txtInventoryItem);
            Controls.Add(btnAddItem);
            Controls.Add(label1);
            Controls.Add(lbInventory);
            Controls.Add(lblCharacterSubtitle);
            Controls.Add(lblCharacterName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Character Manager";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            cmsInventory.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbCharacteristics.ResumeLayout(false);
            gbCharacteristics.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCharacterName;
        private Label lblCharacterSubtitle;
        private Label lblUtilityVal;
        private Label lblAgilityVal;
        private Label lblIntelligenceVal;
        private Label lblStrengthVal;
        private Label lblUtility;
        private Label lblIntelligence;
        private Label lblAgility;
        private Label lblStrength;
        private ListBox lbInventory;
        private Label label1;
        private Button btnAddItem;
        private TextBox txtInventoryItem;
        private ContextMenuStrip cmsInventory;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addDescriptionToolStripMenuItem;
        private ToolStripMenuItem moveItemToolStripMenuItem;
        private ToolStripMenuItem toTopToolStripMenuItem;
        private ToolStripMenuItem upToolStripMenuItem;
        private ToolStripMenuItem downToolStripMenuItem;
        private ToolStripMenuItem toBottomToolStripMenuItem;
        private Label lblHealthVal;
        private Label lblHealth;
        private Label lblMannaVal;
        private Label lblManna;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem characterToolStripMenuItem;
        private ToolStripMenuItem tsLevelUp;
        private GroupBox gbCharacteristics;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox lsGeneralSkills;
        private ListBox lsWeaponSkills;
        private ListBox lsMagicSkills;
        private ToolStripMenuItem tsAddSkills;
    }
}