namespace UI
{
    partial class PersonScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonScreen));
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lblPersonStatement = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPerson
            // 
            this.pbPerson.Location = new System.Drawing.Point(231, 121);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(125, 125);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerson.TabIndex = 41;
            this.pbPerson.TabStop = false;
            // 
            // lblPersonStatement
            // 
            this.lblPersonStatement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonStatement.Location = new System.Drawing.Point(78, 273);
            this.lblPersonStatement.Name = "lblPersonStatement";
            this.lblPersonStatement.Size = new System.Drawing.Size(441, 72);
            this.lblPersonStatement.TabIndex = 40;
            this.lblPersonStatement.Text = "label1";
            this.lblPersonStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonName
            // 
            this.lblPersonName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.Location = new System.Drawing.Point(142, 42);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(312, 42);
            this.lblPersonName.TabIndex = 39;
            this.lblPersonName.Text = "label1";
            this.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(597, 386);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lblPersonStatement);
            this.Controls.Add(this.lblPersonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PersonScreen_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lblPersonStatement;
        private System.Windows.Forms.Label lblPersonName;
    }
}