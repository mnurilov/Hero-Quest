namespace UIWindowsForm
{
    partial class Form1
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
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(535, 12);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.Size = new System.Drawing.Size(361, 374);
            this.rtbLocation.TabIndex = 2;
            this.rtbLocation.Text = "";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(666, 414);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(102, 37);
            this.btnNorth.TabIndex = 3;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(666, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(102, 37);
            this.btnSouth.TabIndex = 4;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(558, 453);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(102, 37);
            this.btnWest.TabIndex = 6;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(774, 453);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(102, 37);
            this.btnEast.TabIndex = 5;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(908, 549);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.rtbLocation);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
    }
}

