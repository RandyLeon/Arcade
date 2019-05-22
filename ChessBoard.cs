﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
    public class ChessBoard
    {
        private string[,] chessBoard;
        public const int DIMENISON = 8; // original 8x8 board

        private Move move;

        public ChessBoard()
        {
            move = new Move();
            chessBoard = new string[DIMENISON, DIMENISON];
            ChessBoardHorizontalSymbol = "+---";
            ChessBoardVerticalSymbol = "| ";

        }

        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }

        public void displayChessBoard()
        {
            while (!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");//x axis header

                for (int r = 0; r < DIMENISON; r++)
                {
                    Console.Write(" ");//left spacing - 2 spaces
                    for (int c = 0; c < DIMENISON; c++)
                    {
                        Console.Write(ChessBoardHorizontalSymbol);//write the horizontal pattern
                    }

                    Console.Write("+\n");

                for (int c = 0; c < DIMENISON; c++)
                {
                    if (c == 0)
                    { 
                        Console.Write(r + " ");//y axis header
                        Console.Write(ChessBoardVerticalSymbol + Pawn.pawns[r, c] + " ");//diplay the pawn neatly centered
                }
                    }

                    Console.Write("|\n");
                }

            //the bottom line needs to be printed seperately
            Console.Write(" "); //left spacing
            for (int c = 0; c < DIMENISON; c++)
            {
                Console.Write(ChessBoardHorizontalSymbol);
            }

            Console.Write("+\n\n");
                move.MakeMove();
            }
        }
    }
}
