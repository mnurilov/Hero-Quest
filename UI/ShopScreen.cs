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
    public partial class ShopScreen : Form
    {
        GameSession gameSession; 


        public ShopScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            InitializePlayerInventory();
            InitializeVendorInventory();
            UpdateUI();
        }


        //<-----------Initialization Functions------------>
        private void InitializePlayerInventory()
        {
            if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                SetUpDGVPlayerItems();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                SetUpDGVPlayerEquipment();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                SetUpDGVPlayerSpells();
            }

            dgvPlayerInventory.CellClick += dgvPlayerInventory_CellClick;
        }

        private void InitializeVendorInventory()
        {
            if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                SetUpDGVVendorItems();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                SetUpDGVVendorEquipment();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                SetUpDGVVendorSpells();
            }

            dgvVendorInventory.CellClick += dgvVendorInventory_CellClick;
        }


        //<-----------Player DGV Update Functions------------->
        private void SetUpDGVPlayerItems()
        {
            dgvPlayerInventory.Rows.Clear();
            dgvPlayerInventory.Columns.Clear();

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value"});
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQuantity", HeaderText = "Quantity" });
            dgvPlayerInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnSell",
                HeaderText = "",
                Text = "Sell 1",
                UseColumnTextForButtonValue = true
            });

            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.PlayerItems)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvPlayerInventory))
                {
                    dgvPlayerInventory.Rows.Add(item.Key.ID, item.Key.Name, item.Key.SellingGoldValue, item.Value);
                }
            }
        }

        private void SetUpDGVPlayerEquipment()
        {
            dgvPlayerInventory.Rows.Clear();
            dgvPlayerInventory.Columns.Clear();

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            dgvPlayerInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnSell",
                HeaderText = "",
                Text = "Sell 1",
                UseColumnTextForButtonValue = true
            });

            foreach (Equipment equipment in gameSession.CurrentPlayer.PlayerEquipments)
            {
                if (!CheckIfInDGV(equipment.ID, dgvPlayerInventory))
                {
                    dgvPlayerInventory.Rows.Add(equipment.ID, equipment.Name, equipment.SellingGoldValue);
                }
            }
        }

        private void SetUpDGVPlayerSpells()
        {
            dgvPlayerInventory.Rows.Clear();
            dgvPlayerInventory.Columns.Clear();

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            dgvPlayerInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnSell",
                HeaderText = "",
                Text = "Sell 1",
                UseColumnTextForButtonValue = true
            });

            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                if (!CheckIfInDGV(spell.ID, dgvPlayerInventory))
                {
                    dgvPlayerInventory.Rows.Add(spell.ID, spell.Name, spell.SellingGoldValue);
                }
            }
        }


        //<----------Vendor DGV Update Functions----------->
        private void SetUpDGVVendorItems()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQuantity", HeaderText = "Quantity" });
            dgvVendorInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnBuy",
                HeaderText = "",
                Text = "Buy 1",
                UseColumnTextForButtonValue = true
            });

            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvVendorInventory))
                {
                    dgvVendorInventory.Rows.Add(item.Key.ID, item.Key.Name, item.Key.GoldValue, item.Value);
                }
            }
        }

        private void SetUpDGVVendorEquipment()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            dgvVendorInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnBuy",
                HeaderText = "",
                Text = "Buy 1",
                UseColumnTextForButtonValue = true
            });

            foreach (Equipment equipment in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory)
            {
                if (!CheckIfInDGV(equipment.ID, dgvVendorInventory))
                {
                    dgvVendorInventory.Rows.Add(equipment.ID, equipment.Name, equipment.GoldValue);
                }
            }
        }

        private void SetUpDGVVendorSpells()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            dgvVendorInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnBuy",
                HeaderText = "",
                Text = "Buy 1",
                UseColumnTextForButtonValue = true
            });

            foreach (Spell spell in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory)
            {
                if (!CheckIfInDGV(spell.ID, dgvVendorInventory))
                {
                    dgvVendorInventory.Rows.Add(spell.ID, spell.Name, spell.GoldValue);
                }
            }
        }


        //Checks if an object is in the data grid view
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


        //<----------DGV Click Events----------->
        private void dgvPlayerInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = 0;

            if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                columnIndex = 4;
            }
            else if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                columnIndex = 3;
            }
            else if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                columnIndex = 3;
            }

            // The 4th or 5th column has the "Buy 1" button.
            // Row Index is not -1 is to make sure the user can't buy the column names
            if (e.ColumnIndex == columnIndex && e.RowIndex != -1)
            {
                // This gets the ID value of the entity, from the hidden 1st column
                var entityID = dgvPlayerInventory.Rows[e.RowIndex].Cells[0].Value;

                if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
                {
                    Item itemBeingSold = World.FindItemByID(Convert.ToInt32(entityID));
                    gameSession.SellToStoreCommand(itemBeingSold);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
                {
                    Equipment equipmentBeingSold = World.FindEquipmentByID(Convert.ToInt32(entityID));
                    gameSession.SellToStoreCommand(equipmentBeingSold);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
                {
                    Spell spellBeingSold = World.FindSpellByID(Convert.ToInt32(entityID));
                    gameSession.SellToStoreCommand(spellBeingSold);
                }
            }

            UpdateUI();
        }

        private void dgvVendorInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = 0;

            if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                columnIndex = 4;
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                columnIndex = 3;
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                columnIndex = 3;
            }

            // The 4th or 5th column has the "Buy 1" button.
            // Row Index is not -1 is to make sure the user can't buy the column names
            if (e.ColumnIndex == columnIndex && e.RowIndex != -1)
            {
                // This gets the ID value of the entity, from the hidden 1st column
                var entityID = dgvVendorInventory.Rows[e.RowIndex].Cells[0].Value;

                if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
                {
                    Item itemBeingSold = World.FindItemByID(Convert.ToInt32(entityID));
                    if (gameSession.BuyFromStoreCommand(itemBeingSold))
                    {
                        MessageBox.Show("You bought the item");
                    }
                    else
                    {
                        MessageBox.Show("Can't buy the item");
                    }
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
                {
                    Equipment equipmentBeingSold = World.FindEquipmentByID(Convert.ToInt32(entityID));
                    if (gameSession.BuyFromStoreCommand(equipmentBeingSold))
                    {
                        MessageBox.Show("You bought the item");
                    }
                    else
                    {
                        MessageBox.Show("Can't buy the item");
                    }
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
                {
                    Spell spellBeingSold = World.FindSpellByID(Convert.ToInt32(entityID));
                    if (gameSession.BuyFromStoreCommand(spellBeingSold))
                    {
                        MessageBox.Show("You bought the item");
                    }
                    else
                    {
                        MessageBox.Show("Can't buy the item");
                    }
                }
            }

            UpdateUI();
        }


        //<-----------Update UI Functions----------->
        private void UpdateUI()
        {
            lblPlayerName.Text = gameSession.CurrentPlayer.Name;
            lblPlayerGold.Text = gameSession.CurrentPlayer.Gold.ToString();

            lblVendorName.Text = gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.Name;
            lblVendorDescription.Text = gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.Description;

            UpdatePlayerInventory();
            UpdateVendorInventory();
        }

        private void UpdatePlayerInventory()
        {
            if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                SetUpDGVPlayerItems();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                SetUpDGVPlayerEquipment();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                SetUpDGVPlayerSpells();
            }
        }

        private void UpdateVendorInventory()
        {
            if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                SetUpDGVVendorItems();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                SetUpDGVVendorEquipment();
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                SetUpDGVVendorSpells();
            }
        }
    }
}
