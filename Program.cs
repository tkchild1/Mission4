Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine("Pick a square by typing a number 1-9:");
Console.WriteLine("1 2 3");
Console.WriteLine("4 5 6");
Console.WriteLine("7 8 9");
Console.WriteLine();
Console.WriteLine("Player X will go first");
char[] board = new char[8];

TicTacToeTools TTT = new TicTacToeTools()
bool iswinner = false;
 int xSelection = 0;
int OSelection = 0

void printBoard(string[] board)

while (!iswinner) ;
{
    TTT.printBoard(board);
    Console.WriteLine("Player X, What is your selection?");
    xSelection = int.Parse(Console.ReadLine());
    TTT.updateBoard("X", xSelection, board);
    TTT.printBoard(board);
    TTT.isWinner(board);
    Console.WriteLine("Player O, What is your selection?");
    OSelection= int.Parse(Console.ReadLine());
    TTT.updateBoard("O",OSelection, board);
    TTT.printBoard(board);
    TTT.isWinner(board);


}
 

