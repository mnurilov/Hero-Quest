namespace UIWindowsForm
{
    partial class InnScreen
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblInnName = new System.Windows.Forms.Label();
            this.btnStay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(599, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(13, 13);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(0, 17);
            this.lblPersonName.TabIndex = 1;
            // 
            // lblInnName
            // 
            this.lblInnName.AutoSize = true;
            this.lblInnName.Location = new System.Drawing.Point(12, 232);
            this.lblInnName.Name = "lblInnName";
            this.lblInnName.Size = new System.Drawing.Size(0, 17);
            this.lblInnName.TabIndex = 2;
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(493, 249);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(115, 46);
            this.btnStay.TabIndex = 3;
            this.btnStay.Text = "Stay at Inn";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // InnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.lblInnName);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "InnScreen";
            this.Text = "InnScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblInnName;
        private System.Windows.Forms.Button btnStay;
    }
}