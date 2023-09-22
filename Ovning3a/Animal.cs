using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// Inheritance 3.3
namespace Ovning3a
{
    abstract class Animal
    {
        // Fields in abstract is this best practise?
        protected double weight;
        protected string name;
        protected int age;
        public bool SpecialProperty = false;

        // Properties in abstract is this best practise?
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

        public String Name
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



        // Constructor, how to manage?

        //public Animal(double weight, string name, int age)
        //{
        //    Age = age;
        //    Name = name;
        //    Weight = weight;
        //}


    }
}
