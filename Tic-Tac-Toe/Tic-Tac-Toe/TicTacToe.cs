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

        public string playerOne = "Player One";
        public string playerTwo = "Player Two";



        public TicTacToe()
        {
           game = new int[3, 3];

        }

        public void GetTable() 
        {
            Console.WriteLine($"{game[0, 0]}{game[0, 1]}{game[0, 2]}\n{game[1, 0]}{game[1, 1]}{game[1, 2]}\n{game[2, 0]}{game[2, 1]}{game[2, 2]}");
        }
            
        public string DetermineWinner()
        {
            for(int i = 0; i <= 9; i++)
            {
                int luckyNumber = 0;
                switch (i)
                {
                    case 0: 
                        luckyNumber = game[0, 0] + game[1, 1] + game[2, 2];
                        break;
                    case 1:                       
                        luckyNumber = game[0, 2] + game[1, 1] + game[2, 0];
                        break;
                    case 2:
                        luckyNumber = game[0, 0] + game[0, 1] + game[0, 2];
                        break;
                    case 3:
                        luckyNumber = game[1, 0] + game[1, 1] + game[1, 2];
                        break;
                    case 4:
                        luckyNumber = game[2, 0] + game[2, 1] + game[2, 2];
                        break;
                    case 5:
                        luckyNumber = game[0, 0] + game[1, 0] + game[2, 0];
                        break;
                    case 6:
                        luckyNumber = game[0, 1] + game[1, 1] + game[2, 1];
                        break;
                    case 7:
                        luckyNumber = game[0, 2] + game[1, 2] + game[2, 2];
                        break;                   
                }

                if (luckyNumber == 3)
                {
                    return playerOne;
                }else if (luckyNumber == 6)
                {
                    return playerTwo;
                }
        
            }

            return null;

        }





    }

        
}
