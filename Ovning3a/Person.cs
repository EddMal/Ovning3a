using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning3a
{
    public class Person
    {
        // Private fields:
        private int age;
        private string? fName;
        private string? lName;
        private double height;
        private double weight;
        

        // Public properties:

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

        public String Fname
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Error caused by parameter-value, fname = \"{value}\", fname must be at least 2 characters");
                    
                }

                fName = value;
            }
        } 
               
        public String Lname
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException($"Error caused by parameter-value, lname = \"{value}\" is out of the range of 3-16 characters");
                }

                lName = value;

            }
        }
        public double Height
        {
            get 
            {
                return height;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException($"Error caused by parameter-value, height = \"{value}\" is out of range, must be greater than 0");
                }
                height = value;
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

        // The constructor blocks any attempt to create a person without parameters with acceopted values. Constructor with null check:
        public Person(int age, string fname, string lname, double height, double weight)
        {
            //add List

            if (fname is null || lname is null)
            {
               throw new NullReferenceException("Error caused by parameter-value for lname and/or fname: Parameters lname and fname cannot be null.");
            }
            
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
            
        }


    }
}
