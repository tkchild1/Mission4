using Mission4;
Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine("Pick a square by typing a number 1-9");
Console.WriteLine("Player X will go first\n");

// Initialize the board with numbers 1-9
string[] board = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
TicTacToeTools TTT = new TicTacToeTools();
int xSelection = 0;
int OSelection = 0;
string winner = "";
int turnsCounter = 0;
List<int> usedSquares = new List<int>(); // Keeps track of squares that have been picked

// Main game loop - runs until someone wins or board is full
while (winner == "" && turnsCounter < 9)
{
    TTT.printBoard(board);

    // Player X's turn with input validation
    bool validInput = false;
    while (!validInput)
    {
        Console.Write("Player X, enter your selection (1-9): ");
        string input = Console.ReadLine();

        // Check if input is a number
        if (int.TryParse(input, out xSelection))
        {
            // Make sure number is in range
            if (xSelection >= 1 && xSelection <= 9)
            {
                // Check if square hasn't been taken yet
                if (!usedSquares.Contains(xSelection))
                {
                    validInput = true;
                    usedSquares.Add(xSelection);
                }
                else
                {
                    Console.WriteLine("That square is already taken! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 9.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    updateBoard("X", xSelection, board);
    turnsCounter++;
    TTT.printBoard(board);
    winner = TTT.isWinner(board); // Gets the winner or empty string
    if (winner != "")
    {
        break;
    }

    // Check for tie after X's turn
    if (turnsCounter >= 9) break;

    // Player O's turn with input validation
    validInput = false;
    while (!validInput)
    {
        Console.Write("Player O, enter your selection (1-9): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out OSelection))
        {
            if (OSelection >= 1 && OSelection <= 9)
            {
                if (!usedSquares.Contains(OSelection))
                {
                    validInput = true;
                    usedSquares.Add(OSelection);
                }
                else
                {
                    Console.WriteLine("That square is already taken! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 9.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    updateBoard("O", OSelection, board);
    turnsCounter++;
    TTT.printBoard(board);
    winner = TTT.isWinner(board); // Gets the winner or empty string
}

// Display final result
if (winner == "")
{
    Console.WriteLine("Cats Game! Good try! I guess you can both be winners.");
}
else
{
    Console.WriteLine($"Congrats Player {winner}! You have won the game. Thanks for playing!");
}

// Function to update the board with player's move
string[] updateBoard(string team, int selection, string[] board)
{
    board[selection - 1] = team;
    return board;
}