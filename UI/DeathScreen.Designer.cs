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
            this.pbSkull1 = new System.Windows.Forms.PictureBox();
            this.pbSkull2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbYouDied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkull1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkull2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbYouDied
            // 
            this.pbYouDied.Image = ((System.Drawing.Image)(resources.GetObject("pbYouDied.Image")));
            this.pbYouDied.Location = new System.Drawing.Point(31, 12);
            this.pbYouDied.Name = "pbYouDied";
            this.pbYouDied.Size = new System.Drawing.Size(850, 175);
            this.pbYouDied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYouDied.TabIndex = 0;
            this.pbYouDied.TabStop = false;
            // 
            // lblExplanation
            // 
            this.lblExplanation.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.ForeColor = System.Drawing.Color.White;
            this.lblExplanation.Location = new System.Drawing.Point(172, 233);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(567, 229);
            this.lblExplanation.TabIndex = 1;
            this.lblExplanation.Text = "asdkaojdoasdjas";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(339, 500);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(234, 54);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pbSkull1
            // 
            this.pbSkull1.Image = ((System.Drawing.Image)(resources.GetObject("pbSkull1.Image")));
            this.pbSkull1.Location = new System.Drawing.Point(751, 270);
            this.pbSkull1.Name = "pbSkull1";
            this.pbSkull1.Size = new System.Drawing.Size(150, 150);
            this.pbSkull1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSkull1.TabIndex = 3;
            this.pbSkull1.TabStop = false;
            // 
            // pbSkull2
            // 
            this.pbSkull2.Image = ((System.Drawing.Image)(resources.GetObject("pbSkull2.Image")));
            this.pbSkull2.Location = new System.Drawing.Point(11, 270);
            this.pbSkull2.Name = "pbSkull2";
            this.pbSkull2.Size = new System.Drawing.Size(150, 150);
            this.pbSkull2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSkull2.TabIndex = 5;
            this.pbSkull2.TabStop = false;
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 566);
            this.Controls.Add(this.pbSkull2);
            this.Controls.Add(this.pbSkull1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.pbYouDied);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hero Quest";
            ((System.ComponentModel.ISupportInitialize)(this.pbYouDied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkull1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkull2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbYouDied;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox pbSkull1;
        private System.Windows.Forms.PictureBox pbSkull2;
    }
}