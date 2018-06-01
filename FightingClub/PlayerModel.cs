using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClub
{
    enum EnumPlayerBodyPart
    {
        Head,
        Body,
        Legs
    }
    internal interface IPlayerModel
    {
        string Name { get; set; }
        int Health { get; set; }
        EnumPlayerBodyPart Blocked { get; set; }
        EnumPlayerBodyPart Hited { get; set; }
        void GetHit(EnumPlayerBodyPart bodyPart);
        void SetBlock(EnumPlayerBodyPart bodyPart);
    }

    class PlayerModelEventArgs : EventArgs
    {
        public readonly int health;
        public readonly string name;

        public PlayerModelEventArgs(string name, int health)
        {
            this.name = name;
            this.health = health;
        }
    }

    class PlayerModel : IPlayerModel
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public EnumPlayerBodyPart Blocked { get; set; }
        public EnumPlayerBodyPart Hited { get; set; }
        public delegate void PlayerEventHandler(PlayerModel sender, PlayerModelEventArgs eventArgs);
        public event PlayerEventHandler Block = delegate { };
        public event PlayerEventHandler Wound = delegate { };
        public event PlayerEventHandler Death = delegate { };

        public void GetHit(EnumPlayerBodyPart bodyPart)
        {
            Hited = bodyPart;
        }
        public void SetBlock(EnumPlayerBodyPart bodyPart)
        {
            //PlayerModelEventArgs eventArgs = new PlayerModelEventArgs(Name, Health);

            if (Blocked == bodyPart)
            {
                Block(this, new PlayerModelEventArgs(Name, Health));
            }
            else
            {
                if (Health > 0)
                {
                    Health -= 10;
                    Wound(this, new PlayerModelEventArgs(Name, Health));
                }
                else
                {
                    Death(this, new PlayerModelEventArgs(Name, Health));
                }
            }
        }
    }
}
