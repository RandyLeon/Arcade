using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Intro();
        }

        public static void Intro()
        {
            TicTacToe Toe = new TicTacToe();
            ChessBoard chessBoard = new ChessBoard();
            Console.WriteLine("Choose a game you would like to play!\na: Chess, b: TicTacToe");
            string x = Console.ReadLine();

            if (x == "a")
            {
                chessBoard.displayChessBoard();
            }
            else if (x == "m")
            {
                Intro();
            }
            else if (x == "b")
            {
                Toe.turn();
            }
        }
    }
}
