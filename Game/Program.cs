using System;
using System.Collections.Generic;

namespace Game
{
    class Player
    {
        public int X;
        public int Y;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        static void PrintBoard(int playerX, int playerY, int boardX, int boardY)
        {
            for (int y = 0; y < boardY; y++)
            {
                string line = "";
                for (int x = 0; x < boardX; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        line += "x ";
                    }
                    else
                    {
                        line += "- ";
                    }
                }
                Console.WriteLine(line);
            }
        }
        static void Main(string[] args)
        {
            bool run = true;
            Dictionary<string, int> boardSize = new Dictionary<string, int>();
            boardSize["X"] = 4;
            boardSize["Y"] = 4;
            Player plr = new Player((int)Math.Floor((double)boardSize["X"] / 2), (int)Math.Floor((double)boardSize["Y"] / 2));

            PrintBoard(plr.X, plr.Y, boardSize["X"], boardSize["Y"]);

            do
            {
                ConsoleKey input = Console.ReadKey(false).Key;
                if (input == ConsoleKey.W || input == ConsoleKey.UpArrow)
                {
                    if (plr.Y > 0)
                    {
                        plr.Y--;
                    }
                }
                else if (input == ConsoleKey.S || input == ConsoleKey.DownArrow)
                {
                    if (plr.Y < boardSize["Y"] - 1)
                    {
                        plr.Y++;
                    }
                }
                else if (input == ConsoleKey.A || input == ConsoleKey.LeftArrow)
                {
                    if (plr.X > 0)
                    {
                        plr.X--;
                    }
                }
                else if (input == ConsoleKey.D || input == ConsoleKey.RightArrow)
                {
                    if (plr.X < boardSize["X"] - 1)
                    {
                        plr.X++;
                    }
                }
                Console.Clear();
                PrintBoard(plr.X, plr.Y, boardSize["X"], boardSize["Y"]);
            } while (run);
        }
    }
}
