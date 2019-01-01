namespace UIWindowsForm
{
    partial class TradingPoo
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
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.dgvVendor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(12, 164);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.RowTemplate.Height = 24;
            this.dgvPlayer.Size = new System.Drawing.Size(388, 274);
            this.dgvPlayer.TabIndex = 0;
            // 
            // dgvVendor
            // 
            this.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendor.Location = new System.Drawing.Point(406, 164);
            this.dgvVendor.Name = "dgvVendor";
            this.dgvVendor.RowTemplate.Height = 24;
            this.dgvVendor.Size = new System.Drawing.Size(382, 274);
            this.dgvVendor.TabIndex = 1;
            // 
            // TradingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVendor);
            this.Controls.Add(this.dgvPlayer);
            this.Name = "TradingScreen";
            this.Text = "TradingScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TradingScreen_FormClosing_1);
            this.Load += new System.EventHandler(this.TradingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.DataGridView dgvVendor;
    }
}