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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblQuestGiverName = new System.Windows.Forms.Label();
            this.lblQuestGiverDescription = new System.Windows.Forms.Label();
            this.lblQuestGiverStatement = new System.Windows.Forms.Label();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.lblQuestDescription = new System.Windows.Forms.Label();
            this.lblQuestRewards = new System.Windows.Forms.Label();
            this.lblQuestState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(13, 361);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(384, 77);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(403, 361);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(385, 76);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblQuestGiverName
            // 
            this.lblQuestGiverName.AutoSize = true;
            this.lblQuestGiverName.Location = new System.Drawing.Point(13, 13);
            this.lblQuestGiverName.Name = "lblQuestGiverName";
            this.lblQuestGiverName.Size = new System.Drawing.Size(46, 17);
            this.lblQuestGiverName.TabIndex = 2;
            this.lblQuestGiverName.Text = "label1";
            // 
            // lblQuestGiverDescription
            // 
            this.lblQuestGiverDescription.AutoSize = true;
            this.lblQuestGiverDescription.Location = new System.Drawing.Point(13, 34);
            this.lblQuestGiverDescription.Name = "lblQuestGiverDescription";
            this.lblQuestGiverDescription.Size = new System.Drawing.Size(46, 17);
            this.lblQuestGiverDescription.TabIndex = 3;
            this.lblQuestGiverDescription.Text = "label2";
            // 
            // lblQuestGiverStatement
            // 
            this.lblQuestGiverStatement.AutoSize = true;
            this.lblQuestGiverStatement.Location = new System.Drawing.Point(13, 55);
            this.lblQuestGiverStatement.Name = "lblQuestGiverStatement";
            this.lblQuestGiverStatement.Size = new System.Drawing.Size(46, 17);
            this.lblQuestGiverStatement.TabIndex = 4;
            this.lblQuestGiverStatement.Text = "label3";
            // 
            // lblQuestName
            // 
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Location = new System.Drawing.Point(353, 13);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(46, 17);
            this.lblQuestName.TabIndex = 5;
            this.lblQuestName.Text = "label4";
            // 
            // lblQuestDescription
            // 
            this.lblQuestDescription.AutoSize = true;
            this.lblQuestDescription.Location = new System.Drawing.Point(353, 34);
            this.lblQuestDescription.Name = "lblQuestDescription";
            this.lblQuestDescription.Size = new System.Drawing.Size(46, 17);
            this.lblQuestDescription.TabIndex = 6;
            this.lblQuestDescription.Text = "label5";
            // 
            // lblQuestRewards
            // 
            this.lblQuestRewards.AutoSize = true;
            this.lblQuestRewards.Location = new System.Drawing.Point(353, 55);
            this.lblQuestRewards.Name = "lblQuestRewards";
            this.lblQuestRewards.Size = new System.Drawing.Size(46, 17);
            this.lblQuestRewards.TabIndex = 7;
            this.lblQuestRewards.Text = "label6";
            // 
            // lblQuestState
            // 
            this.lblQuestState.AutoSize = true;
            this.lblQuestState.Location = new System.Drawing.Point(208, 202);
            this.lblQuestState.Name = "lblQuestState";
            this.lblQuestState.Size = new System.Drawing.Size(46, 17);
            this.lblQuestState.TabIndex = 8;
            this.lblQuestState.Text = "label1";
            // 
            // QuestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestState);
            this.Controls.Add(this.lblQuestRewards);
            this.Controls.Add(this.lblQuestDescription);
            this.Controls.Add(this.lblQuestName);
            this.Controls.Add(this.lblQuestGiverStatement);
            this.Controls.Add(this.lblQuestGiverDescription);
            this.Controls.Add(this.lblQuestGiverName);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestScreen";
            this.Text = "Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblQuestGiverName;
        private System.Windows.Forms.Label lblQuestGiverDescription;
        private System.Windows.Forms.Label lblQuestGiverStatement;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.Label lblQuestDescription;
        private System.Windows.Forms.Label lblQuestRewards;
        private System.Windows.Forms.Label lblQuestState;
    }
}