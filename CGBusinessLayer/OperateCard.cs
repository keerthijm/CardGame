using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class OperateCard : IOperateCard
    {
        public int CalculateScore(List<Card> cards)
        {
            var score = 0;
            var countJoker = cards.Count(i => i.IsJoker);
            foreach (var card in cards)
            {
                var temp = card.GetValue();
                if (!card.IsJoker) score += temp;
            }

            for (var i = 1; i <= countJoker; i++) score *= 2;

            return score;
        }
    }
}