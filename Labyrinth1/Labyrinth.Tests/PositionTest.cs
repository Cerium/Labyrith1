using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Labyrinth.Tests
{
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void ConstructorTesting_With_Row_5()
        {
            Position position = new Position(5, 0);
            int actual = position.Row;
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConstructorTesting_With_Col_5()
        {
            Position position = new Position(0, 5);
            int actual = position.Col;
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
