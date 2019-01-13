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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblSelectedClass = new System.Windows.Forms.Label();
            this.lblWarriorName = new System.Windows.Forms.Label();
            this.lblThiefName = new System.Windows.Forms.Label();
            this.lblMageName = new System.Windows.Forms.Label();
            this.lblWarriorDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThief)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWarrior
            // 
            this.pbWarrior.Image = ((System.Drawing.Image)(resources.GetObject("pbWarrior.Image")));
            this.pbWarrior.Location = new System.Drawing.Point(84, 207);
            this.pbWarrior.Name = "pbWarrior";
            this.pbWarrior.Size = new System.Drawing.Size(125, 125);
            this.pbWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarrior.TabIndex = 0;
            this.pbWarrior.TabStop = false;
            this.pbWarrior.Click += new System.EventHandler(this.pbWarrior_Click);
            // 
            // pbMage
            // 
            this.pbMage.Image = ((System.Drawing.Image)(resources.GetObject("pbMage.Image")));
            this.pbMage.Location = new System.Drawing.Point(422, 207);
            this.pbMage.Name = "pbMage";
            this.pbMage.Size = new System.Drawing.Size(125, 125);
            this.pbMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMage.TabIndex = 1;
            this.pbMage.TabStop = false;
            this.pbMage.Click += new System.EventHandler(this.pbMage_Click);
            // 
            // pbThief
            // 
            this.pbThief.Image = ((System.Drawing.Image)(resources.GetObject("pbThief.Image")));
            this.pbThief.Location = new System.Drawing.Point(743, 207);
            this.pbThief.Name = "pbThief";
            this.pbThief.Size = new System.Drawing.Size(125, 125);
            this.pbThief.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThief.TabIndex = 2;
            this.pbThief.TabStop = false;
            this.pbThief.Click += new System.EventHandler(this.pbThief_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(401, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 28);
            this.tbName.TabIndex = 3;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(230, 41);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(149, 21);
            this.lblPrompt.TabIndex = 4;
            this.lblPrompt.Text = "Enter your name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(609, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.Location = new System.Drawing.Point(359, 702);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(260, 52);
            this.btnFinished.TabIndex = 6;
            this.btnFinished.Text = "Finish Character Creation";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(190, 101);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(601, 39);
            this.lblConfirmation.TabIndex = 7;
            this.lblConfirmation.Text = "label1";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedClass.Location = new System.Drawing.Point(189, 639);
            this.lblSelectedClass.Name = "lblSelectedClass";
            this.lblSelectedClass.Size = new System.Drawing.Size(601, 39);
            this.lblSelectedClass.TabIndex = 8;
            this.lblSelectedClass.Text = "label1";
            this.lblSelectedClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarriorName
            // 
            this.lblWarriorName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarriorName.Location = new System.Drawing.Point(84, 170);
            this.lblWarriorName.Name = "lblWarriorName";
            this.lblWarriorName.Size = new System.Drawing.Size(125, 28);
            this.lblWarriorName.TabIndex = 9;
            this.lblWarriorName.Text = "Warrior";
            this.lblWarriorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThiefName
            // 
            this.lblThiefName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThiefName.Location = new System.Drawing.Point(743, 170);
            this.lblThiefName.Name = "lblThiefName";
            this.lblThiefName.Size = new System.Drawing.Size(125, 28);
            this.lblThiefName.TabIndex = 10;
            this.lblThiefName.Text = "Thief";
            this.lblThiefName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMageName
            // 
            this.lblMageName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMageName.Location = new System.Drawing.Point(422, 170);
            this.lblMageName.Name = "lblMageName";
            this.lblMageName.Size = new System.Drawing.Size(125, 28);
            this.lblMageName.TabIndex = 11;
            this.lblMageName.Text = "Mage";
            this.lblMageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarriorDescription
            // 
            this.lblWarriorDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarriorDescription.Location = new System.Drawing.Point(16, 352);
            this.lblWarriorDescription.Name = "lblWarriorDescription";
            this.lblWarriorDescription.Size = new System.Drawing.Size(257, 229);
            this.lblWarriorDescription.TabIndex = 12;
            this.lblWarriorDescription.Text = "The warrior is a class of power. Known for having high strength and defense. Warr" +
    "ior\'s can take on the strongest of foes with a sword and shield by their side. W" +
    "arriors, however, are dumb and slow.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 229);
            this.label1.TabIndex = 13;
            this.label1.Text = "The mage is a class of wisdom. Known for having high intellect and resistance. Ma" +
    "ge\'s can take on the smartest of foes with a staff and tome by their side. Mages" +
    ", however, are weak and fragile.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 229);
            this.label2.TabIndex = 14;
            this.label2.Text = "The thief is a class of agility. Known for having high speed and luck. Thieves ca" +
    "n take on the quickest of foes with a pair of daggers at their side. Theives, ho" +
    "wever, are dumb and fragile. ";
            // 
            // CharacterCreationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarriorDescription);
            this.Controls.Add(this.lblMageName);
            this.Controls.Add(this.lblThiefName);
            this.Controls.Add(this.lblWarriorName);
            this.Controls.Add(this.lblSelectedClass);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.tbName);
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
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblSelectedClass;
        private System.Windows.Forms.Label lblWarriorName;
        private System.Windows.Forms.Label lblThiefName;
        private System.Windows.Forms.Label lblMageName;
        private System.Windows.Forms.Label lblWarriorDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}