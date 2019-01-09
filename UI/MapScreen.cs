﻿using Engine;
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
            UpdateMap();
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
            SetImage(pb_n2_2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 2)?.Name);
            SetImage(pb_n1_2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 2)?.Name);
            SetImage(pb_0_2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 2)?.Name);
            SetImage(pb_1_2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 2)?.Name);
            SetImage(pb_2_2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 2)?.Name);

            //Top Middle Row
            SetImage(pb_n2_1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate + 1)?.Name);
            SetImage(pb_n1_1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate + 1)?.Name);
            SetImage(pb_0_1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate + 1)?.Name);
            SetImage(pb_1_1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate + 1)?.Name);
            SetImage(pb_2_1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate + 1)?.Name);

            //Middle Row
            SetImage(pb_n2_0, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate)?.Name);
            SetImage(pb_n1_0, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate)?.Name);
            SetImage(pb_0_0, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate)?.Name);
            SetImage(pb_1_0, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate)?.Name);
            SetImage(pb_2_0, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate)?.Name);

            //Bottom Middle Row
            SetImage(pb_n2_n1, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 1)?.Name);
            SetImage(pb_n1_n1, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 1)?.Name);
            SetImage(pb_0_n1, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 1)?.Name);
            SetImage(pb_1_n1, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 1)?.Name);
            SetImage(pb_2_n1, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 1)?.Name);

            //Bottom Row
            SetImage(pb_n2_n2, World.FindLocationByCoordinate(centerXCoordinate - 2, centerYCoordinate - 2)?.Name);
            SetImage(pb_n1_n2, World.FindLocationByCoordinate(centerXCoordinate - 1, centerYCoordinate - 2)?.Name);
            SetImage(pb_0_n2, World.FindLocationByCoordinate(centerXCoordinate, centerYCoordinate - 2)?.Name);
            SetImage(pb_1_n2, World.FindLocationByCoordinate(centerXCoordinate + 1, centerYCoordinate - 2)?.Name);
            SetImage(pb_2_n2, World.FindLocationByCoordinate(centerXCoordinate + 2, centerYCoordinate - 2)?.Name);
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

        private void SetImage(PictureBox pictureBox, string imageName)
        {
            if(imageName == null)
            {
                pictureBox.Image = null;
                return;
            }

            if (World.FindLocationByName(imageName).HasVisited == false)
            {
                using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images." + "Fog" + ".png"))

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
                    thisAssembly.GetName().Name + ".Images." + imageName + ".png"))

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
    }
}