using Ovning3a;
using System;
using System.Reflection.Metadata;

namespace Ovning3Test
{
    [TestClass]
    public class UnitTest1
    {
        // PROPERTIES TESTING, INVALID VALUES
        // -------------------------------------
        // Not great testing invalid input at this stage, due to the exceptions.

        //// PROPERTIES TESTING, TESTING VALID VALUES
        //// -------------------------------------
        //// Testing the constructor at first would be a more methodical approach, but here we go straigt to the createperson method.
        [TestMethod]
        public void CreatePersonTest()
        {
            //-- Arrange
            var personActual = new Person(3, "Mliks", "Mysing", 5, 4);

            //-- Act
            int personAgeExpected = 3;
            string personFirstNameExpected = "Mliks";
            string personLastNameExpected = "Mysing";
            double personHeightExpected = 5;
            double personWeightExpected = 4;

            //-- Assert
            //To many asserts? Covention? Create diffrent type for test variables Expected or divede up the testing?
            Assert.AreEqual(personAgeExpected, personActual.Age);
            Assert.AreEqual(personFirstNameExpected, personActual.Fname);
            Assert.AreEqual(personLastNameExpected, personActual.Lname);
            Assert.AreEqual(personHeightExpected, personActual.Height);
            Assert.AreEqual(personWeightExpected, personActual.Weight);
        }

        //// -------------------------------------
        [TestMethod]
        public void SetAgeTest()
        {
            //-- Arrange
            var personActual = new Person(3, "Mliks", "Mysing", 5, 4);

            // Changed the acess modyfier for PersonHandler to public, feels lika a bad approach to alter the code, other way to go about it?
            var PHandler = new PersonHandler();
            PHandler.SetAge(personActual, 37);

            //-- Act
            int personAgeExpected = 37;
            //-- Assert
            Assert.AreEqual(personAgeExpected, personActual.Age);

        }

        //// -------------------------------------
        [TestMethod]
        public void GetAgeTest()
        {
            //-- Arrange
            var personActual = new Person(3, "Mliks", "Mysing", 5, 4);

            // Changed the acess modyfier for PersonHandler to public, feels lika a bad approach to alter the code, other way to go about it?
            var PHandler = new PersonHandler();
            PHandler.GetAge(personActual);

            //-- Act
            int personAgeExpected = 3;
            //-- Assert
            Assert.AreEqual(personAgeExpected, personActual.Age);

        }

        [TestMethod]
        
        public void RegisterAddNGetTest()
        {
            //-- Arrange
            var PH = new PersonHandler();
            var person1 = new Person(3, "Mliks", "Mysing", 5, 4);
            var person2 = new Person(3, "Klick", "Mysing", 5, 4);
            var person3 = new Person(3, "Slick", "Mysing", 5, 4);

            PH.AddPersonToRegister(person1);
            PH.AddPersonToRegister(person2);
            PH.AddPersonToRegister(person3);

            // Changed the acess modyfier for PersonHandler to public, feels lika a bad approach to alter the code, other way to go about it?
            var PHandler = new PersonHandler();
            var personRegisterActual = PH.GetPersonRegister();

            //-- Act
            var person1Expected = "Mliks";
            var person2Expected = "Kliks";
            var person3Expected = "Sliks";
            //-- Assert
            Assert.AreEqual(person1Expected, personRegisterActual[1]);
            Assert.AreEqual(person2Expected, personRegisterActual[2]);
            Assert.AreEqual(person3Expected, personRegisterActual[3]);

        }

    }
}