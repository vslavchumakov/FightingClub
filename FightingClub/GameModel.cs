using System;
using System.Collections.Generic;
using System.Text;

namespace FightingClub
{
    internal class GameModel
    {
        private int round;
        public int Round { get => round; set => round = value; }

        public delegate void GameModelHandler(GameModel sender, GameModelEventArgs eventArgs);
        public event GameModelHandler StartRound = delegate { };
        public event GameModelHandler FinishRound = delegate { };

        public List<PlayerModel> players = new List<PlayerModel>();

        PlayerModel playerModel1;
        PlayerModel playerModel2;

        public GameModel()
        {
            round = 1;

            playerModel1 = new PlayerModel();
            playerModel1.Name = "Ivan";
            playerModel1.Health = 100;
            players.Add(playerModel1);

            playerModel2 = new PlayerModel();
            playerModel2.Name = "Ramzan";
            playerModel2.Health = 100;
            players.Add(playerModel2);
        }
    }

    public class GameModelEventArgs : EventArgs
    {
        public bool start;

        public GameModelEventArgs(bool start)
        {
            this.start = start;
        }
    }
    public class GameLogEventArgs : EventArgs
    {
        public readonly StringBuilder log;

        public GameLogEventArgs(StringBuilder log)
        {
            this.log = log;
        }
    }
}