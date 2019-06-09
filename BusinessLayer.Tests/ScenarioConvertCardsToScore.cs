using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class ScenarioConvertCardsToScore
    {
        [TestMethod]
        public void TestMethod2C()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Two}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(2, actualResult);
        }

        [TestMethod]
        public void TestMethod2D()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Diamond, CardNumber = CardNumber.Two}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(4, actualResult);
        }

        [TestMethod]
        public void TestMethod2H()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Heart, CardNumber = CardNumber.Two}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(6, actualResult);
        }

        [TestMethod]
        public void TestMethod2S()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Spade, CardNumber = CardNumber.Two}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(8, actualResult);
        }

        [TestMethod]
        public void TestMethodTC()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Ten}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(10, actualResult);
        }


        [TestMethod]
        public void TestMethodJC()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Jack}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(11, actualResult);
        }

        [TestMethod]
        public void TestMethodQC()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Queen}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(12, actualResult);
        }

        [TestMethod]
        public void TestMethodKC()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.King}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(13, actualResult);
        }

        [TestMethod]
        public void TestMethodAC()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Ace}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(14, actualResult);
        }


        [TestMethod]
        public void TestMethod3C4C()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Three},
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Four}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(7, actualResult);
        }

         [TestMethod]
        public void TestMethodTCTDTHTS()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Ten},
                new Card {Suit = Suit.Diamond, CardNumber = CardNumber.Ten},
                new Card {Suit = Suit.Heart, CardNumber = CardNumber.Ten},
                new Card {Suit = Suit.Spade, CardNumber = CardNumber.Ten}
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(500, actualResult);
        }

        [TestMethod]
        public void TestMethodACADAHAS()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Ace}, // 14* 1 = 14
                new Card {Suit = Suit.Diamond, CardNumber = CardNumber.Ace}, // 14* 2 = 28
                new Card {Suit = Suit.Heart, CardNumber = CardNumber.Ace}, // 14* 3 = 42
                new Card {Suit = Suit.Spade, CardNumber = CardNumber.Ace} // 14* 4 = 56
                // Total is 140 + Additional 400
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(540, actualResult);
        }

    }
}
