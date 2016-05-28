using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items
{

    public abstract class Item
    {
        public string Name { get; set; }
  
        public Item(string name)
        {
            this.Name = name;

        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class Weapon : Item
    {
        public int PhysicalPower { get; set; }
        public int MagicalPower { get; set; }

        public Weapon(string name, int physicalPower, int magicalPower) : base(name)
        {
            this.PhysicalPower = physicalPower;
            this.MagicalPower = magicalPower;
        }
    }

    public class Shield : Item
    {
        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }

        public Shield(string name, int physicalDefence, int magicalDefence) : base(name)
        {
            this.PhysicalDefense = physicalDefence;
            this.MagicalDefense = magicalDefence;
        }

        public override string ToString()
        {
            PropertyDescriptorCollection coll = TypeDescriptor.GetProperties(this);
            StringBuilder builder = new StringBuilder();
            foreach (PropertyDescriptor pd in coll)
            {
                builder.Append(string.Format("{0} : {1} ", pd.Name, pd.GetValue(this).ToString()));
            }
            return builder.ToString();
        }
    }

    public class Artefact : Item
    {
        public int PhysicalPower { get; set; }
        public int MagicalPower { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }

        public Artefact(string name, int physicalPower, int magicalPower, int physicalDefence, int magicalDefence, int mana, int health, int speed) : base(name)
        {
            this.PhysicalPower = physicalPower;
            this.MagicalPower = magicalPower;
            this.PhysicalDefense = physicalDefence;
            this.MagicalDefense = magicalDefence;
            this.Mana = mana;
            this.Health = health;
            this.Speed = speed;
        }
    }
}
