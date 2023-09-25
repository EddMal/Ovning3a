using Ovning3a;
using Ovning3a.PersonGroup;
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

            // Changed the acess modyfier for this test for PersonHandler to public, to get acess to PersonHandler content,
            // feels lika a bad approach to alter the code, other way to go about it?
            // Approach 2, added class personhandler and person as links to project solved the issue, new issue = conflict warnings,
            // probebly because of the double references. 
            //
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
            var person2 = new Person(3, "Klicks", "Mysing", 5, 4);
            var person3 = new Person(3, "Slicks", "Mysing", 5, 4);

            PH.AddPersonToRegister(person1);
            PH.AddPersonToRegister(person2);
            PH.AddPersonToRegister(person3);

            // Changed the acess modyfier for PersonHandler to public, feels lika a bad approach to alter the code, other way to go about it?
            var PHandler = new PersonHandler();
            var personRegisterActual = PH.GetPersonRegister();

            //-- Act
            var person1Expected = "Mliks";
            var person2Expected = "Klicks";
            var person3Expected = "Slicks";
            //-- Assert
            Assert.AreEqual(person1Expected, personRegisterActual[0].Fname);
            Assert.AreEqual(person2Expected, personRegisterActual[1].Fname);
            Assert.AreEqual(person3Expected, personRegisterActual[2].Fname);

        }

    }
}