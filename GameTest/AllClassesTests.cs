using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunWithNumbers;
using System;

namespace GameTest
{
    [TestClass]
    public class AllClassesTests
    {
       

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

            Assert.AreEqual("ÁÎËÜØÅ", result1);
            Assert.AreEqual("ÌÅÍÜØÅ", result2);
            Assert.AreEqual("ÂÅĞÍÎ", result3);
        }

    }
}
