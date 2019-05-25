using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IOperateCard
    {
        int CalculateScore(List<Card> cards);
    }
}