using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main()
        {

            TicTacToe game = new();
            game.GetTable();

            Console.WriteLine("Player One, you will be marker '1'.\nPlayer Two, you will be marker '2'.");
            Console.WriteLine("Player One, input a coordinate to make a play. ex. '1,1 or 2,2");
            var p1Move = int.Parse(Console.ReadLine());
            

            

            

            
            

           
        }
    }
}
