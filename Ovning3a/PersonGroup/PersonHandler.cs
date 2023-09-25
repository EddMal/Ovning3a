using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning3a.PersonGroup
{
    // If person used in multiple classes (employee+...+...) might be wirth making an abstract class.
    internal class PersonHandler// changed from when testing, might be a bad idea to alter the program: internal class PersonHandler
    {
        private List<Person> persons = new List<Person>();

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            var person = new Person(age, fname, lname, height, weight);

            return person;

        }

        //EVALUATE!!

        //Might need further control--------------------------------
        public List<Person> GetPersonRegister()
        {
            List<Person> RetrievePersons = persons;
            return RetrievePersons;
        }

        public void AddPersonToRegister(Person person)
        {
            var PH = new PersonHandler();
            var AddAPerson = PH.CreatePerson(person.Age, person.Fname, person.Lname, person.Height, person.Height);
            persons.Add(AddAPerson);
        }
        //----------------------------End Might need further control

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fname)
        {
            pers.Fname = fname;
        }

        public void SetLName(Person pers, string lname)
        {
            pers.Lname = lname;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;

        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        //--Get methods:

        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public string GetFName(Person pers)
        {
            return pers.Fname;
        }

        public string GetLName(Person pers)
        {
            return pers.Lname;
        }

        public double GetHeight(Person pers)
        {
            return pers.Height;

        }

        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }
        //check specifications if implement of methods for handling of:
        //add to List?

        //Save??

        //load//open?

        //Print


        //get persons attributes
        //IPerson: new person, method getpersonsatribute(){}switch attribute, case:Age return Age; string or enum? + exception//or overloaded
        //public void GetPersonsAttribute(Person person, String property) 
        //{
        // 
        //    return $"{person.Attribute}";
        //}

        //get persons attributes
        //IPerson:  method setpersonsatribute(){}switch attribute, case:Age set Age;+ exception//or overloaded
    }
}
