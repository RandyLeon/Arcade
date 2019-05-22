using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{

    public class TicTacToe : Program
    {
        
        static String[] board = new String[9];
        public String playAgain = "Y";
        public int counter = 0;

        static void Initialize()
        {
            for (int i = 0; i < 10; i++)
            {
                board[i] = i.ToString();
            }
        }

        public void playsAgain(string message)
        {
            Console.WriteLine(message + "Do you want to play again?");
            if (Console.ReadLine().Equals("Y"))
            {
                playAgain.Equals("Y");
            }
            else
            {
                playAgain.Equals("N");
            }
        }
        public void turn()
        {
            Hello();
            drawboard();
            Initialize();
            while (won() == false || counter < 9)
            {
                player("x");
                if (won() == true)
                {
                    break;
                }
                player("o");
            }
            if (won() == true)
                playsAgain("congrats");
            else
                playsAgain("sorry");
            goodbye();
            Intro();
        }

        public void goodbye()
        {
            Console.WriteLine("Bye");
        }


        private void Hello()
        {
            Console.WriteLine("this is tic tac toe");
        }


        public void player(string Player)
        {
            Console.Clear();
            Console.WriteLine($"Your turn {Player}");
            int selection;

            while (true)
            {
                Console.WriteLine("Choose where you woud like to place your move good sir");
                drawboard();
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 0 || selection > 9 || board[selection].Equals("x") || board[selection].Equals("o"))
                {
                    Console.WriteLine("Invalid selection!");
                }
                else
                {
                    break;
                }
            }

            board[selection] = Player;
        }

        public void drawboard()
        {
            for (int i = 0; i < 7; i += 3)
            {

                Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);

            }
        }

        public Boolean won()
        {
            for (int i = 0; i < 7; i += 3)
            {
                if (board[i].Equals(board[i + 1]) && board[i + 1].Equals(board[1 + 2]))
                {
                    return true;
                }
            }
            if (board[0].Equals(board[3]) && board[3].Equals(board[6]))
                return true;
            if (board[0].Equals(board[4]) && board[4].Equals(board[7]))
                return true;
            if (board[0].Equals(board[5]) && board[3].Equals(board[8]))
                return true;
            if (board[2].Equals(board[4]) && board[4].Equals(board[6]))
                return true;
            if (board[0].Equals(board[4]) && board[4].Equals(board[8]))
                return true;
            return false;

        }
    }
}
