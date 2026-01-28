using System;
using System.Collections.Generic;
using System.Text;
namespace Mission4
{
    internal class TicTacToeTools
    {
        public void printBoard(string[] board)
        {
            Console.WriteLine($"\n{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}\n");
        }

        // Returns the winner ("X", "O") or empty string if no winner yet
        public string isWinner(string[] board)
        {
            // Check rows
            if (board[0] == board[1] && board[0] == board[2])
            {
                return board[0];
            }
            else if (board[3] == board[4] && board[3] == board[5])
            {
                return board[3];
            }
            else if (board[6] == board[7] && board[6] == board[8])
            {
                return board[6];
            }
            // Check columns
            else if (board[0] == board[3] && board[0] == board[6])
            {
                return board[0];
            }
            else if (board[1] == board[4] && board[1] == board[7])
            {
                return board[1];
            }
            else if (board[2] == board[5] && board[2] == board[8])
            {
                return board[2];
            }
            // Check diagonals
            else if (board[0] == board[4] && board[0] == board[8])
            {
                return board[0];
            }
            else if (board[2] == board[4] && board[2] == board[6])
            {
                return board[2];
            }
            else
            {
                return ""; // No winner yet
            }
        }
    }
}