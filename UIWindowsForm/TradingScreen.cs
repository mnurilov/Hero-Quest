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
    public partial class TradingScreen : Form
    {
        GameSession gameSession;

        public TradingScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            InitializePlayerInventory();
            InitializeVendorInventory();

            //This needs to be assigned only once otherwise it's double cell clickingAJDOAHSDOASHIODHASOIDHIASHDOASHD
            dgvVendorInventory.CellClick += dgvVendorInventory_CellClick;
            dgvPlayerInventory.CellClick += dgvPlayerInventory_CellClick;
        }

        private void InitializePlayerInventory()
        {
            if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                SetUpDGVPlayerItems();
            }
        }

        private void InitializeVendorInventory()
        {
            if(gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory != null)
            {
                SetUpDGVVendorItems();
            }
        }

        private void SetUpDGVPlayerItems()
        {
            dgvPlayerInventory.Rows.Clear();
            dgvPlayerInventory.Columns.Clear();

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
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
                    dgvPlayerInventory.Rows.Add(item.Key.ID, item.Key.Name, item.Value);
                }
            }

        }
        
        private void SetUpDGVVendorItems()
        {
            dgvVendorInventory.Rows.Clear();
            dgvVendorInventory.Columns.Clear();

            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID" , Visible = false});
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgvVendorInventory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQuantity", HeaderText = "Quantity" });
            dgvVendorInventory.Columns.Add(new DataGridViewButtonColumn 
            { 
                Name = "btnBuy",
                HeaderText = "", 
                Text = "Buy 1", 
                UseColumnTextForButtonValue = true 
            });

            foreach(KeyValuePair<Item, int> item in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory)
            {
                if (!CheckIfInDGV(item.Key.ID, dgvVendorInventory))
                {
                    dgvVendorInventory.Rows.Add(item.Key.ID, item.Key.Name, item.Value);
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

        private void dgvVendorInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // The 4th column (ColumnIndex = 3) has the "Buy 1" button.
            // Make sure the user can't buy the column names
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                // This gets the ID value of the item, from the hidden 1st column
                var itemID = dgvVendorInventory.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Item itemBeingBought = World.FindItemByID(Convert.ToInt32(itemID));

                // Check if the player has enough gold to buy the item
                //if (gameSession.BuyInventory(itemBeingBought))
                {
                    MessageBox.Show("You bought da item" + itemBeingBought.Name);
                }
                //else
                {
                    MessageBox.Show("You do not have enough gold to buy the " + itemBeingBought.Name);
                }
            }
        }

        private void dgvPlayerInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // The 4th column (ColumnIndex = 3) has the "Buy 1" button.
            // Make sure the user can't buy the column names
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                // This gets the ID value of the item, from the hidden 1st column
                var itemID = dgvPlayerInventory.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Item itemBeingSold = World.FindItemByID(Convert.ToInt32(itemID));

                // Check if the player has enough gold to buy the item
                //gameSession.SellItem(itemBeingSold);

                MessageBox.Show("ADAHYDEHA");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializePlayerInventory();
            InitializeVendorInventory();
        }

        private void TradingScreen_Load(object sender, EventArgs e)
        {

        }

        private void TradingScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}