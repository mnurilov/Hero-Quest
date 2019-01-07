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
    public partial class MainScreen : Form
    {
        GameSession gameSession = new GameSession();


        public MainScreen()
        {
            InitializeComponent();
            gameSession.OnMessagedRaised += DisplayWorldText;
        }


        //<----------Movement Functions---------->
        private void btnNorth_Click(object sender, EventArgs e)
        {
            gameSession.MoveNorthCommand();
            UpdateButtons();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            gameSession.MoveSouthCommand();
            UpdateButtons();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            gameSession.MoveWestCommand();
            UpdateButtons();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            gameSession.MoveEastCommand();
            UpdateButtons();
        }
        

        //<----------Updating UI Functions---------->
        private void rtbWorldText_TextChanged(object sender, EventArgs e)
        {
            rtbWorldText.SelectionStart = rtbWorldText.Text.Length;
            rtbWorldText.ScrollToCaret();
        }

        private void DisplayWorldText(object o, MessageEventArgs e)
        {
            rtbWorldText.Text += e.Message + "\n";
        }
        
        private void UpdateButtons()
        {
            switch (gameSession.GameStates)
            {
                case GameSession.GameState.Introduction:
                    break;
                case GameSession.GameState.Travel:
                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheNorth == null) 
                    { 
                        btnNorth.Enabled = false; 
                    }
                    else
                    { 
                        btnNorth.Enabled = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheSouth == null)
                    {
                        btnSouth.Enabled = false;
                    }
                    else
                    {
                        btnSouth.Enabled = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheWest == null)
                    {
                        btnWest.Enabled = false;
                    }
                    else
                    {
                        btnWest.Enabled = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheEast == null)
                    {
                        btnEast.Enabled = false;
                    }
                    else
                    {
                        btnEast.Enabled = true;
                    }
                    break;
                case GameSession.GameState.Battle:
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;
                    break;
                case GameSession.GameState.GameOver:
                    break;
            }
        }
    }
}
