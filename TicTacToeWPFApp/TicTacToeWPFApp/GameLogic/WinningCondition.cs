using System;
using TicTacToeWPFApp.Models;

namespace TicTacToeWPFApp.GameLogic
{
    public class WinningConditionAttribute : Attribute
    {
        public int[] Indexes { get; }
        internal WinningConditionAttribute(int i, int j, int k)
        {
            Indexes = new int[] { i, j, k };
        }
    }

    public enum WinningCondition
    {
        [WinningConditionAttribute((int)MatrixIndex.UPPER_LEFT, (int)MatrixIndex.UPPER_CENTER, (int)MatrixIndex.UPPER_RIGHT)] FIRST_ROW,
        [WinningConditionAttribute((int)MatrixIndex.CENTER_LEFT, (int)MatrixIndex.CENTER, (int)MatrixIndex.CENTER_RIGHT)] SECOND_ROW,
        [WinningConditionAttribute((int)MatrixIndex.BOTTOM_LEFT, (int)MatrixIndex.BOTTOM_CENTER, (int)MatrixIndex.BOTTOM_RIGHT)] THIRD_ROW,

        [WinningConditionAttribute((int)MatrixIndex.UPPER_LEFT, (int)MatrixIndex.CENTER_LEFT, (int)MatrixIndex.BOTTOM_LEFT)] FIRST_COLUMN,
        [WinningConditionAttribute((int)MatrixIndex.UPPER_CENTER, (int)MatrixIndex.CENTER, (int)MatrixIndex.BOTTOM_CENTER)] SECOND_COLUMN,
        [WinningConditionAttribute((int)MatrixIndex.UPPER_RIGHT, (int)MatrixIndex.CENTER_RIGHT, (int)MatrixIndex.BOTTOM_RIGHT)] THIRD_COLUMN,

        [WinningConditionAttribute((int)MatrixIndex.UPPER_LEFT, (int)MatrixIndex.CENTER, (int)MatrixIndex.BOTTOM_RIGHT)] MAIN_DIAGONAL,
        [WinningConditionAttribute((int)MatrixIndex.UPPER_RIGHT, (int)MatrixIndex.CENTER, (int)MatrixIndex.BOTTOM_LEFT)] SECONDARY_DIAGONAL
    }
}
