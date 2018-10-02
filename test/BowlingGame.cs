using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class BowlingGame
    {
        private readonly List<int> rolls = new List<int>();
        private int counter;

        public void Roll(int fallenPins)
        {
            rolls.Add(fallenPins);
            if (fallenPins == 10 && rolls.Count % 2 == 1)
                rolls.Add(0); // dirty hack, so that frames always take 2 indexes in the list
        }

        public int Score( )
        {
            var score = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                score += Score(frame);
            }

            return score;
        }

        private int Score(int frame)
        {
            if (IsStrike(frame))
                return NormalScoreOf(frame) + StrikeBonusOf(frame);
            if (IsSpare(frame))
                return NormalScoreOf(frame) + SpareBonusOf(frame);
            else
                return NormalScoreOf(frame);
        }

        private bool IsStrike(int frame)
        {
            return FirstRollOf(frame) == 10;
        }

        private int StrikeBonusOf(int frame)
        {
            if(IsStrike(frame+1))
            {
                return FirstRollOf(frame + 1) + FirstRollOf(frame + 2);
            }
            return FirstRollOf(frame+1) + SecondRollOf(frame+1);
        }

        private int SpareBonusOf(int frame)
        {
            return FirstRollOf(frame+1);
        }

        private int NormalScoreOf(int frame)
        {
            return FirstRollOf(frame) + SecondRollOf(frame);
        }

        private bool IsSpare(int frame)
        {
            return FirstRollOf(frame) + SecondRollOf(frame) == 10;
        }

        private int FirstRollOf(int frame)
        {
            return GetRoll(frame*2);
        }

        private int SecondRollOf(int frame)
        {
            return GetRoll((frame * 2)+1);
        }

        private int GetRoll(int index)
        {
            if (index < rolls.Count())
                return rolls[index];

            return 0;
        }
    }
}