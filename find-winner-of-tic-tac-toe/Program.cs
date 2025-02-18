// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string Tictactoe(int[][] moves)
{
    char[,] board = new char[3, 3]
    {
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' }
    };

    int turnCount = 0;

    foreach (int[] move in moves)
    {
        turnCount++;
        int playedRow = move[0];
        int playedCol = move[1];

        if (turnCount == 9)
        {
            return "Draw";
        }

        if (turnCount % 2 == 0)
        {
            board[playedRow, playedCol] = 'O';
        }
        else
        {
            board[playedRow, playedCol] = 'X';
        }
    }

    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == 'X' && board[i, 1] == 'X' && board[i, 2] == 'X')
        {
            return "A";
        }
        else if (board[0, i] == 'X' && board[1, i] == 'X' && board[2, i] == 'X')
        {
            return "A";
        }

        if (board[i, 0] == 'O' && board[i, 1] == 'O' && board[i, 2] == 'O')
        {
            return "B";
        }
        else if (board[0, i] == 'O' && board[1, i] == 'O' && board[2, i] == 'O')
        {
            return "B";
        }

        if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
        {
            return "A";
        }
        else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
        {
            return "A";
        }

        if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
        {
            return "B";
        }
        else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
        {
            return "B";
        }
    }

    return "Pending";
}

// test cases
Console.WriteLine(Tictactoe(new int[][] { new int[] { 0, 0 }, new int[] { 2, 0 }, new int[] { 1, 1 }, new int[] { 2, 1 }, new int[] { 2, 2 } })); // "A"
Console.WriteLine(Tictactoe(new int[][] { new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 0 }, new int[] { 2, 0 } })); // "B"
