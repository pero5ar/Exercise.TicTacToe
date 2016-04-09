namespace TicTacToeWPFApp.Models
{
    public class Player
    {
        public char Mark { get; }
        public string Name { get; set; }

        public Player(char mark, string name)
        {
            Mark = mark;
            Name = name;
        }
    }
}
