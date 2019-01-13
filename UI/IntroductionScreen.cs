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
    public partial class IntroductionScreen : Form
    {
        public IntroductionScreen()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Hide();
            CharacterCreationScreen characterCreationScreen = new CharacterCreationScreen();
            characterCreationScreen.StartPosition = FormStartPosition.CenterParent;
            characterCreationScreen.ShowDialog(this);
            Close();
        }
    }
}
