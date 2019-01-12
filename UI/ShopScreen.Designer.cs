namespace UI
{
    partial class ShopScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopScreen));
            this.dgvPlayerInventory = new System.Windows.Forms.DataGridView();
            this.dgvVendorInventory = new System.Windows.Forms.DataGridView();
            this.lblPlayerNameLabel = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerGoldLabel = new System.Windows.Forms.Label();
            this.lblPlayerGold = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorDescription = new System.Windows.Forms.Label();
            this.pbPlayerName = new System.Windows.Forms.PictureBox();
            this.pbPlayerGold = new System.Windows.Forms.PictureBox();
            this.pbVendorPicture = new System.Windows.Forms.PictureBox();
            this.lblPlayerInventoryLabel = new System.Windows.Forms.Label();
            this.lblVendorInventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayerInventory
            // 
            this.dgvPlayerInventory.AllowUserToAddRows = false;
            this.dgvPlayerInventory.AllowUserToDeleteRows = false;
            this.dgvPlayerInventory.AllowUserToResizeColumns = false;
            this.dgvPlayerInventory.AllowUserToResizeRows = false;
            this.dgvPlayerInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlayerInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerInventory.Location = new System.Drawing.Point(12, 354);
            this.dgvPlayerInventory.Name = "dgvPlayerInventory";
            this.dgvPlayerInventory.ReadOnly = true;
            this.dgvPlayerInventory.RowHeadersVisible = false;
            this.dgvPlayerInventory.RowTemplate.Height = 24;
            this.dgvPlayerInventory.Size = new System.Drawing.Size(384, 243);
            this.dgvPlayerInventory.TabIndex = 0;
            // 
            // dgvVendorInventory
            // 
            this.dgvVendorInventory.AllowUserToAddRows = false;
            this.dgvVendorInventory.AllowUserToDeleteRows = false;
            this.dgvVendorInventory.AllowUserToResizeColumns = false;
            this.dgvVendorInventory.AllowUserToResizeRows = false;
            this.dgvVendorInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVendorInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorInventory.Location = new System.Drawing.Point(404, 354);
            this.dgvVendorInventory.Name = "dgvVendorInventory";
            this.dgvVendorInventory.ReadOnly = true;
            this.dgvVendorInventory.RowHeadersVisible = false;
            this.dgvVendorInventory.RowTemplate.Height = 24;
            this.dgvVendorInventory.Size = new System.Drawing.Size(384, 243);
            this.dgvVendorInventory.TabIndex = 1;
            // 
            // lblPlayerNameLabel
            // 
            this.lblPlayerNameLabel.AutoSize = true;
            this.lblPlayerNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameLabel.Location = new System.Drawing.Point(57, 17);
            this.lblPlayerNameLabel.Name = "lblPlayerNameLabel";
            this.lblPlayerNameLabel.Size = new System.Drawing.Size(66, 21);
            this.lblPlayerNameLabel.TabIndex = 2;
            this.lblPlayerNameLabel.Text = "Name:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(150, 17);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(60, 21);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "label2";
            // 
            // lblPlayerGoldLabel
            // 
            this.lblPlayerGoldLabel.AutoSize = true;
            this.lblPlayerGoldLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerGoldLabel.Location = new System.Drawing.Point(57, 67);
            this.lblPlayerGoldLabel.Name = "lblPlayerGoldLabel";
            this.lblPlayerGoldLabel.Size = new System.Drawing.Size(56, 21);
            this.lblPlayerGoldLabel.TabIndex = 4;
            this.lblPlayerGoldLabel.Text = "Gold:";
            // 
            // lblPlayerGold
            // 
            this.lblPlayerGold.AutoSize = true;
            this.lblPlayerGold.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerGold.Location = new System.Drawing.Point(150, 67);
            this.lblPlayerGold.Name = "lblPlayerGold";
            this.lblPlayerGold.Size = new System.Drawing.Size(60, 21);
            this.lblPlayerGold.TabIndex = 5;
            this.lblPlayerGold.Text = "label4";
            // 
            // lblVendorName
            // 
            this.lblVendorName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.Location = new System.Drawing.Point(416, 9);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(360, 32);
            this.lblVendorName.TabIndex = 6;
            this.lblVendorName.Text = "label2";
            this.lblVendorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVendorDescription
            // 
            this.lblVendorDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorDescription.Location = new System.Drawing.Point(416, 222);
            this.lblVendorDescription.Name = "lblVendorDescription";
            this.lblVendorDescription.Size = new System.Drawing.Size(355, 56);
            this.lblVendorDescription.TabIndex = 7;
            this.lblVendorDescription.Text = "label4";
            this.lblVendorDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPlayerName
            // 
            this.pbPlayerName.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerName.Image")));
            this.pbPlayerName.Location = new System.Drawing.Point(15, 15);
            this.pbPlayerName.Name = "pbPlayerName";
            this.pbPlayerName.Size = new System.Drawing.Size(25, 25);
            this.pbPlayerName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerName.TabIndex = 33;
            this.pbPlayerName.TabStop = false;
            // 
            // pbPlayerGold
            // 
            this.pbPlayerGold.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerGold.Image")));
            this.pbPlayerGold.Location = new System.Drawing.Point(15, 65);
            this.pbPlayerGold.Name = "pbPlayerGold";
            this.pbPlayerGold.Size = new System.Drawing.Size(25, 25);
            this.pbPlayerGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerGold.TabIndex = 34;
            this.pbPlayerGold.TabStop = false;
            // 
            // pbVendorPicture
            // 
            this.pbVendorPicture.Location = new System.Drawing.Point(529, 67);
            this.pbVendorPicture.Name = "pbVendorPicture";
            this.pbVendorPicture.Size = new System.Drawing.Size(125, 125);
            this.pbVendorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVendorPicture.TabIndex = 35;
            this.pbVendorPicture.TabStop = false;
            // 
            // lblPlayerInventoryLabel
            // 
            this.lblPlayerInventoryLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInventoryLabel.Location = new System.Drawing.Point(26, 298);
            this.lblPlayerInventoryLabel.Name = "lblPlayerInventoryLabel";
            this.lblPlayerInventoryLabel.Size = new System.Drawing.Size(356, 44);
            this.lblPlayerInventoryLabel.TabIndex = 36;
            this.lblPlayerInventoryLabel.Text = "Player Inventory";
            this.lblPlayerInventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVendorInventoryLabel
            // 
            this.lblVendorInventoryLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorInventoryLabel.Location = new System.Drawing.Point(418, 298);
            this.lblVendorInventoryLabel.Name = "lblVendorInventoryLabel";
            this.lblVendorInventoryLabel.Size = new System.Drawing.Size(356, 44);
            this.lblVendorInventoryLabel.TabIndex = 37;
            this.lblVendorInventoryLabel.Text = "Vendor Inventory";
            this.lblVendorInventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShopScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.lblVendorInventoryLabel);
            this.Controls.Add(this.lblPlayerInventoryLabel);
            this.Controls.Add(this.pbVendorPicture);
            this.Controls.Add(this.pbPlayerGold);
            this.Controls.Add(this.pbPlayerName);
            this.Controls.Add(this.lblVendorDescription);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblPlayerGold);
            this.Controls.Add(this.lblPlayerGoldLabel);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerNameLabel);
            this.Controls.Add(this.dgvVendorInventory);
            this.Controls.Add(this.dgvPlayerInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayerInventory;
        private System.Windows.Forms.DataGridView dgvVendorInventory;
        private System.Windows.Forms.Label lblPlayerNameLabel;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerGoldLabel;
        private System.Windows.Forms.Label lblPlayerGold;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorDescription;
        private System.Windows.Forms.PictureBox pbPlayerName;
        private System.Windows.Forms.PictureBox pbPlayerGold;
        private System.Windows.Forms.PictureBox pbVendorPicture;
        private System.Windows.Forms.Label lblPlayerInventoryLabel;
        private System.Windows.Forms.Label lblVendorInventoryLabel;
    }
}