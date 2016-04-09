using System.Collections.Generic;
using TicTacToeWPFApp.Models;

namespace TicTacToeWPFApp.GameLogic
{
    public interface IGameLogic
    {
        bool Move(int index);

        Player CurrentPlayer { get; }

        void SwitchPlayer(); 

        bool HasWon();

        bool IsDraw();

        IList<WinningCondition> GetWinningConditions();
    }
}
