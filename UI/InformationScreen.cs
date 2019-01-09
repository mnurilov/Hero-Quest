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
    public partial class InformationScreen : Form
    {
        GameSession gameSession;

        public InformationScreen(GameSession gameSession, object informationObject)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            UpdateUI(informationObject);
            Label label = new Label();
            label.Text = "What the fuck";
            label.Name = "Sexy Boi";
            label.Visible = true;
            this.Controls.Add(label);
            this.Width = 50;
        }


        //<-----------Update UI Functions----------->
        private void UpdateUI(object informationObject)
        {
            if(informationObject is Item)
            {

            }
        }

        private void UpdateItemUI(Item item)
        {
            Label label = new Label();
            label.Text = "What the fuck";
            label.Name = "Sexy Boi";
            label.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
