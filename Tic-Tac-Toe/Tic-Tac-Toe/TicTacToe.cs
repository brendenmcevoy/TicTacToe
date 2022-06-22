using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToe
    {
        private readonly int[,] game;
        public string playerOne = "Player One";
        public string playerTwo = "Player Two";



        public TicTacToe() => game = new int[3, 3];

        

        public void GetTable() 
        {
            Console.WriteLine($"\n\t{game[0, 0]}{game[0, 1]}{game[0, 2]}\n\t{game[1, 0]}{game[1, 1]}{game[1, 2]}\n\t{game[2, 0]}{game[2, 1]}{game[2, 2]}\n");
        }

        public void MakeMove(char one, int b, int playerMove)
        {
            int a = 0;

            if (one == 'a')
            {
                a = 0;
            }
            else if (one == 'b')
            {
                a = 1;
            }
            else if (one == 'c')
            {
                a = 2;
            }
            else { Console.WriteLine("Incorrect character."); }

            try
            {
                if (game[a, b - 1] == 1 || game[a, b - 1] == 2)
                {
                    Console.WriteLine("Space already taken, try another move.");
                }
                else { game[a, b - 1] = playerMove; }
            }
            catch (IndexOutOfRangeException ex)
            {   
               Console.WriteLine(ex.Message);
                Console.WriteLine("Number must be 1, 2, or 3.");
            }                                  
        }

        public int DetermineWinner()
        {

            for (int i = 0; i < 3; i++)
            {
                if((game[i, 0] != 0 && game [i,1] != 0 && game[i,2] != 0) && (game [i, 0] == game[i,1]) && game[i,1] == game[i, 2])
                {
                    return game[i, 0];
                }

                if ((game[0, 0] != 0 && game[1, 1] != 0 && game[2,2] != 0) && (game[0, 0] == game[1, 1]) && game[1, 1] == game[2, 2])
                {
                    return game[0, 0];
                }

                if ((game[0, 2] != 0 && game[1, 1] != 0 && game[2,0] != 0) && (game[0, 2] == game[1, 1]) && game[1, 1] == game[2, 0])
                {
                    return game[0, 0];
                }

                if ((game[0, 0] != 0 && game[0, 1] != 0 && game[0,2] != 0 && game[1,0] != 0 && game[1,1] != 0 && game[1,2] != 0 && game[2,0] != 0 && game[2,1] != 0 && game[2,2] != 0))
                {
                    return 3;
                }
            }
            return 0;
        }   
                
        public void Reset()
        {                        
            game[0, 0] = 0;
            game[0, 1] = 0;
            game[0, 2] = 0;
            game[1, 0] = 0;
            game[1, 1] = 0;
            game[1, 2] = 0;
            game[2, 0] = 0;
            game[2, 1] = 0;
            game[2, 2] = 0;

            GetTable();            
        }
    }
}



   
   
        





   

        
