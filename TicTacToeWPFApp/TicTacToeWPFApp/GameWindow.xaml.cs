using System.Windows;
using System.Windows.Controls;
using TicTacToeWPFApp.GameLogic;

namespace TicTacToeWPFApp
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private IGameLogic _game;

        public GameWindow(IGameLogic game)
        {
            _game = game;
            InitializeComponent();
            UpdateStatus("Player " + _game.CurrentPlayer.Name + " is on the move");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var index = btn.DataContext;
            if ( _game.Move((int)index) )
            {
                btn.IsEnabled = false;
                btn.Content = _game.CurrentPlayer.Mark.ToString();
                if ( _game.HasWon() )
                {
                    UpdateStatus("PLAYER " + _game.CurrentPlayer.Name + " WINS!");
                    GameOver();
                }
                else if ( _game.IsDraw() )
                {
                    UpdateStatus("DRAW!");
                    GameOver();
                }
                else
                {
                    _game.SwitchPlayer();
                    UpdateStatus("Player " + _game.CurrentPlayer.Name + " is on the move");
                }
            }
        }

        private void GameOver()
        {
            foreach (Button btn in Helper.GetLogicalChildCollection<Button>(this))
            {
                btn.IsEnabled = false;
            }
        }

        private void UpdateStatus(string message)
        {
            this.Title = message;
        }
    }
}
