using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    class Warrior : Character
    {
        public static int physicalPower = 200;
        public static int physicalDefense = 200;
        public static int magicalPower = 0;
        public static int magicalDefense = 50;
        public static int health = 10000;
        public static int mana = 5000;
        public static int speed = 50;
        public Items.Shield Shield { get; set; }

        public Warrior(string nick)  : base(nick,  physicalPower,  physicalDefense,  magicalPower,  magicalDefense,  health,  mana,  speed)
        {
            this.Shield = new Shield("Basic Shield", 50, 50);
            this.Weapon = new Weapon("Sword", 100, 0);
            this.Wehicle = Wehicles.Horses.BasicHorse;
        }


    }
}

