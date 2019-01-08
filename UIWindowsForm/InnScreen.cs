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
    public partial class InnScreen : Form
    {
        GameSession gameSession;

        public InnScreen(GameSession gameSession)
        {
            this.gameSession = gameSession;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblPersonName.Text = gameSession.CurrentPlayer.CurrentLocation.InnInLocation.InnKeeper.Name;
            lblInnName.Text = gameSession.CurrentPlayer.CurrentLocation.InnInLocation.Name;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            if (gameSession.StayAtInnCommand(gameSession.CurrentPlayer.CurrentLocation.InnInLocation))
            {
                MessageBox.Show("YAYYYy WE STAYED AT INN");
            }
            else
            {
                MessageBox.Show("Boo I didn't stay at the inn");
            }
        }
    }
}
