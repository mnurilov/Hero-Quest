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
            this.tbpEquipment = new System.Windows.Forms.TabPage();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.colEquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipmentEquip = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEquipmentUnequip = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbpSpells = new System.Windows.Forms.TabPage();
            this.dgvSpells = new System.Windows.Forms.DataGridView();
            this.colSpellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colItemUse});
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
            // tbpEquipment
            // 
            this.tbpEquipment.Controls.Add(this.dgvEquipment);
            this.tbpEquipment.Location = new System.Drawing.Point(4, 25);
            this.tbpEquipment.Name = "tbpEquipment";
            this.tbpEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEquipment.Size = new System.Drawing.Size(273, 203);
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
            this.tbpSpells.Size = new System.Drawing.Size(273, 203);
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
            this.colSpellName});
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
            // tbpQuests
            // 
            this.tbpQuests.Controls.Add(this.dgvQuests);
            this.tbpQuests.Location = new System.Drawing.Point(4, 25);
            this.tbpQuests.Name = "tbpQuests";
            this.tbpQuests.Size = new System.Drawing.Size(273, 203);
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
            this.pictureBox10.Location = new System.Drawing.Point(12, 43);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 30;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(12, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 31;
            this.pictureBox11.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 347);
            this.panel1.TabIndex = 32;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 572);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentName;
        private System.Windows.Forms.DataGridViewButtonColumn colEquipmentEquip;
        private System.Windows.Forms.DataGridViewButtonColumn colEquipmentUnequip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpellName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private DataGridViewDisableButtonColumn colItemUse;
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
    }
}

