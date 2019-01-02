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
        }

        //<----------Movement Functions---------->
        private void btnNorth_Click(object sender, EventArgs e)
        {
            gameSession.MoveNorthCommand();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            gameSession.MoveSouthCommand();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            gameSession.MoveWestCommand();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            gameSession.MoveEastCommand();
        }


        //<----------Updating UI Functions---------->
        private void rtbWorld_TextChanged(object sender, EventArgs e)
        {
            rtbWorld.SelectionStart = rtbWorld.Text.Length;
            rtbWorld.ScrollToCaret();
        }
    }
}
