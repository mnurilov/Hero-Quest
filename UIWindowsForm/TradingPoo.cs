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
    public partial class TradingPoo : Form
    {
        GameSession gameSession;

        public TradingPoo(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            dgvVendor.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID" });
            dgvVendor.Columns.Add(new DataGridViewTextBoxColumn{ Name = "colName", HeaderText = "Name"});
            dgvVendor.Columns.Add(new DataGridViewTextBoxColumn{ Name = "colQuantity", HeaderText = "Quantity"});
            dgvVendor.Columns.Add(new DataGridViewButtonColumn{ Name = "btnBuy", HeaderText = "Buy 1", });
            dgvVendor.CellClick += dgvVendor_CellClick;

            UpdateVendor();
        }

        private void dgvVendor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // The 4th column (ColumnIndex = 3) has the "Buy 1" button.
            if (e.ColumnIndex == 3)
            {
                // This gets the ID value of the item, from the hidden 1st column
                var itemID = dgvVendor.Rows[e.RowIndex].Cells[0].Value;

                // Get the Item object for the selected item row
                Item itemBeingBought = World.FindItemByID(Convert.ToInt32(itemID));

                // Check if the player has enough gold to buy the item
                if (gameSession.CurrentPlayer.BuyItem(itemBeingBought))
                {
                    MessageBox.Show("You bought da item" + itemBeingBought.Name);
                }
                else
                {
                    MessageBox.Show("You do not have enough gold to buy the " + itemBeingBought.Name);
                }

            }
        }

        private void UpdateVendor()
        {
            dgvVendor.Rows.Clear();
            foreach (KeyValuePair<Item, int> kvp in gameSession.CurrentPlayer.CurrentLocation.VendorInLocation.VendorItemInventory)
            {
                if (!CheckIfInDGV(kvp.Key.ID))
                {
                    dgvVendor.Rows.Add(kvp.Key.ID, kvp.Key.Name, kvp.Value);
                }
            }
        }

        private bool CheckIfInDGV(int ID)
        {
            foreach (DataGridViewRow row in dgvVendor.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == ID.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void TradingScreen_Load(object sender, EventArgs e)
        {
        }

        private void TradingScreen_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Leaving Shop");
            gameSession.ExitShop();
        }
    }
}
