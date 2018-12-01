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

namespace UIWindowsForm
{
    public partial class QuestForm : Form
    {
        GameSession gameSession;
        Quest quest;

        public QuestForm(GameSession gameSession, Quest quest)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            this.quest = quest;
            UpdateQuestDetails();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.AcceptQuest(quest);
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateQuestDetails()
        {
            lblQuestName.Text = gameSession.CurrentPlayer.CurrentLocation.QuestInLocation.Name;
            lblQuestDescription.Text = gameSession.CurrentPlayer.CurrentLocation.QuestInLocation.Description;

            if (gameSession.CurrentPlayer.PlayerQuests.Contains(quest))
            {
                btnAccept.Visible = false;
                btnReject.Visible = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (gameSession.CheckIfQuestCompleted(quest))
            {
                lblFun.Text = "YEAHHHHHHH";
            }
        }
    }
}
