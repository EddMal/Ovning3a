using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// Inheritance 3.3
namespace Ovning3a.Animals
{
    abstract class Animal
    {
        // Fields in abstract is this best practise?
        protected double weight;
        protected string name;
        protected int age;
        protected string specialProperty;
        protected string specialPropertySubBirds;

        // Properties in abstract is this best practise?

        public string SpecialPropertySubBirds
        {
            get
            {
                return specialPropertySubBirds;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException($"Error caused by parameter-value, name = \"{value}\" is out of the range of 3-30 characters");
                }

                specialPropertySubBirds = value;

            }
        }

        public string SpecialProperty
        {
            get
            {
                return specialProperty;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException($"Error caused by parameter-value, name = \"{value}\" is out of the range of 3-30 characters");
                }

                specialProperty = value;

            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Error caused by parameter-value age = \"{value}\", age must be greater than 0 ");
                }

                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException($"Error caused by parameter-value, name = \"{value}\" is out of the range of 3-16 characters");
                }

                name = value;

            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException($"Error caused by parameter-value, weight = \"{value}\" is out of range, must be greater than 0");
                }
                weight = value;
            }
        }

        public abstract string DoSound();

        public virtual string Stats()
        {
            string stats = $"Animals statistics:Age:{Age}, Name{Name}, Weight:{Weight}"; 
            return stats;
        }



}
}
