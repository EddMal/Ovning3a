using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning3a.Animals;

namespace Ovning3a.Animals
{
    internal class Birds
    {     

        internal class Bird : AnimalsSubclass
        {
            public Bird(double weight, string name, int age) : base(weight, name, age)
            {
                Age = age;
                Name = name;
                Weight = weight;
            }

            public override string AnimalsSpecialProperty()
            {
                SpecialProperty = "Got wings";
                return SpecialProperty;
            }

            public virtual string AnimalsSecondSpecialProperty()
            {
                SpecialPropertySubBirds = "Snazzy color";
                return SpecialPropertySubBirds;
            }

            public override string DoSound()
            {
                return $"Pipipi!";
            }
        }

        internal class Flamingo : Bird
        {
            public Flamingo(double weight, string name, int age) : base(weight, name, age)
            {
                Age = age;
                Name = name;
                Weight = weight;
            }

            public override string AnimalsSecondSpecialProperty()
            {
                SpecialPropertySubBirds = "Snazzy color";
                return SpecialPropertySubBirds;
            }

        }
    }
}
