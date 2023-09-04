using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Board
{

    public static void DrawBoard(char[] board)
    {
        Console.Clear();

        Console.WriteLine("┌━━━┬━━━┬━━━┐");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("│ ");

            for (int j = 0; j < 3; j++)
            {
                char symbol = board[i * 3 + j];
                ConsoleColor originalColor = Console.ForegroundColor;

                if (symbol == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (symbol == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Write($"{symbol} ");
                Console.ForegroundColor = originalColor;

                if (j < 2)
                {
                    Console.Write("│ ");
                }
            }

            Console.WriteLine("│");

            if (i < 2)
            {
                Console.WriteLine("├━━━┼━━━┼━━━┤");
            }
        }

        Console.WriteLine("└━━━┴━━━┴━━━┘");
    }

    public static void Reset(char[] board)
    {
        for (int i = 0;i < board.Length;i++)
        {
            board[i] = ' ';
        }
    }
}

