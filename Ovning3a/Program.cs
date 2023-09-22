
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
            //Considder ways to halt unwanted acess of constructor and properties:
            var person = new Person(3, "Mliks", "Mysing", 5, 4);

            
            person.Age = 10;
            person.Fname = "Korke";
            var getAge = person.Age;
            // End unwanted use of constructor and properties.


            var PHandler = new PersonHandler();

            //Evaluate this executes the same thing as "var person = new Person(3, "Mliks", "Mysing", 5, 4);"
            //Might be an idea to replace ad to register inside create person, or rather halt the use of new person.
            var NewPerson = PHandler.CreatePerson(30, "Dinkel", "Mysing", 7, 10);
            PHandler.SetAge(person, 0);
            Console.WriteLine(person.Age);

            //3.2 Polymorfism
            // This should be cleaned up by dividing code in to methoods:
            List<string> UserErrors = new List<string>();

            var UEText = new TextInputError();
            var UENumeric = new NumericInputError();

            var UEWhitespace = new WhitespaceInputError();
            var UENull = new NullInputError();
            var UEToFewCharacters = new ToFewCharactersInputError();

            var UETextMessage = UEText.UEMessage();
            var UENumericMessage = UENumeric.UEMessage();

            var UEWhitespaceMessage = UEWhitespace.UEMessage();
            var UENullMessage = UENull.UEMessage();
            var UEToFewCharactersMessage = UEToFewCharacters.UEMessage();

            UserErrors.Add(UETextMessage);
            UserErrors.Add(UENumericMessage);

            UserErrors.Add(UEWhitespaceMessage);
            UserErrors.Add(UENullMessage);
            UserErrors.Add(UEToFewCharactersMessage);

            foreach (var error in UserErrors)
            {
                Console.WriteLine(error);
            }
            // End 3.2 Polymorfism.

            
        }
    }
}