namespace UIWindowsForm
{
    partial class TradingScreen
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.dgvPlayerInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerInventory.Location = new System.Drawing.Point(12, 191);
            this.dgvPlayerInventory.Name = "dgvPlayerInventory";
            this.dgvPlayerInventory.ReadOnly = true;
            this.dgvPlayerInventory.RowHeadersVisible = false;
            this.dgvPlayerInventory.RowTemplate.Height = 24;
            this.dgvPlayerInventory.Size = new System.Drawing.Size(380, 250);
            this.dgvPlayerInventory.TabIndex = 0;
            // 
            // dgvVendorInventory
            // 
            this.dgvVendorInventory.AllowUserToAddRows = false;
            this.dgvVendorInventory.AllowUserToDeleteRows = false;
            this.dgvVendorInventory.AllowUserToResizeColumns = false;
            this.dgvVendorInventory.AllowUserToResizeRows = false;
            this.dgvVendorInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorInventory.Location = new System.Drawing.Point(408, 191);
            this.dgvVendorInventory.Name = "dgvVendorInventory";
            this.dgvVendorInventory.ReadOnly = true;
            this.dgvVendorInventory.RowHeadersVisible = false;
            this.dgvVendorInventory.RowTemplate.Height = 24;
            this.dgvVendorInventory.Size = new System.Drawing.Size(380, 250);
            this.dgvVendorInventory.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TradingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVendorInventory);
            this.Controls.Add(this.dgvPlayerInventory);
            this.Name = "TradingScreen";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayerInventory;
        private System.Windows.Forms.DataGridView dgvVendorInventory;
        private System.Windows.Forms.Button button1;
    }
}