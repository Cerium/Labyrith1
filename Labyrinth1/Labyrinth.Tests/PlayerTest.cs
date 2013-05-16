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
            int expected = Player.PlayerCol;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ConstructorTest_Row_POsition()
        {
            Player player = new Player();
            int actual = player.GetPosition.Row;
            int expected = Player.PlayerRow;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetPositionTest_After_Three_Moves_ToLeft()
        {
            Direction direction = Direction.Left;
            Player player = new Player();
            player.Move(direction);
            player.Move(direction);
            player.Move(direction);
    
            int actual = player.GetPosition.Row;
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HasWon_Test_Result_False()
        {
            Player player = new Player();
            bool actual = player.HasWon();
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Points_Test_With_One_Move_ToRight()
        {
            Direction direction = Direction.Right;
            Player player = new Player();
            player.Move(direction);
            int actual = player.Points;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Points_Test_With_One_Move_ToLeft()
        {
            Direction direction = Direction.Left;
            Player player = new Player();
            player.Move(direction);
            int actual = player.Points;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Points_Test_With_Four_Moves_ToLeft()
        {
            Direction directionToLeft = Direction.Left;
            Direction directionToRight = Direction.Right;
            Player player = new Player();
            player.Move(directionToLeft);
            player.Move(directionToLeft);
            player.Move(directionToLeft);
            player.Move(directionToRight);
            int actual = player.Points;
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Player_GetPosition_Test_OutSideTheField_WithRow8()
        {
            Position position = new Position(8, 0);
            Player player = new Player(position);
            int actual = player.GetPosition.Col;          
        }

        [TestMethod]
        public void Player_GetPosition_With_RowAndCol_4()
        {
            Position position = new Position(4, 4);
            Player player = new Player(position);
            int actual = player.GetPosition.Col;
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void restart_Deafault_Position_Test()
        {
            Position position = new Position(4, 4);
            Player player = new Player(position);
            player.RestartDefaultPosition();
            int actual = player.GetPosition.Col;
            int expected = Player.PlayerCol;
            Assert.AreEqual(expected, actual);
        }


    }
}
