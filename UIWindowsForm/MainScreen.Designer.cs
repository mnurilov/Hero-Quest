﻿namespace UIWindowsForm
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
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLuck = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblIntellect = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.rtbBattle = new System.Windows.Forms.RichTextBox();
            this.btnShopExit = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnSpell = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationDescription = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.pbEnemyPicture = new System.Windows.Forms.PictureBox();
            this.pbLocationPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNorth
            // 
            this.btnNorth.Enabled = false;
            this.btnNorth.Location = new System.Drawing.Point(681, 396);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(102, 37);
            this.btnNorth.TabIndex = 3;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(681, 482);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(102, 37);
            this.btnSouth.TabIndex = 4;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(573, 439);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(102, 37);
            this.btnWest.TabIndex = 6;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(789, 439);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(102, 37);
            this.btnEast.TabIndex = 5;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(120, 348);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(78, 110);
            this.btnShop.TabIndex = 7;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Level:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(130, 42);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 17);
            this.lblLevel.TabIndex = 10;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(130, 69);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 17);
            this.lblExperience.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Experience:";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(130, 123);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(0, 17);
            this.lblMana.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mana:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(130, 96);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(0, 17);
            this.lblHealth.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Health:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(130, 231);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(0, 17);
            this.lblSpeed.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Speed:";
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Location = new System.Drawing.Point(130, 204);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(0, 17);
            this.lblLuck.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Luck:";
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Location = new System.Drawing.Point(130, 177);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(0, 17);
            this.lblDefense.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Defense:";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(130, 150);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(0, 17);
            this.lblAttack.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Attack:";
            // 
            // lblIntellect
            // 
            this.lblIntellect.AutoSize = true;
            this.lblIntellect.Location = new System.Drawing.Point(130, 258);
            this.lblIntellect.Name = "lblIntellect";
            this.lblIntellect.Size = new System.Drawing.Size(0, 17);
            this.lblIntellect.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "Intellect:";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Location = new System.Drawing.Point(130, 285);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(0, 17);
            this.lblResistance.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Resistance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Class:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(130, 15);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 17);
            this.lblClass.TabIndex = 30;
            // 
            // rtbBattle
            // 
            this.rtbBattle.Location = new System.Drawing.Point(566, 12);
            this.rtbBattle.Name = "rtbBattle";
            this.rtbBattle.Size = new System.Drawing.Size(330, 350);
            this.rtbBattle.TabIndex = 31;
            this.rtbBattle.Text = "";
            // 
            // btnShopExit
            // 
            this.btnShopExit.Location = new System.Drawing.Point(39, 348);
            this.btnShopExit.Name = "btnShopExit";
            this.btnShopExit.Size = new System.Drawing.Size(75, 110);
            this.btnShopExit.TabIndex = 32;
            this.btnShopExit.Text = "Exit";
            this.btnShopExit.UseVisualStyleBackColor = true;
            this.btnShopExit.Click += new System.EventHandler(this.btnShopExit_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(218, 426);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(153, 50);
            this.btnAttack.TabIndex = 33;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(218, 495);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(153, 50);
            this.btnItem.TabIndex = 34;
            this.btnItem.Text = "Items";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnSpell
            // 
            this.btnSpell.Location = new System.Drawing.Point(383, 426);
            this.btnSpell.Name = "btnSpell";
            this.btnSpell.Size = new System.Drawing.Size(153, 50);
            this.btnSpell.TabIndex = 35;
            this.btnSpell.Text = "Spell";
            this.btnSpell.UseVisualStyleBackColor = true;
            this.btnSpell.Click += new System.EventHandler(this.btnSpell_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(383, 495);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(153, 50);
            this.btnRun.TabIndex = 36;
            this.btnRun.Text = "Run Away";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnMap
            // 
            this.btnMap.Enabled = false;
            this.btnMap.Location = new System.Drawing.Point(681, 439);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(102, 37);
            this.btnMap.TabIndex = 39;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(226, -3);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(0, 23);
            this.lblLocationName.TabIndex = 40;
            this.lblLocationName.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblLocationDescription
            // 
            this.lblLocationDescription.AutoSize = true;
            this.lblLocationDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDescription.Location = new System.Drawing.Point(226, 182);
            this.lblLocationDescription.Name = "lblLocationDescription";
            this.lblLocationDescription.Size = new System.Drawing.Size(0, 21);
            this.lblLocationDescription.TabIndex = 41;
            this.lblLocationDescription.Click += new System.EventHandler(this.lblLocationDescription_Click);
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.Location = new System.Drawing.Point(226, 252);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(0, 23);
            this.lblEnemyName.TabIndex = 42;
            this.lblEnemyName.Click += new System.EventHandler(this.lblEnemyName_Click);
            // 
            // pbEnemyPicture
            // 
            this.pbEnemyPicture.Location = new System.Drawing.Point(306, 270);
            this.pbEnemyPicture.Name = "pbEnemyPicture";
            this.pbEnemyPicture.Size = new System.Drawing.Size(150, 150);
            this.pbEnemyPicture.TabIndex = 43;
            this.pbEnemyPicture.TabStop = false;
            // 
            // pbLocationPicture
            // 
            this.pbLocationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLocationPicture.ImageLocation = "C:\\Users\\Michael\\Documents\\GitHub\\Hero-Quest\\Test\\House.png";
            this.pbLocationPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLocationPicture.InitialImage")));
            this.pbLocationPicture.Location = new System.Drawing.Point(306, 57);
            this.pbLocationPicture.Name = "pbLocationPicture";
            this.pbLocationPicture.Size = new System.Drawing.Size(150, 150);
            this.pbLocationPicture.TabIndex = 37;
            this.pbLocationPicture.TabStop = false;
            this.pbLocationPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(908, 549);
            this.Controls.Add(this.pbEnemyPicture);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblLocationDescription);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.pbLocationPicture);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSpell);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnShopExit);
            this.Controls.Add(this.rtbBattle);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIntellect);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblLuck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblIntellect;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.RichTextBox rtbBattle;
        private System.Windows.Forms.Button btnShopExit;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnSpell;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox pbLocationPicture;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblLocationDescription;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.PictureBox pbEnemyPicture;
    }
}
