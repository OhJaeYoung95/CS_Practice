using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904
{
    internal class TicTacToe
    {
        private static bool isGameEnd = false;
        public static bool IsGameEnd
        {
            get { return isGameEnd; }
            set { isGameEnd = value; }
        }
        static void Main(string[] args)
        {
            char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            Board.DrawBoard(board);
            Console.SetCursorPosition(2, 1);

            while (!isGameEnd)
            {
                Player.UseTurn(board);
            }
        }
    }
}