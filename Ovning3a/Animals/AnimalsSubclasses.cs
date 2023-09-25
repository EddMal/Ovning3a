using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// Inheritance 3.3

namespace Ovning3a.Animals
{

    abstract class AnimalsSubclass : Animal
    {

        public AnimalsSubclass(double weight, string name, int age)
        {
            Age = age;
            Name = name;
            Weight = weight;

        }

        public virtual string AnimalsSpecialProperty()
        {
            SpecialProperty = "NA";
            return SpecialProperty;
        }
        public override string Stats()
        {
            string stats = $"Animals statistics:Age:{Age}, Name:{Name}, Weight:{Weight}, SpecialProperty:{SpecialProperty}";
            return stats;
        }

    }

    // Classes should be divided in to separate files.
    internal class Horse : AnimalsSubclass
    {
        public Horse(double weight, string name, int age) : base(weight, name, age)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public override string AnimalsSpecialProperty()
        {
            SpecialProperty = "Jump 2 meters";
            return SpecialProperty;
        }


        public override string DoSound()
        {
            return $"Neheheh!";
        }
    }

    internal class Dog : AnimalsSubclass
    {
        public Dog(double weight, string name, int age) : base(weight, name, age)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public override string AnimalsSpecialProperty()
        {
            SpecialProperty = $"Barks really loud";
            return SpecialProperty;
        }

        public override string DoSound()
        {
            return $"Woff!";
        }

        public string DogReturns()
        {
            return $"{Name} returns a bone.";
        }
    }

    internal class HedgeHog : AnimalsSubclass
    {

        public HedgeHog(double weight, string name, int age) : base(weight, name, age)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public override string AnimalsSpecialProperty()
        {
            SpecialProperty = "Sharp spikes";
            return SpecialProperty;
        }

        public override string DoSound()
        {
            return $"Schwip!";
        }
    }

    internal class Worm : AnimalsSubclass
    {

        public Worm(double weight, string name, int age) : base(weight, name, age)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public override string AnimalsSpecialProperty()
        {
            SpecialProperty = "Super dry";
            return SpecialProperty;
        }
        public override string DoSound()
        {
            return $"Schschsch..";
        }
    }

    internal class Wolf : AnimalsSubclass
    {

        public Wolf(double weight, string name, int age) : base(weight, name, age)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public override string AnimalsSpecialProperty()
        {
            SpecialProperty = "Warm fur";
            return SpecialProperty;
        }

        public override string DoSound()
        {
            return $"Aooo!";
        }
    }

}
