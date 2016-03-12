using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Tests
{
    [TestClass]
    public class ChessTests
    {
        [TestMethod]
        public void KnightVsBishop_KnightHitBishop_ReturnsKnight()
        { 
            var knightCoordinates = new object[] { 1, "A"};
            var bishopCoordinates = new object[] { 3, "C"};

            var winner = Chess.KnightVsBishop(knightCoordinates, bishopCoordinates);
            Assert.IsTrue(winner.Equals("Knight"));
        }
    }
}
