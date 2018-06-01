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
            this.model.StartRound += Model_StartRound;
            this.view.Init(this);

            foreach (PlayerModel player in this.model.players)
            {
                PlayerModelEventArgs eventArgs = new PlayerModelEventArgs(player.Name, player.Health);
                view.UpdatePlayersInfo(player, eventArgs);
                player.Wound += Player_Wound;
                player.Block += Player_Block;
                player.Death += Player_Death;
            }
        }

        private void Model_StartRound(GameModel sender, GameModelEventArgs eventArgs)
        {
            view.EnabledButtonStart(eventArgs.start);
        }

        private void Player_Death(PlayerModel sender, PlayerModelEventArgs eventArgs)
        {
            view.UpdatePlayersInfo(sender, eventArgs);
        }

        private void Player_Block(PlayerModel sender, PlayerModelEventArgs eventArgs)
        {
            view.UpdatePlayersInfo(sender, eventArgs);
        }

        private void Player_Wound(PlayerModel sender, PlayerModelEventArgs eventArgs)
        {
            view.UpdatePlayersInfo(sender, eventArgs);
        }

        internal void StartRound()
        {
            model.players[0].Blocked = EnumPlayerBodyPart.Body;
            model.players[0].Hited = EnumPlayerBodyPart.Body;

            model.players[1].Blocked = EnumPlayerBodyPart.Head;
            model.players[1].Hited = EnumPlayerBodyPart.Body;

            model.players[0].SetBlock(model.players[1].Hited);

            model.players[1].SetBlock(model.players[0].Hited);
        }
    }
}