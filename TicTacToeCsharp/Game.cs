using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace TicTacToeCsharp
{
    public class Game 
    { 


        
        public static void Play()
        {
            bool running = View.Menu();

            while (running)
            {
                
                bool playing = true;
                bool winner = false;
                int player = 1;
                int row;
                int col;
                Board board = new Board(3, 3);
                Player player1 = new Player(View.GetPlayerName(), 1);
                Player player2 = new Player(View.GetPlayerName(), 2);
                board.SetBoard();


                while (playing)
                {
                    if (player == 1)
                    {
                        View.Move(board, player1);

                        if (VerticalWin(player, board) || HorizontalWin(player, board) || DiagonalWin(player, board))
                        {
                            View.DisplayWinner(player1);
                            winner = true;
                            playing = false;
                        }

                        player = 2;
                    }

                    else
                    {
                        View.Move(board, player2);

                        if (VerticalWin(player, board) || HorizontalWin(player, board) || DiagonalWin(player, board))
                        {
                            View.DisplayWinner(player2);
                            winner = true;
                            playing = false;
                        }

                        player = 1;
                    }

                    if (!winner && GameIsADraw(board))
                    {
                        View.DisplayDraw();
                        playing = false;
                    }

                }
                running = View.Menu();
            }
        }

        public static bool GameIsADraw(Board board)
        {
            bool draw = true;
            for (int row = 1; row < 4; row++)
            {

                for (int col = 1; col < 4; col++)
                {
                    if (board.GetStatus(row, col).Equals(0))
                    {
                        draw = false;
                    }
                }
               
            }
            return draw;
        }

        public static bool VerticalWin (int id, Board board)
        {
            bool win = false;

            for (int col = 1; col < 4; col++)
            {
                int count = 0;
                for (int row = 1; row < 4; row++)
                {
                    if (board.GetStatus(row, col).Equals(id))
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    win = true;
                }
            }

            return win;
        }

        public static bool HorizontalWin (int id, Board board)
        {
            bool win = false;
            for (int row = 1; row < 4; row++)
            {
                int count = 0;

                for (int col = 1; col < 4; col++)
                {
                    if (board.GetStatus(row, col).Equals(id))
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    win = true;
                }
            }
            return win;
        }

        public static bool DiagonalWin (int id, Board board)
        {
            bool win = false;

            int count = 0;

            for (int row = 1; row < 4; row ++)
            {

                int col = row;

                if (board.GetStatus(row, col).Equals(id))
                {
                    count++;
                }
                
                
            }

            if (count == 3)
            {
                win = true;
            }

            if (!win)
            {
                count = 0;
                int col = 4;
                for (int row = 1; row < 4; row++)
                {
                    col --;
                    

                    if (board.GetStatus(row, col).Equals(id))
                    {
                        count++;
                    }
                    
                    
                }
            }

            if (count == 3)
            {
                win = true;
            }

            return win;
        }
    }
}
