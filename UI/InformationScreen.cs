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
        }

        private void CreateItemInformationScreen(Item item)
        {
            SetWindow(item.Name, 400, 270);

            PictureBox pbItemImage = CreatePictureBox(item.Name, new Point(0, 20), new Size(125, 125));
            Label lblItemName = CreateLabel(item.Name, true, new Point(0, 0), new Size(0, 0));
            Label lblItemDescription = CreateLabel(item.Description, false, new Point(0, 165), new Size(300, 200));

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

            Controls.Add(pbItemImage);
            Controls.Add(lblItemName);
            Controls.Add(lblItemDescription);
        }

        private void CreateEquipmentInformationScreen(Equipment equipment)
        {
            SetWindow(equipment.Name, 400, 320);

            PictureBox pbEquipmentImage = CreatePictureBox(equipment.Name, new Point(0, 20), new Size(125, 125));
            Label lblEquipmentName = CreateLabel(equipment.Name, true, new Point(0, 0), new Size(0, 0));
            Label lblEquipmentDescription = CreateLabel(equipment.Description, false, new Point(0, 165), new Size(300, 200));

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

            Controls.Add(pbEquipmentImage);
            Controls.Add(lblEquipmentName);
            Controls.Add(lblEquipmentDescription);
        }

        private void CreateSpellInformationScreen(Spell spell)
        {
            SetWindow(spell.Name, 400, 320);

            PictureBox pbSpellImage = CreatePictureBox(spell.Name, new Point(0, 20), new Size(125, 125));
            Label lblSpellName = CreateLabel(spell.Name, true, new Point(0, 0), new Size(0, 0));
            Label lblSpellDescription = CreateLabel(spell.Description, false, new Point(0, 165), new Size(300, 200));

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

            Controls.Add(pbSpellImage);
            Controls.Add(lblSpellName);
            Controls.Add(lblSpellDescription);
        }

        private void CreateInnInformationScreen(Inn inn)
        {
            SetWindow(inn.Name, 400, 320);

            PictureBox pbSpellImage = CreatePictureBox(inn.Name, new Point(0, 20), new Size(125, 125));
            Label lblSpellName = CreateLabel(inn.Name, true, new Point(0, 0), new Size(0, 0));
            Label lblSpellDescription = CreateLabel(inn.Description, false, new Point(0, 165), new Size(300, 200));

            CreateIconValueCombo("Gold", "Gold Cost:", inn.GoldCost.ToString(), 145, 20);

            Controls.Add(pbSpellImage);
            Controls.Add(lblSpellName);
            Controls.Add(lblSpellDescription);
        }

        private void CreateQuestInformationScreen(Quest quest)
        {
            SetWindow(quest.Name, 400, 320);

            PictureBox pbQuestImage = CreatePictureBox(quest.Name, new Point(0, 20), new Size(125, 125));
            Label lblQuestName = CreateLabel(quest.Name, true, new Point(0, 0), new Size(0, 0));
            Label lblQuestDescription = CreateLabel(quest.Description, false, new Point(0, 165), new Size(300, 200));
            
            if (quest.IsCompleted)
            {
                CreateIconValueCombo("", "Quest Status:", "Completed", 145, 20);
            }
            else
            {
                CreateIconValueCombo("", "Quest Status:", "In Progress", 145, 20);
            }

            Label lblRewards = CreateLabel("Rewards", true, new Point(145, 50), new Size(0, 0));

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
                CreateIconValueCombo(quest.RewardItem.Name, "Reward Item:", quest.RewardItem.ToString(), x, y);
                y += 30;
            }
            if(quest.RewardEquipment != null)
            {
                CreateIconValueCombo(quest.RewardEquipment.Name, "Reward Equipment:", quest.RewardEquipment.ToString(), x, y);
                y += 30;
            }
            if(quest.RewardSpell != null)
            {
                CreateIconValueCombo(quest.RewardSpell.Name, "Reward Spell:", quest.RewardSpell.Name, x, y);
                y += 30;
            }

            Controls.Add(pbQuestImage);
            Controls.Add(lblQuestName);
            Controls.Add(lblQuestDescription);
            Controls.Add(lblRewards);
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

        private PictureBox CreatePictureBox(string imageName, Point point, Size size)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = size;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage(pictureBox, imageName);
            pictureBox.Location = point;

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

            return label;
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

        private void SetWindow(string title, int width, int height)
        {
            Text = title;
            Width = width;
            Height = height;
        }
    }
}
