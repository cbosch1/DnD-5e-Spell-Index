namespace SpellIndexForm
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblSpellName = new System.Windows.Forms.Label();
            this.lblSpellLevel = new System.Windows.Forms.Label();
            this.lblSpellSchool = new System.Windows.Forms.Label();
            this.lblSpellCastingTime = new System.Windows.Forms.Label();
            this.lblCastingTime = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblComponents = new System.Windows.Forms.Label();
            this.lblSpellRange = new System.Windows.Forms.Label();
            this.lblSpellComponents = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSpellDuration = new System.Windows.Forms.Label();
            this.lblSpellDescription = new System.Windows.Forms.Label();
            this.lblRitual = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.drdnSchool = new System.Windows.Forms.ListBox();
            this.drdnLevel = new System.Windows.Forms.ListBox();
            this.boxSearch1 = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(120, 19, 0, 19);
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblSpellName
            // 
            this.lblSpellName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellName.AutoSize = true;
            this.lblSpellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpellName.Location = new System.Drawing.Point(408, 25);
            this.lblSpellName.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellName.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblSpellName.Name = "lblSpellName";
            this.lblSpellName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSpellName.Size = new System.Drawing.Size(500, 36);
            this.lblSpellName.TabIndex = 1;
            this.lblSpellName.Text = "SpellName";
            this.lblSpellName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSpellName.Click += new System.EventHandler(this.lblSpellName_Click);
            // 
            // lblSpellLevel
            // 
            this.lblSpellLevel.AutoSize = true;
            this.lblSpellLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpellLevel.Location = new System.Drawing.Point(562, 78);
            this.lblSpellLevel.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellLevel.Name = "lblSpellLevel";
            this.lblSpellLevel.Size = new System.Drawing.Size(73, 17);
            this.lblSpellLevel.TabIndex = 2;
            this.lblSpellLevel.Text = "SpellLevel";
            this.lblSpellLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpellSchool
            // 
            this.lblSpellSchool.AutoSize = true;
            this.lblSpellSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpellSchool.Location = new System.Drawing.Point(672, 78);
            this.lblSpellSchool.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellSchool.Name = "lblSpellSchool";
            this.lblSpellSchool.Size = new System.Drawing.Size(82, 17);
            this.lblSpellSchool.TabIndex = 3;
            this.lblSpellSchool.Text = "SpellSchool";
            this.lblSpellSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpellCastingTime
            // 
            this.lblSpellCastingTime.AutoSize = true;
            this.lblSpellCastingTime.Location = new System.Drawing.Point(131, 332);
            this.lblSpellCastingTime.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellCastingTime.Name = "lblSpellCastingTime";
            this.lblSpellCastingTime.Size = new System.Drawing.Size(117, 17);
            this.lblSpellCastingTime.TabIndex = 4;
            this.lblSpellCastingTime.Text = "SpellCastingTime";
            this.lblSpellCastingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCastingTime
            // 
            this.lblCastingTime.AutoSize = true;
            this.lblCastingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCastingTime.Location = new System.Drawing.Point(11, 332);
            this.lblCastingTime.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblCastingTime.Name = "lblCastingTime";
            this.lblCastingTime.Size = new System.Drawing.Size(107, 17);
            this.lblCastingTime.TabIndex = 7;
            this.lblCastingTime.Text = "Casting Time:";
            this.lblCastingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRange.Location = new System.Drawing.Point(56, 280);
            this.lblRange.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(60, 17);
            this.lblRange.TabIndex = 8;
            this.lblRange.Text = "Range:";
            this.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComponents
            // 
            this.lblComponents.AutoSize = true;
            this.lblComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponents.Location = new System.Drawing.Point(108, 469);
            this.lblComponents.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblComponents.Name = "lblComponents";
            this.lblComponents.Size = new System.Drawing.Size(97, 17);
            this.lblComponents.TabIndex = 9;
            this.lblComponents.Text = "Components";
            this.lblComponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComponents.Click += new System.EventHandler(this.lblComponents_Click);
            // 
            // lblSpellRange
            // 
            this.lblSpellRange.AutoSize = true;
            this.lblSpellRange.Location = new System.Drawing.Point(131, 280);
            this.lblSpellRange.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellRange.Name = "lblSpellRange";
            this.lblSpellRange.Size = new System.Drawing.Size(81, 17);
            this.lblSpellRange.TabIndex = 10;
            this.lblSpellRange.Text = "SpellRange";
            this.lblSpellRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpellComponents
            // 
            this.lblSpellComponents.AutoSize = true;
            this.lblSpellComponents.Location = new System.Drawing.Point(45, 505);
            this.lblSpellComponents.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellComponents.MaximumSize = new System.Drawing.Size(212, 0);
            this.lblSpellComponents.Name = "lblSpellComponents";
            this.lblSpellComponents.Size = new System.Drawing.Size(205, 119);
            this.lblSpellComponents.TabIndex = 11;
            this.lblSpellComponents.Text = "The Spell Components I also have to write a lot of text for because there are occ" +
    "ations where the component text ends up behind the description text and we would" +
    "n\'t want that now would we?";
            this.lblSpellComponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(42, 391);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(75, 17);
            this.lblDuration.TabIndex = 12;
            this.lblDuration.Text = "Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpellDuration
            // 
            this.lblSpellDuration.AutoSize = true;
            this.lblSpellDuration.Location = new System.Drawing.Point(131, 391);
            this.lblSpellDuration.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellDuration.Name = "lblSpellDuration";
            this.lblSpellDuration.Size = new System.Drawing.Size(93, 17);
            this.lblSpellDuration.TabIndex = 13;
            this.lblSpellDuration.Text = "SpellDuration";
            this.lblSpellDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpellDescription
            // 
            this.lblSpellDescription.AutoSize = true;
            this.lblSpellDescription.Location = new System.Drawing.Point(361, 118);
            this.lblSpellDescription.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSpellDescription.MaximumSize = new System.Drawing.Size(594, 750);
            this.lblSpellDescription.MinimumSize = new System.Drawing.Size(594, 750);
            this.lblSpellDescription.Name = "lblSpellDescription";
            this.lblSpellDescription.Size = new System.Drawing.Size(594, 750);
            this.lblSpellDescription.TabIndex = 14;
            this.lblSpellDescription.Text = "The Spell Description Goes Here. I am writing a lot of text to see where this tex" +
    "t box will end or loop.";
            this.lblSpellDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSpellDescription.Click += new System.EventHandler(this.lblSpellDescription_Click);
            // 
            // lblRitual
            // 
            this.lblRitual.AutoSize = true;
            this.lblRitual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRitual.Location = new System.Drawing.Point(632, 61);
            this.lblRitual.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblRitual.Name = "lblRitual";
            this.lblRitual.Size = new System.Drawing.Size(44, 17);
            this.lblRitual.TabIndex = 15;
            this.lblRitual.Text = "Ritual";
            this.lblRitual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(10, 30);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 17);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(237, 25);
            this.btnGo.Margin = new System.Windows.Forms.Padding(60, 28, 60, 28);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 26);
            this.btnGo.TabIndex = 18;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // drdnSchool
            // 
            this.drdnSchool.FormattingEnabled = true;
            this.drdnSchool.ItemHeight = 16;
            this.drdnSchool.Items.AddRange(new object[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
            this.drdnSchool.Location = new System.Drawing.Point(15, 60);
            this.drdnSchool.Margin = new System.Windows.Forms.Padding(4);
            this.drdnSchool.Name = "drdnSchool";
            this.drdnSchool.Size = new System.Drawing.Size(103, 148);
            this.drdnSchool.TabIndex = 23;
            this.drdnSchool.SelectedIndexChanged += new System.EventHandler(this.drdnSchool_SelectedIndexChanged);
            // 
            // drdnLevel
            // 
            this.drdnLevel.FormattingEnabled = true;
            this.drdnLevel.ItemHeight = 16;
            this.drdnLevel.Items.AddRange(new object[] {
            "Cantrip",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9"});
            this.drdnLevel.Location = new System.Drawing.Point(126, 61);
            this.drdnLevel.Margin = new System.Windows.Forms.Padding(4);
            this.drdnLevel.Name = "drdnLevel";
            this.drdnLevel.Size = new System.Drawing.Size(65, 180);
            this.drdnLevel.TabIndex = 24;
            this.drdnLevel.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // boxSearch1
            // 
            this.boxSearch1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.boxSearch1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxSearch1.FormattingEnabled = true;
            this.boxSearch1.Location = new System.Drawing.Point(90, 26);
            this.boxSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.boxSearch1.Name = "boxSearch1";
            this.boxSearch1.Size = new System.Drawing.Size(134, 24);
            this.boxSearch1.TabIndex = 25;
            this.boxSearch1.SelectedIndexChanged += new System.EventHandler(this.boxSearch_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(198, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 28);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(979, 776);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.boxSearch1);
            this.Controls.Add(this.drdnLevel);
            this.Controls.Add(this.drdnSchool);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblRitual);
            this.Controls.Add(this.lblSpellDescription);
            this.Controls.Add(this.lblSpellDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblSpellComponents);
            this.Controls.Add(this.lblSpellRange);
            this.Controls.Add(this.lblComponents);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblCastingTime);
            this.Controls.Add(this.lblSpellCastingTime);
            this.Controls.Add(this.lblSpellSchool);
            this.Controls.Add(this.lblSpellLevel);
            this.Controls.Add(this.lblSpellName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(60, 28, 60, 28);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblSpellName;
        private System.Windows.Forms.Label lblSpellLevel;
        private System.Windows.Forms.Label lblSpellSchool;
        private System.Windows.Forms.Label lblSpellCastingTime;
        private System.Windows.Forms.Label lblCastingTime;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblComponents;
        private System.Windows.Forms.Label lblSpellRange;
        private System.Windows.Forms.Label lblSpellComponents;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSpellDuration;
        private System.Windows.Forms.Label lblSpellDescription;
        private System.Windows.Forms.Label lblRitual;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox drdnSchool;
        private System.Windows.Forms.ListBox drdnLevel;
        private System.Windows.Forms.ComboBox boxSearch1;
        private System.Windows.Forms.Button btnReset;
    }
}

