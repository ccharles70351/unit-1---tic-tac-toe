// TicTacToe
// By Colin Charles

using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playerX = true;
            bool playerO = false;
            List<string> boardNums = new List<string> {"1","2","3","4","5","6","7","8","9"};

// Function: Display Board
            void displayMessage ()
            {
                Console.WriteLine(($@" {boardNums[0]} | {boardNums[1]} | {boardNums[2]} 
---+---+---
 {boardNums[3]} | {boardNums[4]} | {boardNums[5]} 
---+---+---
 {boardNums[6]} | {boardNums[7]} | {boardNums[8]} "));
            }

// Function: Player Turn
            string playerTurn ()
            {
                bool playerResponse = true;
                while (playerResponse)
                { 
                    if (playerX)
                    {
                        Console.WriteLine("Player X: Select a number ");
                        playerO = true;
                        playerX = false;
                        playerResponse = false;
                    }

                    else if (playerO)
                    {
                        Console.WriteLine("Player O: Select a number ");
                        playerO = false;
                        playerX = true;
                        playerResponse = false;
                    }
                }
                
                string choice = Console.ReadLine();
                return choice;

                Console.WriteLine("");
                
            }

// Function: Check Square
            bool checkSquare ()
            {
                if (boardNums[0] == boardNums[1] && boardNums[1] == boardNums[2] || 
                    boardNums[3] == boardNums[4] && boardNums[4] == boardNums[5] || 
                    boardNums[6] == boardNums[7] && boardNums[7] == boardNums[8] ||
                    boardNums[0] == boardNums[3] && boardNums[3] == boardNums[6] ||
                    boardNums[1] == boardNums[4] && boardNums[4] == boardNums[7] ||
                    boardNums[2] == boardNums[5] && boardNums[5] == boardNums[8] ||
                    boardNums[0] == boardNums[4] && boardNums[4] == boardNums[8] ||
                    boardNums[2] == boardNums[4] && boardNums[4] == boardNums[6])
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

// Function: Update Board
            void updateBoard (string choice)
            {
                if (playerX)
                {
                    if (choice == "1")
                    {
                        boardNums[0] = "O";
                    }
                    else if (choice == "2")
                    {
                        boardNums[1] = "O";
                    }
                    else if (choice == "3")
                    {
                        boardNums[2] = "O";
                    }
                    else if (choice == "4")
                    {
                        boardNums[3] = "O";
                    }
                    else if (choice == "5")
                    {
                        boardNums[4] = "O";
                    }
                    else if (choice == "6")
                    {
                        boardNums[5] = "O";
                    }
                    else if (choice == "7")
                    {
                        boardNums[6] = "O";
                    }
                    else if (choice == "8")
                    {
                        boardNums[7] = "O";
                    }
                    else if (choice == "9")
                    {
                        boardNums[8] = "O";
                    }
                }

                else if (playerO)
                {
                    if (choice == "1")
                    {
                        boardNums[0] = "X";
                    }
                    else if (choice == "2")
                    {
                        boardNums[1] = "X";
                    }
                    else if (choice == "3")
                    {
                        boardNums[2] = "X";
                    }
                    else if (choice == "4")
                    {
                        boardNums[3] = "X";
                    }
                    else if (choice == "5")
                    {
                        boardNums[4] = "X";
                    }
                    else if (choice == "6")
                    {
                        boardNums[5] = "X";
                    }
                    else if (choice == "7")
                    {
                        boardNums[6] = "X";
                    }
                    else if (choice == "8")
                    {
                        boardNums[7] = "X";
                    }
                    else if (choice == "9")
                    {
                        boardNums[8] = "X";
                    }
                }
            }

// Function: Main

            void Main ()
            {
                displayMessage();
                bool noWin = true;
                while (noWin)
                {
                    string choice = playerTurn();
                    updateBoard(choice);
                    bool win = checkSquare();
                    noWin = win;
                    displayMessage();
                }
                Console.WriteLine("Game Over!");
            }

            Main();
        }
    }
}