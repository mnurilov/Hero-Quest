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
            gameSession.OnMessagedRaised += DisplayWorldText;
            UpdateUI();
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
            UpdateButtons();
            UpdateDGVs();
        }

        private void UpdateDGVs()
        {
            UpdateDGVItems();
            UpdateDGVEquipment();
            UpdateDGVSpells();
            UpdateDGVQuests();
        }

        private void UpdateDGVItems()
        {

        }

        private void UpdateDGVEquipment()
        {
            dgvEquipment.Rows.Clear();
            foreach (Equipment equipment in gameSession.CurrentPlayer.PlayerEquipments)
            {
                if (!CheckIfInDGV(equipment.ID, dgvEquipment))
                {
                    dgvEquipment.Rows.Add(equipment.ID, equipment.Name);
                }
            }
            //dgvEquipment.CellClick += dgvEquipment_CellClick;
            //dgvEquipment.CellClick += dgvEquipment2_CellClick;
        }

        private void UpdateDGVSpells()
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
                    btnAttack.Visible = false;
                    btnMagic.Visible = false;
                    btnItems.Visible = false;
                    btnRun.Visible = false;
                    break;
                case GameSession.GameState.Battle:
                    btnAttack.Visible = true;
                    btnMagic.Visible = true;
                    btnItems.Visible = true;
                    btnRun.Visible = true;
                    btnNorth.Enabled = false;
                    btnSouth.Enabled = false;
                    btnWest.Enabled = false;
                    btnEast.Enabled = false;
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

        
        //<----------Battle Buttons---------->
        private void btnAttack_Click(object sender, EventArgs e)
        {
            gameSession.AttackCommand();
            UpdateUI();
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {

        }

        private void btnItems_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            gameSession.RunCommand();
            UpdateUI();
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
            InformationScreen informationScreen = new InformationScreen(gameSession, 5);
            informationScreen.StartPosition = FormStartPosition.CenterParent;
            informationScreen.ShowDialog(this);
        }
    }
}
