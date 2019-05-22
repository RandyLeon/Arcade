using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade
{
   public class Pawn
    {
        public const char PAWN_SYMBOL = 'P';
        public const char SPACE = ' ';
        public static char[,] pawns;

        public Pawn()
        {
            pawns = new char[ChessBoard.DIMENISON, ChessBoard.DIMENISON];
            initPawn();//populate pawn array with X and spaces
        }

        private void initPawn()
        {
            for (int r = 0; r < ChessBoard.DIMENISON; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENISON; c++)
                {
                    //place pawns (X) into proper rows
                    if (r == 0 || r == 1 || r == ChessBoard.DIMENISON - 2 || r == ChessBoard.DIMENISON - 1)

                        pawns[r, c] = PAWN_SYMBOL;
                    else
                        pawns[r, c] = SPACE;

                }
            }
        }
    }
}
