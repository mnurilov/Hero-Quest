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
    public partial class PersonScreen : Form
    {
        GameSession gameSession;

        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();


        public PersonScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            UpdatePersonScreen();
        }

        public void UpdatePersonScreen()
        {
            Text = gameSession.CurrentPlayer.CurrentLocation.PersonInLocation.Name;
            lblPersonName.Text = gameSession.CurrentPlayer.CurrentLocation.PersonInLocation.Name;
            SetImage(pbPerson, gameSession.CurrentPlayer.CurrentLocation.PersonInLocation.Name);
            lblPersonStatement.Text = gameSession.CurrentPlayer.CurrentLocation.PersonInLocation.Statement;
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
    }
}
