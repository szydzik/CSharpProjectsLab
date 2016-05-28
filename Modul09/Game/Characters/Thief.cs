using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    class Thief : Character
    {
        public static int physicalPower = 100;
        public static int physicalDefense = 100;
        public static int magicalPower = 100;
        public static int magicalDefense = 100;
        public static int health = 7500;
        public static int mana = 7500;
        public static int speed = 120;

        public Thief(string nick) : base(nick, physicalPower, physicalDefense, magicalPower, magicalDefense, health, mana, speed)
        {
            this.Weapon = new Weapon("Basic Bow", 100, 50);
            this.Wehicle = Wehicles.Horses.BasicHorse;
        }
    }
}
