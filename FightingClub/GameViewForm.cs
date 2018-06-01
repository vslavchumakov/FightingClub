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

        public GameView()
        {
            InitializeComponent();      
        }

        internal void UpdatePlayersInfo(GameModel gameModel)
        {
            textPlayerName_1.Text = gameModel.players[0].Name;
            progressBarPlayerHealth_1.Maximum = gameModel.players[0].Health;
            progressBarPlayerHealth_1.Value = gameModel.players[0].Health;
            progressBarPlayerHealth_1.Minimum = 0;
            progressBarPlayerHealth_1.Step = 1;

            textPlayerName_2.Text = gameModel.players[1].Name;
            progressBarPlayerHealth_2.Maximum = gameModel.players[1].Health;
            progressBarPlayerHealth_2.Value = gameModel.players[1].Health;
            progressBarPlayerHealth_2.Minimum = 0;
            progressBarPlayerHealth_2.Step = 1;

            buttonStartRound.Enabled = false;

            CheckedRadioButtonEvent(groupBoxHit.Controls);
            CheckedRadioButtonEvent(groupBoxBlock.Controls);
        }

        internal void UpdateRound(GameModelEventArgs eventArgs)
        {
            textRoundNumber.Text = eventArgs.round.ToString();
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
            RadioButton checkedHitRadioButton = GetCheckedRadioButton(groupBoxHit.Controls);
            RadioButton checkedBlockRadioButton = GetCheckedRadioButton(groupBoxBlock.Controls);
            if (checkedHitRadioButton != null && checkedBlockRadioButton != null)
            {
                buttonStartRound.Enabled = true;
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
