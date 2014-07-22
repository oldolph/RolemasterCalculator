namespace RolemasterCalculator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpWeapon = new System.Windows.Forms.TabPage();
            this.lblWeaponLookup = new System.Windows.Forms.Label();
            this.lblAttackRollMsg = new System.Windows.Forms.Label();
            this.btnWeaponClear = new System.Windows.Forms.Button();
            this.btnWeaponCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboArmorType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboWeaponType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveDefenseMod = new System.Windows.Forms.Button();
            this.btnAddDefenseMod = new System.Windows.Forms.Button();
            this.dgDefenseMod = new System.Windows.Forms.DataGridView();
            this.txtDefenseBonus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAttackRoll = new System.Windows.Forms.TextBox();
            this.btnRemoveAttackMod = new System.Windows.Forms.Button();
            this.btnAddAttackMod = new System.Windows.Forms.Button();
            this.dgAttackMod = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tpCritical = new System.Windows.Forms.TabPage();
            this.btnCriticalClear = new System.Windows.Forms.Button();
            this.btnCriticalCalculate = new System.Windows.Forms.Button();
            this.lblCriticalLookup = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboCriticalSeverity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCriticalType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCriticalRoll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpWeapon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDefenseMod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttackMod)).BeginInit();
            this.tpCritical.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpWeapon);
            this.tabControl1.Controls.Add(this.tpCritical);
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 482);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpWeapon
            // 
            this.tpWeapon.Controls.Add(this.lblWeaponLookup);
            this.tpWeapon.Controls.Add(this.lblAttackRollMsg);
            this.tpWeapon.Controls.Add(this.btnWeaponClear);
            this.tpWeapon.Controls.Add(this.btnWeaponCalculate);
            this.tpWeapon.Controls.Add(this.label4);
            this.tpWeapon.Controls.Add(this.cboArmorType);
            this.tpWeapon.Controls.Add(this.label3);
            this.tpWeapon.Controls.Add(this.cboWeaponType);
            this.tpWeapon.Controls.Add(this.groupBox2);
            this.tpWeapon.Controls.Add(this.groupBox1);
            this.tpWeapon.Location = new System.Drawing.Point(4, 22);
            this.tpWeapon.Name = "tpWeapon";
            this.tpWeapon.Padding = new System.Windows.Forms.Padding(3);
            this.tpWeapon.Size = new System.Drawing.Size(629, 456);
            this.tpWeapon.TabIndex = 0;
            this.tpWeapon.Text = "Weapons";
            this.tpWeapon.UseVisualStyleBackColor = true;
            // 
            // lblWeaponLookup
            // 
            this.lblWeaponLookup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblWeaponLookup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponLookup.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponLookup.ForeColor = System.Drawing.Color.Green;
            this.lblWeaponLookup.Location = new System.Drawing.Point(511, 22);
            this.lblWeaponLookup.Name = "lblWeaponLookup";
            this.lblWeaponLookup.Size = new System.Drawing.Size(103, 39);
            this.lblWeaponLookup.TabIndex = 7;
            this.lblWeaponLookup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttackRollMsg
            // 
            this.lblAttackRollMsg.AutoSize = true;
            this.lblAttackRollMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackRollMsg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAttackRollMsg.Location = new System.Drawing.Point(258, 64);
            this.lblAttackRollMsg.Name = "lblAttackRollMsg";
            this.lblAttackRollMsg.Size = new System.Drawing.Size(0, 12);
            this.lblAttackRollMsg.TabIndex = 4;
            // 
            // btnWeaponClear
            // 
            this.btnWeaponClear.Location = new System.Drawing.Point(452, 421);
            this.btnWeaponClear.Name = "btnWeaponClear";
            this.btnWeaponClear.Size = new System.Drawing.Size(75, 23);
            this.btnWeaponClear.TabIndex = 5;
            this.btnWeaponClear.Text = "Clear";
            this.btnWeaponClear.UseVisualStyleBackColor = true;
            this.btnWeaponClear.Click += new System.EventHandler(this.btnWeaponClear_Click);
            // 
            // btnWeaponCalculate
            // 
            this.btnWeaponCalculate.Enabled = false;
            this.btnWeaponCalculate.Location = new System.Drawing.Point(533, 421);
            this.btnWeaponCalculate.Name = "btnWeaponCalculate";
            this.btnWeaponCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnWeaponCalculate.TabIndex = 4;
            this.btnWeaponCalculate.Text = "Calculate";
            this.btnWeaponCalculate.UseVisualStyleBackColor = true;
            this.btnWeaponCalculate.Click += new System.EventHandler(this.btnWeaponCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Armor:";
            // 
            // cboArmorType
            // 
            this.cboArmorType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArmorType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboArmorType.FormattingEnabled = true;
            this.cboArmorType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboArmorType.Location = new System.Drawing.Point(58, 19);
            this.cboArmorType.Name = "cboArmorType";
            this.cboArmorType.Size = new System.Drawing.Size(64, 21);
            this.cboArmorType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // cboWeaponType
            // 
            this.cboWeaponType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboWeaponType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboWeaponType.FormattingEnabled = true;
            this.cboWeaponType.Location = new System.Drawing.Point(58, 60);
            this.cboWeaponType.Name = "cboWeaponType";
            this.cboWeaponType.Size = new System.Drawing.Size(182, 21);
            this.cboWeaponType.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveDefenseMod);
            this.groupBox2.Controls.Add(this.btnAddDefenseMod);
            this.groupBox2.Controls.Add(this.dgDefenseMod);
            this.groupBox2.Controls.Add(this.txtDefenseBonus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(325, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 311);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Defense";
            // 
            // btnRemoveDefenseMod
            // 
            this.btnRemoveDefenseMod.Location = new System.Drawing.Point(170, 84);
            this.btnRemoveDefenseMod.Name = "btnRemoveDefenseMod";
            this.btnRemoveDefenseMod.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveDefenseMod.TabIndex = 2;
            this.btnRemoveDefenseMod.Text = "Remove Modifier";
            this.btnRemoveDefenseMod.UseVisualStyleBackColor = true;
            this.btnRemoveDefenseMod.Click += new System.EventHandler(this.btnRemoveDefenseMod_Click);
            // 
            // btnAddDefenseMod
            // 
            this.btnAddDefenseMod.Location = new System.Drawing.Point(51, 84);
            this.btnAddDefenseMod.Name = "btnAddDefenseMod";
            this.btnAddDefenseMod.Size = new System.Drawing.Size(113, 23);
            this.btnAddDefenseMod.TabIndex = 1;
            this.btnAddDefenseMod.Text = "Add Modifier";
            this.btnAddDefenseMod.UseVisualStyleBackColor = true;
            this.btnAddDefenseMod.Click += new System.EventHandler(this.btnAddDefenseMod_Click);
            // 
            // dgDefenseMod
            // 
            this.dgDefenseMod.AllowUserToAddRows = false;
            this.dgDefenseMod.AllowUserToDeleteRows = false;
            this.dgDefenseMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDefenseMod.Location = new System.Drawing.Point(6, 113);
            this.dgDefenseMod.MultiSelect = false;
            this.dgDefenseMod.Name = "dgDefenseMod";
            this.dgDefenseMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDefenseMod.Size = new System.Drawing.Size(277, 192);
            this.dgDefenseMod.TabIndex = 3;
            // 
            // txtDefenseBonus
            // 
            this.txtDefenseBonus.Location = new System.Drawing.Point(64, 38);
            this.txtDefenseBonus.Name = "txtDefenseBonus";
            this.txtDefenseBonus.Size = new System.Drawing.Size(100, 20);
            this.txtDefenseBonus.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bonus:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAttackRoll);
            this.groupBox1.Controls.Add(this.btnRemoveAttackMod);
            this.groupBox1.Controls.Add(this.btnAddAttackMod);
            this.groupBox1.Controls.Add(this.dgAttackMod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attack";
            // 
            // txtAttackRoll
            // 
            this.txtAttackRoll.Location = new System.Drawing.Point(51, 37);
            this.txtAttackRoll.Name = "txtAttackRoll";
            this.txtAttackRoll.Size = new System.Drawing.Size(100, 20);
            this.txtAttackRoll.TabIndex = 0;
            this.txtAttackRoll.TextChanged += new System.EventHandler(this.txtAttackRoll_TextChanged);
            // 
            // btnRemoveAttackMod
            // 
            this.btnRemoveAttackMod.Location = new System.Drawing.Point(170, 84);
            this.btnRemoveAttackMod.Name = "btnRemoveAttackMod";
            this.btnRemoveAttackMod.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveAttackMod.TabIndex = 2;
            this.btnRemoveAttackMod.Text = "Remove Modifier";
            this.btnRemoveAttackMod.UseVisualStyleBackColor = true;
            this.btnRemoveAttackMod.Click += new System.EventHandler(this.btnRemoveAttackMod_Click);
            // 
            // btnAddAttackMod
            // 
            this.btnAddAttackMod.Location = new System.Drawing.Point(51, 84);
            this.btnAddAttackMod.Name = "btnAddAttackMod";
            this.btnAddAttackMod.Size = new System.Drawing.Size(113, 23);
            this.btnAddAttackMod.TabIndex = 1;
            this.btnAddAttackMod.Text = "Add Modifier";
            this.btnAddAttackMod.UseVisualStyleBackColor = true;
            this.btnAddAttackMod.Click += new System.EventHandler(this.btnAddAttackMod_Click);
            // 
            // dgAttackMod
            // 
            this.dgAttackMod.AllowUserToAddRows = false;
            this.dgAttackMod.AllowUserToDeleteRows = false;
            this.dgAttackMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttackMod.Location = new System.Drawing.Point(6, 113);
            this.dgAttackMod.MultiSelect = false;
            this.dgAttackMod.Name = "dgAttackMod";
            this.dgAttackMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAttackMod.Size = new System.Drawing.Size(277, 192);
            this.dgAttackMod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll:";
            // 
            // tpCritical
            // 
            this.tpCritical.Controls.Add(this.btnCriticalClear);
            this.tpCritical.Controls.Add(this.btnCriticalCalculate);
            this.tpCritical.Controls.Add(this.lblCriticalLookup);
            this.tpCritical.Controls.Add(this.groupBox3);
            this.tpCritical.Location = new System.Drawing.Point(4, 22);
            this.tpCritical.Name = "tpCritical";
            this.tpCritical.Size = new System.Drawing.Size(629, 456);
            this.tpCritical.TabIndex = 1;
            this.tpCritical.Text = "Criticals";
            this.tpCritical.UseVisualStyleBackColor = true;
            // 
            // btnCriticalClear
            // 
            this.btnCriticalClear.Location = new System.Drawing.Point(452, 421);
            this.btnCriticalClear.Name = "btnCriticalClear";
            this.btnCriticalClear.Size = new System.Drawing.Size(75, 23);
            this.btnCriticalClear.TabIndex = 2;
            this.btnCriticalClear.Text = "Clear";
            this.btnCriticalClear.UseVisualStyleBackColor = true;
            this.btnCriticalClear.Click += new System.EventHandler(this.btnCriticalClear_Click);
            // 
            // btnCriticalCalculate
            // 
            this.btnCriticalCalculate.Enabled = false;
            this.btnCriticalCalculate.Location = new System.Drawing.Point(533, 421);
            this.btnCriticalCalculate.Name = "btnCriticalCalculate";
            this.btnCriticalCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCriticalCalculate.TabIndex = 2;
            this.btnCriticalCalculate.Text = "Calculate";
            this.btnCriticalCalculate.UseVisualStyleBackColor = true;
            this.btnCriticalCalculate.Click += new System.EventHandler(this.btnCriticalCalculate_Click);
            // 
            // lblCriticalLookup
            // 
            this.lblCriticalLookup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCriticalLookup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCriticalLookup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalLookup.ForeColor = System.Drawing.Color.Green;
            this.lblCriticalLookup.Location = new System.Drawing.Point(19, 199);
            this.lblCriticalLookup.Name = "lblCriticalLookup";
            this.lblCriticalLookup.Size = new System.Drawing.Size(590, 119);
            this.lblCriticalLookup.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboCriticalSeverity);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cboCriticalType);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCriticalRoll);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(19, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 97);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Critical Input";
            // 
            // cboCriticalSeverity
            // 
            this.cboCriticalSeverity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCriticalSeverity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCriticalSeverity.FormattingEnabled = true;
            this.cboCriticalSeverity.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cboCriticalSeverity.Location = new System.Drawing.Point(451, 44);
            this.cboCriticalSeverity.Name = "cboCriticalSeverity";
            this.cboCriticalSeverity.Size = new System.Drawing.Size(121, 21);
            this.cboCriticalSeverity.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Severity:";
            // 
            // cboCriticalType
            // 
            this.cboCriticalType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCriticalType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCriticalType.FormattingEnabled = true;
            this.cboCriticalType.Location = new System.Drawing.Point(246, 44);
            this.cboCriticalType.Name = "cboCriticalType";
            this.cboCriticalType.Size = new System.Drawing.Size(121, 21);
            this.cboCriticalType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Type:";
            // 
            // txtCriticalRoll
            // 
            this.txtCriticalRoll.Location = new System.Drawing.Point(55, 44);
            this.txtCriticalRoll.Name = "txtCriticalRoll";
            this.txtCriticalRoll.Size = new System.Drawing.Size(121, 20);
            this.txtCriticalRoll.TabIndex = 0;
            this.txtCriticalRoll.TextChanged += new System.EventHandler(this.txtCriticalRoll_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Roll:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 527);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 556);
            this.MinimumSize = new System.Drawing.Size(669, 556);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rolemaster Damage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpWeapon.ResumeLayout(false);
            this.tpWeapon.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDefenseMod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttackMod)).EndInit();
            this.tpCritical.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpWeapon;
        private System.Windows.Forms.Label lblWeaponLookup;
        private System.Windows.Forms.Label lblAttackRollMsg;
        private System.Windows.Forms.Button btnWeaponClear;
        private System.Windows.Forms.Button btnWeaponCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboArmorType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboWeaponType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveDefenseMod;
        private System.Windows.Forms.Button btnAddDefenseMod;
        private System.Windows.Forms.DataGridView dgDefenseMod;
        private System.Windows.Forms.TextBox txtDefenseBonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAttackRoll;
        private System.Windows.Forms.Button btnRemoveAttackMod;
        private System.Windows.Forms.Button btnAddAttackMod;
        private System.Windows.Forms.DataGridView dgAttackMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpCritical;
        private System.Windows.Forms.Button btnCriticalClear;
        private System.Windows.Forms.Button btnCriticalCalculate;
        private System.Windows.Forms.Label lblCriticalLookup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboCriticalSeverity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCriticalType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCriticalRoll;
        private System.Windows.Forms.Label label5;

    }
}

