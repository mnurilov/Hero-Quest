namespace UI
{
    partial class MainScreen
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
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbWorldText = new System.Windows.Forms.RichTextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMagic = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbcInventory = new System.Windows.Forms.TabControl();
            this.tbpItems = new System.Windows.Forms.TabPage();
            this.tbpEquipment = new System.Windows.Forms.TabPage();
            this.tbpSpells = new System.Windows.Forms.TabPage();
            this.tbpQuests = new System.Windows.Forms.TabPage();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.dgvSpells = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnInn = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.tbcInventory.SuspendLayout();
            this.tbpItems.SuspendLayout();
            this.tbpEquipment.SuspendLayout();
            this.tbpSpells.SuspendLayout();
            this.tbpQuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(953, 435);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 0;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(869, 463);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 1;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(1038, 463);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 2;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(953, 494);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 3;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // rtbWorldText
            // 
            this.rtbWorldText.Location = new System.Drawing.Point(826, 12);
            this.rtbWorldText.Name = "rtbWorldText";
            this.rtbWorldText.Size = new System.Drawing.Size(315, 373);
            this.rtbWorldText.TabIndex = 4;
            this.rtbWorldText.Text = "";
            this.rtbWorldText.TextChanged += new System.EventHandler(this.rtbWorldText_TextChanged);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(953, 463);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 5;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(428, 13);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(0, 17);
            this.lblLocationName.TabIndex = 6;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(484, 448);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 7;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(593, 448);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(75, 23);
            this.btnMagic.TabIndex = 8;
            this.btnMagic.Text = "Magic";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(484, 488);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 23);
            this.btnItems.TabIndex = 9;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(593, 488);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbcInventory
            // 
            this.tbcInventory.Controls.Add(this.tbpItems);
            this.tbcInventory.Controls.Add(this.tbpEquipment);
            this.tbcInventory.Controls.Add(this.tbpSpells);
            this.tbcInventory.Controls.Add(this.tbpQuests);
            this.tbcInventory.Location = new System.Drawing.Point(12, 334);
            this.tbcInventory.Name = "tbcInventory";
            this.tbcInventory.SelectedIndex = 0;
            this.tbcInventory.Size = new System.Drawing.Size(281, 210);
            this.tbcInventory.TabIndex = 11;
            // 
            // tbpItems
            // 
            this.tbpItems.Controls.Add(this.dgvItems);
            this.tbpItems.Location = new System.Drawing.Point(4, 25);
            this.tbpItems.Name = "tbpItems";
            this.tbpItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItems.Size = new System.Drawing.Size(273, 181);
            this.tbpItems.TabIndex = 0;
            this.tbpItems.Text = "Items";
            this.tbpItems.UseVisualStyleBackColor = true;
            // 
            // tbpEquipment
            // 
            this.tbpEquipment.Controls.Add(this.dgvEquipment);
            this.tbpEquipment.Location = new System.Drawing.Point(4, 25);
            this.tbpEquipment.Name = "tbpEquipment";
            this.tbpEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEquipment.Size = new System.Drawing.Size(273, 181);
            this.tbpEquipment.TabIndex = 1;
            this.tbpEquipment.Text = "Equipment";
            this.tbpEquipment.UseVisualStyleBackColor = true;
            // 
            // tbpSpells
            // 
            this.tbpSpells.Controls.Add(this.dgvSpells);
            this.tbpSpells.Location = new System.Drawing.Point(4, 25);
            this.tbpSpells.Name = "tbpSpells";
            this.tbpSpells.Size = new System.Drawing.Size(273, 181);
            this.tbpSpells.TabIndex = 2;
            this.tbpSpells.Text = "Spells";
            this.tbpSpells.UseVisualStyleBackColor = true;
            // 
            // tbpQuests
            // 
            this.tbpQuests.Controls.Add(this.dgvQuests);
            this.tbpQuests.Location = new System.Drawing.Point(4, 25);
            this.tbpQuests.Name = "tbpQuests";
            this.tbpQuests.Size = new System.Drawing.Size(273, 181);
            this.tbpQuests.TabIndex = 3;
            this.tbpQuests.Text = "Quests";
            this.tbpQuests.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(273, 181);
            this.dgvItems.TabIndex = 12;
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.Size = new System.Drawing.Size(273, 181);
            this.dgvEquipment.TabIndex = 12;
            // 
            // dgvSpells
            // 
            this.dgvSpells.AllowUserToAddRows = false;
            this.dgvSpells.AllowUserToDeleteRows = false;
            this.dgvSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpells.Location = new System.Drawing.Point(0, 0);
            this.dgvSpells.Name = "dgvSpells";
            this.dgvSpells.ReadOnly = true;
            this.dgvSpells.RowTemplate.Height = 24;
            this.dgvSpells.Size = new System.Drawing.Size(273, 181);
            this.dgvSpells.TabIndex = 12;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.Location = new System.Drawing.Point(0, 0);
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.Size = new System.Drawing.Size(273, 181);
            this.dgvQuests.TabIndex = 12;
            // 
            // btnInn
            // 
            this.btnInn.Location = new System.Drawing.Point(725, 423);
            this.btnInn.Name = "btnInn";
            this.btnInn.Size = new System.Drawing.Size(75, 23);
            this.btnInn.TabIndex = 12;
            this.btnInn.Text = "Inn";
            this.btnInn.UseVisualStyleBackColor = true;
            this.btnInn.Click += new System.EventHandler(this.btnInn_Click);
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(725, 463);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 13;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(725, 508);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(75, 23);
            this.btnTalk.TabIndex = 14;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = true;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 556);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnInn);
            this.Controls.Add(this.tbcInventory);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.rtbWorldText);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero Quest";
            this.tbcInventory.ResumeLayout(false);
            this.tbpItems.ResumeLayout(false);
            this.tbpEquipment.ResumeLayout(false);
            this.tbpSpells.ResumeLayout(false);
            this.tbpQuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.RichTextBox rtbWorldText;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TabControl tbcInventory;
        private System.Windows.Forms.TabPage tbpItems;
        private System.Windows.Forms.TabPage tbpEquipment;
        private System.Windows.Forms.TabPage tbpSpells;
        private System.Windows.Forms.TabPage tbpQuests;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.DataGridView dgvSpells;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Button btnInn;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnTalk;
    }
}

