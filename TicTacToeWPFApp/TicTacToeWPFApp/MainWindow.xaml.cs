using System.Windows;
using TicTacToeWPFApp.GameLogic;
using TicTacToeWPFApp.Models;

namespace TicTacToeWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window game = new GameWindow(new PlayerVsPlayerGameLogic( new Player('X', txtPlayer1.Text), 
                                                                      new Player('O', txtPlayer2.Text)
                                         ));
            game.ShowDialog();
        }
    }
}
