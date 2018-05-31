using System;

namespace FightingClub
{
    internal class GameController
    {
        private GameView view;
        private GameModel model;

        public GameController(GameView view, GameModel model)
        {
            this.view = view;
            this.model = model;
            this.view.Init(this);
            this.model.RoundHandler += RoundHandler;
            SetPlayerData();
        }

        private void RoundHandler(object sender, GameModelEventArgs eventArgs)
        {
            view.UpdateRound(eventArgs);
        }

        private void SetPlayerData()
        {
            view.UpdatePlayersInfo(model);
        }

        internal void StartRound()
        {
            model.NextRound();
        }
    }
}