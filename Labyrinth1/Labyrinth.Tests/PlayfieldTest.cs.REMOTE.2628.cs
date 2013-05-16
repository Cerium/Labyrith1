using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Labyrinth.Tests
{
    [TestClass]
    public class PlayfieldTest
    {
        [TestMethod]
        public void Constructor_Test_Rows_Lenght()
        {
            Playfield palyfield = new Playfield();
            int actual = palyfield.Labyrinth.GetLength(0);
            var expected = Playfield.PlayfieldRows;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor_Test_Col_Lenght()
        {
            Playfield palyfield = new Playfield();
            int actual = palyfield.Labyrinth.GetLength(1);
            var expected = Playfield.PlayfieldCols;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsVisitedPosition_Test_False()
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            Playfield palyfield = new Playfield();
            Player player = new Player(); 
            Direction direction = Direction.Left;
            Object[] arguments = new object[] { player, direction };
            MethodInfo testedMethod = typeof(Playfield).GetMethod("IsVisitedPosition", eFlags);
            bool actual = (bool)testedMethod.Invoke(palyfield, arguments);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsVisitedPosition_Test_True()
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            Playfield palyfield = new Playfield();
            Position position = new Position(3, 5);
            Player player = new Player(position);
            Direction direction = Direction.Left;
            Object[] arguments = new object[] { player, direction };
            MethodInfo testedMethod = typeof(Playfield).GetMethod("IsVisitedPosition", eFlags);
            bool actual = (bool)testedMethod.Invoke(palyfield, arguments);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
