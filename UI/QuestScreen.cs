using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class QuestScreen : Form
    {
        GameSession gameSession; 
        Quest quest;

        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();


        public QuestScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            this.quest = gameSession.CurrentPlayer.CurrentLocation.QuestInLocation;
            UpdateUI();
        }


        //<-----------Update UI Functions---------->
        private void UpdateUI()
        {
            lblQuestName.Text = quest.Name;
            lblQuestDescription.Text = quest.Description;
            UpdateRewards();

            SetImage(pbQuest, quest.Name);

            if (gameSession.CurrentPlayer.PlayerQuests.Contains(quest))
            {
                btnAccept.Visible = false;

                if (quest.IsCompleted)
                {
                    if (quest.QuestGivenIn)
                    {
                        lblQuestState.Text = "You have finished the quest!";
                    }
                    else
                    {
                        lblQuestState.Text = "You have completed the quest you must hand it in";
                    }
                }
                else
                {
                    lblQuestState.Text = "You still haven't completed the quest!";
                }
            }
            else
            {
                btnAccept.Visible = true;

                lblQuestState.Text = "";
                lblQuestState.Visible = false;
            }
        }

        private void UpdateRewards()
        {
            int x = 300;
            int y = 75;

            if(quest.RewardGold != 0)
            {
                CreateIconValueCombo("Gold", "Gold Reward:", quest.RewardGold.ToString(), x, y);
                y += 40;
            }
            if(quest.RewardExperience != 0)
            {
                CreateIconValueCombo("Experience", "Experience Reward:", quest.RewardExperience.ToString(), x, y);
                y += 40;
            }
            if(quest.RewardItem != null)
            {
                CreateIconValueCombo("Item", "Item Reward:", quest.RewardItem.Name, x, y);
                y += 40;
            }
            if(quest.RewardEquipment != null)
            {
                CreateIconValueCombo("Equipment", "Equipment Reward:", quest.RewardEquipment.Name, x, y);
                y += 40;
            }
            if(quest.RewardSpell != null)
            {
                CreateIconValueCombo("Spell", "Spell Reward:", quest.RewardSpell.Name, x, y);
                y += 40;
            }
        }


        //<-----------Button Event Functions----------->
        private void btnAccept_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.AcceptQuest(quest);
            Close();
        }

        private void SetImage(PictureBox pictureBox, string imageName)
        {
            if (imageName == null)
            {
                pictureBox.Image = null;
                return;
            }

            using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images." + imageName + ".png"))

            {
                if (resourceStream != null)
                {
                    pictureBox.Image = new Bitmap(resourceStream);
                }
            }
        }


        private PictureBox CreatePictureBox(string imageName, Point point, Size size)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = size;
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage(pictureBox, imageName);
            pictureBox.Location = point;

            Controls.Add(pictureBox);

            return pictureBox;
        }

        private Label CreateLabel(string labelText, bool autoSize, Point point, Size size)
        {
            Label label = new Label();
            label.Text = labelText;
            label.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            label.AutoSize = autoSize;
            label.Location = point;
            if (!autoSize)
            {
                label.Size = size;
            }
            Controls.Add(label);

            return label;
        }

        private void CreateIconValueCombo(string iconName, string labelName, string value, int x, int y)
        {
            PictureBox pbIconImage = CreatePictureBox(iconName, new Point(x, y), new Size(25, 25));
            Label lblLabelName = CreateLabel(labelName, true, new Point(x + 42, y + 2), new Size(0, 0));
            Label lblValue = CreateLabel(value, true, new Point(x + 210, y + 2), new Size(0, 0));

            Controls.Add(pbIconImage);
            Controls.Add(lblLabelName);
            Controls.Add(lblValue);
        }


        //<------------Setting Functions--------------->
        private void SetWindow(string title, int width, int height)
        {
            Text = title;
            Width = width;
            Height = height;
        }
    }
}