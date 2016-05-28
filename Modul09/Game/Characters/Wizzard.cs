using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    class Wizzard : Character
    {
        public static int physicalPower = 0;
        public static int physicalDefense = 50;
        public static int magicalPower = 300;
        public static int magicalDefense = 300;
        public static int health = 5000;
        public static int mana = 10000;
        public static int speed = 100;

        public Wizzard(string nick) : base(nick, physicalPower, physicalDefense, magicalPower, magicalDefense, health, mana, speed)
        {
            this.Weapon = new Weapon("Basic Staff", 0, 100);
            this.Wehicle = Wehicles.Horses.BasicHorse;
        }
    }
}
