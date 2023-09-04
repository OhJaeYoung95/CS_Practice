using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0904
{
    enum PlayerTurn
    {
        O,
        X
    };
    internal class Player
    {
        static PlayerTurn playerTurn = PlayerTurn.O;
        static char playerSymbol = 'O';
        static int placeCursorX = 2;
        static int placeCursorY = 1;

        static bool isSelectRestart = false;
        static bool isNotOverlappiing = false;
        static bool isNotFill = true;

        public static void UseTurn(char[] board)
        {
            Console.SetCursorPosition(placeCursorX, placeCursorY);
            if(!isSelectRestart)
                Choice(board);
            CheckRule(board);
        }

        public static void Choice(char[] board)
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);

            // 가로는 4 씩 증가
            // 세로는 2 씩 증가
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    placeCursorY -= 2;
                    if(placeCursorY <= 0)
                    {
                        placeCursorY = 5;
                    }
                    break;
                case ConsoleKey.A:
                    placeCursorX -= 4;
                    if (placeCursorX <= 0)
                    {
                        placeCursorX = 10;
                    }
                    break;
                case ConsoleKey.S:
                    placeCursorY += 2;
                    if (placeCursorY >= 6)
                    {
                        placeCursorY = 1;
                    }
                    break;
                case ConsoleKey.D:
                    placeCursorX += 4;
                    if(placeCursorX >= 11)
                    {
                        placeCursorX = 2;
                    }
                    break;
                case ConsoleKey.Enter:
                    if(playerTurn == PlayerTurn.O)
                    {
                        playerSymbol = 'O';
                        if (board[(placeCursorY / 2) * 3 + placeCursorX / 4] == ' ')
                        {
                            board[(placeCursorY / 2) * 3 + placeCursorX / 4] = playerSymbol;
                            isNotOverlappiing = true;
                        }
                        else
                        {
                            isNotOverlappiing = false;
                        }
                    }
                    else
                    {
                        playerSymbol = 'X';
                        if(board[(placeCursorY / 2) * 3 + placeCursorX / 4] == ' ')
                        {
                            board[(placeCursorY / 2) * 3 + placeCursorX / 4] = playerSymbol;
                            isNotOverlappiing = true;
                        }
                        else
                        {
                            isNotOverlappiing = false;
                        }

                    }
                    if(isNotOverlappiing)
                    {
                        playerTurn += 1;
                        playerTurn = (PlayerTurn)((int)playerTurn % 2);
                        Board.DrawBoard(board);
                        Console.SetCursorPosition(placeCursorX, placeCursorY);
                    }
                    break;
            }
        }

        public static void CheckRule(char[] board)
        {
            for(int i = 0; i < 3; ++i)
            {
                if(board[i * 3 + 0] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2] && board[i* 3 + 0] == playerSymbol)
                {
                    PrintResult(board);
                    break;
                }
                else if(board[0 * 3 + i] == board[1 * 3 + i] && board[1 * 3 + i] == board[2 * 3 + i] && board[0* 3 + i] == playerSymbol)
                {
                    PrintResult(board);
                    break;
                }
                else if (board[0] == board[4] && board[4] == board[8] && board[0] == playerSymbol)
                {
                    PrintResult(board);
                    break;
                }
                else if (board[2] == board[4] && board[4] == board[6] && board[2] == playerSymbol)
                {
                    PrintResult(board);
                    break;
                }
            }

            foreach (var c in board)
            {
                if(c == ' ')
                {
                    isNotFill = true;
                    break;
                }
                isNotFill = false;
            }


            if(!isNotFill)
            {
                PrintResult(board);
            }
        }

        public static void PrintResult(char[] board)
        {
            Console.SetCursorPosition(15, 2);
            if(isNotFill)
            {
                StringBuilder whoWin = new StringBuilder();
                whoWin.Append("Player");
                whoWin.Append(playerSymbol);
                whoWin.Append(" is Win!");
                Console.WriteLine(whoWin);
            }
            else
            {
                Console.WriteLine("무승부!");
            }

            RestartInfo(board);
            Board.DrawBoard(board);

        }

        public static void RestartInfo(char[] board)
        {
            isSelectRestart = true;
            Console.SetCursorPosition(15, 4);
            Console.WriteLine("이어서 하시겠습니까?");
            Console.SetCursorPosition(15, 6);
            Console.WriteLine("Yes : Enter / No : Esc");

            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Board.Reset(board);
                    Board.DrawBoard(board);
                    Reset();
                    TicTacToe.IsGameEnd = false;
                    isSelectRestart = false;
                    break;
                case ConsoleKey.Escape:
                    TicTacToe.IsGameEnd = true;
                    break;
            }
        }

        public static void Reset()
        {
            placeCursorX = 2;
            placeCursorY = 1;
            playerTurn = PlayerTurn.O;
            playerSymbol = 'O';
            Console.SetCursorPosition(placeCursorX, placeCursorY);
        }
    }
}
