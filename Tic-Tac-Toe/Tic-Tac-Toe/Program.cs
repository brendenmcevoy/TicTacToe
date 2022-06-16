using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main()
        {

            TicTacToe game = new();
            
            Console.WriteLine("Player One, you will be marker '1'.\nPlayer Two, you will be marker '2'.");
            Console.WriteLine("Players, take turns inputing a coordinate to make a play.\n The rows are labeled as follows (top to bottom) 'a, b, c'\n The columns are labeled as follows (left to right) '1,2,3'.");

            game.GetTable();

            for (int c = 0; c <= 9; c++)
            {
                int playerTurn;

                Console.WriteLine($"Input 'a, b, or c'.");
                var move1 = char.Parse(Console.ReadLine());
               
                Console.WriteLine("Input '1, 2, or 3.'");
                var move2 = int.Parse(Console.ReadLine());

                if (c % 2 == 0) 
                {
                    playerTurn = 1;
                }
                else { playerTurn = 2; }

                game.MakeMove(move1, move2, playerTurn);
                game.GetTable();
                game.DetermineWinner();              
            }
            

            

            

            

            
            

           
        }
    }
}
