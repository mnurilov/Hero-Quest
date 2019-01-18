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
    public partial class InformationScreen : Form
    {
        GameSession gameSession;

        readonly Assembly thisAssembly = Assembly.GetExecutingAssembly();

        object informationObject;


        public InformationScreen(GameSession gameSession, object informationObject)
        {
            InitializeComponent();
            this.gameSession = gameSession;
            this.informationObject = informationObject;
            UpdateUI(informationObject);
        }


        //<-----------Update UI Functions----------->
        private void UpdateUI(object informationObject)
        {
            if(informationObject is Item)
            {
                CreateItemInformationScreen((Item)informationObject);
            }
            else if(informationObject is Equipment)
            {
                CreateEquipmentInformationScreen((Equipment)informationObject);
            }
            else if(informationObject is Spell)
            {
                CreateSpellInformationScreen((Spell)informationObject);
            }
            else if(informationObject is Inn)
            {
                CreateInnInformationScreen((Inn)informationObject);
            }
            else if(informationObject is Quest)
            {
                CreateQuestInformationScreen((Quest)informationObject);
            }
            else if(informationObject is Vendor)
            {
                CreateVendorInformationScreen((Vendor)informationObject);
            }
            else if(informationObject is Location)
            {
                CreateLocationInformationScreen((Location)informationObject);
            }
            else
            {
                throw new Exception("Trying to bring up information about an object that hasn't been added");
            }
        }

        private void CreateItemInformationScreen(Item item)
        {
            SetWindow(item.Name, 758, 388);
            SetIcon("Item");

            CreateLabel(item.Name, false, new Point(37, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(item.Name, new Point(143, 100), new Size(125, 125));
            CreateLabel(item.Description, false, new Point(37, 257), new Size(343, 63), 11);
            CreateLabel("Info", false, new Point(380, 34), new Size(284, 43), 11, true);

            CreateIconValueCombo("Gold", "Gold:", item.SellingGoldValue.ToString(), 412, 100);

            if(item is HealthReplenishingItem)
            {
                CreateIconValueCombo("Health", "Healing Amount:", ((HealthReplenishingItem)item).HealthReplenishingValue.ToString(), 412, 140);
            }
            else if(item is ManaReplenishingItem)
            {
                CreateIconValueCombo("Mana", "Replenishing Amount:", ((ManaReplenishingItem)item).ManaReplenishingValue.ToString(), 412, 140);
            }
            else if(item is DamageItem)
            {
                CreateIconValueCombo("Damage", "Damage Amount:", ((DamageItem)item).DamageValue.ToString(), 412, 140);
            }
        }

        private void CreateEquipmentInformationScreen(Equipment equipment)
        {
            SetWindow(equipment.Name, 758, 588);
            SetIcon("Equipment");

            CreateLabel(equipment.Name, false, new Point(37, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(equipment.Name, new Point(143, 100), new Size(125, 125));
            CreateLabel(equipment.Description, false, new Point(37, 257), new Size(343, 63), 11);
            CreateLabel("Info", false, new Point(380, 34), new Size(284, 43), 11, true);

            CreateIconValueCombo("Gold", "Gold:", equipment.SellingGoldValue.ToString(), 412, 100);

            int x = 412;
            int y = 140;

            if(equipment.HealthBonus != 0)
            {
                CreateIconValueCombo("Health", "Health Bonus:", equipment.HealthBonus.ToString(), x, y);
                y += 40;
            }
            if(equipment.ManaBonus != 0)
            {
                CreateIconValueCombo("Mana", "Mana Bonus:", equipment.ManaBonus.ToString(), x, y);
                y += 40;
            }
            if(equipment.StrengthBonus != 0)
            {
                CreateIconValueCombo("Strength", "Strength Bonus:", equipment.StrengthBonus.ToString(), x, y);
                y += 40;
            }
            if (equipment.DefenseBonus != 0)
            {
                CreateIconValueCombo("Defense", "Defense Bonus:", equipment.DefenseBonus.ToString(), x, y);
                y += 40;
            }
            if (equipment.LuckBonus != 0)
            {
                CreateIconValueCombo("Luck", "Luck Bonus:", equipment.LuckBonus.ToString(), x, y);
                y += 40;
            }
            if (equipment.SpeedBonus != 0)
            {
                CreateIconValueCombo("Speed", "Speed Bonus:", equipment.SpeedBonus.ToString(), x, y);
                y += 40;
            }
            if (equipment.IntellectBonus != 0)
            {
                CreateIconValueCombo("Intellect", "Intellect Bonus:", equipment.IntellectBonus.ToString(), x, y);
                y += 40;
            }
            if (equipment.ResistanceBonus != 0)
            {
                CreateIconValueCombo("Resistance", "Resistance Bonus:", equipment.ResistanceBonus.ToString(), x, y);
                y += 40;
            }
        }

        private void CreateSpellInformationScreen(Spell spell)
        {
            SetWindow(spell.Name, 758, 388);
            SetIcon("Spell");

            CreateLabel(spell.Name, false, new Point(37, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(spell.Name, new Point(143, 100), new Size(125, 125));
            CreateLabel(spell.Description, false, new Point(37, 257), new Size(343, 63), 11);
            CreateLabel("Info", false, new Point(380, 34), new Size(284, 43), 11, true);

            CreateIconValueCombo("Gold", "Gold:", spell.SellingGoldValue.ToString(), 412, 100);

            if(spell is DamageSpell)
            {
                CreateIconValueCombo("Damage", "Base Damage:", ((DamageSpell)spell).DamageValue.ToString(), 412, 140);
            }
            else if(spell is ReplenishSpell)
            {
                CreateIconValueCombo("Healing", "Base Heal:", ((ReplenishSpell)spell).ReplenishValue.ToString(), 412, 140);
            }
        }

        private void CreateInnInformationScreen(Inn inn)
        {
            SetWindow(inn.Name, 708, 388);
            SetIcon("Inn");

            CreateLabel(inn.Name, false, new Point(37, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(inn.Name, new Point(143, 100), new Size(125, 125));
            CreateLabel(inn.Description, false, new Point(37, 257), new Size(343, 63), 11);
            CreateLabel("Info", false, new Point(380, 34), new Size(284, 43), 11, true);

            CreateIconValueCombo("Gold", "Gold to stay a night:", inn.GoldCost.ToString(), 412, 100);
        }

        private void CreateQuestInformationScreen(Quest quest)
        {
            SetWindow(quest.Name, 758, 588);
            SetIcon("Quest");

            CreateLabel(quest.Name, false, new Point(37, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(quest.Name, new Point(143, 100), new Size(125, 125));
            CreateLabel(quest.Description, false, new Point(37, 257), new Size(343, 63), 11);
            CreateLabel("Quest Rewards", false, new Point(380, 34), new Size(284, 43), 11, true);

            int x = 412;
            int y = 100;

            if(quest.RewardGold != 0)
            {
                CreateIconValueCombo("Gold", "Gold Reward:", quest.RewardGold.ToString(), x, y);
                y += 40;
            }
            if(quest.RewardExperience != 0)
            {
                CreateIconValueCombo("Experience", "Experience Reward:", quest.RewardExperience.ToString(), x, y);
                y += 40;
            }
            if(quest.RewardItem != null)
            {
                CreateIconValueCombo("Item", "Item Reward:", quest.RewardItem.Name, x, y);
                y += 40;
            }
            if(quest.RewardEquipment != null)
            {
                CreateIconValueCombo("Equipment", "Equipment Reward:", quest.RewardEquipment.Name, x, y);
                y += 40;
            }
            if(quest.RewardSpell != null)
            {
                CreateIconValueCombo("Spell", "Spell Reward:", quest.RewardSpell.Name, x, y);
                y += 40;
            }

            if (!gameSession.CurrentPlayer.PlayerQuests.Contains(quest))
            {
                return;
            }
            if (!quest.IsCompleted)
            {
                CreateLabel("Progress", false, new Point(237, 320), new Size(284, 43), 11, true);

                if (quest is TravelQuest)
                {
                    int xpos = 237;
                    int ypos = 377;

                    string locationInfo;

                    if (((TravelQuest)quest).HasVisitedLocation)
                    {
                        locationInfo = "You have already visited " + ((TravelQuest)quest).RequiredLocation.Name;
                    }
                    else
                    {
                        locationInfo = "You have not yet traveled to " + ((TravelQuest)quest).RequiredLocation.Name;
                    }

                    CreateLabel(locationInfo, false, new Point(xpos, ypos), new Size(284, 43));
                }
                else if (quest is GatherQuest)
                {
                    int xpos = 237;
                    int ypos = 377;

                    foreach (KeyValuePair<Item, int> lootRequirement in ((GatherQuest)quest).RequiredItems)
                    {
                        string itemInfo;

                        if (gameSession.CurrentPlayer.PlayerItems.ContainsKey(lootRequirement.Key))
                        {
                            if (gameSession.CurrentPlayer.PlayerItems[lootRequirement.Key] <= lootRequirement.Value)
                            {
                                itemInfo = gameSession.CurrentPlayer.PlayerItems[lootRequirement.Key] + "/" + lootRequirement.Value;
                            }
                            else
                            {
                                itemInfo = lootRequirement.Value + "/" + lootRequirement.Value;
                            }
                        }
                        else
                        {
                            itemInfo = "0" + "/" + lootRequirement.Value;
                        }

                        CreateIconValueCombo(lootRequirement.Key.Name, lootRequirement.Key.Name + ":", itemInfo, xpos, ypos);
                        ypos += 40;
                    }
                }
                else if (quest is KillQuest)
                {
                    int xpos = 237;
                    int ypos = 377;

                    foreach (KeyValuePair<Enemy, int> enemyRequirement in ((KillQuest)quest).RequiredEnemies)
                    {
                        string enemyInfo;

                        if (((KillQuest)quest).EnemiesDefeatedSoFar.ContainsKey(enemyRequirement.Key))
                        {
                            if (((KillQuest)quest).EnemiesDefeatedSoFar[enemyRequirement.Key] <= enemyRequirement.Value)
                            {
                                enemyInfo = ((KillQuest)quest).EnemiesDefeatedSoFar[enemyRequirement.Key] + "/" + enemyRequirement.Value;
                            }
                            else
                            {
                                enemyInfo = enemyRequirement.Value + "/" + enemyRequirement.Value;
                            }
                        }
                        else
                        {
                            enemyInfo = "0" + "/" + enemyRequirement.Value;
                        }

                        CreateIconValueCombo(enemyRequirement.Key.Name, enemyRequirement.Key.Name + ":", enemyInfo, xpos, ypos);
                        ypos += 40;
                    }
                }
            }
            else
            {
                CreateLabel("You have completed this quest", false, new Point(237, 377), new Size(284, 43));
            }
        }

        private void CreateVendorInformationScreen(Vendor vendor)
        {
            SetWindow(vendor.Name, 758, 388);
            SetIcon("Shop");

            CreateLabel(vendor.Name, false, new Point(37, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(vendor.Name, new Point(143, 100), new Size(125, 125));
            CreateLabel(vendor.Description, false, new Point(37, 257), new Size(343, 63), 11);
            CreateLabel(vendor.Name + "'s Inventory", false, new Point(380, 34), new Size(284, 43), 11, true);

            CreateDataGridView(vendor, new Point(400, 100));
        }

        private void CreateLocationInformationScreen(Location location)
        {
            SetWindow(location.Name, 1254, 768);
            SetIcon("Location");

            CreateLabel(location.Name, false, new Point(445, 28), new Size(343, 39), 14, false, true);
            CreatePictureBox(location.Name, new Point(551, 100), new Size(125, 125));
            CreateLabel(location.Description, false, new Point(445, 257), new Size(343, 63), 11);

            CreateLabel("Locational Commodities", false, new Point(445, 330), new Size(343, 35), 12, true);

            if (location.InnInLocation != null)
            {
                int innPositionX = 37;
                int innPositionY = 417;

                CreateLabel("Inn", false, new Point(innPositionX, innPositionY - 35), new Size(343, 39), 11, true);

                CreateLabel(location.InnInLocation.Name, false, new Point(innPositionX, innPositionY), new Size(343, 39), 14, false, true);
                
                PictureBox pbInn = CreatePictureBox(location.InnInLocation.Name, new Point(innPositionX + 106, innPositionY + 72), 
                    new Size(125, 125), true);
                pbInn.Click += OpenInnInformationalScreen;
                Controls.Add(pbInn);

                CreateLabel(location.InnInLocation.Description, false, new Point(innPositionX, innPositionY + 229), new Size(343, 63), 11);
            }
            if(location.VendorInLocation != null)
            {
                int vendorPositionX = 445;
                int vendorPositionY = 417;

                CreateLabel("Vendor", false, new Point(vendorPositionX, vendorPositionY - 35), new Size(343, 39), 11, true);

                CreateLabel(location.VendorInLocation.Name, false, new Point(vendorPositionX, vendorPositionY), new Size(343, 39), 14, false, true);

                PictureBox pbVendor = CreatePictureBox(location.VendorInLocation.Name, new Point(vendorPositionX + 106, vendorPositionY + 72),
                    new Size(125, 125), true);
                pbVendor.Click += OpenVendorInformationalScreen;
                Controls.Add(pbVendor);
                
                CreateLabel(location.VendorInLocation.Description, false, new Point(vendorPositionX, vendorPositionY + 229), new Size(343, 63), 11);
            }
            if(location.QuestInLocation != null)
            {
                int questPositionX = 853;
                int questPositionY = 417;

                CreateLabel("Quest", false, new Point(questPositionX, questPositionY - 35), new Size(343, 39), 11, true);

                CreateLabel(location.QuestInLocation.Name, false, new Point(questPositionX, questPositionY), new Size(343, 39), 14, false, true);

                PictureBox pbQuest = CreatePictureBox(location.QuestInLocation.Name, new Point(questPositionX + 106, questPositionY + 72),
                    new Size(125, 125), true);
                pbQuest.Click += OpenQuestInformationalScreen;
                Controls.Add(pbQuest);

                CreateLabel(location.QuestInLocation.Description, false, new Point(questPositionX, questPositionY + 229), new Size(343, 63), 11);
            }
        }


        //<----------Vendor DGV Update Functions----------->
        private void SetUpDGVVendorItems(DataGridView dgv, Vendor vendor)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgv.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity",
                HeaderText = "Qty",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGold",
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            int rowIndex = 0;

            foreach (KeyValuePair<Item, int> item in vendor.VendorItemInventory)
            {
                if (!CheckIfInDGV(item.Key.ID, dgv))
                {
                    dgv.Rows.Add(item.Key.ID, null, item.Key.Name, item.Value + "x", item.Key.GoldValue);

                    SetDGVImage((DataGridViewImageCell)dgv.Rows[rowIndex].Cells[1], item.Key.Name);

                    rowIndex++;
                }
            }

            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
        }

        private void SetUpDGVVendorEquipment(DataGridView dgv, Vendor vendor)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgv.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGold",
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            int rowIndex = 0;

            foreach (Equipment equipment in vendor.VendorEquipmentInventory)
            {
                dgv.Rows.Add(equipment.ID, null, equipment.Name, equipment.GoldValue);

                SetDGVImage((DataGridViewImageCell)dgv.Rows[rowIndex].Cells[1], equipment.Name);

                rowIndex++;
            }

            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
        }

        private void SetUpDGVVendorSpells(DataGridView dgv, Vendor vendor)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Regular);

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                Resizable = DataGridViewTriState.False,
                Visible = false,
                ReadOnly = true,
            });

            dgv.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "",
                Resizable = DataGridViewTriState.False,
                Visible = true,
                ReadOnly = true,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 25,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Name",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGold",
                HeaderText = "Gold Value",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                ReadOnly = true,
                Width = 45,
            });

            int rowIndex = 0;

            foreach (Spell spell in vendor.VendorSpellInventory)
            {
                dgv.Rows.Add(spell.ID, null, spell.Name, spell.GoldValue);

                SetDGVImage((DataGridViewImageCell)dgv.Rows[rowIndex].Cells[1], spell.Name);

                rowIndex++;
            }

            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
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


        //<------------Click Events------------>
        private void OpenInnInformationalScreen(object sender, EventArgs e)
        {
            InformationScreen informationScreen = new InformationScreen(gameSession, ((Location)informationObject).InnInLocation);
            informationScreen.StartPosition = FormStartPosition.CenterParent;
            informationScreen.ShowDialog(this);
        }

        private void OpenVendorInformationalScreen(object sender, EventArgs e)
        {
            InformationScreen informationScreen = new InformationScreen(gameSession, ((Location)informationObject).VendorInLocation);
            informationScreen.StartPosition = FormStartPosition.CenterParent;
            informationScreen.ShowDialog(this);
        }

        private void OpenQuestInformationalScreen(object sender, EventArgs e)
        {
            InformationScreen informationScreen = new InformationScreen(gameSession, ((Location)informationObject).QuestInLocation);
            informationScreen.StartPosition = FormStartPosition.CenterParent;
            informationScreen.ShowDialog(this);
        }


        //<------------Creation Functions-------------->
        private PictureBox CreatePictureBox(string imageName, Point point, Size size, bool dontAdd = false)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = size;
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage(pictureBox, imageName);
            pictureBox.Location = point;

            if (!dontAdd)
            {
                Controls.Add(pictureBox);
            }

            return pictureBox;
        }

        private Label CreateLabel(string labelText, bool autoSize, Point point, Size size, int fontSize = 0, bool underLine = false, bool bold = false)
        {
            Label label = new Label();
            label.Text = labelText;
            if(fontSize == 0)
            {
                if (underLine)
                {
                    label.Font = new Font("Century Gothic", 10, FontStyle.Underline);
                }
                else if (bold)
                {
                    label.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                }
                else
                {
                    label.Font = new Font("Century Gothic", 10, FontStyle.Regular);
                }
            }
            else
            {
                if (underLine)
                {
                    label.Font = new Font("Century Gothic", fontSize, FontStyle.Underline);
                }
                else if (bold)
                {
                    label.Font = new Font("Century Gothic", fontSize, FontStyle.Bold);
                }
                else
                {
                    label.Font = new Font("Century Gothic", fontSize, FontStyle.Regular);
                }
            }
            label.AutoSize = autoSize;
            label.Location = point;
            if (!autoSize)
            {
                label.Size = size;
                label.TextAlign = ContentAlignment.MiddleCenter;
            }

            Controls.Add(label);

            return label;
        }

        private DataGridView CreateDataGridView(Vendor vendor, Point point)
        {
            DataGridView dgv = new DataGridView();

            dgv.ColumnHeadersVisible = true;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Location = point;
            dgv.Height = 200;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            if(vendor.VendorItemInventory != null)
            {
                SetUpDGVVendorItems(dgv, vendor);
            }
            if(vendor.VendorEquipmentInventory != null)
            {
                SetUpDGVVendorEquipment(dgv, vendor);
            }
            if(vendor.VendorSpellInventory != null)
            {
                SetUpDGVVendorSpells(dgv, vendor);
            }

            Controls.Add(dgv);

            return dgv;
        }

        private void CreateIconValueCombo(string iconName, string labelName, string value, int x, int y)
        {
            PictureBox pbIconImage = CreatePictureBox(iconName, new Point(x, y), new Size(25, 25));
            Label lblLabelName = CreateLabel(labelName, true, new Point(x + 42, y + 2), new Size(0, 0));
            Label lblValue = CreateLabel(value, true, new Point(x + 205, y + 2), new Size(0, 0));

            Controls.Add(pbIconImage);
            Controls.Add(lblLabelName);
            Controls.Add(lblValue);
        }


        //<------------Setting Functions--------------->
        private void SetWindow(string title, int width, int height)
        {
            Text = title;
            Width = width;
            Height = height;
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

        private void SetIcon(string imageName)
        {
            if (imageName == null)
            {
                return;
            }

            using (Stream resourceStream =
                thisAssembly.GetManifestResourceStream(
                    thisAssembly.GetName().Name + ".Images." + imageName + ".ico"))

            {
                if (resourceStream != null)
                {
                    Icon = new Icon(resourceStream);
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
