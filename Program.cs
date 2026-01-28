using Mission4;
Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine("Pick a square by typing a number 1-9:");
Console.WriteLine();
Console.WriteLine("Player X will go first");
string[] board = ["1","2","3","4","5","6","7","8","9"];

TicTacToeTools TTT = new TicTacToeTools();
bool iswinner = false;
 int xSelection = 0;
 int OSelection = 0;



while (iswinner)
{
    TTT.printBoard(board);
    Console.WriteLine("Player X, What is your selection?");
    xSelection = int.Parse(Console.ReadLine());
    TTT.updateBoard("X", xSelection, board);
    TTT.printBoard(board);
   iswinner = TTT.isWinner(board);
    Console.WriteLine("Player O, What is your selection?");
    OSelection= int.Parse(Console.ReadLine());
    TTT.updateBoard("O",OSelection, board);
    TTT.printBoard(board);
    iswinner = TTT.isWinner(board);


}

 

