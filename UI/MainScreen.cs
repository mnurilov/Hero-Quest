using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Engine;

namespace UI
{
    public partial class MainScreen : Form
    {
        GameSession gameSession = new GameSession();
        
        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();


        public MainScreen()
        {
            InitializeComponent();
            gameSession.OnMessagedRaised += DisplayWorldText;
            UpdateUI();
            dgvItems.CellClick += dgvItems_CellClick;
            dgvEquipment.CellClick += dgvEquipmentEquip_CellClick;
            dgvEquipment.CellClick += dgvEquipmentUnequip_CellClick;
            dgvSpells.CellClick += dgvSpells_CellClick;
            dgvBattleSpells.CellClick += dgvBattleSpells_CellClick;
            dgvBattleItems.CellClick += dgvBattleItems_CellClick;
            dgvQuests.CellClick += dgvQuests_CellClick;
        }


        //<----------Movement Buttons---------->
        private void btnNorth_Click(object sender, EventArgs e)
        {
            gameSession.MoveNorthCommand();
            UpdateUI();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            gameSession.MoveSouthCommand();
            UpdateUI();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            gameSession.MoveWestCommand();
            UpdateUI();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            gameSession.MoveEastCommand();
            UpdateUI();
        }


        //<----------Updating UI Functions---------->
        private void UpdateUI()
        {
            UpdateStats();
            UpdateButtons();
            UpdateDGVs();
            UpdateLocation();
            UpdateEnemy();
        }

        private void UpdateStats()
        {
            //Used because sometimes the equipment makes a stat negative and we need to reflect that in the UI
            string normalBonus = " (+";
            string alternativeBonus = " (";

            lblPlayerName.Text = gameSession.CurrentPlayer.Name;

            lblPlayerClass.Text = gameSession.CurrentPlayer.GetClass().ToString();

            switch (gameSession.CurrentPlayer.GetClass())
            {
                case Player.Class.Warrior:
                    SetImage(pbPlayerClass, Player.Class.Warrior.ToString());
                    break;
                case Player.Class.Mage:
                    SetImage(pbPlayerClass, Player.Class.Mage.ToString());
                    break;
                case Player.Class.Thief:
                    SetImage(pbPlayerClass, Player.Class.Thief.ToString());
                    break;
            }

            lblPlayerLevel.Text = gameSession.CurrentPlayer.Level.ToString();

            lblPlayerExperience.Text = gameSession.CurrentPlayer.CurrentExperiencePoints + "/" + 
                                       gameSession.CurrentPlayer.MaximumExperiencePoints;

            lblPlayerHealth.Text = gameSession.CurrentPlayer.CurrentHealth + "/" + gameSession.CurrentPlayer.TotalMaximumHealth;

            lblPlayerMana.Text = gameSession.CurrentPlayer.CurrentMana + "/" + gameSession.CurrentPlayer.TotalMaximumMana;

            if(gameSession.CurrentPlayer.TotalStrength - gameSession.CurrentPlayer.BaseStrength >= 0)
            { 
                lblPlayerStrength.Text = gameSession.CurrentPlayer.TotalStrength + normalBonus +
                                        (gameSession.CurrentPlayer.TotalStrength - gameSession.CurrentPlayer.BaseStrength) + ")";
            }
            else
            {
                lblPlayerStrength.Text = gameSession.CurrentPlayer.TotalStrength + alternativeBonus +
                                           (gameSession.CurrentPlayer.TotalStrength - gameSession.CurrentPlayer.BaseStrength) + ")";
            }

            if(gameSession.CurrentPlayer.TotalDefense - gameSession.CurrentPlayer.BaseDefense >= 0)
            {
                lblPlayerDefense.Text = gameSession.CurrentPlayer.TotalDefense + normalBonus +
                                    (gameSession.CurrentPlayer.TotalDefense - gameSession.CurrentPlayer.BaseDefense) + ")";
            }
            else
            {
                lblPlayerDefense.Text = gameSession.CurrentPlayer.TotalDefense + alternativeBonus +
                                    (gameSession.CurrentPlayer.TotalDefense - gameSession.CurrentPlayer.BaseDefense) + ")";
            }

            if (gameSession.CurrentPlayer.TotalLuck - gameSession.CurrentPlayer.BaseLuck >= 0)
            {
                lblPlayerLuck.Text = gameSession.CurrentPlayer.TotalLuck + normalBonus +
                                    (gameSession.CurrentPlayer.TotalLuck - gameSession.CurrentPlayer.BaseLuck) + ")";
            }
            else
            {
                lblPlayerLuck.Text = gameSession.CurrentPlayer.TotalLuck + alternativeBonus +
                                    (gameSession.CurrentPlayer.TotalLuck - gameSession.CurrentPlayer.BaseLuck) + ")";
            }

            if (gameSession.CurrentPlayer.TotalSpeed - gameSession.CurrentPlayer.BaseSpeed >= 0)
            {
                lblPlayerSpeed.Text = gameSession.CurrentPlayer.TotalSpeed + normalBonus +
                                    (gameSession.CurrentPlayer.TotalSpeed - gameSession.CurrentPlayer.BaseSpeed) + ")";
            }
            else
            {
                lblPlayerSpeed.Text = gameSession.CurrentPlayer.TotalSpeed + alternativeBonus +
                                    (gameSession.CurrentPlayer.TotalSpeed - gameSession.CurrentPlayer.BaseSpeed) + ")";
            }

            if (gameSession.CurrentPlayer.TotalIntellect - gameSession.CurrentPlayer.BaseIntellect >= 0)
            {
                lblPlayerIntellect.Text = gameSession.CurrentPlayer.TotalIntellect + normalBonus +
                                    (gameSession.CurrentPlayer.TotalIntellect - gameSession.CurrentPlayer.BaseIntellect) + ")";
            }
            else
            {
                lblPlayerIntellect.Text = gameSession.CurrentPlayer.TotalIntellect + alternativeBonus +
                                    (gameSession.CurrentPlayer.TotalIntellect - gameSession.CurrentPlayer.BaseIntellect) + ")";
            }

            if (gameSession.CurrentPlayer.TotalResistance - gameSession.CurrentPlayer.BaseResistance >= 0)
            {
                lblPlayerResistance.Text = gameSession.CurrentPlayer.TotalResistance + normalBonus +
                                    (gameSession.CurrentPlayer.TotalResistance - gameSession.CurrentPlayer.BaseResistance) + ")";
            }
            else
            {
                lblPlayerResistance.Text = gameSession.CurrentPlayer.TotalResistance + alternativeBonus +
                                    (gameSession.CurrentPlayer.TotalResistance - gameSession.CurrentPlayer.BaseResistance) + ")";
            }
            
            lblPlayerGold.Text = gameSession.CurrentPlayer.Gold.ToString();

            lblPlayerCriticalChance.Text = ((int)gameSession.CurrentPlayer.CriticalChanceRate).ToString() + "%";

            lblPlayerDodgeChance.Text = ((int)gameSession.CurrentPlayer.DodgeChanceRate).ToString() + "%";
        }

        private void UpdateLocation()
        {
            lblLocationName.Text = gameSession.CurrentPlayer.CurrentLocation.Name;
            lblLocationDescription.Text = gameSession.CurrentPlayer.CurrentLocation.Description;
            SetImage(pbLocationPicture, gameSession.CurrentPlayer.CurrentLocation.Name);
        }

        private void UpdateEnemy()
        {
            lblEnemyName.Text = gameSession.CurrentEnemy?.Name;
            lblEnemyDescription.Text = gameSession.CurrentEnemy?.Description;
            SetImage(pbEnemyPicture, gameSession.CurrentEnemy?.Name);
        }

        private void UpdateDGVs()
        {
            UpdateDGVItems();
            UpdateDGVEquipment();
            UpdateDGVSpells();
            UpdateDGVQuests();
            UpdateDGVBattleSpells();
            UpdateDGVBattleItems();
        }

        private void UpdateDGVItems()
        {
            int rowIndex = 0;
            dgvItems.Rows.Clear();
            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.PlayerItems)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvItems))
                {
                    dgvItems.Rows.Add(item.Key.ID, item.Key.Name, item.Value);
                }

                if(gameSession.GameStates == GameSession.GameState.Battle)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                if (item.Key is EnemyLoot)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[3])).Enabled = false;
                }
                else if(item.Key is KeyItem)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[3])).Enabled = false;
                }
                else if(item.Key is DamageItem)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[3])).Enabled = false;
                }
                else if(item.Key is QuestItem)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                rowIndex++;
            }
        }

        private void UpdateDGVEquipment()
        {
            int rowIndex = 0;
            dgvEquipment.Rows.Clear();
            foreach (Equipment equipment in gameSession.CurrentPlayer.PlayerEquipments)
            {
                if (!CheckIfInDGV(equipment.ID, dgvEquipment))
                {
                    dgvEquipment.Rows.Add(equipment.ID, equipment.Name);
                }
            
                if (gameSession.GameStates == GameSession.GameState.Battle)
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[2])).Enabled = false;
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                if (!gameSession.CheckIfEquippableCommand(equipment))
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[2])).Enabled = false;
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                if (gameSession.CheckIfAlreadyEquipped(equipment))
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[2])).Enabled = false;
                }
                else
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                rowIndex++;
            }
            
            //dgvEquipment.CellClick += dgvEquipment_CellClick;
            //dgvEquipment.CellClick += dgvEquipment2_CellClick;
        }

        private void UpdateDGVSpells()
        {
            int rowIndex = 0;
            dgvSpells.Rows.Clear();
            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                if (!CheckIfInDGV(spell.ID, dgvSpells))
                {
                    dgvSpells.Rows.Add(spell.ID, spell.Name, spell.ManaCost);
                }

                if (gameSession.GameStates == GameSession.GameState.Battle)
                {
                    ((DataGridViewDisableButtonCell)(dgvSpells.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                if(spell is DamageSpell)
                {
                    ((DataGridViewDisableButtonCell)(dgvSpells.Rows[rowIndex].Cells[3])).Enabled = false;
                }

                //Make the cast button to be off when the player doesn't have enough mana

                rowIndex++;
            }
        }

        private void UpdateDGVQuests()
        {
            int rowIndex = 0;
            dgvQuests.Rows.Clear();
            foreach (Quest quest in gameSession.CurrentPlayer.PlayerQuests)
            {
                if (!CheckIfInDGV(quest.ID, dgvQuests))
                {
                    //Sets a string to completed or in progress to signify the player's current progress on the quest
                    string status = "";
                    if (quest.IsCompleted)
                    {
                        status = "Completed";
                    }
                    else
                    {
                        status = "In Progress";
                    }

                    dgvQuests.Rows.Add(quest.ID, quest.Name, status);

                    //Sets color of status to green if complete yellow if incomplete
                    if (quest.IsCompleted)
                    {
                        dgvQuests.Rows[rowIndex].Cells[2].Style.BackColor = Color.LawnGreen;
                    }
                    else
                    {
                        dgvQuests.Rows[rowIndex].Cells[2].Style.BackColor = Color.PaleGoldenrod;
                    }
                }
                rowIndex++;
            }
            //dgvQuests.CellClick += dgvQuests_CellClick;
        }

        private void UpdateDGVBattleSpells()
        {
            if(gameSession.GameStates == GameSession.GameState.Travel)
            {
                dgvBattleSpells.Visible = false;
            }

            int rowIndex = 0;
            dgvBattleSpells.Rows.Clear();
            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                if (!CheckIfInDGV(spell.ID, dgvBattleSpells))
                {
                    dgvBattleSpells.Rows.Add(spell.ID, spell.Name, spell.ManaCost);
                }

                //Make the cast button to be off when the player doesn't have enough mana

                rowIndex++;
            }
        }

        private void UpdateDGVBattleItems()
        {
            if (gameSession.GameStates == GameSession.GameState.Travel)
            {
                dgvBattleItems.Visible = false;
            }

            dgvBattleItems.Rows.Clear();
            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.PlayerItems)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvBattleItems))
                {
                    if (item.Key is HealthReplenishingItem || item.Key is ManaReplenishingItem || item.Key is DamageItem)
                    {
                        dgvBattleItems.Rows.Add(item.Key.ID, item.Key.Name, item.Value);
                    }
                }
            }
        }

        private bool CheckIfInDGV(int id, DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == id.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
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

                    if (gameSession.CurrentPlayer.CurrentLocation.InnInLocation == null)
                    {
                        btnInn.Enabled = false;
                    }
                    else
                    {
                        btnInn.Enabled = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation == null)
                    {
                        btnShop.Enabled = false;
                    }
                    else
                    {
                        btnShop.Enabled = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.QuestInLocation == null)
                    {
                        btnTalk.Enabled = false;
                    }
                    else
                    {
                        btnTalk.Enabled = true;
                    }

                    btnAttack.Visible = false;
                    btnMagic.Visible = false;
                    btnItems.Visible = false;
                    btnRun.Visible = false;
                    btnEmpower.Visible = false;
                    btnGreed.Visible = false;
                    btnClose.Visible = false;
                    break;
                case GameSession.GameState.Battle:
                    btnAttack.Visible = true;
                    btnMagic.Visible = true;
                    btnItems.Visible = true;
                    if (gameSession.CurrentEnemy.IsBoss)
                    {
                        btnRun.Enabled = false;
                    }
                    else
                    {
                        btnRun.Enabled = true;
                    }
                    btnRun.Visible = true;
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;

                    if (gameSession.IsGreedActivated())
                    {
                        btnEmpower.Visible = false;
                    }
                    else
                    {
                        btnEmpower.Visible = true;

                    }

                    if (gameSession.CanActivateEmpowerment())
                    {
                        btnEmpower.Enabled = true;
                    }
                    else
                    {
                        btnEmpower.Enabled = false;
                    }

                    if (gameSession.TurnCounter == 1)
                    {
                        btnGreed.Visible = true;
                    }
                    else
                    {
                        btnGreed.Visible = false;
                    }
                    
                    break;
                case GameSession.GameState.GameOver:
                    break;
            }
        }

        private void DisplayWorldText(object o, MessageEventArgs e)
        {
            rtbWorldText.Text += e.Message + "\n";
        }
        
        private void rtbWorldText_TextChanged(object sender, EventArgs e)
        {
            rtbWorldText.SelectionStart = rtbWorldText.Text.Length;
            rtbWorldText.ScrollToCaret();
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

        private void OpenBattleSpells()
        {
            UpdateDGVs();
            dgvBattleSpells.Visible = true;
            btnClose.Visible = true;
        }

        private void CloseBattleSpellsAndItems()
        {
            UpdateDGVs();
            dgvBattleSpells.Visible = false;
            dgvBattleItems.Visible = false;
            btnClose.Visible = false;
        }

        private void OpenBattleItems()
        {
            UpdateDGVs();
            dgvBattleItems.Visible = true;
            btnClose.Visible = true;
        }


        //<-------------Event Functions------------->
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                var itemID = dgvItems.Rows[e.RowIndex].Cells[0].Value;

                Item itemBeingUsed = World.FindItemByID(Convert.ToInt32(itemID));

                InformationScreen informationScreen = new InformationScreen(gameSession, itemBeingUsed);
                informationScreen.StartPosition = FormStartPosition.CenterParent;
                informationScreen.ShowDialog(this);
                UpdateUI();
                return;
            }
            if (gameSession.GameStates == GameSession.GameState.Battle)
            {
                return;
            }
            if (((DataGridViewDisableButtonCell)(dgvItems.Rows[e.RowIndex].Cells[3])).Enabled == false)
            {
                return;
            }

            // The 4th column has the "Use" button.
            // Row Index is not -1 is to make sure the user can't buy the column names
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                // This gets the ID value of the entity, from the hidden 1st column
                var itemID = dgvItems.Rows[e.RowIndex].Cells[0].Value;
                
                Item itemBeingUsed = World.FindItemByID(Convert.ToInt32(itemID));
                gameSession.UseItemWhileTravelCommand(itemBeingUsed);
            }
            UpdateUI();
        }

        private void dgvEquipmentEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 && e.ColumnIndex != 2)
            {
                var equipmentID = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                // Get the equipment object in the row
                Equipment equipment = World.FindEquipmentByID(Convert.ToInt32(equipmentID));

                InformationScreen informationScreen = new InformationScreen(gameSession, equipment);
                informationScreen.StartPosition = FormStartPosition.CenterParent;
                informationScreen.ShowDialog(this);
                UpdateUI();
                return;
            }
            if (gameSession.GameStates == GameSession.GameState.Battle)
            {
                return;
            }
            if (((DataGridViewDisableButtonCell)(dgvEquipment.Rows[e.RowIndex].Cells[2])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                var equipmentID = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                // Get the equipment object in the row
                Equipment equipment = World.FindEquipmentByID(Convert.ToInt32(equipmentID));

                gameSession.EquipCommand(equipment);
                UpdateUI();
            }
        }

        private void dgvEquipmentUnequip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameSession.GameStates == GameSession.GameState.Battle)
            {
                return;
            }
            if (((DataGridViewDisableButtonCell)(dgvEquipment.Rows[e.RowIndex].Cells[3])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                var equipmentID = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                // Get the equipment object in the row
                Equipment equipment = World.FindEquipmentByID(Convert.ToInt32(equipmentID));

                gameSession.UnEquipCommand(equipment);
                UpdateUI();
            }
        }

        private void dgvSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                var spellID = dgvSpells.Rows[e.RowIndex].Cells[0].Value;

                // Get the spell object in the row
                Spell spell = World.FindSpellByID(Convert.ToInt32(spellID));

                InformationScreen informationScreen = new InformationScreen(gameSession, spell);
                informationScreen.StartPosition = FormStartPosition.CenterParent;
                informationScreen.ShowDialog(this);
                UpdateUI();
                return;
            }
            if (gameSession.GameStates == GameSession.GameState.Battle)
            {
                return;
            }
            if (((DataGridViewDisableButtonCell)(dgvSpells.Rows[e.RowIndex].Cells[3])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                var spellID = dgvSpells.Rows[e.RowIndex].Cells[0].Value;

                // Get the spell object in the row
                Spell spell = World.FindSpellByID(Convert.ToInt32(spellID));

                gameSession.CastSpellWhileTravelCommand(spell);
                UpdateUI();
            }
        }

        private void dgvQuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var questID = dgvQuests.Rows[e.RowIndex].Cells[0].Value;

            // Get the quest object in the row
            Quest quest = World.FindQuestByID(Convert.ToInt32(questID));

            InformationScreen informationScreen = new InformationScreen(gameSession, quest);
            informationScreen.StartPosition = FormStartPosition.CenterParent;
            informationScreen.ShowDialog(this);

            UpdateUI();
        }

        private void dgvBattleSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameSession.GameStates == GameSession.GameState.Travel)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                var spellID = dgvBattleSpells.Rows[e.RowIndex].Cells[0].Value;

                // Get the spell object in the row
                Spell spell = World.FindSpellByID(Convert.ToInt32(spellID));

                gameSession.CastSpellCommand(spell);
                UpdateUI();
                CloseBattleSpellsAndItems();
            }
        }

        private void dgvBattleItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var itemID = dgvBattleItems.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Item item = World.FindItemByID(Convert.ToInt32(itemID));

                //Use Item Function
                gameSession.UseItemCommand(item);
                UpdateUI();
                CloseBattleSpellsAndItems();
            }
        }

        
        //<----------Battle Buttons---------->
        private void btnAttack_Click(object sender, EventArgs e)
        {
            gameSession.AttackCommand();
            UpdateUI();
            CloseBattleSpellsAndItems();
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            OpenBattleSpells();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            OpenBattleItems();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            gameSession.RunCommand();
            UpdateUI();
            CloseBattleSpellsAndItems();
        }


        //<----------Inn Buttons----------->
        private void btnInn_Click(object sender, EventArgs e)
        {
            InnScreen innScreen = new InnScreen(gameSession);
            innScreen.StartPosition = FormStartPosition.CenterParent;
            innScreen.ShowDialog(this);
        }


        //<----------Shop Buttons----------->
        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopScreen shopScreen = new ShopScreen(gameSession);
            shopScreen.StartPosition = FormStartPosition.CenterParent;
            shopScreen.ShowDialog(this);
        }


        //<----------Quest Buttons----------->
        private void btnTalk_Click(object sender, EventArgs e)
        {
            QuestScreen questScreen = new QuestScreen(gameSession);
            questScreen.StartPosition = FormStartPosition.CenterParent;
            questScreen.ShowDialog(this);
        }


        //<----------Map Buttons----------->
        private void btnMap_Click(object sender, EventArgs e)
        {
            MapScreen mapScreen = new MapScreen(gameSession);
            mapScreen.StartPosition = FormStartPosition.CenterParent;
            mapScreen.ShowDialog(this);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            InformationScreen informationScreen = new InformationScreen(gameSession, World.FindVendorByID(1));
            informationScreen.StartPosition = FormStartPosition.CenterParent;
            informationScreen.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseBattleSpellsAndItems();
        }

        private void btnEmpower_Click(object sender, EventArgs e)
        {
            gameSession.ActivateEmpowermentCommand();
            UpdateUI();
        }

        private void btnGreed_Click(object sender, EventArgs e)
        {
            if(gameSession.TurnCounter == 1)
            {
                gameSession.ActivateGreedCommand();
            }
            UpdateUI();
        }
    }
}
