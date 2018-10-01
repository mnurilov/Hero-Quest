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
    public partial class Form1 : Form
    {
        public Player bob = new Player(1, "Bob", Player.Class.Thief);

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHitPoints.Text = bob.CurrentHealth.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            bob.MoveNorth();
            rtbLocation.Text = bob.CurrentLocation.ToString();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            bob.MoveSouth();
            rtbLocation.Text = bob.CurrentLocation.ToString();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            bob.MoveWest();
            rtbLocation.Text = bob.CurrentLocation.ToString();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            bob.MoveEast();
            rtbLocation.Text = bob.CurrentLocation.ToString();
        }


    }
}
