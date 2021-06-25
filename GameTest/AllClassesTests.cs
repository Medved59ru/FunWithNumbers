using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunWithNumbers;
using System;

namespace GameTest
{
    [TestClass]
    public class AllClassesTests
    {
        [TestMethod]
        public void GetFromConsoleTest()
        {
            string number1 = "0";
            string number2 = "100";
            string number3 = "50";

            var result1 = InputOutput.GetFromConsoleThe(number1);
            var result2 = InputOutput.GetFromConsoleThe(number2);
            var result3 = InputOutput.GetFromConsoleThe(number3);

            Assert.AreEqual(0, result1);
            Assert.AreEqual(100, result2);
            Assert.AreEqual(50, result3);
        }

        [TestMethod]
        public void CompareTest()
        {
            int userNumber1 = 0;
            int userNumber2 = 100;
            int userNumber3 = 50;

            Game game = new Game(50);  

            var result1 = game.CompareComputerNumberWith(userNumber1);
            var result2 = game.CompareComputerNumberWith(userNumber2);
            var result3 = game.CompareComputerNumberWith(userNumber3);

            Assert.AreEqual("ÁÎËÜØÅ...", result1);
            Assert.AreEqual("ÌÅÍÜØÅ...", result2);
            Assert.AreEqual("ÂÅĞÍÎ!!!", result3);
        }

        [TestMethod]
        public void CheckMessageTest()
        {
            string message1 = "ÂÅĞÍÎ!!!";
            string message2 = "Èíîå ñëîâî";

            Game game = new Game();

            var result1 = game.CheckThe(message1);
            var result2 = game.CheckThe(message2);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);

        }
    }
}
