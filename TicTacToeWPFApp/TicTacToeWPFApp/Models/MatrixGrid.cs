namespace TicTacToeWPFApp.Models
{
    /// <summary>
    /// The Tic-Tac-Toe grid.
    /// Internally indexed as an 1D array:
    ///     <example>
    ///         0 | 1 | 2
    ///         ---------
    ///         3 | 4 | 5 
    ///         ---------
    ///         6 | 7 | 8 
    ///     </example>
    /// </summary>
    public class MatrixGrid
    {
        private char[] _matrix;

        private const int SIZE = 9;
        private const int ORDER = 3;
        private const int NON_EXISTENT = -1;

        public const int MAIN_DIAGONAL = 1;
        public const int SECONDARY_DIAGONAL = 2;


        public MatrixGrid()
        {
            _matrix = new char[SIZE];
        }

        public bool IsElementEmpty(int index)
        {
            if (_matrix[index] == 0)
            {
                return true;
            }
            return false;
        }

        public bool SetElement(int index, char mark)
        {
            if (!IsElementEmpty(index))
            {
                return false;
            }
            _matrix[index] = mark;
            return true;
        }

        public bool InspectWinningCondition(char mark)
        {
            if (FindWinningRow(mark) != NON_EXISTENT)
            {
                return true;
            }
            if (FindWinningColumn(mark) != NON_EXISTENT)
            {
                return true;
            }
            if (FindWinningDiagonal(mark) != NON_EXISTENT)
            {
                return true;
            }
            return false;
        }

        public int FindWinningRow(char mark)
        {
            for (int i = 0; i < SIZE; i += ORDER)
            {
                if (_matrix[i] != mark)
                {
                    continue;
                }
                if ((_matrix[i] == _matrix[i + 1]) && (_matrix[i] == _matrix[i + 2]))
                {
                    return (i / ORDER);
                }
            }
            return NON_EXISTENT;
        }

        public int FindWinningColumn(char mark)
        {
            for (int i = 0; i < ORDER; i++)
            {
                if (_matrix[i] != mark)
                {
                    continue;
                }
                if ((_matrix[i] == _matrix[i + 1*ORDER]) && (_matrix[i] == _matrix[i + 2*ORDER]))
                {
                    return i;
                }
            }
            return NON_EXISTENT;
        }
        
        public int FindWinningDiagonal(char mark)
        {
            if (_matrix[(int)MatrixIndex.CENTER] == mark)
            {
                if ((_matrix[(int)MatrixIndex.UPPER_LEFT] == mark) && (_matrix[(int)MatrixIndex.BOTTOM_RIGHT] == mark))
                {
                    return MAIN_DIAGONAL;
                }
                if ((_matrix[(int)MatrixIndex.UPPER_RIGHT] == mark) && (_matrix[(int)MatrixIndex.BOTTOM_LEFT] == mark))
                {
                    return SECONDARY_DIAGONAL;
                }
            }
            return NON_EXISTENT;
        }
    }

    public enum MatrixIndex
    {
        UPPER_LEFT = 0,
        UPPER_CENTER = 1,
        UPPER_RIGHT = 2,

        CENTER_LEFT = 3,
        CENTER = 4,
        CENTER_RIGHT = 5,

        BOTTOM_LEFT = 6,
        BOTTOM_CENTER = 7,
        BOTTOM_RIGHT = 8
    }
}
