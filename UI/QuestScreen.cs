using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class QuestScreen : Form
    {
        GameSession gameSession; 
        Quest quest;


        public QuestScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            this.quest = gameSession.CurrentPlayer.CurrentLocation.QuestInLocation;
            CheckQuestCompletion();
            UpdateUI();
        }


        private void CheckQuestCompletion()
        {
            if (quest.IsCompleted)
            {
                return;
            }
            else
            {
                gameSession.CheckIfQuestCompleted(quest);
            }
        }


        //<-----------Update UI Functions---------->
        private void UpdateUI()
        {
            lblQuestGiverName.Text = quest.QuestGiver.Name;
            lblQuestGiverDescription.Text = quest.QuestGiver.Description;
            lblQuestGiverStatement.Text = quest.QuestGiver.Statement;

            lblQuestName.Text = quest.Name;
            lblQuestDescription.Text = quest.Description;
            lblQuestRewards.Text = quest.Rewards;

            if (gameSession.CurrentPlayer.PlayerQuests.Contains(quest))
            {
                btnAccept.Visible = false;
                btnReject.Visible = false;
            }

            if (quest.IsCompleted)
            {
                lblQuestState.Text = "You completed the quest!";
            }
            else
            {
                lblQuestState.Text = "You still haven't completed the quest!";
            }
        }


        //<-----------Button Event Functions----------->
        private void btnAccept_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.AcceptQuest(quest);
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
