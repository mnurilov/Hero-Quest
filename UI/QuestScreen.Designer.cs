namespace UI
{
    partial class QuestScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestScreen));
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.lblQuestDescription = new System.Windows.Forms.Label();
            this.lblQuestState = new System.Windows.Forms.Label();
            this.pbQuest = new System.Windows.Forms.PictureBox();
            this.lblQuestRewardsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(12, 348);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(841, 77);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblQuestName
            // 
            this.lblQuestName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestName.Location = new System.Drawing.Point(37, 28);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(343, 39);
            this.lblQuestName.TabIndex = 5;
            this.lblQuestName.Text = "label4";
            this.lblQuestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestDescription
            // 
            this.lblQuestDescription.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestDescription.Location = new System.Drawing.Point(37, 257);
            this.lblQuestDescription.Name = "lblQuestDescription";
            this.lblQuestDescription.Size = new System.Drawing.Size(343, 63);
            this.lblQuestDescription.TabIndex = 6;
            this.lblQuestDescription.Text = "label5";
            this.lblQuestDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestState
            // 
            this.lblQuestState.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestState.Location = new System.Drawing.Point(12, 374);
            this.lblQuestState.Name = "lblQuestState";
            this.lblQuestState.Size = new System.Drawing.Size(841, 35);
            this.lblQuestState.TabIndex = 8;
            this.lblQuestState.Text = "label1";
            this.lblQuestState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbQuest
            // 
            this.pbQuest.Location = new System.Drawing.Point(143, 100);
            this.pbQuest.Name = "pbQuest";
            this.pbQuest.Size = new System.Drawing.Size(125, 125);
            this.pbQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuest.TabIndex = 27;
            this.pbQuest.TabStop = false;
            // 
            // lblQuestRewardsLabel
            // 
            this.lblQuestRewardsLabel.AutoSize = true;
            this.lblQuestRewardsLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestRewardsLabel.Location = new System.Drawing.Point(507, 40);
            this.lblQuestRewardsLabel.Name = "lblQuestRewardsLabel";
            this.lblQuestRewardsLabel.Size = new System.Drawing.Size(149, 22);
            this.lblQuestRewardsLabel.TabIndex = 28;
            this.lblQuestRewardsLabel.Text = "Quest Rewards";
            // 
            // QuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(865, 437);
            this.Controls.Add(this.lblQuestRewardsLabel);
            this.Controls.Add(this.pbQuest);
            this.Controls.Add(this.lblQuestState);
            this.Controls.Add(this.lblQuestDescription);
            this.Controls.Add(this.lblQuestName);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestScreen";
            this.Text = "Quest";
            ((System.ComponentModel.ISupportInitialize)(this.pbQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.Label lblQuestDescription;
        private System.Windows.Forms.Label lblQuestState;
        private System.Windows.Forms.PictureBox pbQuest;
        private System.Windows.Forms.Label lblQuestRewardsLabel;
    }
}