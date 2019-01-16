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
    public partial class ShopScreen : Form
    {
        GameSession gameSession;

        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();


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

            dgvPlayerInventory.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvPlayerInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colID", 
                HeaderText = "ID", 
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn
            { 
                Name = "colName", 
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colQuantity", 
                HeaderText = "Qty",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colGold", 
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnSell",
                HeaderText = "",
                Text = "Sell 1",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 50,
            });

            int rowIndex = 0;
            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.PlayerItems)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvPlayerInventory))
                {
                    dgvPlayerInventory.Rows.Add(item.Key.ID, null, item.Key.Name, item.Value + "x", item.Key.SellingGoldValue);

                    SetDGVImage((DataGridViewImageCell)dgvPlayerInventory.Rows[rowIndex].Cells[1], item.Key.Name);

                    if(item.Key is KeyItem || item.Key is QuestItem)
                    {
                        ((DataGridViewDisableButtonCell)(dgvPlayerInventory.Rows[rowIndex].Cells[5])).Enabled = false;
                    }

                    rowIndex++;
                }
            }

            dgvPlayerInventory.Sort(dgvPlayerInventory.Columns[0], ListSortDirection.Ascending);
        }

        private void SetUpDGVPlayerEquipment()
        {
            dgvPlayerInventory.Rows.Clear();
            dgvPlayerInventory.Columns.Clear();

            dgvPlayerInventory.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvPlayerInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colID", 
                HeaderText = "ID", 
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colName", 
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colGold", 
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewDisableButtonColumn
            {
                Name = "btnSell",
                HeaderText = "",
                Text = "Sell 1",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 50,
            });

            int rowIndex = 0;

            foreach (Equipment equipment in gameSession.CurrentPlayer.PlayerEquipments)
            {
                dgvPlayerInventory.Rows.Add(equipment.ID, null, equipment.Name, equipment.SellingGoldValue);

                SetDGVImage((DataGridViewImageCell)dgvPlayerInventory.Rows[rowIndex].Cells[1], equipment.Name);

                if (gameSession.CheckIfAlreadyEquipped(equipment))
                {
                    ((DataGridViewDisableButtonCell)(dgvPlayerInventory.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else
                {
                    ((DataGridViewDisableButtonCell)(dgvPlayerInventory.Rows[rowIndex].Cells[4])).Enabled = true;
                }

                rowIndex++;
            }

            dgvPlayerInventory.Sort(dgvPlayerInventory.Columns[0], ListSortDirection.Ascending);
        }

        private void SetUpDGVPlayerSpells()
        {
            dgvPlayerInventory.Rows.Clear();
            dgvPlayerInventory.Columns.Clear();

            dgvPlayerInventory.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvPlayerInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colID", 
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colName", 
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colGold", 
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnSell",
                HeaderText = "",
                Text = "Sell 1",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 50,
            });

            int rowIndex = 0;

            foreach (Spell spell in gameSession.CurrentPlayer.PlayerSpells)
            {
                dgvPlayerInventory.Rows.Add(spell.ID, null, spell.Name, spell.SellingGoldValue);

                SetDGVImage((DataGridViewImageCell)dgvPlayerInventory.Rows[rowIndex].Cells[1], spell.Name);

                rowIndex++;
            }

            dgvPlayerInventory.Sort(dgvPlayerInventory.Columns[0], ListSortDirection.Ascending);
        }


        //<----------Vendor DGV Update Functions----------->
        private void SetUpDGVVendorItems()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvVendorInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colID", 
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colName", 
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colQuantity", 
                HeaderText = "Qty",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGold",
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewDisableButtonColumn
            {
                Name = "btnBuy",
                HeaderText = "",
                Text = "Buy 1",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 50,
            });

            int rowIndex = 0;

            foreach (KeyValuePair<Item, int> item in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvVendorInventory))
                {
                    dgvVendorInventory.Rows.Add(item.Key.ID, null, item.Key.Name, item.Value + "x", item.Key.GoldValue);

                    SetDGVImage((DataGridViewImageCell)dgvVendorInventory.Rows[rowIndex].Cells[1], item.Key.Name);

                    if (gameSession.CurrentPlayer.Gold < item.Key.GoldValue)
                    {
                        ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[5])).Enabled = false;
                    }
                    else
                    {
                        ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[5])).Enabled = true;
                    }
                }
                rowIndex++;
            }

            dgvVendorInventory.Sort(dgvVendorInventory.Columns[0], ListSortDirection.Ascending);
        }

        private void SetUpDGVVendorEquipment()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvVendorInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colID", 
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colName",
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colGold", 
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewDisableButtonColumn
            {
                Name = "btnBuy",
                HeaderText = "",
                Text = "Buy 1",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 50,
            });

            int rowIndex = 0;

            foreach (Equipment equipment in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory)
            {
                dgvVendorInventory.Rows.Add(equipment.ID, null, equipment.Name, equipment.GoldValue);

                SetDGVImage((DataGridViewImageCell)dgvVendorInventory.Rows[rowIndex].Cells[1], equipment.Name);

                if (gameSession.CurrentPlayer.Gold < equipment.GoldValue)
                {
                    ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else if (!gameSession.CurrentPlayer.CheckIfEquippable(equipment))
                {
                    ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else
                {
                    ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[4])).Enabled = true;
                }

                rowIndex++;
            }

            dgvVendorInventory.Sort(dgvVendorInventory.Columns[0], ListSortDirection.Ascending);
        }

        private void SetUpDGVVendorSpells()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgvVendorInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colID", 
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colName",
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                Name = "colGold",
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgvVendorInventory.Columns.Add(new DataGridViewDisableButtonColumn
            {
                Name = "btnBuy",
                HeaderText = "",
                Text = "Buy 1",
                UseColumnTextForButtonValue = true,
                ReadOnly = true,
                Width = 50,
            });
            
            int rowIndex = 0;

            foreach (Spell spell in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory)
            {
                dgvVendorInventory.Rows.Add(spell.ID, null, spell.Name, spell.GoldValue);

                SetDGVImage((DataGridViewImageCell)dgvVendorInventory.Rows[rowIndex].Cells[1], spell.Name);

                if (gameSession.CurrentPlayer.Gold < spell.GoldValue)
                {
                    ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[4])).Enabled = false;
                }
                else
                {
                    ((DataGridViewDisableButtonCell)(dgvVendorInventory.Rows[rowIndex].Cells[4])).Enabled = true;
                }

                rowIndex++;
            }

            dgvVendorInventory.Sort(dgvVendorInventory.Columns[0], ListSortDirection.Ascending);
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
                columnIndex = 5;
            }
            else if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                columnIndex = 4;
            }
            else if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                columnIndex = 4;
            }

            if (e.ColumnIndex != columnIndex)
            {
                var entityID = dgvPlayerInventory.Rows[e.RowIndex].Cells[0].Value;

                if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
                {
                    Item itemBeingViewed = World.FindItemByID(Convert.ToInt32(entityID));
                    
                    InformationScreen informationScreen = new InformationScreen(gameSession, itemBeingViewed);
                    informationScreen.StartPosition = FormStartPosition.CenterParent;
                    informationScreen.ShowDialog(this);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
                {
                    Equipment equipmentBeingViewed = World.FindEquipmentByID(Convert.ToInt32(entityID));

                    InformationScreen informationScreen = new InformationScreen(gameSession, equipmentBeingViewed);
                    informationScreen.StartPosition = FormStartPosition.CenterParent;
                    informationScreen.ShowDialog(this);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
                {
                    Spell spellBeingViewed = World.FindSpellByID(Convert.ToInt32(entityID));
                    
                    InformationScreen informationScreen = new InformationScreen(gameSession, spellBeingViewed);
                    informationScreen.StartPosition = FormStartPosition.CenterParent;
                    informationScreen.ShowDialog(this);
                }

                UpdateUI();
                return;
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
                    if (itemBeingSold is KeyItem || itemBeingSold is QuestItem)
                    {
                        return;
                    }
                    gameSession.SellToStoreCommand(itemBeingSold);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
                {
                    Equipment equipmentBeingSold = World.FindEquipmentByID(Convert.ToInt32(entityID));
                    if (gameSession.CheckIfAlreadyEquipped(equipmentBeingSold))
                    {
                        return;
                    }
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
                columnIndex = 5;
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
            {
                columnIndex = 4;
            }
            else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
            {
                columnIndex = 4;
            }

            if (e.ColumnIndex != columnIndex)
            {
                var entityID = dgvVendorInventory.Rows[e.RowIndex].Cells[0].Value;

                if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
                {
                    Item itemBeingViewed = World.FindItemByID(Convert.ToInt32(entityID));

                    InformationScreen informationScreen = new InformationScreen(gameSession, itemBeingViewed);
                    informationScreen.StartPosition = FormStartPosition.CenterParent;
                    informationScreen.ShowDialog(this);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
                {
                    Equipment equipmentBeingViewed = World.FindEquipmentByID(Convert.ToInt32(entityID));

                    InformationScreen informationScreen = new InformationScreen(gameSession, equipmentBeingViewed);
                    informationScreen.StartPosition = FormStartPosition.CenterParent;
                    informationScreen.ShowDialog(this);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
                {
                    Spell spellBeingViewed = World.FindSpellByID(Convert.ToInt32(entityID));

                    InformationScreen informationScreen = new InformationScreen(gameSession, spellBeingViewed);
                    informationScreen.StartPosition = FormStartPosition.CenterParent;
                    informationScreen.ShowDialog(this);
                }

                UpdateUI();
                return;
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
                    gameSession.BuyFromStoreCommand(itemBeingSold);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorEquipmentInventory != null)
                {
                    Equipment equipmentBeingSold = World.FindEquipmentByID(Convert.ToInt32(entityID));
                    if (!gameSession.CurrentPlayer.CheckIfEquippable(equipmentBeingSold))
                    {
                        UpdateUI();
                        return;
                    }
                    gameSession.BuyFromStoreCommand(equipmentBeingSold);
                }
                else if (gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorSpellInventory != null)
                {
                    Spell spellBeingSold = World.FindSpellByID(Convert.ToInt32(entityID));
                    gameSession.BuyFromStoreCommand(spellBeingSold);
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

            lblPlayerInventoryLabel.Text = gameSession.CurrentPlayer.Name + "'s Inventory";
            lblVendorInventoryLabel.Text = gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.Name +  "'s Inventory";

            SetImage(pbVendorPicture, gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.Name);

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
            if (imageName == null)
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
    }
}
