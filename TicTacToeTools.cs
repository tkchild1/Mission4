using System;
using System.Collections.Generic;
using System.Text;
// The class that contains the two methods of the TicTacToeTools
namespace Mission4
{
    internal class TicTacToeTools
    {
        // A method that prints the board, so that it is formatted nicely
        public void printBoard(string[] board)
        {
            Console.WriteLine($"\n{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}\n");
        }

        // Check the board to see if there is a winner. Basically just checks if any of the winning combinations have all the same letter
        public bool isWinner(string[] board)
        {
            bool result = false;
            if (board[0] == board[1] && board[0] == board[2])
            {
                result = true;
            }
            else if (board[3] == board[4]  && board[3] == board[5])
            {
                result = true;
            }
            else if (board[6] == board[7] && board[6] == board[8])
            {
                result = true;
            }
            else if (board[0] == board[3] && board[0] == board[6])
            {
                result = true;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                result = true;
            }
            else if (board[2] == board[5] && board[2] == board[8])
            {
                result = true;
            }
            else if (board[0] == board[4] && board[0] == board[8])
            {
                result = true;
            }
            else if (board[2] == board[4] && board[2] == board[6])
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
