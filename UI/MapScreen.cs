using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI
{
    public partial class MapScreen : Form
    {
        GameSession gameSession;

        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();

        int centerXCoordinate { get; set; }
        int centerYCoordinate { get; set; }

        public MapScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            centerXCoordinate = gameSession.CurrentPlayer.CurrentLocation.XCoordinate;
            centerYCoordinate = gameSession.CurrentPlayer.CurrentLocation.YCoordinate;
            UpdateMap();
        }


        //<-----------Update UI Functions----------->
        private void UpdateMap()
        {
            UpdatePictureBoxes();
        }
            
        private void UpdatePictureBoxes()
        {
            SetImage(pb_n2_2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2)?.Name);
            SetImage(pb_n1_2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2)?.Name);
            SetImage(pb_0_2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2)?.Name);
            SetImage(pb_1_2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2)?.Name);
            SetImage(pb_2_2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 2)?.Name);

            SetImage(pb_n2_1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1)?.Name);
            SetImage(pb_n1_1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1)?.Name);
            SetImage(pb_0_1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1)?.Name);
            SetImage(pb_1_1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1)?.Name);
            SetImage(pb_2_1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 1)?.Name);

            SetImage(pb_n2_0, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate)?.Name);
            SetImage(pb_n1_0, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate)?.Name);
            SetImage(pb_0_0, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate)?.Name);
            SetImage(pb_1_0, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate)?.Name);
            SetImage(pb_2_0, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate)?.Name);

            SetImage(pb_n2_n1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1)?.Name);
            SetImage(pb_n1_n1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1)?.Name);
            SetImage(pb_0_n1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1)?.Name);
            SetImage(pb_1_n1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1)?.Name);
            SetImage(pb_2_n1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 1)?.Name);

            SetImage(pb_n2_n2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 2)?.Name);
            SetImage(pb_n1_n2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 2)?.Name);
            SetImage(pb_0_n2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 2)?.Name);
            SetImage(pb_1_n2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 2)?.Name);
            SetImage(pb_2_n2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 2)?.Name);
        }

        private void SetImage(PictureBox pictureBox, string imageName)
        {
            if(imageName == null)
            {
                pictureBox.Image = null;
                return;
            }
            using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images." + imageName + ".png"))

            {
                if(resourceStream != null)
                {
                    pictureBox.Image = new Bitmap(resourceStream);
                }
            }
        }


        //<----------Move Map Buttons----------->
        private void pbMapMoveUp_Click(object sender, EventArgs e)
        {
            centerYCoordinate = centerYCoordinate + 1;
            UpdateMap();
        }

        private void pbMoveMapDown_Click(object sender, EventArgs e)
        {
            centerYCoordinate = centerYCoordinate - 1;
            UpdateMap();
        }

        private void pbMoveMapLeft_Click(object sender, EventArgs e)
        {
            centerXCoordinate = centerXCoordinate - 1;
            UpdateMap();
        }

        private void pbMoveMapRight_Click(object sender, EventArgs e)
        {
            centerXCoordinate = centerXCoordinate + 1;
            UpdateMap();
        }
    }
}
