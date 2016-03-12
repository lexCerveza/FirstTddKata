using System.Collections.Generic;

namespace Kata
{
    public class Chess
    {
        private const int _letterOrNumberCount = 8;

        public static string KnightVsBishop(object[] knightCoordinates, object[] bishopCoordinates)
        {
            var knightHitPoints = new List<object[]>();
            var currentKnightPositionNumber = (int) knightCoordinates[0];
            var currentKnightPositionLetter = (string)knightCoordinates[1];

            while (currentKnightPositionNumber < _letterOrNumberCount)
            {
                currentKnightPositionLetter = GetNextLetterOnChessBoard(currentKnightPositionLetter);
                knightHitPoints.Add(
                    new object[] { ++currentKnightPositionNumber,
                                   currentKnightPositionLetter });
            }

            foreach (var hit in knightHitPoints)
            {
                if (hit[0].Equals(bishopCoordinates[0]) && hit[1].Equals(bishopCoordinates[1]))
                {
                    return "Knight";
                }
            }

            return string.Empty;
        }

        private static string GetNextLetterOnChessBoard(string inputString)
        {
            return (++inputString.ToCharArray()[0]).ToString();
        }
    }
}
