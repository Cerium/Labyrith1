using Labyrinth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Labyrinth.Tests
{
    
    
    /// <summary>
    ///This is a test class for ScoreboardTest and is intended
    ///to contain all ScoreboardTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScoreboardTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            Scoreboard target = new Scoreboard();
            string fileName = "AddTest.txt";
            Player player = new Player();
            player.Name = "nakov";
            player.Points = 10;
            target.Add(fileName, player);
        }

        /// <summary>
        ///A test for Show
        ///</summary>
        [TestMethod()]
        public void ShowTest()
        {
            Scoreboard target = new Scoreboard();
            string fileName = "ShowTest.txt";
            Player player = new Player();
            player.Name = "nakov";
            player.Points = 10;
            target.Add(fileName, player);

            string expected = "1: nakov -> 10" + Environment.NewLine;
            string actual;
            actual = target.Show(fileName);
            Assert.AreEqual(expected, actual);
        }
    }
}
