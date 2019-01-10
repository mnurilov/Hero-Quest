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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemUse = new UI.DataGridViewDisableButtonColumn();
            this.test = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbpEquipment = new System.Windows.Forms.TabPage();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.colEquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipmentEquip = new UI.DataGridViewDisableButtonColumn();
            this.colEquipmentUnequip = new UI.DataGridViewDisableButtonColumn();
            this.tbpSpells = new System.Windows.Forms.TabPage();
            this.dgvSpells = new System.Windows.Forms.DataGridView();
            this.colSpellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpellManaCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpellCast = new UI.DataGridViewDisableButtonColumn();
            this.tbpQuests = new System.Windows.Forms.TabPage();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.colQuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInn = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dataGridViewDisableButtonColumn1 = new UI.DataGridViewDisableButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblLocationDescription = new System.Windows.Forms.Label();
            this.pbLocationPicture = new System.Windows.Forms.PictureBox();
            this.pbEnemyPicture = new System.Windows.Forms.PictureBox();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyDescription = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.lblPlayerStrength = new System.Windows.Forms.Label();
            this.lblPlayerGold = new System.Windows.Forms.Label();
            this.lblPlayerResistance = new System.Windows.Forms.Label();
            this.lblPlayerIntellect = new System.Windows.Forms.Label();
            this.lblPlayerSpeed = new System.Windows.Forms.Label();
            this.lblPlayerLuck = new System.Windows.Forms.Label();
            this.lblPlayerDefense = new System.Windows.Forms.Label();
            this.lblPlayerMana = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayerExperience = new System.Windows.Forms.Label();
            this.dgvBattleSpells = new System.Windows.Forms.DataGridView();
            this.colBattleSpellsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattleSpellsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattleSpellsManaCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattleSpellsCast = new UI.DataGridViewDisableButtonColumn();
            this.dgvBattleItems = new System.Windows.Forms.DataGridView();
            this.colBattleItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattleItemsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattleItemsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBattleItemsUse = new UI.DataGridViewDisableButtonColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEmpower = new System.Windows.Forms.Button();
            this.btnGreed = new System.Windows.Forms.Button();
            this.tbcInventory.SuspendLayout();
            this.tbpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tbpEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.tbpSpells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).BeginInit();
            this.tbpQuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocationPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBattleSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBattleItems)).BeginInit();
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
            this.rtbWorldText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rtbWorldText.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.lblLocationName.Location = new System.Drawing.Point(316, 13);
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
            this.tbcInventory.Location = new System.Drawing.Point(0, 344);
            this.tbcInventory.Name = "tbcInventory";
            this.tbcInventory.SelectedIndex = 0;
            this.tbcInventory.Size = new System.Drawing.Size(281, 210);
            this.tbcInventory.TabIndex = 11;
            // 
            // tbpItems
            // 
            this.tbpItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpItems.BackgroundImage")));
            this.tbpItems.Controls.Add(this.dgvItems);
            this.tbpItems.Location = new System.Drawing.Point(4, 25);
            this.tbpItems.Name = "tbpItems";
            this.tbpItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItems.Size = new System.Drawing.Size(273, 181);
            this.tbpItems.TabIndex = 0;
            this.tbpItems.Text = "Items";
            this.tbpItems.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.ColumnHeadersVisible = false;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colItemName,
            this.colItemQuantity,
            this.colItemUse,
            this.test});
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(273, 181);
            this.dgvItems.TabIndex = 12;
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "ID";
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            this.colItemID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemID.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.Name = "colItemQuantity";
            this.colItemQuantity.ReadOnly = true;
            this.colItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemQuantity.Width = 50;
            // 
            // colItemUse
            // 
            this.colItemUse.HeaderText = "Use";
            this.colItemUse.Name = "colItemUse";
            this.colItemUse.ReadOnly = true;
            this.colItemUse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemUse.Text = "Use";
            this.colItemUse.UseColumnTextForButtonValue = true;
            this.colItemUse.Width = 30;
            // 
            // test
            // 
            this.test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.test.HeaderText = "";
            this.test.Image = ((System.Drawing.Image)(resources.GetObject("test.Image")));
            this.test.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.AllowUserToResizeColumns = false;
            this.dgvEquipment.AllowUserToResizeRows = false;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.ColumnHeadersVisible = false;
            this.dgvEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEquipmentID,
            this.colEquipmentName,
            this.colEquipmentEquip,
            this.colEquipmentUnequip});
            this.dgvEquipment.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.RowHeadersVisible = false;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.Size = new System.Drawing.Size(273, 181);
            this.dgvEquipment.TabIndex = 12;
            // 
            // colEquipmentID
            // 
            this.colEquipmentID.HeaderText = "ID";
            this.colEquipmentID.Name = "colEquipmentID";
            this.colEquipmentID.ReadOnly = true;
            this.colEquipmentID.Visible = false;
            // 
            // colEquipmentName
            // 
            this.colEquipmentName.HeaderText = "Name";
            this.colEquipmentName.Name = "colEquipmentName";
            this.colEquipmentName.ReadOnly = true;
            this.colEquipmentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEquipmentEquip
            // 
            this.colEquipmentEquip.HeaderText = "Equip";
            this.colEquipmentEquip.Name = "colEquipmentEquip";
            this.colEquipmentEquip.ReadOnly = true;
            this.colEquipmentEquip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEquipmentEquip.Text = "Equip";
            this.colEquipmentEquip.UseColumnTextForButtonValue = true;
            this.colEquipmentEquip.Width = 50;
            // 
            // colEquipmentUnequip
            // 
            this.colEquipmentUnequip.HeaderText = "Unequip";
            this.colEquipmentUnequip.Name = "colEquipmentUnequip";
            this.colEquipmentUnequip.ReadOnly = true;
            this.colEquipmentUnequip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEquipmentUnequip.Text = "Unequip";
            this.colEquipmentUnequip.UseColumnTextForButtonValue = true;
            this.colEquipmentUnequip.Width = 50;
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
            // dgvSpells
            // 
            this.dgvSpells.AllowUserToAddRows = false;
            this.dgvSpells.AllowUserToDeleteRows = false;
            this.dgvSpells.AllowUserToResizeColumns = false;
            this.dgvSpells.AllowUserToResizeRows = false;
            this.dgvSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpells.ColumnHeadersVisible = false;
            this.dgvSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpellID,
            this.colSpellName,
            this.colSpellManaCost,
            this.colSpellCast});
            this.dgvSpells.Location = new System.Drawing.Point(0, 0);
            this.dgvSpells.Name = "dgvSpells";
            this.dgvSpells.ReadOnly = true;
            this.dgvSpells.RowHeadersVisible = false;
            this.dgvSpells.RowTemplate.Height = 24;
            this.dgvSpells.Size = new System.Drawing.Size(273, 181);
            this.dgvSpells.TabIndex = 12;
            // 
            // colSpellID
            // 
            this.colSpellID.HeaderText = "ID";
            this.colSpellID.Name = "colSpellID";
            this.colSpellID.ReadOnly = true;
            this.colSpellID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSpellID.Visible = false;
            // 
            // colSpellName
            // 
            this.colSpellName.HeaderText = "Name";
            this.colSpellName.Name = "colSpellName";
            this.colSpellName.ReadOnly = true;
            this.colSpellName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSpellManaCost
            // 
            this.colSpellManaCost.HeaderText = "Mana Cost";
            this.colSpellManaCost.Name = "colSpellManaCost";
            this.colSpellManaCost.ReadOnly = true;
            this.colSpellManaCost.Width = 50;
            // 
            // colSpellCast
            // 
            this.colSpellCast.HeaderText = "Cast";
            this.colSpellCast.Name = "colSpellCast";
            this.colSpellCast.ReadOnly = true;
            this.colSpellCast.Text = "Cast";
            this.colSpellCast.UseColumnTextForButtonValue = true;
            this.colSpellCast.Width = 50;
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
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeColumns = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.ColumnHeadersVisible = false;
            this.dgvQuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestID,
            this.colQuestName,
            this.colQuestStatus});
            this.dgvQuests.Location = new System.Drawing.Point(0, 0);
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.Size = new System.Drawing.Size(273, 181);
            this.dgvQuests.TabIndex = 12;
            // 
            // colQuestID
            // 
            this.colQuestID.HeaderText = "ID";
            this.colQuestID.Name = "colQuestID";
            this.colQuestID.ReadOnly = true;
            this.colQuestID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuestID.Visible = false;
            // 
            // colQuestName
            // 
            this.colQuestName.HeaderText = "Name";
            this.colQuestName.Name = "colQuestName";
            this.colQuestName.ReadOnly = true;
            this.colQuestName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colQuestStatus
            // 
            this.colQuestStatus.HeaderText = "Status";
            this.colQuestStatus.Name = "colQuestStatus";
            this.colQuestStatus.ReadOnly = true;
            this.colQuestStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 291);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 260);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 229);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 198);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(12, 167);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(12, 322);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            // 
            // dataGridViewDisableButtonColumn1
            // 
            this.dataGridViewDisableButtonColumn1.HeaderText = "Use";
            this.dataGridViewDisableButtonColumn1.Name = "dataGridViewDisableButtonColumn1";
            this.dataGridViewDisableButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDisableButtonColumn1.Text = "Use";
            this.dataGridViewDisableButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewDisableButtonColumn1.Width = 30;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Equip";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = "Equip";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 50;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Unequip";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn2.Text = "Unequip";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 50;
            // 
            // lblLocationDescription
            // 
            this.lblLocationDescription.AutoSize = true;
            this.lblLocationDescription.Location = new System.Drawing.Point(316, 198);
            this.lblLocationDescription.Name = "lblLocationDescription";
            this.lblLocationDescription.Size = new System.Drawing.Size(0, 17);
            this.lblLocationDescription.TabIndex = 25;
            // 
            // pbLocationPicture
            // 
            this.pbLocationPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLocationPicture.Location = new System.Drawing.Point(347, 43);
            this.pbLocationPicture.Name = "pbLocationPicture";
            this.pbLocationPicture.Size = new System.Drawing.Size(125, 125);
            this.pbLocationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocationPicture.TabIndex = 26;
            this.pbLocationPicture.TabStop = false;
            // 
            // pbEnemyPicture
            // 
            this.pbEnemyPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnemyPicture.Location = new System.Drawing.Point(347, 273);
            this.pbEnemyPicture.Name = "pbEnemyPicture";
            this.pbEnemyPicture.Size = new System.Drawing.Size(125, 125);
            this.pbEnemyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyPicture.TabIndex = 27;
            this.pbEnemyPicture.TabStop = false;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(316, 242);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(0, 17);
            this.lblEnemyName.TabIndex = 28;
            // 
            // lblEnemyDescription
            // 
            this.lblEnemyDescription.AutoSize = true;
            this.lblEnemyDescription.Location = new System.Drawing.Point(316, 415);
            this.lblEnemyDescription.Name = "lblEnemyDescription";
            this.lblEnemyDescription.Size = new System.Drawing.Size(0, 17);
            this.lblEnemyDescription.TabIndex = 29;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 31);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 30;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 31;
            this.pictureBox11.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPlayerLevel);
            this.panel1.Controls.Add(this.lblPlayerStrength);
            this.panel1.Controls.Add(this.lblPlayerGold);
            this.panel1.Controls.Add(this.lblPlayerResistance);
            this.panel1.Controls.Add(this.lblPlayerIntellect);
            this.panel1.Controls.Add(this.lblPlayerSpeed);
            this.panel1.Controls.Add(this.lblPlayerLuck);
            this.panel1.Controls.Add(this.lblPlayerDefense);
            this.panel1.Controls.Add(this.lblPlayerMana);
            this.panel1.Controls.Add(this.lblPlayerHealth);
            this.panel1.Controls.Add(this.lblPlayerExperience);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 347);
            this.panel1.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Experience:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.Location = new System.Drawing.Point(54, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Health:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Strength:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Defense:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Luck:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Intellect:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resistance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gold:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Level:";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.AutoSize = true;
            this.lblPlayerLevel.Location = new System.Drawing.Point(173, 12);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerLevel.TabIndex = 10;
            // 
            // lblPlayerStrength
            // 
            this.lblPlayerStrength.AutoSize = true;
            this.lblPlayerStrength.Location = new System.Drawing.Point(173, 144);
            this.lblPlayerStrength.Name = "lblPlayerStrength";
            this.lblPlayerStrength.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerStrength.TabIndex = 9;
            // 
            // lblPlayerGold
            // 
            this.lblPlayerGold.AutoSize = true;
            this.lblPlayerGold.Location = new System.Drawing.Point(173, 324);
            this.lblPlayerGold.Name = "lblPlayerGold";
            this.lblPlayerGold.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerGold.TabIndex = 8;
            // 
            // lblPlayerResistance
            // 
            this.lblPlayerResistance.AutoSize = true;
            this.lblPlayerResistance.Location = new System.Drawing.Point(173, 291);
            this.lblPlayerResistance.Name = "lblPlayerResistance";
            this.lblPlayerResistance.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerResistance.TabIndex = 7;
            // 
            // lblPlayerIntellect
            // 
            this.lblPlayerIntellect.AutoSize = true;
            this.lblPlayerIntellect.Location = new System.Drawing.Point(173, 260);
            this.lblPlayerIntellect.Name = "lblPlayerIntellect";
            this.lblPlayerIntellect.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerIntellect.TabIndex = 6;
            // 
            // lblPlayerSpeed
            // 
            this.lblPlayerSpeed.AutoSize = true;
            this.lblPlayerSpeed.Location = new System.Drawing.Point(173, 229);
            this.lblPlayerSpeed.Name = "lblPlayerSpeed";
            this.lblPlayerSpeed.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerSpeed.TabIndex = 5;
            // 
            // lblPlayerLuck
            // 
            this.lblPlayerLuck.AutoSize = true;
            this.lblPlayerLuck.Location = new System.Drawing.Point(173, 201);
            this.lblPlayerLuck.Name = "lblPlayerLuck";
            this.lblPlayerLuck.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerLuck.TabIndex = 4;
            // 
            // lblPlayerDefense
            // 
            this.lblPlayerDefense.AutoSize = true;
            this.lblPlayerDefense.Location = new System.Drawing.Point(173, 175);
            this.lblPlayerDefense.Name = "lblPlayerDefense";
            this.lblPlayerDefense.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerDefense.TabIndex = 3;
            // 
            // lblPlayerMana
            // 
            this.lblPlayerMana.AutoSize = true;
            this.lblPlayerMana.Location = new System.Drawing.Point(173, 113);
            this.lblPlayerMana.Name = "lblPlayerMana";
            this.lblPlayerMana.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerMana.TabIndex = 2;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(173, 82);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerHealth.TabIndex = 1;
            // 
            // lblPlayerExperience
            // 
            this.lblPlayerExperience.AutoSize = true;
            this.lblPlayerExperience.Location = new System.Drawing.Point(173, 51);
            this.lblPlayerExperience.Name = "lblPlayerExperience";
            this.lblPlayerExperience.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerExperience.TabIndex = 0;
            // 
            // dgvBattleSpells
            // 
            this.dgvBattleSpells.AllowUserToAddRows = false;
            this.dgvBattleSpells.AllowUserToDeleteRows = false;
            this.dgvBattleSpells.AllowUserToResizeColumns = false;
            this.dgvBattleSpells.AllowUserToResizeRows = false;
            this.dgvBattleSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBattleSpells.ColumnHeadersVisible = false;
            this.dgvBattleSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBattleSpellsID,
            this.colBattleSpellsName,
            this.colBattleSpellsManaCost,
            this.colBattleSpellsCast});
            this.dgvBattleSpells.Location = new System.Drawing.Point(522, 260);
            this.dgvBattleSpells.Name = "dgvBattleSpells";
            this.dgvBattleSpells.ReadOnly = true;
            this.dgvBattleSpells.RowHeadersVisible = false;
            this.dgvBattleSpells.RowTemplate.Height = 24;
            this.dgvBattleSpells.Size = new System.Drawing.Size(240, 150);
            this.dgvBattleSpells.TabIndex = 33;
            this.dgvBattleSpells.Visible = false;
            // 
            // colBattleSpellsID
            // 
            this.colBattleSpellsID.HeaderText = "ID";
            this.colBattleSpellsID.Name = "colBattleSpellsID";
            this.colBattleSpellsID.ReadOnly = true;
            this.colBattleSpellsID.Visible = false;
            // 
            // colBattleSpellsName
            // 
            this.colBattleSpellsName.HeaderText = "Name";
            this.colBattleSpellsName.Name = "colBattleSpellsName";
            this.colBattleSpellsName.ReadOnly = true;
            this.colBattleSpellsName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colBattleSpellsManaCost
            // 
            this.colBattleSpellsManaCost.HeaderText = "Mana Cost";
            this.colBattleSpellsManaCost.Name = "colBattleSpellsManaCost";
            this.colBattleSpellsManaCost.ReadOnly = true;
            this.colBattleSpellsManaCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBattleSpellsManaCost.Width = 30;
            // 
            // colBattleSpellsCast
            // 
            this.colBattleSpellsCast.HeaderText = "Cast";
            this.colBattleSpellsCast.Name = "colBattleSpellsCast";
            this.colBattleSpellsCast.ReadOnly = true;
            this.colBattleSpellsCast.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBattleSpellsCast.Text = "Cast";
            this.colBattleSpellsCast.UseColumnTextForButtonValue = true;
            this.colBattleSpellsCast.Width = 40;
            // 
            // dgvBattleItems
            // 
            this.dgvBattleItems.AllowUserToAddRows = false;
            this.dgvBattleItems.AllowUserToDeleteRows = false;
            this.dgvBattleItems.AllowUserToResizeColumns = false;
            this.dgvBattleItems.AllowUserToResizeRows = false;
            this.dgvBattleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBattleItems.ColumnHeadersVisible = false;
            this.dgvBattleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBattleItemsID,
            this.colBattleItemsName,
            this.colBattleItemsQuantity,
            this.colBattleItemsUse});
            this.dgvBattleItems.Location = new System.Drawing.Point(509, 18);
            this.dgvBattleItems.Name = "dgvBattleItems";
            this.dgvBattleItems.ReadOnly = true;
            this.dgvBattleItems.RowHeadersVisible = false;
            this.dgvBattleItems.RowTemplate.Height = 24;
            this.dgvBattleItems.Size = new System.Drawing.Size(240, 150);
            this.dgvBattleItems.TabIndex = 34;
            // 
            // colBattleItemsID
            // 
            this.colBattleItemsID.HeaderText = "ID";
            this.colBattleItemsID.Name = "colBattleItemsID";
            this.colBattleItemsID.ReadOnly = true;
            this.colBattleItemsID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBattleItemsID.Visible = false;
            // 
            // colBattleItemsName
            // 
            this.colBattleItemsName.HeaderText = "Name";
            this.colBattleItemsName.Name = "colBattleItemsName";
            this.colBattleItemsName.ReadOnly = true;
            this.colBattleItemsName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBattleItemsName.Width = 80;
            // 
            // colBattleItemsQuantity
            // 
            this.colBattleItemsQuantity.HeaderText = "Quantity";
            this.colBattleItemsQuantity.Name = "colBattleItemsQuantity";
            this.colBattleItemsQuantity.ReadOnly = true;
            this.colBattleItemsQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBattleItemsQuantity.Width = 30;
            // 
            // colBattleItemsUse
            // 
            this.colBattleItemsUse.HeaderText = "Use";
            this.colBattleItemsUse.Name = "colBattleItemsUse";
            this.colBattleItemsUse.ReadOnly = true;
            this.colBattleItemsUse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colBattleItemsUse.Text = "Use";
            this.colBattleItemsUse.UseColumnTextForButtonValue = true;
            this.colBattleItemsUse.Width = 40;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(368, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEmpower
            // 
            this.btnEmpower.Location = new System.Drawing.Point(368, 488);
            this.btnEmpower.Name = "btnEmpower";
            this.btnEmpower.Size = new System.Drawing.Size(75, 23);
            this.btnEmpower.TabIndex = 36;
            this.btnEmpower.Text = "Empower";
            this.btnEmpower.UseVisualStyleBackColor = true;
            this.btnEmpower.Click += new System.EventHandler(this.btnEmpower_Click);
            // 
            // btnGreed
            // 
            this.btnGreed.Location = new System.Drawing.Point(368, 526);
            this.btnGreed.Name = "btnGreed";
            this.btnGreed.Size = new System.Drawing.Size(75, 23);
            this.btnGreed.TabIndex = 37;
            this.btnGreed.Text = "Greed";
            this.btnGreed.UseVisualStyleBackColor = true;
            this.btnGreed.Click += new System.EventHandler(this.btnGreed_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 572);
            this.Controls.Add(this.btnGreed);
            this.Controls.Add(this.btnEmpower);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvBattleItems);
            this.Controls.Add(this.dgvBattleSpells);
            this.Controls.Add(this.lblEnemyDescription);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.pbEnemyPicture);
            this.Controls.Add(this.pbLocationPicture);
            this.Controls.Add(this.lblLocationDescription);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero Quest";
            this.tbcInventory.ResumeLayout(false);
            this.tbpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tbpEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.tbpSpells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpells)).EndInit();
            this.tbpQuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocationPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBattleSpells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBattleItems)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Label lblLocationDescription;
        private System.Windows.Forms.PictureBox pbLocationPicture;
        private System.Windows.Forms.PictureBox pbEnemyPicture;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyDescription;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentName;
        private DataGridViewDisableButtonColumn colEquipmentEquip;
        private DataGridViewDisableButtonColumn colEquipmentUnequip;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label lblPlayerStrength;
        private System.Windows.Forms.Label lblPlayerGold;
        private System.Windows.Forms.Label lblPlayerResistance;
        private System.Windows.Forms.Label lblPlayerIntellect;
        private System.Windows.Forms.Label lblPlayerSpeed;
        private System.Windows.Forms.Label lblPlayerLuck;
        private System.Windows.Forms.Label lblPlayerDefense;
        private System.Windows.Forms.Label lblPlayerMana;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblPlayerExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpellManaCost;
        private DataGridViewDisableButtonColumn colSpellCast;
        private System.Windows.Forms.DataGridView dgvBattleSpells;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattleSpellsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattleSpellsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattleSpellsManaCost;
        private DataGridViewDisableButtonColumn colBattleSpellsCast;
        private System.Windows.Forms.DataGridView dgvBattleItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattleItemsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattleItemsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBattleItemsQuantity;
        private DataGridViewDisableButtonColumn colBattleItemsUse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEmpower;
        private System.Windows.Forms.Button btnGreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private DataGridViewDisableButtonColumn colItemUse;
        private System.Windows.Forms.DataGridViewImageColumn test;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

