﻿namespace Minesweeper.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void FullOneByOne()
        {
            Board board = new Board(1, 1);

            var result = board.ToLines();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("*", result[0]);
        }

        [TestMethod]
        public void FullTwoByThree()
        {
            Board board = new Board(2, 3);

            var result = board.ToLines();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("***", result[0]);
            Assert.AreEqual("***", result[1]);
        }
    }
}