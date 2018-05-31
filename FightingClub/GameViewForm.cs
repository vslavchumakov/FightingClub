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
            textPlayerName_2.Text = gameModel.players[1].Name;
        }

        internal void UpdateRound(GameModelEventArgs eventArgs)
        {
            textRoundNumber.Text = eventArgs.round.ToString();
        }

        internal void Init(GameController controller)
        {
            this.controller = controller;
        }

        private void buttonStartRound_Click(object sender, EventArgs e)
        {
            RadioButton checkedHitRadioButton = GetCheckedRadioButton(groupBoxHit.Controls);
            RadioButton checkedBlockRadioButton = GetCheckedRadioButton(groupBoxBlock.Controls);
            controller.StartRound();
        }

        private RadioButton GetCheckedRadioButton(Control.ControlCollection collection)
        {
            RadioButton checkedRadioButton = null;

            foreach (RadioButton item in collection)
            {
                if (item.Checked) checkedRadioButton = item;
            }
            return checkedRadioButton;
        }
    }
}
