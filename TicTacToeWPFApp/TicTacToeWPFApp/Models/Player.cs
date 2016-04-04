namespace TicTacToeWPFApp.Models
{
    public class Player
    {
        protected MatrixGrid _matrix;
        public char Mark { get; }
        public string Name { get; set; }

        public Player(MatrixGrid matrix, char mark, string name)
        {
            _matrix = matrix;
            Mark = mark;
            Name = name;
        }

        public virtual bool MakeAMove(int index)
        {
            return _matrix.SetElement(index, Mark);
        }
    }
}
