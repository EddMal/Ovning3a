
using System.Diagnostics;

namespace Ovning3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool initiationFailed = false;
            do
            {
                initiationFailed = false;
                //Handle exeptions for properties of person with try-cach hook.
                //Change to exceptions
                try
                {
                    ExecuteProgram();
                }
                catch (Exception exceptionMessage)
                {
                    Debug.WriteLine($"{exceptionMessage}");
                    initiationFailed = true;
                    break;
                }
            } while (initiationFailed == true);
            

            }

        private static void ExecuteProgram()
        {
            var person = new Person(3, "Mliks", "Mysing", 5, 4);
            person.Age = 10;
            person.Fname = "Korke";

            var getAge = person.Age;
            var PHandler = new PersonHandler();
            //var NewPerson = PHandler.CreatePerson(0, "", "", 0, 0);
            PHandler.SetAge(person, 0);

            Console.WriteLine(person.Age);
        }
    }
}