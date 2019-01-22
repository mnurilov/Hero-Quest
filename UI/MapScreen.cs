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

        private enum Direction { North, South, West, East }


        public MapScreen(GameSession gameSession)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            centerXCoordinate = gameSession.CurrentPlayer.CurrentLocation.XCoordinate;
            centerYCoordinate = gameSession.CurrentPlayer.CurrentLocation.YCoordinate;
            LinkMapsWithEvent();
            UpdateMap();
        }


        private void LinkMapsWithEvent()
        {
            pb_n2_n2.Click += Map_Click;
            pb_n2_n1.Click += Map_Click;
            pb_n2_0.Click += Map_Click;
            pb_n2_1.Click += Map_Click;
            pb_n2_2.Click += Map_Click;

            pb_n1_n2.Click += Map_Click;
            pb_n1_n1.Click += Map_Click;
            pb_n1_0.Click += Map_Click;
            pb_n1_1.Click += Map_Click;
            pb_n1_2.Click += Map_Click;

            pb_0_n2.Click += Map_Click;
            pb_0_n1.Click += Map_Click;
            pb_0_0.Click += Map_Click;
            pb_0_1.Click += Map_Click;
            pb_0_2.Click += Map_Click;

            pb_1_n2.Click += Map_Click;
            pb_1_n1.Click += Map_Click;
            pb_1_0.Click += Map_Click;
            pb_1_1.Click += Map_Click;
            pb_1_2.Click += Map_Click;

            pb_2_n2.Click += Map_Click;
            pb_2_n1.Click += Map_Click;
            pb_2_0.Click += Map_Click;
            pb_2_1.Click += Map_Click;
            pb_2_2.Click += Map_Click;
        }

        //<-----------Update UI Functions----------->
        private void UpdateMap()
        {
            UpdatePictureBoxes();
            UpdateMapConnections();
        }
            
        private void UpdatePictureBoxes()
        {
            //Top Row
            SetImage(pb_n2_2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2));
            SetImage(pb_n1_2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2));
            SetImage(pb_0_2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2));
            SetImage(pb_1_2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2));
            SetImage(pb_2_2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 2));

            //Top Middle Row
            SetImage(pb_n2_1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1));
            SetImage(pb_n1_1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1));
            SetImage(pb_0_1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1));
            SetImage(pb_1_1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1));
            SetImage(pb_2_1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 1));

            //Middle Row
            SetImage(pb_n2_0, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate));
            SetImage(pb_n1_0, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate));
            SetImage(pb_0_0, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate));
            SetImage(pb_1_0, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate));
            SetImage(pb_2_0, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate));

            //Bottom Middle Row
            SetImage(pb_n2_n1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1));
            SetImage(pb_n1_n1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1));
            SetImage(pb_0_n1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1));
            SetImage(pb_1_n1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1));
            SetImage(pb_2_n1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 1));

            //Bottom Row
            SetImage(pb_n2_n2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 2));
            SetImage(pb_n1_n2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 2));
            SetImage(pb_0_n2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 2));
            SetImage(pb_1_n2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 2));
            SetImage(pb_2_n2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 2));
        }

        private void UpdateMapConnections()
        {
            //First Column
            SetMapConnection(pnl_n2_2__n1_2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2), Direction.East);
            SetMapConnection(pnl_n2_1__n1_1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1), Direction.East);
            SetMapConnection(pnl_n2_0__n1_0, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate), Direction.East);
            SetMapConnection(pnl_n2_n1__n1_n1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1), Direction.East);
            SetMapConnection(pnl_n2_n2__n1_n2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 2), Direction.East);

            //Second Column
            SetMapConnection(pnl_n1_2__0_2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2), Direction.East);
            SetMapConnection(pnl_n1_1__0_1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1), Direction.East);
            SetMapConnection(pnl_n1_0__0_0, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate), Direction.East);
            SetMapConnection(pnl_n1_n1__0_n1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1), Direction.East);
            SetMapConnection(pnl_n1_n2__0_n2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 2), Direction.East);

            //Third Column
            SetMapConnection(pnl_0_2__1_2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2), Direction.East);
            SetMapConnection(pnl_0_1__1_1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1), Direction.East);
            SetMapConnection(pnl_0_0__1_0, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate), Direction.East);
            SetMapConnection(pnl_0_n1__1_n1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1), Direction.East);
            SetMapConnection(pnl_0_n2__1_n2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 2), Direction.East);

            //Fourth Column
            SetMapConnection(pnl_1_2__2_2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2), Direction.East);
            SetMapConnection(pnl_1_1__2_1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1), Direction.East);
            SetMapConnection(pnl_1_0__2_0, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate), Direction.East);
            SetMapConnection(pnl_1_n1__2_n1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1), Direction.East);
            SetMapConnection(pnl_1_n2__2_n2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 2), Direction.East);

            //First Row
            SetMapConnection(pnl_n2_2__n2_1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2), Direction.South);
            SetMapConnection(pnl_n1_2__n1_1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2), Direction.South);
            SetMapConnection(pnl_0_2__0_1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2), Direction.South);
            SetMapConnection(pnl_1_2__1_1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2), Direction.South);
            SetMapConnection(pnl_2_2__2_1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 2), Direction.South);

            //Second Row
            SetMapConnection(pnl_n2_1__n2_0, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1), Direction.South);
            SetMapConnection(pnl_n1_1__n1_0, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1), Direction.South);
            SetMapConnection(pnl_0_1__0_0, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1), Direction.South);
            SetMapConnection(pnl_1_1__1_0, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1), Direction.South);
            SetMapConnection(pnl_2_1__2_0, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 1), Direction.South);

            //Third Row
            SetMapConnection(pnl_n2_0__n2_n1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate), Direction.South);
            SetMapConnection(pnl_n1_0__n1_n1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate), Direction.South);
            SetMapConnection(pnl_0_0__0_n1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate), Direction.South);
            SetMapConnection(pnl_1_0__1_n1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate), Direction.South);
            SetMapConnection(pnl_2_0__2_n1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate), Direction.South);

            //Fourth Row
            SetMapConnection(pnl_n2_n1__n2_n2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1), Direction.South);
            SetMapConnection(pnl_n1_n1__n1_n2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1), Direction.South);
            SetMapConnection(pnl_0_n1__0_n2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1), Direction.South);
            SetMapConnection(pnl_1_n1__1_n2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1), Direction.South);
            SetMapConnection(pnl_2_n1__2_n2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 1), Direction.South);
        }

        private void SetMapConnection(Panel panel, Location location, Direction direction)
        {
            if(location == null)
            {
                panel.Visible = false;
                return;
            }

            switch (direction)
            {
                case Direction.North:
                    if (location.HasVisited == false && location.LocationToTheNorth?.HasVisited == false)
                    {
                        panel.Visible = false;
                        return;
                    }
                    break;
                case Direction.South:
                    if (location.HasVisited == false && location.LocationToTheSouth?.HasVisited == false)
                    {
                        panel.Visible = false;
                        return;
                    }
                    break;
                case Direction.West:
                    if (location.HasVisited == false && location.LocationToTheWest?.HasVisited == false)
                    {
                        panel.Visible = false;
                        return;
                    }
                    break;
                case Direction.East:
                    if (location.HasVisited == false && location.LocationToTheEast?.HasVisited == false)
                    {
                        panel.Visible = false;
                        return;
                    }
                    break;
            }
            
            switch (direction)
            {
                case Direction.North:
                    if(location.LocationToTheNorth != null)
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                    break;
                case Direction.South:
                    if (location.LocationToTheSouth != null)
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                    break;
                case Direction.West:
                    if (location.LocationToTheWest != null)
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                    break;
                case Direction.East:
                    if (location.LocationToTheEast != null)
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                    break;
            }
        }

        private void SetImage(PictureBox pictureBox, Location location)
        {
            if(location == null)
            {
                pictureBox.Image = null;
                return;
            }

            if (location.HasVisited == false)
            {
                using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images.Locations." + "Fog" + ".png"))

                {
                    if (resourceStream != null)
                    {
                        pictureBox.Image = new Bitmap(resourceStream);
                    }
                }
                return;
            }
            using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images.Locations." + "(" + location.ID + ") " + location.Name + ".png"))

            {
                if(resourceStream != null)
                {
                    pictureBox.Image = new Bitmap(resourceStream);
                }
            }
        }


        //<----------Move Map Buttons----------->
        private void pbMoveMapUp_Click(object sender, EventArgs e)
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



        //<------------Map Events------------->
        private void Map_Click(object sender, EventArgs e)
        {
            if(((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                Map_RightClick(sender, e);
                return;
            }

            Location location;

            if (sender == pb_n2_n2) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 2);
            else if (sender == pb_n2_n1) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1);
            else if (sender == pb_n2_0) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate);
            else if (sender == pb_n2_1) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1);
            else if (sender == pb_n2_2) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2);

            else if (sender == pb_n1_n2) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 2);
            else if (sender == pb_n1_n1) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1);
            else if (sender == pb_n1_0) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate);
            else if (sender == pb_n1_1) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1);
            else if (sender == pb_n1_2) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2);

            else if (sender == pb_0_n2) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 2);
            else if (sender == pb_0_n1) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1);
            else if (sender == pb_0_0) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate);
            else if (sender == pb_0_1) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1);
            else if (sender == pb_0_2) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2);

            else if (sender == pb_1_n2) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 2);
            else if (sender == pb_1_n1) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1);
            else if (sender == pb_1_0) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate);
            else if (sender == pb_1_1) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1);
            else if (sender == pb_1_2) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2);

            else if (sender == pb_2_n2) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 2);
            else if (sender == pb_2_n1) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 1);
            else if (sender == pb_2_0) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate);
            else if (sender == pb_2_1) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 1);
            else if (sender == pb_2_2) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 2);

            else location = null;

            UpdateMap();
            OpenInformationScreen(location);
        }

        private void Map_RightClick(object sender, EventArgs e)
        {
            Location location;

            if (sender == pb_n2_n2) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 2);
            else if (sender == pb_n2_n1) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1);
            else if (sender == pb_n2_0) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate);
            else if (sender == pb_n2_1) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1);
            else if (sender == pb_n2_2) location = World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2);

            else if (sender == pb_n1_n2) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 2);
            else if (sender == pb_n1_n1) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1);
            else if (sender == pb_n1_0) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate);
            else if (sender == pb_n1_1) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1);
            else if (sender == pb_n1_2) location = World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2);

            else if (sender == pb_0_n2) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 2);
            else if (sender == pb_0_n1) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1);
            else if (sender == pb_0_0) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate);
            else if (sender == pb_0_1) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1);
            else if (sender == pb_0_2) location = World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2);

            else if (sender == pb_1_n2) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 2);
            else if (sender == pb_1_n1) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1);
            else if (sender == pb_1_0) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate);
            else if (sender == pb_1_1) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1);
            else if (sender == pb_1_2) location = World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2);

            else if (sender == pb_2_n2) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 2);
            else if (sender == pb_2_n1) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 1);
            else if (sender == pb_2_0) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate);
            else if (sender == pb_2_1) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 1);
            else if (sender == pb_2_2) location = World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 2);

            else location = null;

            if(location != null)
            {
                location.IsAllowedToEnter = true;
                gameSession.MoveToCommand(location);
                centerXCoordinate = location.XCoordinate;
                centerYCoordinate = location.YCoordinate;
            }

            UpdateMap();
        }

        private void OpenInformationScreen(Location location)
        {
            if (location != null && location.HasVisited)
            {
                InformationScreen informationScreen = new InformationScreen(gameSession, location);
                informationScreen.StartPosition = FormStartPosition.CenterParent;
                informationScreen.ShowDialog(this);
            }
        }
    }
}
