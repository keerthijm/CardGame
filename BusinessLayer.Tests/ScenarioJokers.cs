using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class ScenarioJokers
    {
        [TestMethod]
        public void TestMethodJR()
        {
            var cards = new List<Card>
            {
                new JokerCard()
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(0, actualResult);
        }

        [TestMethod]
        public void TestMethodJRJR()
        {
            var cards = new List<Card>
            {
                new JokerCard(),
                new JokerCard()
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(0, actualResult);
        }

        [TestMethod]
        public void TestMethod2CJR()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Two},
                new JokerCard()
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(4, actualResult);
        }

        [TestMethod]
        public void TestMethoJR2CJR()
        {
            var cards = new List<Card>
            {
                new JokerCard(),
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Two},
                new JokerCard()
            };

            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(8, actualResult);
        }

        [TestMethod]
        public void TestMethodTCTDJRTHTS()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Ten}, // 10
                new Card {Suit = Suit.Diamond, CardNumber = CardNumber.Ten}, // 20
                new JokerCard(), // 40
                new Card {Suit = Suit.Heart, CardNumber = CardNumber.Ten}, // 30
                new Card {Suit = Suit.Spade, CardNumber = CardNumber.Ten} // 40
            };


            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(200, actualResult);
        }

        [TestMethod]
        public void TestMethodTCTDJRTHTSJR()
        {
            var cards = new List<Card>
            {
                new Card {Suit = Suit.Club, CardNumber = CardNumber.Ten}, // 10
                new Card {Suit = Suit.Diamond, CardNumber = CardNumber.Ten}, // 20
                new JokerCard(), // 40
                new Card {Suit = Suit.Heart, CardNumber = CardNumber.Ten}, // 30
                new Card {Suit = Suit.Spade, CardNumber = CardNumber.Ten}, // 40
                new JokerCard()
            };


            IOperateCard operateCard = new OperateCard();
            var actualResult = operateCard.CalculateScore(cards);

            Assert.AreEqual(400, actualResult);
        }


    }
}