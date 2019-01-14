namespace UI
{
    partial class DeathScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathScreen));
            this.pbYouDied = new System.Windows.Forms.PictureBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbYouDied)).BeginInit();
            this.SuspendLayout();
            // 
            // pbYouDied
            // 
            this.pbYouDied.Image = ((System.Drawing.Image)(resources.GetObject("pbYouDied.Image")));
            this.pbYouDied.Location = new System.Drawing.Point(14, 12);
            this.pbYouDied.Name = "pbYouDied";
            this.pbYouDied.Size = new System.Drawing.Size(850, 175);
            this.pbYouDied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYouDied.TabIndex = 0;
            this.pbYouDied.TabStop = false;
            // 
            // lblExplanation
            // 
            this.lblExplanation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(253, 231);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(368, 229);
            this.lblExplanation.TabIndex = 1;
            this.lblExplanation.Text = "asdkaojdoasdjas";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(320, 500);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(234, 54);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(878, 566);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.pbYouDied);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hero Quest";
            ((System.ComponentModel.ISupportInitialize)(this.pbYouDied)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbYouDied;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Button btnContinue;
    }
}