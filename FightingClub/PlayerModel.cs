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
        void GetHit(EnumPlayerBodyPart bodyPart);
        void SetBlock(EnumPlayerBodyPart bodyPart);
    }
    class PlayerModel : IPlayerModel
    {
        public PlayerModel()
        {
            
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public EnumPlayerBodyPart Blocked { get; set; }
        public event EventHandler Block = delegate { };
        public event EventHandler Wound = delegate { };
        public event EventHandler Death = delegate { };

        public void GetHit(EnumPlayerBodyPart bodyPart)
        {
            EventArgs e = new EventArgs();

            if (Blocked != bodyPart)
            {
                Block(this, e);
            }
            else
            {
                if (Health > 0)
                {
                    Wound(this, e);
                }
                else
                {
                    Death(this, e);
                }
            }
        }
        public void SetBlock(EnumPlayerBodyPart bodyPart)
        {
            Blocked = bodyPart;
        }
    }
}
