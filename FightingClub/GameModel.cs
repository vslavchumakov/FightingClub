using System;
using System.Collections.Generic;
using System.Text;

namespace FightingClub
{
    internal class GameModel
    {
        private int round;
        public int Round { get => round; set => round = value; }

        public delegate void GameModelHandler(object sender, GameModelEventArgs eventArgs);
        public event GameModelHandler RoundHandler = delegate { };

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

        public void NextRound()
        {
            playerModel1.GetHit(EnumPlayerBodyPart.Body);
            playerModel1.SetBlock(EnumPlayerBodyPart.Body);


           
            round++;
            RoundHandler(this, new GameModelEventArgs(round));
        }
    }

    public class GameModelEventArgs : EventArgs
    {
        public readonly int round;

        public GameModelEventArgs(int round)
        {
            this.round = round;
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