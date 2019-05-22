using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
    public class Move : Pawn
    {
        private int targetX;
        private int targetY;
        private int destinationX;
        private int destinationY;

        public Move()
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
            Exit = false;
        }

        public bool Exit { get; set; }

        public void MakeMove()
        {
            getInput();
            if(!Exit)
            rearrangePawns();
        }

        private void getInput()
        {
            //get input and validate it 
            //the program runs until user enters invalid input
            Console.WriteLine("Enter Target's X asix");
            Exit = validateInput(int.TryParse(Console.ReadLine(), out targetX));

            if (!Exit)//if we passed the previos validation, movt to the next coordinates
            {
                Console.WriteLine("Enter Target's Y asix");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out targetY));
            }

            if (!Exit)//if we passed the previos validation, movt to the next coordinates
            {
                Console.WriteLine("Enter Target's X asix");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationX));
            }


            if (!Exit)//if we passed the previos validation, movt to the next coordinates
            {
                Console.WriteLine("Enter Target's Y asix");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationY));
            }
        }

        private bool validateInput(bool parsed)
        {
            bool error = false;

            if (!parsed)
                error = true;
            else if (targetX < 0 || targetX < 0 || destinationX < 0 || destinationY < 0)
                error = true;
            else if (targetX > ChessBoard.DIMENISON - 1 || targetY > ChessBoard.DIMENISON - 1 ||
                destinationX > ChessBoard.DIMENISON - 1 || destinationY > ChessBoard.DIMENISON - 1)
                error = true;
            if (error)
                Console.WriteLine("Invalid input. Exiting program now!");
            return error;
        }

        private void rearrangePawns()
        {
            pawns[destinationY, destinationY] = pawns[targetX, targetY];//place the symbol of the target into the destination coordinates
            pawns[targetX, targetY] = SPACE; //set the target symbol to space
        }
    }
}
