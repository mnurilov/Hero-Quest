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
            if(gameSession.CurrentEnemy != null)
            {
                if (gameSession.GameStates == GameSession.GameState.Battle)
                {
                    lblEnemyName.Text = gameSession.CurrentEnemy?.Name;
                    lblEnemyDescription.Text = gameSession.CurrentEnemy?.Description;
                    SetImage(pbEnemyPicture, gameSession.CurrentEnemy?.Name);
                }
                else
                {
                    lblEnemyName.Text = "";
                    lblEnemyDescription.Text = "";
                    SetImage(pbEnemyPicture, null);
                }
            }
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
                    dgvItems.Rows.Add(item.Key.ID, null, item.Key.Name, item.Value + "x");
                }
                else
                {
                    continue;
                }

                SetDGVImage((DataGridViewImageCell)dgvItems.Rows[rowIndex].Cells[1], item.Key.Name);

                if(gameSession.GameStates == GameSession.GameState.Battle)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                if (item.Key is EnemyLoot)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else if(item.Key is KeyItem)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else if(item.Key is DamageItem)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else if(item.Key is QuestItem)
                {
                    ((DataGridViewDisableButtonCell)(dgvItems.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                rowIndex++;
            }

            dgvItems.Sort(colItemID, ListSortDirection.Ascending);
        }

        private void UpdateDGVEquipment()
        {
            int rowIndex = 0;
            dgvEquipment.Rows.Clear();
            foreach (Equipment equipment in gameSession.CurrentPlayer.PlayerEquipments)
            {
                dgvEquipment.Rows.Add(equipment.ID, null, equipment.Name);

                SetDGVImage((DataGridViewImageCell)dgvEquipment.Rows[rowIndex].Cells[1], equipment.Name);

                if (gameSession.GameStates == GameSession.GameState.Battle)
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[3])).Enabled = false;
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                if (!gameSession.CheckIfEquippableCommand(equipment))
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[3])).Enabled = false;
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                if (gameSession.CheckIfAlreadyEquipped(equipment))
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[3])).Enabled = false;
                }
                else
                {
                    ((DataGridViewDisableButtonCell)(dgvEquipment.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                rowIndex++;
            }
            
            dgvEquipment.Sort(colEquipmentID, ListSortDirection.Ascending);
        }

        private void UpdateDGVSpells()
        {
            int rowIndex = 0;
            dgvSpells.Rows.Clear();
            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                dgvSpells.Rows.Add(spell.ID, null, spell.Name, spell.ManaCost);

                SetDGVImage((DataGridViewImageCell)dgvSpells.Rows[rowIndex].Cells[1], spell.Name);

                if (gameSession.GameStates == GameSession.GameState.Battle)
                {
                    ((DataGridViewDisableButtonCell)(dgvSpells.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                if(spell is DamageSpell)
                {
                    ((DataGridViewDisableButtonCell)(dgvSpells.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                if(gameSession.CurrentPlayer.CurrentMana < spell.ManaCost)
                {
                    ((DataGridViewDisableButtonCell)(dgvSpells.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                rowIndex++;
            }

            dgvSpells.Sort(colSpellID, ListSortDirection.Ascending);
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

                    dgvQuests.Rows.Add(quest.ID, null, quest.Name, status);
                    
                    SetDGVImage((DataGridViewImageCell)dgvQuests.Rows[rowIndex].Cells[1], quest.Name);

                    //Sets color of status to green if complete yellow if incomplete
                    if (quest.IsCompleted)
                    {
                        dgvQuests.Rows[rowIndex].Cells[3].Style.BackColor = Color.FromArgb(28, 237, 91);
                    }
                    else
                    {
                        dgvQuests.Rows[rowIndex].Cells[3].Style.BackColor = Color.FromArgb(242, 255, 145);
                    }
                }
                else
                {
                    continue;
                }
                rowIndex++;
            }

            dgvQuests.Sort(colQuestID, ListSortDirection.Ascending);
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
                dgvBattleSpells.Rows.Add(spell.ID, null, spell.Name, spell.ManaCost);

                SetDGVImage((DataGridViewImageCell)dgvBattleSpells.Rows[rowIndex].Cells[1], spell.Name);

                if (gameSession.CurrentPlayer.CurrentMana < spell.ManaCost)
                {
                    ((DataGridViewDisableButtonCell)(dgvBattleSpells.Rows[rowIndex].Cells[4])).Enabled = false;
                }

                rowIndex++;
            }

            dgvBattleSpells.Sort(colBattleSpellsID, ListSortDirection.Ascending);
        }

        private void UpdateDGVBattleItems()
        {
            if (gameSession.GameStates == GameSession.GameState.Travel)
            {
                dgvBattleItems.Visible = false;
            }

            int rowIndex = 0;
            dgvBattleItems.Rows.Clear();
            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.PlayerItems)
            {
                if (item.Key is HealthReplenishingItem || item.Key is ManaReplenishingItem || item.Key is DamageItem)
                {
                    dgvBattleItems.Rows.Add(item.Key.ID, null, item.Key.Name, item.Value + "x");

                    SetDGVImage((DataGridViewImageCell)dgvBattleItems.Rows[rowIndex].Cells[1], item.Key.Name);

                    rowIndex++;
                }
            }

            dgvBattleItems.Sort(colBattleItemsID, ListSortDirection.Ascending);
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
                        btnNorth.Visible = false;
                    }
                    else
                    {
                        btnNorth.Visible = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheSouth == null)
                    {
                        btnSouth.Visible = false;
                    }
                    else
                    {
                        btnSouth.Visible = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheWest == null)
                    {
                        btnWest.Visible = false;
                    }
                    else
                    {
                        btnWest.Visible = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.LocationToTheEast == null)
                    {
                        btnEast.Visible = false;
                    }
                    else
                    {
                        btnEast.Visible = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.InnInLocation == null)
                    {
                        btnInn.Visible = false;
                    }
                    else
                    {
                        btnInn.Visible = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation == null)
                    {
                        btnShop.Visible = false;
                    }
                    else
                    {
                        btnShop.Visible = true;
                    }

                    if (gameSession.CurrentPlayer.CurrentLocation.QuestInLocation == null)
                    {
                        btnTalk.Visible = false;
                    }
                    else
                    {
                        btnTalk.Visible = true;
                    }

                    btnAttack.Visible = false;
                    btnMagic.Visible = false;
                    btnItems.Visible = false;
                    btnRun.Visible = false;
                    DisableEmpowerVisuals();
                    btnGreed.Visible = false;
                    pbGreed.Visible = false;
                    btnClose.Visible = false;
                    btnMap.Visible = true;
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
                    btnNorth.Visible = false;
                    btnSouth.Visible = false;
                    btnWest.Visible = false;
                    btnEast.Visible = false;
                    btnMap.Visible = false;
                    btnInn.Visible = false;
                    btnShop.Visible = false;
                    btnTalk.Visible = false;

                    if (gameSession.TurnCounter == 1)
                    {
                        btnGreed.Visible = true;
                    }
                    else
                    {
                        btnGreed.Visible = false;
                    }

                    if (gameSession.IsGreedActivated())
                    {
                        btnEmpower.Visible = false;
                        btnGreed.Visible = false;
                        pbGreed.Visible = true;
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

                    if (gameSession.IsEmpowered())
                    {
                        pbEmpower.Visible = true;
                    }

                    if(gameSession.CurrentPlayer.EmpowerCounter == 0)
                    {
                        pnEmpower1.Visible = false;
                        pnEmpower2.Visible = false;
                        pnEmpower3.Visible = false;
                        pnEmpower4.Visible = false;
                    }
                    else if(gameSession.CurrentPlayer.EmpowerCounter == 1)
                    {
                        pnEmpower1.Visible = true;
                        pnEmpower2.Visible = false;
                        pnEmpower3.Visible = false;
                        pnEmpower4.Visible = false;
                    }
                    else if(gameSession.CurrentPlayer.EmpowerCounter == 2)
                    {
                        pnEmpower1.Visible = true;
                        pnEmpower2.Visible = true;
                        pnEmpower3.Visible = false;
                        pnEmpower4.Visible = false;
                    }
                    else if (gameSession.CurrentPlayer.EmpowerCounter == 3)
                    {
                        pnEmpower1.Visible = true;
                        pnEmpower2.Visible = true;
                        pnEmpower3.Visible = true;
                        pnEmpower4.Visible = false;
                    }
                    else if (gameSession.CurrentPlayer.EmpowerCounter == 4)
                    {
                        pnEmpower1.Visible = true;
                        pnEmpower2.Visible = true;
                        pnEmpower3.Visible = true;
                        pnEmpower4.Visible = true;
                    }

                    break;
                case GameSession.GameState.GameOver:
                    break;
            }
        }

        private void DisplayWorldText(object o, MessageEventArgs e)
        {
            rtbWorldText.Text += "~" + e.Message + "\n";
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

        private void SetDGVImage(DataGridViewImageCell imageCell, string imageName)
        {
            if(imageName == null)
            {
                imageCell.Value = null;
                return;
            }

            using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images." + imageName + ".png"))

            {
                if (resourceStream != null)
                {
                    imageCell.Value = new Bitmap(resourceStream);
                }
            }
        }

        private void OpenBattleSpells()
        {
            UpdateUI();
            dgvBattleSpells.Visible = true;
            btnClose.Visible = true;
        }

        private void CloseBattleSpellsAndItems()
        {
            UpdateUI();
            dgvBattleSpells.Visible = false;
            dgvBattleItems.Visible = false;
            btnClose.Visible = false;
        }

        private void OpenBattleItems()
        {
            UpdateUI();
            dgvBattleItems.Visible = true;
            btnClose.Visible = true;
        }

        private void DisableEmpowerVisuals()
        {
            btnEmpower.Visible = false;
            pnEmpower1.Visible = false;
            pnEmpower2.Visible = false;
            pnEmpower3.Visible = false;
            pnEmpower4.Visible = false;
            pbEmpower.Visible = false;
        }


        //<-------------Event Functions------------->
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex != 4)
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
            if (((DataGridViewDisableButtonCell)(dgvItems.Rows[e.RowIndex].Cells[4])).Enabled == false)
            {
                return;
            }

            // The 4th column has the "Use" button.
            // Row Index is not -1 is to make sure the user can't buy the column names
            if (e.ColumnIndex == 4)
            {
                // This gets the ID value of the entity, from the hidden 1st column
                var itemID = dgvItems.Rows[e.RowIndex].Cells[0].Value;

                Item itemBeingUsed = World.FindItemByID(Convert.ToInt32(itemID));
                gameSession.UseItemWhileTravelCommand(itemBeingUsed);
                UpdateUI();
                return;
            }
        }

        private void dgvEquipmentEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            
            if (e.ColumnIndex != 4 && e.ColumnIndex != 3)
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
            if (((DataGridViewDisableButtonCell)(dgvEquipment.Rows[e.RowIndex].Cells[3])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                var equipmentID = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                // Get the equipment object in the row
                Equipment equipment = World.FindEquipmentByID(Convert.ToInt32(equipmentID));

                gameSession.EquipCommand(equipment);
                UpdateUI();
                return;
            }
        }

        private void dgvEquipmentUnequip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (gameSession.GameStates == GameSession.GameState.Battle)
            {
                return;
            }
            if (((DataGridViewDisableButtonCell)(dgvEquipment.Rows[e.RowIndex].Cells[4])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 4)
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
            if(e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex != 4)
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
            if (((DataGridViewDisableButtonCell)(dgvSpells.Rows[e.RowIndex].Cells[4])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 4)
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
            if (e.RowIndex == -1)
            {
                return;
            }

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
            if (((DataGridViewDisableButtonCell)(dgvBattleSpells.Rows[e.RowIndex].Cells[4])).Enabled == false)
            {
                return;
            }

            if (e.ColumnIndex == 4)
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
            if (e.ColumnIndex == 4)
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

            UpdateUI();
        }


        //<----------Shop Buttons----------->
        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopScreen shopScreen = new ShopScreen(gameSession);
            shopScreen.StartPosition = FormStartPosition.CenterParent;
            shopScreen.ShowDialog(this);

            UpdateUI();
        }


        //<----------Quest Buttons----------->
        private void btnTalk_Click(object sender, EventArgs e)
        {
            QuestScreen questScreen = new QuestScreen(gameSession);
            questScreen.StartPosition = FormStartPosition.CenterParent;
            questScreen.ShowDialog(this);

            UpdateUI();
        }


        //<----------Map Buttons----------->
        private void btnMap_Click(object sender, EventArgs e)
        {
            MapScreen mapScreen = new MapScreen(gameSession);
            mapScreen.StartPosition = FormStartPosition.CenterParent;
            mapScreen.ShowDialog(this);

            UpdateUI();
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
