using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class OperateCard : IOperateCard
    {
        public int CalculateScore(List<Card> cards)
        {
            var score = 0;
            List<int> tempCardValues = new List<int>();
            var countJoker = cards.Count(i => i.IsJoker);

            foreach (var card in cards)
            {
                var temp = card.GetValue();
                if (!card.IsJoker)
                {
                    score += temp;
                    tempCardValues.Add((int)card.CardNumber);
                }
            }

            for (var i = 1; i <= countJoker; i++) score *= 2;

            score = ScoreBasedonSameCardDuplicateAppearence(countJoker, score, tempCardValues);

            return score;
        }

        private static int ScoreBasedonSameCardDuplicateAppearence(int jockerCount, int score, List<int> tempCardValues)
        {
            // Check if temp has same values more then twice
            if (jockerCount == 0)
            {
                var duplicateExists = tempCardValues.GroupBy(n => n).Any(g => g.Count() > 1);
                if (duplicateExists)
                {
                    // Duplicates exist
                    score += 400;
                }
            }

            return score;
        }
    }
}
