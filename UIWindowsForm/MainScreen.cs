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
            //Application.Idle += HandleApplicationIdle;
            InitializeComponent();
            gameSession.CurrentPlayer.StatsChanged += UpdateStats;
            gameSession.OnMessagedRaised += DisplayBattleText;
            rtbLocation.Text = gameSession.CurrentPlayer.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.MoveNorth();
            rtbLocation.Text = gameSession.CurrentPlayer.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.MoveSouth();
            rtbLocation.Text = gameSession.CurrentPlayer.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.MoveWest();
            rtbLocation.Text = gameSession.CurrentPlayer.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.MoveEast();
            rtbLocation.Text = gameSession.CurrentPlayer.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.EnterShop();
            rtbShop.Text = gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.ToString();
            btnShop.Visible = false;
            btnShopExit.Visible = true;
            UpdateButtons();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.GainExperience(100);
        }

        private void UpdateButtons()
        {
            switch (Player.PlayerState)
            {
                case Player.State.Travel:
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
                case Player.State.Shop:
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;
                    btnAttack.Visible = false;
                    btnSpell.Visible = false;
                    btnItem.Visible = false;
                    btnRun.Visible = false;
                    break;
                case Player.State.Battle:
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
            lblAttack.Text = gameSession.CurrentPlayer.Attack.ToString();
            lblDefense.Text = gameSession.CurrentPlayer.Defense.ToString();
            lblLuck.Text = gameSession.CurrentPlayer.Luck.ToString();
            lblSpeed.Text = gameSession.CurrentPlayer.Speed.ToString();
            lblIntellect.Text = gameSession.CurrentPlayer.Intellect.ToString();
            lblResistance.Text = gameSession.CurrentPlayer.Resistance.ToString();
        }

        private void btnShopExit_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.ExitShop();
            rtbShop.Text = "You left the shop";
            btnShop.Visible = true;
            btnShopExit.Visible = false;
            UpdateButtons();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.RunCommand(gameSession.CurrentPlayer.CurrentLocation.CurrentEnemy);
            UpdateButtons();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            gameSession.AttackCommand();
            UpdateButtons();
        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.SpellCommand(gameSession.CurrentPlayer.CurrentLocation.CurrentEnemy, World.FindSpellByID(1));
            UpdateButtons();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.UseItem(World.FindItemByID(1));
            UpdateButtons();
        }
        /*private void HandleApplicationIdle(object sender, EventArgs e)
        {
            GameStateManager.Run();
        }*/

        private void DisplayBattleText(object o, MessageEventArgs e)
        {
            rtbBattle.Text = e.Message;
        }
    }
}
