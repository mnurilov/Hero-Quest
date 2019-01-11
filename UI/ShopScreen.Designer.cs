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
            this.dgvPlayerInventory = new System.Windows.Forms.DataGridView();
            this.dgvVendorInventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerGold = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorInventory)).BeginInit();
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
            this.dgvPlayerInventory.Location = new System.Drawing.Point(12, 195);
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
            this.dgvVendorInventory.Location = new System.Drawing.Point(416, 195);
            this.dgvVendorInventory.Name = "dgvVendorInventory";
            this.dgvVendorInventory.ReadOnly = true;
            this.dgvVendorInventory.RowHeadersVisible = false;
            this.dgvVendorInventory.RowTemplate.Height = 24;
            this.dgvVendorInventory.Size = new System.Drawing.Size(372, 243);
            this.dgvVendorInventory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(78, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(46, 17);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gold";
            // 
            // lblPlayerGold
            // 
            this.lblPlayerGold.AutoSize = true;
            this.lblPlayerGold.Location = new System.Drawing.Point(253, 13);
            this.lblPlayerGold.Name = "lblPlayerGold";
            this.lblPlayerGold.Size = new System.Drawing.Size(46, 17);
            this.lblPlayerGold.TabIndex = 5;
            this.lblPlayerGold.Text = "label4";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(13, 64);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(46, 17);
            this.lblVendorName.TabIndex = 6;
            this.lblVendorName.Text = "label2";
            // 
            // lblVendorDescription
            // 
            this.lblVendorDescription.AutoSize = true;
            this.lblVendorDescription.Location = new System.Drawing.Point(12, 85);
            this.lblVendorDescription.Name = "lblVendorDescription";
            this.lblVendorDescription.Size = new System.Drawing.Size(46, 17);
            this.lblVendorDescription.TabIndex = 7;
            this.lblVendorDescription.Text = "label4";
            // 
            // ShopScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVendorDescription);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblPlayerGold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVendorInventory);
            this.Controls.Add(this.dgvPlayerInventory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopScreen";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayerInventory;
        private System.Windows.Forms.DataGridView dgvVendorInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerGold;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorDescription;
    }
}