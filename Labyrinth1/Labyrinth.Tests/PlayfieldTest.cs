﻿using Labyrinth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Labyrinth.Tests
{
    
    
    /// <summary>
    ///This is a test class for PlayfieldTest and is intended
    ///to contain all PlayfieldTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlayfieldTest
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
        ///A test for Playfield Constructor
        ///</summary>
        [TestMethod()]
        public void PlayfieldConstructorTest()
        {
            Playfield target = new Playfield();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for isWinning
        ///</summary>
        [TestMethod()]
        public void isWinningTest()
        {
            Playfield target = new Playfield(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isWinning();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for move
        ///</summary>
        [TestMethod()]
        public void moveTest()
        {
            Playfield target = new Playfield(); // TODO: Initialize to an appropriate value
            Direction direction = new Direction(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.move(direction);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for print
        ///</summary>
        [TestMethod()]
        public void printTest()
        {
            Playfield target = new Playfield(); // TODO: Initialize to an appropriate value
            target.print();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for reset
        ///</summary>
        [TestMethod()]
        public void resetTest()
        {
            Playfield target = new Playfield(); // TODO: Initialize to an appropriate value
            target.reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
