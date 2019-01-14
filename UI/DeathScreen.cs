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
    public partial class DeathScreen : Form
    {
        GameSession gameSession;


        public DeathScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            UpdateDeathScreen();
        }

        private void UpdateDeathScreen()
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
