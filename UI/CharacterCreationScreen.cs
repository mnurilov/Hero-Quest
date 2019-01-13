using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace UI
{
    public partial class CharacterCreationScreen : Form
    {
        string playerName = "";
        Player.Class playerClass;
        bool classHasBeenSelected = false;

        public CharacterCreationScreen()
        {
            InitializeComponent();
            lblConfirmation.Text = "";
            lblSelectedClass.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            playerName = tbName.Text;
            if(playerName.ToLower() == "faggot")
            {
                playerName = "Omar";
            }

            if(playerName.Length > 15)
            {
                tbName.Text = "";
                playerName = "";
                lblConfirmation.Text = "Your name was too long!";
            }
            else
            {
                tbName.Text = "";
                lblConfirmation.Text = "Your name will be " + playerName;
            }
        }

        private void pbWarrior_Click(object sender, EventArgs e)
        {
            classHasBeenSelected = true;
            playerClass = Player.Class.Warrior;
            lblSelectedClass.Text = "You class will be " + Player.Class.Warrior.ToString();
        }

        private void pbMage_Click(object sender, EventArgs e)
        {
            classHasBeenSelected = true;
            playerClass = Player.Class.Mage;
            lblSelectedClass.Text = "You class will be " + Player.Class.Mage.ToString();
        }

        private void pbThief_Click(object sender, EventArgs e)
        {
            classHasBeenSelected = true;
            playerClass = Player.Class.Thief;
            lblSelectedClass.Text = "You class will be " + Player.Class.Thief.ToString();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            if(playerName == "")
            {
                lblConfirmation.Text = "You did not enter a name!";
                return;
            }
            if(!classHasBeenSelected)
            {
                lblSelectedClass.Text = "You did not pick a class!";
                return;
            }
            GameSession gameSession = new GameSession(playerName, playerClass);

            Hide();
            MainScreen mainScreen = new MainScreen(gameSession);
            mainScreen.StartPosition = FormStartPosition.CenterParent;
            mainScreen.ShowDialog(this);
            Close();
        }
    }
}
