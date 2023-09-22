using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// Inheritance 3.3

namespace Ovning3a
{

    abstract class AnimalsSubclass: Animal
    {
        public bool SpecialProperty = false;

        public AnimalsSubclass(double weight, string name, int age, bool specialProperty)
        {
            Age = age;
            Name = name;
            Weight = weight;
            SpecialProperty = specialProperty;
        }




    }
    internal class Horse : AnimalsSubclass
    {
        public bool Domesticated = false;
        public Horse(double weight, string name, int age, bool specialProperty) : base(weight, name, age, specialProperty)
        {
            Age = age;
            Name = name;
            Weight = weight;
            Domesticated = specialProperty;
        }


        public override string DoSound()
        {
            return ($"Neheheh!");
        }
    }

    //internal class Dog : AnimalsSubclass
    //{
    //    public bool Domesticated = false;
    //    public Dog(double weight, string name, int age) : base(weight, name, age)
    //    {
    //        Age = age;
    //        Name = name;
    //        Weight = weight;
    //    }

    //    public override string DoSound()
    //    {
    //        return ($"Woff!");
    //    }
    //}

    //internal class HedgeHog : AnimalsSubclass
    //{
    //    bool Parent = false;

    //    public HedgeHog(double weight, string name, int age) : base(weight, name, age)
    //    {
    //        Age = age;
    //        Name = name;
    //        Weight = weight;
    //    }

    //    public override string DoSound()
    //    {
    //        return ($"Schwip!");
    //    }
    //}

    //internal class Worm : AnimalsSubclass
    //{
    //    bool DriedOut = false;

    //    public Worm(double weight, string name, int age) : base(weight, name, age)
    //    {
    //        Age = age;
    //        Name = name;
    //        Weight = weight;
    //    }

    //    public override string DoSound()
    //    {
    //        if (DriedOut == false)
    //            return ($"Slipperislick!");
    //        else
    //            return ($"Silence.");
    //    }
    //}

    //internal class Bird : AnimalsSubclass
    //{
    //    bool  CanFly = false;

    //    public Bird(double weight, string name, int age) : base(weight, name, age)
    //    {
    //        Age = age;
    //        Name = name;
    //        Weight = weight;
    //    }

    //    public override string DoSound()
    //    {
    //        return ($"Pipipi!");
    //    }
    //}

    //internal class Wolf : AnimalsSubclass
    //{
    //    bool Domesticated = false;

    //    public Wolf(double weight, string name, int age) : base(weight, name, age)
    //    {
    //        Age = age;
    //        Name = name;
    //        Weight = weight;
    //    }

    //    public override string DoSound()
    //    {
    //        return ($"Aooo!");
    //    }
    //}

}
