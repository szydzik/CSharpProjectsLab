using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Wehicles
{
    public class Wehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Wehicle(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Speed: {1}", Name, Speed);
        }
    }

    public static class Horses
    {
        private static Wehicle basicHorse = new Wehicle("Basic Horse", 170);
        private static Wehicle premiumHorse = new Wehicle("Premium Horse", 200);

        public static Wehicle BasicHorse
        {
            get
            {
                return basicHorse;
            }
        }

        public static Wehicle PremiumHorse
        {
            get
            {
                return premiumHorse;
            }
        }
    }
}
