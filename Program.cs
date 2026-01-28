using Mission4;


Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine("Pick a square by typing a number 1-9");
Console.WriteLine("Player X will go first\n");


string[] board = ["1","2","3","4","5","6","7","8","9"];

TicTacToeTools TTT = new TicTacToeTools();
bool isWinner = false;
int xSelection = 0;
int OSelection = 0;
string winner = "";
int turnsCounter = 0;


while (!isWinner)
{
    TTT.printBoard(board);
    Console.Write("Player X, enter your selection: ");
    xSelection = int.Parse(Console.ReadLine());
    turnsCounter++;
    updateBoard("X", xSelection, board);
    TTT.printBoard(board);
    isWinner = TTT.isWinner(board);
    if (isWinner)
    {
        winner = "Player X";
        break;
    }
    if (turnsCounter >= 9)
    {
        winner = "None";
        break;
    }

    Console.Write("Player O, enter your selection: ");
    OSelection= int.Parse(Console.ReadLine());
    turnsCounter++;

    updateBoard("O", OSelection, board);
    isWinner = TTT.isWinner(board);
    if (isWinner)
    {
        TTT.printBoard(board);
        winner = "Player O";
    }
}
if(winner == "None")
{
    Console.WriteLine("Cats Game! Good try! I guess you can both be winners.");
}
else
{
    Console.WriteLine($"Congrats {winner}! You have won the game. Thanks for playing!");
}  

string[] updateBoard(string team, int selection, string[] board)
{
    board[selection - 1] = team;
    return board;
}



