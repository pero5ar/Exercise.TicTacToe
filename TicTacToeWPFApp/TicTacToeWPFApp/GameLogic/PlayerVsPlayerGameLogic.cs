using System;
using System.Collections.Generic;
using TicTacToeWPFApp.Models;

namespace TicTacToeWPFApp.GameLogic
{
    public class PlayerVsPlayerGameLogic : IGameLogic
    {
        private Player _playerOne;
        private Player _playerTwo;
        private MatrixGrid _matrix;

        public Player CurrentPlayer { get; private set; }

        public PlayerVsPlayerGameLogic(Player one, Player two)
        {
            _playerOne = one;
            _playerTwo = two;
            CurrentPlayer = _playerOne;
            _matrix = new MatrixGrid();
        }

        public bool HasWon()
        {
            return _matrix.InspectWinningCondition(CurrentPlayer.Mark);
        }
        
        public bool IsDraw()
        {
            return _matrix.IsMatrixGridFull();
        }

        public bool Move(int index)
        {
            return _matrix.SetElement(index, CurrentPlayer.Mark);
        }

        public void SwitchPlayer()
        {
            CurrentPlayer = (CurrentPlayer == _playerOne) ? _playerTwo : _playerOne;
        }

        public IList<WinningCondition> GetWinningConditions()
        {
            throw new NotImplementedException();
        }

    }
}
