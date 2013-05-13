using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Labyrinth.Tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Player player = new Player();
            int actual = player.GetPosition.Col;
            int expected = 3;
            Assert.AreEqual(expected, actual);

        }
    }
}
