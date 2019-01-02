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
            //Introduction introduction = new Introduction();
            //introduction.StartPosition = FormStartPosition.CenterParent;
            //introduction.ShowDialog(this);
            UpdateButtons();
            UpdateStats();
            dgvBattleSpells.Visible = false;
            dgvBattleItems.Visible = false;
            dgvBattleItems.CellClick += dgvBattleItems_CellClick;
            dgvBattleSpells.CellClick += dgvBattleSpells_CellClick;
           // System.IO.Stream str = Properties.Resources.enemy;
           // System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
          //  snd.Play();
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
            UpdateEnemy();
        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            dgvBattleSpells.Visible = true;
            btnAttack.Visible = false;
            btnSpell.Visible = false;
            btnItem.Visible = false;
            btnRun.Visible = false;
            dgvBattleSpellsUpdate();
            UpdateButtons();
            UpdateEnemy();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            dgvBattleItems.Visible = true;
            btnAttack.Visible = false;
            btnSpell.Visible = false;
            btnItem.Visible = false;
            btnRun.Visible = false;
            dgvBattleItemsUpdate();
            UpdateButtons();
            UpdateEnemy();
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
                        btnShop.Visible = false;
                    }
                    else
                        btnShop.Visible = true;

                    if(gameSession.CurrentPlayer.CurrentLocation.QuestInLocation == null)
                    {
                        btnTalk.Visible = false;
                    }
                    else
                    {
                        btnTalk.Visible = true;
                    }

                    if(gameSession.CurrentPlayer.CurrentLocation.InnInLocation == null)
                    {
                        btnInn.Visible = false;
                    }
                    else
                    {
                        btnInn.Visible = true;
                    }

                    btnAttack.Visible = false;
                    btnSpell.Visible = false;
                    btnItem.Visible = false;
                    btnRun.Visible = false;
                    DisableEmpowerControl();
                    btnGreed.Visible = false;
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
                    btnShop.Enabled = false;
                    btnTalk.Visible = false;
                    DisableEmpowerControl();
                    btnGreed.Visible = false;
                    btnInn.Visible = false;
                    break;
                case GameSession.GameState.Battle:
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;
                    btnShop.Visible = false;
                    btnAttack.Visible = true;
                    btnSpell.Visible = true;
                    btnItem.Visible = true;
                    btnRun.Visible = true;
                    btnTalk.Visible = false;
                    btnEmpower.Visible = true;
                    btnInn.Visible = false;
                    UpdateEmpower();
                    if(gameSession.TurnCounter == 1)
                    {
                        btnGreed.Visible = true;
                    }
                    else
                    {
                        btnGreed.Visible = false;
                    }
                    break;
            }
        }

        private void UpdateStats()
        {
            lblClass.Text = gameSession.CurrentPlayer.GetClass().ToString();
            lblLevel.Text = gameSession.CurrentPlayer.Level.ToString();
            lblExperience.Text = gameSession.CurrentPlayer.CurrentExperiencePoints.ToString() + "/" + gameSession.CurrentPlayer.MaximumExperiencePoints.ToString();
            lblHealth.Text = gameSession.CurrentPlayer.CurrentHealth.ToString() + "/" + gameSession.CurrentPlayer.TotalMaximumHealth.ToString();
            lblMana.Text = gameSession.CurrentPlayer.CurrentMana.ToString() + "/" + gameSession.CurrentPlayer.TotalMaximumMana.ToString();
            lblAttack.Text = gameSession.CurrentPlayer.TotalStrength.ToString();
            lblDefense.Text = gameSession.CurrentPlayer.TotalDefense.ToString();
            lblLuck.Text = gameSession.CurrentPlayer.TotalLuck.ToString();
            lblSpeed.Text = gameSession.CurrentPlayer.TotalSpeed.ToString();
            lblIntellect.Text = gameSession.CurrentPlayer.TotalIntellect.ToString();
            lblResistance.Text = gameSession.CurrentPlayer.TotalResistance.ToString();
        }

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
                lblEnemyDescription.Text = gameSession.CurrentEnemy.Description;
                lblEnemyHealth.Text = gameSession.CurrentEnemy.CurrentHealth + "\\" + gameSession.CurrentEnemy.MaximumHealth; 
            }
        }
        
        private void DisplayBattleText(object o, MessageEventArgs e)
        {
            rtbBattle.Text += e.Message + "\n";
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            foreach (KeyValuePair<Item, int> kvp in gameSession.CurrentPlayer.PlayerItems)
            {
                if (!CheckIfInDGV(kvp.Key.ID, dgvItems))
                {
                    dgvItems.Rows.Add(kvp.Key.ID, kvp.Key.Name, kvp.Value);
                }
            }
        }

        private bool CheckIfInDGV(int id, DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == id.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            gameSession.EnterShop();
            TradingScreen tradingScreen = new TradingScreen(gameSession);
            tradingScreen.StartPosition = FormStartPosition.CenterParent;
            tradingScreen.ShowDialog(this);
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            dgvEquipment.Rows.Clear();
            foreach (Equipment equipment in gameSession.CurrentPlayer.PlayerEquipments)
            {
                if (!CheckIfInDGV(equipment.ID, dgvEquipment))
                {
                    dgvEquipment.Rows.Add(equipment.ID, equipment.Name);
                }
            }
            dgvEquipment.CellClick += dgvEquipment_CellClick;
            dgvEquipment.CellClick += dgvEquipment2_CellClick;
        }

        private void dgvEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 2)
            {
                var equipmentID = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Equipment equipment = World.FindEquipmentByID(Convert.ToInt32(equipmentID));

                gameSession.EquipCommand(equipment);
                UpdateStats();
            }
        }

        private void dgvEquipment2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var equipmentID = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                //Get the equipment object for the selected equipment row
                Equipment equipment = World.FindEquipmentByID(Convert.ToInt32(equipmentID));

                gameSession.UnEquipCommand(equipment);
                UpdateStats();
            }
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            QuestForm quest = new QuestForm(gameSession, gameSession.CurrentPlayer.CurrentLocation.QuestInLocation);
            quest.StartPosition = FormStartPosition.CenterParent;
            quest.ShowDialog(this);
        }

        private void btnUpdateQuests_Click(object sender, EventArgs e)
        {
            dgvQuests.Rows.Clear();
            foreach (Quest quest in gameSession.CurrentPlayer.PlayerQuests)
            {
                if (!CheckIfInDGV(quest.ID, dgvQuests))
                {
                    dgvQuests.Rows.Add(quest.ID, quest.Name, quest.IsCompleted);
                }
            }
            dgvQuests.CellClick += dgvQuests_CellClick;
        }

        private void dgvQuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateSpells_Click(object sender, EventArgs e)
        {
            dgvSpells.Rows.Clear();
            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                if (!CheckIfInDGV(spell.ID, dgvSpells))
                {
                    dgvSpells.Rows.Add(spell.ID, spell.Name);
                }
            }
        }

        private void dgvBattleSpellsUpdate()
        {
            dgvBattleSpells.Rows.Clear();
            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                if (!CheckIfInDGV(spell.ID, dgvBattleSpells))
                {
                    dgvBattleSpells.Rows.Add(spell.ID, spell.Name);
                }
            }
        }

        private void dgvBattleSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var spellID = dgvBattleSpells.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Spell spell = World.FindSpellByID(Convert.ToInt32(spellID));

                gameSession.CastSpellCommand(spell);
                
                dgvBattleSpells.Visible = false;
                btnAttack.Visible = true;
                btnSpell.Visible = true;
                btnItem.Visible = true;
                btnRun.Visible = true; 
                UpdateButtons();
            }
        }

        private void dgvBattleItemsUpdate()
        {
            dgvBattleItems.Rows.Clear();
            foreach (KeyValuePair<Item, int> kvp in gameSession.CurrentPlayer.PlayerItems)
            {
                if (!CheckIfInDGV(kvp.Key.ID, dgvBattleItems))
                {
                    if(kvp.Key is HealthReplenishingItem || kvp.Key is ManaReplenishingItem || kvp.Key is DamageItem)
                    {
                        dgvBattleItems.Rows.Add(kvp.Key.ID, kvp.Key.Name, kvp.Value);
                    }
                }
            }
        }

        private void dgvBattleItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var itemID = dgvBattleItems.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Item item = World.FindItemByID(Convert.ToInt32(itemID));

                //Use Item Function
                gameSession.UseItemCommand(item);

                dgvBattleItems.Visible = false;
                btnAttack.Visible = true;
                btnSpell.Visible = true;
                btnItem.Visible = true;
                btnRun.Visible = true;
                UpdateButtons();
            }
        }

        private void dgvBattleSpells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {

        }

        private void dgvEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtbBattle_TextChanged(object sender, EventArgs e)
        {
            rtbBattle.SelectionStart = rtbBattle.Text.Length;
            rtbBattle.ScrollToCaret();
        }

        private void btnEmpower_Click(object sender, EventArgs e)
        {
            if(gameSession.CurrentPlayer.EmpowerCounter == 4 && gameSession.CurrentPlayer.Greed == false)
            {
                gameSession.CurrentPlayer.Empowered = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void DisableEmpowerControl()
        {
            btnEmpower.Visible = false;
            ptbEmpower1.Visible = false;
            ptbEmpower2.Visible = false;
            ptbEmpower3.Visible = false;
            ptbEmpower4.Visible = false;
        }

        private void UpdateEmpower()
        {
            switch (gameSession.CurrentPlayer.EmpowerCounter)
            {
                case 0:
                    ptbEmpower1.Visible = false;
                    ptbEmpower2.Visible = false;
                    ptbEmpower3.Visible = false;
                    ptbEmpower4.Visible = false;
                    break;
                case 1:
                    ptbEmpower1.Visible = true;
                    ptbEmpower2.Visible = false;
                    ptbEmpower3.Visible = false;
                    ptbEmpower4.Visible = false;
                    break;
                case 2:
                    ptbEmpower1.Visible = true;
                    ptbEmpower2.Visible = true;
                    ptbEmpower3.Visible = false;
                    ptbEmpower4.Visible = false;
                    break;
                case 3:
                    ptbEmpower1.Visible = true;
                    ptbEmpower2.Visible = true;
                    ptbEmpower3.Visible = true;
                    ptbEmpower4.Visible = false;
                    break;
                case 4:
                    ptbEmpower1.Visible = true;
                    ptbEmpower2.Visible = true;
                    ptbEmpower3.Visible = true;
                    ptbEmpower4.Visible = true;
                    break;
                default:
                    throw new Exception("Empowerment under 0 or over 4");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSession.CurrentPlayer.CurrentHealth = gameSession.CurrentPlayer.TotalMaximumHealth;
        }

        private void ptbEmpower3_Click(object sender, EventArgs e)
        {

        }

        private void btnGreed_Click(object sender, EventArgs e)
        {
            if(gameSession.TurnCounter == 1)
            {
                gameSession.CurrentPlayer.ActivateGreed();
            }
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            lblTurn.Text = gameSession.TurnCounter.ToString();
        }

        private void lblTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void btnInn_Click(object sender, EventArgs e)
        {
            InnScreen innScreen = new InnScreen(gameSession);
            innScreen.StartPosition = FormStartPosition.CenterParent;
            innScreen.ShowDialog(this);
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            lblGold.Text = gameSession.CurrentPlayer.Gold.ToString();
        }
    }
}