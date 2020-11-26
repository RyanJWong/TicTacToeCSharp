using System;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using System.Text;

namespace TicTacToeCsharp
{
    public class Board
    {
        private int _rows;
        private int _cols;
       
        public int[,] board;

        public Board(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;

            board = new int [_rows, _cols];
        }

        

        public int GetStatus (int row, int col)
        {
            return board[row-1, col-1];
        }

        public bool IsEmpty (int row, int col)
        {
            bool empty = false;
            if (board[row-1, col-1] == 0)
            {
                empty = true;
            }
            return empty;
        }


        public void SetCell (int row, int col, int value)
        {
            board[row-1, col-1] = value;
        }

        public void SetBoard()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = 0;
                }
            }
        }

        public void DisplayBoard()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    int cell = board[row, col];

                    if (cell == 0)
                    {
                        if (col == 0 || col == 1)
                        {
                            Console.Write("   |");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    else if (cell == 1)
                    {
                        if (col == 0 || col == 1)
                        {
                            Console.Write(" X |");
                        }
                        else
                        {
                            Console.Write(" X ");
                        }
                    }
                    else
                    {
                        if (col == 0 || col == 1)
                        {
                            Console.Write(" O |");
                        }
                        else
                        {
                            Console.Write(" O ");
                        }
                    }
                    if (col == 2)
                    {
                        Console.WriteLine();
                    }
                }
                if (row == 0 || row ==1 )
                {
                    Console.WriteLine("-----------");
                }
            }
              
        }
    }
}
