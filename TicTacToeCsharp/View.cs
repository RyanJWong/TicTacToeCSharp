using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeCsharp
{
    public class View
    {  
        public static void Move(Board board, Player player)
        {
            bool entered    = false;
            bool rowEntered = false;
            bool colEntered = false;
            int row = 0;
            int col = 0;

            while (!entered)
            {
                board.DisplayBoard();

                while (!rowEntered)
                {

                    Console.WriteLine("It is " + player.Name + "'s turn, please enter a row: ");
                    try
                    {
                        row = Int32.Parse(Console.ReadLine());
                        if (row < 4 && row > 0)
                        {
                            rowEntered = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a row between 1 and 3");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

                while (!colEntered)
                {

                    Console.WriteLine("It is " + player.Name + "'s turn, please enter a column: ");

                    try
                    {
                        col = Int32.Parse(Console.ReadLine());
                        if (col < 4 && col > 0)
                        {
                            colEntered = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a column between 1 and 3");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

                if (board.IsEmpty(row, col))
                {
                    entered = true;
                    board.SetCell(row, col, player.PlayerNumber);
                    Console.WriteLine();

                    board.DisplayBoard();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please enter an empty row, column pair");
                    rowEntered = false;
                    colEntered = false;
                }
            }

        }

        public static void DisplayDraw()
        {
            Console.WriteLine("No one won, game over.");
        }

        public static void DisplayWinner(Player player)
        {
            Console.WriteLine(player.Name + " has won the game!");
        }


        public static bool Menu()
        {
            bool running = true;
           
            Console.WriteLine("Welcome to Tic Tac Toe, enter a character to start a PvP game, or enter a blank line to exit the program");
               
            string input = Console.ReadLine();
            if (input.Length > 0)
            {
                Console.WriteLine("Starting a PvP game...\n");
            }
            else
            {
                Console.WriteLine("Thank you for playing loser!");
                running = false;
            }

            return running;
        }


        public static String GetPlayerName()
        {
            Boolean finished = false;
            String name = "";

            while (!finished)
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                if (name.Length > 0)
                {
                    finished = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid name.\n");
                }
            }

            Console.WriteLine("Your player name is: " + name + "\n");
            return name;
        }
    }
}
