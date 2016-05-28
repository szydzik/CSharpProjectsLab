using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Items;
using System.ComponentModel;

namespace Game
{
    public abstract class Character
    {
        //phy
        public int PhysicalPower { get; set; }
        public int PhysicalDefense { get; set; }

        //mag
        public int MagicalPower { get; set; }
        public int MagicalDefense { get; set; }

        //basic
        public readonly string Nick;
        public int Mana { get; set; }
        public int CurrentMana { get; set; }
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public double Experience { get; set; }

        //equipment
        public Items.Weapon Weapon { get; set; } 
        public List<Items.Artefact> Artefacts { get; set; }
        public Wehicles.Wehicle Wehicle { get; set; }

        //metods
        public void AddArtefact(Artefact artefact)
        {
            this.Artefacts.Add(artefact);
        }
        public void DeleteArtefact(Artefact artefact)
        {
            this.Artefacts.Remove(artefact);
        }

        //constructor
        protected Character(string nick, int physicalPower, int physicalDefense, int magicalPower, int magicalDefense, int health, int mana, int speed)
        {
            PhysicalPower = physicalPower;
            PhysicalDefense = physicalDefense;
            MagicalPower = magicalPower;
            MagicalDefense = magicalDefense;
            Nick = nick;
            Mana = mana;
            CurrentMana = mana;
            Health = health;
            CurrentHealth = health;
            Speed = speed;
            Level = 1;
            Experience = 0;
            Weapon = null;
            Artefacts = new List<Artefact>();
            Wehicle = null;
        }

        public override string ToString()
        {
            PropertyDescriptorCollection coll = TypeDescriptor.GetProperties(this);
            StringBuilder builder = new StringBuilder();
            foreach (PropertyDescriptor pd in coll)
            {
                builder.Append(string.Format("{0} : {1}\n", pd.Name, pd.GetValue(this).ToString()));
            }
            return builder.ToString();
        }
    }


}
