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
        public Player Player = new Player(1, "Bob", Player.Class.Thief);
        private void HandleApplicationIdle(object sender, EventArgs e)
        {
            GameStateManager.Run();
        }
        public MainScreen()
        {
            Application.Idle += HandleApplicationIdle;
            InitializeComponent();
            Player.StatsChanged += UpdateStats;
            rtbLocation.Text = Player.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            Player.MoveNorth();
            rtbLocation.Text = Player.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            Player.MoveSouth();
            rtbLocation.Text = Player.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            Player.MoveWest();
            rtbLocation.Text = Player.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            Player.MoveEast();
            rtbLocation.Text = Player.CurrentLocation.ToString();
            UpdateButtons();
            UpdateStats();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Player.EnterShop();
            rtbShop.Text = Player.CurrentLocation.VendorInLocation.ToString();
            btnShop.Visible = false;
            btnShopExit.Visible = true;
            UpdateButtons();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            Player.GainExperience(100);
        }

        private void UpdateButtons()
        {
            switch (Player.PlayerState)
            {
                case Player.State.Travel:
                    if (Player.CurrentLocation.LocationToTheNorth == null)
                        btnNorth.Enabled = false;
                    else
                        btnNorth.Enabled = true;

                    if (Player.CurrentLocation.LocationToTheSouth == null)
                        btnSouth.Enabled = false;
                    else
                        btnSouth.Enabled = true;

                    if (Player.CurrentLocation.LocationToTheWest == null)
                        btnWest.Enabled = false;
                    else
                        btnWest.Enabled = true;

                    if (Player.CurrentLocation.LocationToTheEast == null)
                        btnEast.Enabled = false;
                    else
                        btnEast.Enabled = true;

                    if (Player.CurrentLocation.VendorInLocation == null)
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
                    rtbBattle.Text = Player.CurrentLocation.CurrentEnemy.ToString();
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
            lblClass.Text = Player.GetClass().ToString();
            lblLevel.Text = Player.Level.ToString();
            lblExperience.Text = Player.CurrentExperiencePoints.ToString() + "/" + Player.MaximumExperiencePoints.ToString();
            lblHealth.Text = Player.CurrentHealth.ToString() + "/" + Player.MaximumHealth.ToString();
            lblMana.Text = Player.CurrentMana.ToString() + "/" + Player.MaximumMana.ToString();
            lblAttack.Text = Player.Attack.ToString();
            lblDefense.Text = Player.Defense.ToString();
            lblLuck.Text = Player.Luck.ToString();
            lblSpeed.Text = Player.Speed.ToString();
            lblIntellect.Text = Player.Intellect.ToString();
            lblResistance.Text = Player.Resistance.ToString();
        }

        private void btnShopExit_Click(object sender, EventArgs e)
        {
            Player.ExitShop();
            rtbShop.Text = "You left the shop";
            btnShop.Visible = true;
            btnShopExit.Visible = false;
            UpdateButtons();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Player.RunCommand(Player.CurrentLocation.CurrentEnemy);
            UpdateButtons();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Player.AttackCommand(Player.CurrentLocation.CurrentEnemy);
            UpdateButtons();
        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            Player.SpellCommand(Player.CurrentLocation.CurrentEnemy, World.FindSpellByID(1));
            UpdateButtons();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Player.UseItem(World.FindItemByID(1));
            UpdateButtons();
        }
    }
}
