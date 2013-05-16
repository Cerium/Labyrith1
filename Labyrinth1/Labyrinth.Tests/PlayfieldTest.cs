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
        public void IsVisitedPosition_Test()
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
        public void Playfield_Set_Position_Test()
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            Playfield palyfield = new Playfield();
            Object[] arguments = new object[] { 5 };
            MethodInfo testedMethod = typeof(Playfield).GetMethod("Labyrinth", eFlags);
            int[] actual = (int[])testedMethod.Invoke(palyfield.Labyrinth, arguments);
            int[] expected =new int[]{3,3} ;
            Assert.AreEqual(expected, actual);
        }
    }
}
