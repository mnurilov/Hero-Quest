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

namespace UIWindowsForm
{
    public partial class MainScreen : Form
    {
        GameSession gameSession = new GameSession();

        public MainScreen()
        {
            InitializeComponent();
            gameSession.OnMessagedRaised += DisplayBattleText;
            UpdateButtons();
            UpdateStats();
        }

        //Uses game session to control player instead of the player itself
        private void btnNorth_Click(object sender, EventArgs e)
        {
            gameSession.MoveNorthCommand();
            UpdateButtons();
            UpdateStats();
            UpdateLocation();
            UpdateEnemy();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            gameSession.MoveSouthCommand();
            UpdateButtons();
            UpdateStats();
            UpdateLocation();
            UpdateEnemy();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            gameSession.MoveWestCommand();
            UpdateButtons();
            UpdateStats();
            UpdateLocation();
            UpdateEnemy();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            gameSession.MoveEastCommand();
            UpdateButtons();
            UpdateStats(); 
            UpdateLocation();
            UpdateEnemy();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            gameSession.AttackCommand();
            UpdateButtons();
        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            gameSession.CastSpellCommand();
            UpdateButtons();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            gameSession.RunCommand();
            UpdateButtons();
        }



        //Have not used game session yet on these
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void btnShop_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.EnterShop();
            //rtbShop.Text = gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.ToString();
            btnShop.Visible = false;
            btnShopExit.Visible = true;
            UpdateButtons();
        }*/

        private void btnTrade_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.GainExperience(100);
        }

        private void UpdateButtons()
        {
            switch (gameSession.GameStates)
            {
                case GameSession.GameState.Travel:
                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheNorth == null)
                        btnNorth.Enabled = false;
                    else
                        btnNorth.Enabled = true;

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheSouth == null)
                        btnSouth.Enabled = false;
                    else
                        btnSouth.Enabled = true;

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheWest == null)
                        btnWest.Enabled = false;
                    else
                        btnWest.Enabled = true;

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheEast == null)
                        btnEast.Enabled = false;
                    else
                        btnEast.Enabled = true;

                    if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation == null)
                    {
                        btnShop.Enabled = false;
                        btnShopExit.Visible = false;
                    }
                    else
                        btnShop.Enabled = true;

                    btnAttack.Visible = false;
                    btnSpell.Visible = false;
                    btnItem.Visible = false;
                    btnRun.Visible = false;
                    break;
                case GameSession.GameState.Shop:
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;
                    btnAttack.Visible = false;
                    btnSpell.Visible = false;
                    btnItem.Visible = false;
                    btnRun.Visible = false;
                    break;
                case GameSession.GameState.Battle:
                    //rtbBattle.Text = gameSession.CurrentPlayer.CurrentLocation.CurrentEnemy.ToString();
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;
                    btnShop.Enabled = false;
                    btnAttack.Visible = true;
                    btnSpell.Visible = true;
                    btnItem.Visible = true;
                    btnRun.Visible = true;
                    break;
            }
        }

        private void UpdateStats()
        {
            lblClass.Text = gameSession.CurrentPlayer.GetClass().ToString();
            lblLevel.Text = gameSession.CurrentPlayer.Level.ToString();
            lblExperience.Text = gameSession.CurrentPlayer.CurrentExperiencePoints.ToString() + "/" + gameSession.CurrentPlayer.MaximumExperiencePoints.ToString();
            lblHealth.Text = gameSession.CurrentPlayer.CurrentHealth.ToString() + "/" + gameSession.CurrentPlayer.MaximumHealth.ToString();
            lblMana.Text = gameSession.CurrentPlayer.CurrentMana.ToString() + "/" + gameSession.CurrentPlayer.MaximumMana.ToString();
            lblAttack.Text = gameSession.CurrentPlayer.Strength.ToString();
            lblDefense.Text = gameSession.CurrentPlayer.Defense.ToString();
            lblLuck.Text = gameSession.CurrentPlayer.Luck.ToString();
            lblSpeed.Text = gameSession.CurrentPlayer.Speed.ToString();
            lblIntellect.Text = gameSession.CurrentPlayer.Intellect.ToString();
            lblResistance.Text = gameSession.CurrentPlayer.Resistance.ToString();
        }

        /*private void btnShopExit_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.ExitShop();
            //rtbShop.Text = "You left the shop";
            btnShop.Visible = true;
            btnShopExit.Visible = false;
            UpdateButtons();
        }*/

        private void UpdateLocation()
        {
            lblLocationName.Text = gameSession.CurrentPlayer.CurrentLocation.Name;
            lblLocationDescription.Text = gameSession.CurrentPlayer.CurrentLocation.Description;
            //pbLocationPicture.ImageLocation = gameSession.CurrentPlayer.CurrentLocation.ImageLocation;
        }

        private void UpdateEnemy()
        {
            if(gameSession.CurrentEnemy != null)
            {
                lblEnemyName.Text = gameSession.CurrentEnemy.Name;
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            //gameSession.CurrentPlayer.UseItem(World.FindItemByID(1));
            UpdateButtons();
        }

        private void DisplayBattleText(object o, MessageEventArgs e)
        {
            rtbBattle.Text = e.Message;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblLocationDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblEnemyName_Click(object sender, EventArgs e)
        {

        }
    }
}