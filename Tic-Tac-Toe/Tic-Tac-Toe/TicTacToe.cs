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
            else { a = 2; }

            game[a, b-1] = playerMove;
        
        }

        public void DetermineWinner()
        {

            for (int i = 0; i <= 9; i++)
            {
                string combo = "";
                
                switch (i)
                {
                    case 0:
                        combo =
                            game[0, 0].ToString() + game[1, 1].ToString() + game[2, 2].ToString();
                        break;
                    case 1:
                        combo =
                            game[0, 2].ToString() + game[1, 1].ToString() + game[2, 0].ToString();
                        break;
                    case 2:
                        combo =
                            game[0, 0].ToString() + game[0, 1].ToString() + game[0, 2].ToString();
                        break;
                    case 3:
                        combo =
                            game[1, 0].ToString() + game[1, 1].ToString() + game[1, 2].ToString();
                        break;
                    case 4:
                        combo =
                            game[2, 0].ToString() + game[2, 1].ToString() + game[2, 2].ToString();
                        break;
                    case 5:
                        combo =
                            game[0, 0].ToString() + game[1, 0].ToString() + game[2, 0].ToString();
                        break;
                    case 6:
                        combo =
                            game[0, 1].ToString() + game[1, 1].ToString() + game[2, 1].ToString();
                        break;
                    case 7:
                        combo =
                            game[0, 2].ToString() + game[1, 2].ToString() + game[2, 2].ToString();
                        break;
                }

                if (combo.Equals("111"))
                {
                    Console.WriteLine($"{playerOne}, you are the winner!");
                    Reset();

                }
                else if (combo.Equals("222"))
                {
                    Console.WriteLine($"{playerTwo}, you are the winner!");
                    Reset();

                }

                CheckForDraw();
            }
        }   

        public void CheckForDraw()
        {
            int counter = 0;
            for (int i = 0; i <= 2; i++)
            {
                if(game[0,i] != 0)
                {
                    counter++;
                }
                if(game[i,0] != 0)
                {
                    counter++;
                }
            }

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



   
   
        





   

        
