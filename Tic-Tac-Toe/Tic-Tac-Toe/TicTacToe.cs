using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToe
    {
        private int[,] game;

        private string playerOne;

        private string playerTwo;


        public TicTacToe()
        {
            game = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                              
        }

        public void BeginGame(string playerName, string player2Name)
        {

        }
        public void MakeMove(string player, int location)
        {

        }

        public void DetermineWinner()
        {

        }
    }
}
