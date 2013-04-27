﻿using Labyrinth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Labyrinth.Tests
{
    
    
    /// <summary>
    ///This is a test class for MessageTest and is intended
    ///to contain all MessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MessageTest
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
        ///A test for Message Constructor
        ///</summary>
        [TestMethod()]
        public void MessageConstructorTest()
        {
            Message target = new Message();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for intro
        ///</summary>
        [TestMethod()]
        public void introTest()
        {
            Message target = new Message(); // TODO: Initialize to an appropriate value
            target.Intro();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for invalid
        ///</summary>
        [TestMethod()]
        public void invalidTest()
        {
            Message target = new Message(); // TODO: Initialize to an appropriate value
            target.Invalid();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for move
        ///</summary>
        [TestMethod()]
        public void moveTest()
        {
            Message target = new Message(); // TODO: Initialize to an appropriate value
            target.Move();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for nl
        ///</summary>
        [TestMethod()]
        public void nlTest()
        {
            Message target = new Message(); // TODO: Initialize to an appropriate value
            target.NewLine();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for playing
        ///</summary>
        [TestMethod()]
        public void playingTest()
        {
            Message target = new Message(); // TODO: Initialize to an appropriate value
            target.Playing();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for win
        ///</summary>
        [TestMethod()]
        public void winTest()
        {
            Message target = new Message(); // TODO: Initialize to an appropriate value
            int moves = 0; // TODO: Initialize to an appropriate value
            target.Win(moves);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
