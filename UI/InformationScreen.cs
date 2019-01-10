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


        public InformationScreen(GameSession gameSession, object informationObject)
        {
            InitializeComponent();
            this.gameSession = gameSession;
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
            SetWindow(item.Name, 400, 270);

            CreatePictureBox(item.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(item.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(item.Description, false, new Point(0, 165), new Size(300, 200));

            CreateIconValueCombo("Gold", "Gold:", item.SellingGoldValue.ToString(), 145, 30);

            if(item is HealthReplenishingItem)
            {
                CreateIconValueCombo("Health", "Healing Amount:", ((HealthReplenishingItem)item).HealthReplenishingValue.ToString(), 145, 60);
            }
            else if(item is ManaReplenishingItem)
            {
                CreateIconValueCombo("Mana", "Replenishing Amount:", ((ManaReplenishingItem)item).ManaReplenishingValue.ToString(), 145, 60);
            }
            else if(item is DamageItem)
            {
                CreateIconValueCombo("Damage", "Damage Amount:", ((DamageItem)item).DamageValue.ToString(), 145, 60);
            }
        }

        private void CreateEquipmentInformationScreen(Equipment equipment)
        {
            SetWindow(equipment.Name, 400, 320);

            CreatePictureBox(equipment.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(equipment.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(equipment.Description, false, new Point(0, 165), new Size(300, 200));

            CreateIconValueCombo("Gold", "Gold:", equipment.SellingGoldValue.ToString(), 145, 20);

            int x = 145;
            int y = 50;

            if(equipment.HealthBonus != 0)
            {
                CreateIconValueCombo("Health", "Health Bonus:", equipment.HealthBonus.ToString(), x, y);
                y += 30;
            }
            if(equipment.ManaBonus != 0)
            {
                CreateIconValueCombo("Mana", "Mana Bonus:", equipment.ManaBonus.ToString(), x, y);
                y += 30;
            }
            if(equipment.StrengthBonus != 0)
            {
                CreateIconValueCombo("Strength", "Strength Bonus:", equipment.StrengthBonus.ToString(), x, y);
                y += 30;
            }
            if (equipment.DefenseBonus != 0)
            {
                CreateIconValueCombo("Defense", "Defense Bonus:", equipment.DefenseBonus.ToString(), x, y);
                y += 30;
            }
            if (equipment.LuckBonus != 0)
            {
                CreateIconValueCombo("Luck", "Luck Bonus:", equipment.LuckBonus.ToString(), x, y);
                y += 30;
            }
            if (equipment.SpeedBonus != 0)
            {
                CreateIconValueCombo("Speed", "Speed Bonus:", equipment.SpeedBonus.ToString(), x, y);
                y += 30;
            }
            if (equipment.IntellectBonus != 0)
            {
                CreateIconValueCombo("Intellect", "Intellect Bonus:", equipment.IntellectBonus.ToString(), x, y);
                y += 30;
            }
            if (equipment.ResistanceBonus != 0)
            {
                CreateIconValueCombo("Resistance", "Resistance Bonus:", equipment.ResistanceBonus.ToString(), x, y);
                y += 30;
            }
        }

        private void CreateSpellInformationScreen(Spell spell)
        {
            SetWindow(spell.Name, 400, 320);

            CreatePictureBox(spell.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(spell.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(spell.Description, false, new Point(0, 165), new Size(300, 200));

            CreateIconValueCombo("Gold", "Gold:", spell.SellingGoldValue.ToString(), 145, 20);
            CreateIconValueCombo("Mana", "Mana Cost:", spell.ManaCost.ToString(), 145, 50);

            if(spell is DamageSpell)
            {
                CreateIconValueCombo("Damage", "Base Damage:", ((DamageSpell)spell).DamageValue.ToString(), 145, 80);
            }
            else if(spell is ReplenishSpell)
            {
                CreateIconValueCombo("Healing", "Base Heal:", ((ReplenishSpell)spell).ReplenishValue.ToString(), 145, 80);
            }
        }

        private void CreateInnInformationScreen(Inn inn)
        {
            SetWindow(inn.Name, 400, 320);

            CreatePictureBox(inn.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(inn.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(inn.Description, false, new Point(0, 165), new Size(300, 200));

            CreateIconValueCombo("Gold", "Gold Cost:", inn.GoldCost.ToString(), 145, 20);
        }

        private void CreateQuestInformationScreen(Quest quest)
        {
            SetWindow(quest.Name, 400, 500);

            CreatePictureBox(quest.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(quest.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(quest.Description, false, new Point(0, 165), new Size(100, 50));
            
            if (quest.IsCompleted)
            {
                CreateIconValueCombo("", "Quest Status:", "Completed", 145, 20);
            }
            else
            {
                CreateIconValueCombo("", "Quest Status:", "In Progress", 145, 20);
            }

            CreateLabel("Rewards", true, new Point(145, 50), new Size(0, 0));

            int x = 145;
            int y = 80;

            if(quest.RewardGold != 0)
            {
                CreateIconValueCombo("Gold", "Reward Gold:", quest.RewardGold.ToString(), x, y);
                y += 30;
            }
            if(quest.RewardExperience != 0)
            {
                CreateIconValueCombo("Experience", "Reward Experience:", quest.RewardExperience.ToString(), x, y);
                y += 30;
            }
            if(quest.RewardItem != null)
            {
                CreateIconValueCombo(quest.RewardItem.Name, "Reward Item:", quest.RewardItem.Name, x, y);
                y += 30;
            }
            if(quest.RewardEquipment != null)
            {
                CreateIconValueCombo(quest.RewardEquipment.Name, "Reward Equipment:", quest.RewardEquipment.Name, x, y);
                y += 30;
            }
            if(quest.RewardSpell != null)
            {
                CreateIconValueCombo(quest.RewardSpell.Name, "Reward Spell:", quest.RewardSpell.Name, x, y);
                y += 30;
            }

            CreateLabel("Requirements", true, new Point(0, 240), new Size(0, 0));

            if(quest is TravelQuest)
            {
                int xpos = 0;
                int ypos = 260;
                CreateLabel("Location:", true, new Point(xpos, ypos), new Size(0, 0));

                string locationInfo;

                if (((TravelQuest)quest).RequiredLocation.HasVisited)
                {
                    locationInfo = "You have visited " + ((TravelQuest)quest).RequiredLocation.Name;
                }
                else
                {
                    locationInfo = "You have not yet traveled to " + ((TravelQuest)quest).RequiredLocation.Name;
                }

                CreateLabel(locationInfo, true, new Point(xpos, ypos+ 30), new Size(0, 0));
            }
            else if(quest is GatherQuest)
            {
                int xpos = 0;
                int ypos = 260;
                CreateLabel("Items:", true, new Point(xpos, ypos), new Size(0, 0));
                ypos += 20;
                foreach (KeyValuePair<EnemyLoot, int> lootRequirement in ((GatherQuest)quest).RequiredEnemyLoots)
                {
                    string itemInfo;

                    if (gameSession.CurrentPlayer.PlayerItems.ContainsKey(lootRequirement.Key))
                    {
                        if(gameSession.CurrentPlayer.PlayerItems[lootRequirement.Key] <= lootRequirement.Value)
                        {
                            itemInfo = lootRequirement.Key.Name + ": " + gameSession.CurrentPlayer.PlayerItems[lootRequirement.Key]
                                + "/" + lootRequirement.Value;
                        }
                        else
                        {
                            itemInfo = lootRequirement.Key.Name + ": " + lootRequirement.Value
                                   + "/" + lootRequirement.Value;
                        }
                    }
                    else
                    {
                        itemInfo = lootRequirement.Key.Name + ": " + "0" + "/" + lootRequirement.Value;
                    }

                    CreateLabel(itemInfo, true, new Point(xpos, ypos), new Size(0, 0));
                    ypos += 20;
                }

            }
            else if(quest is KillQuest)
            {
                int xpos = 0;
                int ypos = 260;
                CreateLabel("Enemies:", true, new Point(xpos, ypos), new Size(0, 0));
                ypos += 20;
                foreach(KeyValuePair<Enemy, int> enemyRequirement in ((KillQuest)quest).RequiredEnemies)
                {
                    string enemyInfo;

                    if (((KillQuest)quest).EnemiesDefeatedSoFar.ContainsKey(enemyRequirement.Key))
                    {
                        if(((KillQuest)quest).EnemiesDefeatedSoFar[enemyRequirement.Key] <= enemyRequirement.Value)
                        {
                            enemyInfo = enemyRequirement.Key.Name + ": " + ((KillQuest)quest).EnemiesDefeatedSoFar[enemyRequirement.Key]
                            + "/" + enemyRequirement.Value;
                        }
                        else
                        {
                            enemyInfo = enemyRequirement.Key.Name + ": " + enemyRequirement.Value
                            + "/" + enemyRequirement.Value;
                        }
                        
                    }
                    else
                    {
                        enemyInfo = enemyRequirement.Key.Name + ": " + "0" + "/" + enemyRequirement.Value;
                    }
                    
                    CreateLabel(enemyInfo, true, new Point(xpos, ypos), new Size(0, 0));
                    ypos += 20;
                }
            }
        }

        private void CreateVendorInformationScreen(Vendor vendor)
        {
            SetWindow(vendor.Name, 400, 320);

            CreatePictureBox(vendor.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(vendor.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(vendor.Description, false, new Point(0, 165), new Size(100, 50));

            CreateDataGridView(vendor, new Point(150, 20));
        }

        private void CreateLocationInformationScreen(Location location)
        {
            SetWindow(location.Name, 600, 500);

            CreatePictureBox(location.Name, new Point(0, 20), new Size(125, 125));
            CreateLabel(location.Name, true, new Point(0, 0), new Size(0, 0));
            CreateLabel(location.Description, false, new Point(0, 160), new Size(100, 50));

            if(location.InnInLocation != null)
            {
                int innPositionX = 0;
                int innPositionY = 230;

                CreatePictureBox(location.InnInLocation.Name, new Point(innPositionX, innPositionY), new Size(125, 125));
                CreateLabel(location.InnInLocation.Name, true, new Point(innPositionX, innPositionY - 20), new Size(0, 0));
                CreateLabel(location.InnInLocation.Description, false, new Point(innPositionX, innPositionY + 140), new Size(100, 50));
            }
            if(location.VendorInLocation != null)
            {
                int vendorPositionX = 200;
                int vendorPositionY = 230;

                CreatePictureBox(location.VendorInLocation.Name, new Point(vendorPositionX, vendorPositionY), new Size(125, 125));
                CreateLabel(location.VendorInLocation.Name, true, new Point(vendorPositionX, vendorPositionY - 20), new Size(0, 0));
                CreateLabel(location.VendorInLocation.Description, false, new Point(vendorPositionX, vendorPositionY + 140), new Size(100, 50));
            }
            if(location.QuestInLocation != null)
            {
                int questPositionX = 400;
                int questPositionY = 230;

                CreatePictureBox(location.QuestInLocation.Name, new Point(questPositionX, questPositionY), new Size(125, 125));
                CreateLabel(location.QuestInLocation.Name, true, new Point(questPositionX, questPositionY - 20), new Size(0, 0));
                CreateLabel(location.QuestInLocation.Description, false, new Point(questPositionX, questPositionY + 140), new Size(100, 50));
            }
        }
        
        
        //<----------Vendor DGV Update Functions----------->
        private void SetUpDGVVendorItems(DataGridView dgv, Vendor vendor)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQuantity", HeaderText = "Quantity" });

            foreach (KeyValuePair<Item, int> item in vendor.VendorItemInventory)
            {
                if (!CheckIfInDGV(item.Key.ID, dgv))
                {
                    dgv.Rows.Add(item.Key.ID, item.Key.Name, item.Key.GoldValue, item.Value);
                }
            }
        }

        private void SetUpDGVVendorEquipment(DataGridView dgv, Vendor vendor)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });

            foreach (Equipment equipment in vendor.VendorEquipmentInventory)
            {
                if (!CheckIfInDGV(equipment.ID, dgv))
                {
                    dgv.Rows.Add(equipment.ID, equipment.Name, equipment.GoldValue);
                }
            }
        }

        private void SetUpDGVVendorSpells(DataGridView dgv, Vendor vendor)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", HeaderText = "ID", Visible = false });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Name" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGold", HeaderText = "Gold Value" });
            

            foreach (Spell spell in vendor.VendorSpellInventory)
            {
                if (!CheckIfInDGV(spell.ID, dgv))
                {
                    dgv.Rows.Add(spell.ID, spell.Name, spell.GoldValue);
                }
            }
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


        //<------------Creation Functions-------------->
        private PictureBox CreatePictureBox(string imageName, Point point, Size size)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = size;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage(pictureBox, imageName);
            pictureBox.Location = point;

            Controls.Add(pictureBox);

            return pictureBox;
        }

        private Label CreateLabel(string labelText, bool autoSize, Point point, Size size)
        {
            Label label = new Label();
            label.Text = labelText;
            label.AutoSize = autoSize;
            label.Location = point;
            if (!autoSize)
            {
                label.Size = size;
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
            Label lblLabelName = CreateLabel(labelName, true, new Point(x + 30, y + 5), new Size(0, 0));
            Label lblValue = CreateLabel(value, true, new Point(x + 150, y + 5), new Size(0, 0));
            
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

    }
}
