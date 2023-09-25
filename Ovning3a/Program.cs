
using System;
using System.Diagnostics;
using Ovning3a.ErrorMessages;
using Ovning3a.Animals;
using Ovning3a.Person;

namespace Ovning3a
{
    internal class Program
    {
        // Svar frågor:
        // F.1:
        // I klassen Animals om devisen #placera så lågt som möjligt". Det skullle eventuellt vara tänkbart
        // att placera attributet i klassen Birds då det är specefikt för fågelns subklasser.

        //F.2:
        // I klassen Animals´.


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
                    //Debug window, do not se the message?.
                    //Debug.WriteLine(exceptionMessage);
                    Console.WriteLine(exceptionMessage);
                    initiationFailed = true;
                    break;
                }
            } while (initiationFailed == true);
            

            }

        private static void ExecuteProgram()
        {
            //Considder ways to halt unwanted acess of constructor and properties:
            var person = new Person(3, "Mliks", "Mysing", 5, 4);   
           // person.Age = 10;
            //person.Fname = "Korke";
            //var getAge = person.Age;
            // End unwanted use of constructor and properties.


            var PHandler = new PersonHandler();

            //Evaluate this executes the same thing as "var person = new Person(3, "Mliks", "Mysing", 5, 4);"
            //Might be an idea to replace ad to register inside create person, or rather halt the use of new person.
            var NewPerson = PHandler.CreatePerson(30, "Dinkel", "Mysing", 7, 10);

            
            PHandler.SetAge(person, 22);
            Console.WriteLine(person.Age);

            //3.2 Polymorfism
            // This should be cleaned up by dividing code in to methoods:
           
            /*List<string> UserErrors = new List<string>();

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
            }*/
            //-- End 3.2 Polymorfism.

            // Inheritance 3.3:
            var horse = new Horse(45,"Choppy",17);
            var horseSpecial = horse.AnimalsSpecialProperty();
            var horseSound = horse.DoSound();
            Console.WriteLine(horseSound);
            Console.WriteLine(horseSpecial);

            //Flamingo
            var flamingo = new Birds.Flamingo(10, "Krinko", 3);
            var flamingoSpecial = flamingo.AnimalsSpecialProperty();
            var flamingoSpecial2 = flamingo.AnimalsSecondSpecialProperty();
            var flamingoSound = flamingo.DoSound();

            Console.WriteLine(flamingoSound);
            Console.WriteLine(flamingoSpecial);
            Console.WriteLine(flamingoSpecial2);


            //Wolfman
            //var wolfPerson = new Ovning3a.Person.Wolfman(45, "Stimmy", 17);
            //var wolfPersonSpecialP = wolfPerson.AnimalsSpecialProperty();
            //var wolfPersonSays = wolfPerson.Talk();
            //var wolfPersonSounds = wolfPerson.DoSound();

            //Console.WriteLine(wolfPersonSounds);
            //Console.WriteLine(wolfPersonSays);
            //Console.WriteLine(wolfPersonSounds);

            //Animals 3.4:
            List<Animal> Animals = new List<Animal>();

            Animals.Add(horse);

            var hedgehog = new HedgeHog(45, "gerd", 17);
            Animals.Add(hedgehog);

            var swan = new Birds.Swan(45, "Swanis", 17);
            Animals.Add(swan);



            foreach (var animal in Animals)
            { 
            
            }




    }
    }
}