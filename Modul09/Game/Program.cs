using Game.Characters;
using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizzard wizz1 = new Wizzard("Wizzard pierwszy");
            Thief thief1 = new Thief("Thief pierwszy");
            Warrior warrior1 = new Warrior("Warrior pierwszy");

            Weapon w1 = new Weapon("Premium Sword", 500, 50);
            warrior1.Weapon = w1;

            Console.WriteLine(warrior1.ToString());

            Console.ReadKey();
        }
    }
}
