namespace UI
{
    partial class CharacterCreationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreationScreen));
            this.pbWarrior = new System.Windows.Forms.PictureBox();
            this.pbMage = new System.Windows.Forms.PictureBox();
            this.pbThief = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThief)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWarrior
            // 
            this.pbWarrior.Location = new System.Drawing.Point(105, 167);
            this.pbWarrior.Name = "pbWarrior";
            this.pbWarrior.Size = new System.Drawing.Size(125, 125);
            this.pbWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarrior.TabIndex = 0;
            this.pbWarrior.TabStop = false;
            // 
            // pbMage
            // 
            this.pbMage.Location = new System.Drawing.Point(338, 167);
            this.pbMage.Name = "pbMage";
            this.pbMage.Size = new System.Drawing.Size(125, 125);
            this.pbMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMage.TabIndex = 1;
            this.pbMage.TabStop = false;
            // 
            // pbThief
            // 
            this.pbThief.Location = new System.Drawing.Point(581, 167);
            this.pbThief.Name = "pbThief";
            this.pbThief.Size = new System.Drawing.Size(125, 125);
            this.pbThief.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThief.TabIndex = 2;
            this.pbThief.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Finish Character Creation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CharacterCreationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbThief);
            this.Controls.Add(this.pbMage);
            this.Controls.Add(this.pbWarrior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterCreationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hero Quest";
            ((System.ComponentModel.ISupportInitialize)(this.pbWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThief)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWarrior;
        private System.Windows.Forms.PictureBox pbMage;
        private System.Windows.Forms.PictureBox pbThief;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}