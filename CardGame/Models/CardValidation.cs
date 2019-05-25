using System.Collections.Generic;
using BusinessLayer;

namespace CardGame.Models
{
    public class CardValidation
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }


    public class RealCards
    {
        private readonly string[] _cards;

        public CardValidation CardValidation;

        public RealCards(string[] cards)
        {
            _cards = cards;
            _RealCards = GetCardList();
            if (CardValidation == null)
                CardValidation = new CardValidation
                {
                    IsSuccess = true
                };
        }

        public List<Card> _RealCards { get; }

        public List<Card> GetCardList()
        {
            var jokerCount = 0;
            var realCards = new List<Card>();

            var hashSet = new HashSet<string>();
            var isDuplicate = false;
            foreach (var eachCard in _cards)
                if (eachCard != "JR")
                    if (!hashSet.Add(eachCard))
                    {
                        isDuplicate = true;
                        SetCardValidationResults(ErrorMessage.Duplicated);
                        break;
                    }

            if (isDuplicate) return realCards;
            foreach (var card in _cards)
                if (card.Length == 2)
                {
                    switch (card)
                    {
                        case "JR":

                            var itsJoker = new JokerCard();
                            jokerCount += 1;
                            if (jokerCount > 2)
                            {
                                SetCardValidationResults(ErrorMessage.TowJokers);
                                break;
                            }

                            realCards.Add(itsJoker);
                            break;
                        default:
                            var charArr = card.ToCharArray();
                            var cardNumber = GetCardNumberFromChar(charArr[0]);
                            if (cardNumber != CardNumber.Zero)
                            {
                                var cardSuit = GetCardSuitFromChar(charArr[1]);
                                if (cardSuit != Suit.None)
                                {
                                    var itsCard = new Card
                                    {
                                        Suit = cardSuit,
                                        CardNumber = cardNumber
                                    };
                                    realCards.Add(itsCard);
                                }
                                else
                                {
                                    SetCardValidationResults(ErrorMessage.NotRecognised);
                                }
                            }
                            else
                            {
                                SetCardValidationResults(ErrorMessage.NotRecognised);
                            }

                            break;
                    }
                }
                else
                {
                    SetCardValidationResults(ErrorMessage.InvalidInputString);
                    break;
                }

            return realCards;
        }

        private Suit GetCardSuitFromChar(char v)
        {
            if (v == 'H')
                return Suit.Heart;
            if (v == 'C')
                return Suit.Club;
            if (v == 'D')
                return Suit.Diamond;
            if (v == 'S')
                return Suit.Spade;
            return Suit.None;
        }

        private CardNumber GetCardNumberFromChar(char charArr)
        {
            if (charArr == 'T')
                return CardNumber.Ten;
            if (charArr == 'J')
                return CardNumber.Jack;
            if (charArr == 'Q')
                return CardNumber.Queen;
            if (charArr == 'A')
                return CardNumber.Ace;
            if (charArr == 'K')
                return CardNumber.King;
            if (charArr == '2')
                return CardNumber.Two;
            if (charArr == '3')
                return CardNumber.Three;
            if (charArr == '4')
                return CardNumber.Four;
            if (charArr == '5')
                return CardNumber.Five;
            if (charArr == '6')
                return CardNumber.Six;
            if (charArr == '7')
                return CardNumber.Seven;
            if (charArr == '8')
                return CardNumber.Eight;
            if (charArr == '9')
                return CardNumber.Nine;
            return CardNumber.Zero;
        }

        private void SetCardValidationResults(string message)
        {
            CardValidation = new CardValidation {Message = message, IsSuccess = false};
        }
    }
}