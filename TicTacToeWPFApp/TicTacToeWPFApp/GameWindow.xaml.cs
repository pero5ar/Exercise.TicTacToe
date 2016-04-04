using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TicTacToeWPFApp.Models;

namespace TicTacToeWPFApp
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private Player[] _players;
        private MatrixGrid _matrix;
        public GameWindow(string firstPlayerName, string secondPlayerName)
        {
            _matrix = new MatrixGrid();
            _players = new Player[2];
            _players[1] = new Player(_matrix, 'X', firstPlayerName);
            _players[2] = new Player(_matrix, 'O', secondPlayerName);
            InitializeComponent();
        }
        
    }
}
