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
    public partial class InnScreen : Form
    {
        GameSession gameSession;

        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();


        public InnScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            UpdateInnScreen();
        }

        private void UpdateInnScreen()
        {
            lblInnName.Text = gameSession.CurrentPlayer.CurrentLocation.InnInLocation.Name;
            lblInnDescription.Text = gameSession.CurrentPlayer.CurrentLocation.InnInLocation.Description;
            lblInnGoldCost.Text = gameSession.CurrentPlayer.CurrentLocation.InnInLocation.GoldCost.ToString();

            lblPlayerName.Text = gameSession.CurrentPlayer.Name;
            lblPlayerHealth.Text = gameSession.CurrentPlayer.CurrentHealth + "/" + gameSession.CurrentPlayer.TotalMaximumHealth;
            lblPlayerMana.Text = gameSession.CurrentPlayer.CurrentMana + "/" + gameSession.CurrentPlayer.TotalMaximumMana;
            lblPlayerGold.Text = gameSession.CurrentPlayer.Gold.ToString();

            SetImage(pbInn, gameSession.CurrentPlayer.CurrentLocation.InnInLocation.Name);
        }

        private void btnStayAtInn_Click(object sender, EventArgs e)
        {
            if (gameSession.StayAtInnCommand(gameSession.CurrentPlayer.CurrentLocation.InnInLocation))
            {
                MessageBox.Show("You spent the night at the inn and fully replenished your health and mana");
                Close();
            }
            else
            {
                MessageBox.Show("You did not have enough money to stay at the inn");
            }

            UpdateInnScreen();
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
    }
}
