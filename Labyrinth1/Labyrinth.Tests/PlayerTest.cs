using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Labyrinth.Tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void ConstructorTest_Col_POsition()
        {
            Player player = new Player();
            int actual = player.GetPosition.Col;
            int expected = 3;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ConstructorTest_Row_POsition()
        {
            Player player = new Player();
            int actual = player.GetPosition.Row;
            int expected = 3;
            Assert.AreEqual(expected, actual);

        }
    }
}
