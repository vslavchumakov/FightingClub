using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightingClub
{
    public partial class GameView : Form
    {
        private GameController controller;
        RadioButton checkedHitRadioButton;
        RadioButton checkedBlockRadioButton;

        public GameView()
        {
            InitializeComponent();      
        }

        internal void UpdatePlayersInfo(PlayerModel sender, PlayerModelEventArgs eventArgs)
        {
            //kostil
            if (sender.Name == "Ivan")
            {
                textPlayerName_1.Text = eventArgs.name;
                textPlayerHealth_1.Text = eventArgs.health.ToString();
                progressBarPlayerHealth_1.Maximum = 100;
                progressBarPlayerHealth_1.Value = eventArgs.health;
                progressBarPlayerHealth_1.Minimum = 0;
                progressBarPlayerHealth_1.Step = 1;
            }
            else
            {
                textPlayerName_2.Text = eventArgs.name;
                textPlayerHealth_2.Text = eventArgs.health.ToString();
                progressBarPlayerHealth_2.Maximum = 100;
                progressBarPlayerHealth_2.Value = eventArgs.health;
                progressBarPlayerHealth_2.Minimum = 0;
                progressBarPlayerHealth_2.Step = 1;
            }

            CheckedRadioButtonEvent(groupBoxHit.Controls);
            CheckedRadioButtonEvent(groupBoxBlock.Controls);
        }

        internal void PlayerDeath(PlayerModel sender, PlayerModelEventArgs eventArgs)
        {
            textLog.Text = "Игрок " + eventArgs.name + " получил смертельные увечия!";
        }

        internal void EnabledButtonStart(bool start)
        {
            buttonStartRound.Enabled = start;
        }

        internal void UpdateRound(GameModelEventArgs eventArgs)
        {
            textRoundNumber.Text = eventArgs.start.ToString();
        }

        internal void Init(GameController controller)
        {
            this.controller = controller;
        }

        private void CheckedRadioButtonEvent(Control.ControlCollection collection)
        {
            foreach (RadioButton item in collection)
            {
                item.MouseClick += CheckedRadioButton_MouseClick;
            }
        }

        private void CheckedRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            checkedHitRadioButton = GetCheckedRadioButton(groupBoxHit.Controls);
            checkedBlockRadioButton = GetCheckedRadioButton(groupBoxBlock.Controls);
            if (checkedHitRadioButton != null && checkedBlockRadioButton != null)
            {
                controller.RoundIsStart();
            }
        }

        private RadioButton GetCheckedRadioButton(Control.ControlCollection collection)
        {
            RadioButton checkedRadioButton = null;
            foreach (RadioButton item in collection)
            {
                if (item.Checked)
                    checkedRadioButton = item;
            }
            return checkedRadioButton;
        }

        private void UpdateTextLog(GameModelEventArgs eventArgs)
        {
            StringBuilder sb = new StringBuilder("Название: ");
            textLog.Text = sb.ToString(); 
        }

        private void buttonStartRound_Click(object sender, EventArgs e)
        {
            controller.StartRound();
        }
    }
}
