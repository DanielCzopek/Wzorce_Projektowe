using System;

class Program
{
    private char winChar;

    public char winPerson
    {
        get { return winChar; }
        set { winChar = value; }
    }

    private bool hasWon;

    public bool isWin
    {
        get { return hasWon; }
        set { hasWon = value; }
    }

    private bool isX;

    public bool isY
    {
        get { return isX; }
        set { isX = value; }
    }

    private char boxone, boxtwo, boxthree, boxfour, boxfive, boxsix, boxseven, boxeight, boxnine;

    public char box1
    {
        get { return boxone; }
        set { boxone = value; }
    }

    public char box2
    {
        get { return boxtwo; }
        set { boxtwo = value; }
    }

    public char box3
    {
        get { return boxthree; }
        set { boxthree = value; }
    }

    public char box4
    {
        get { return boxfour; }
        set { boxfour = value; }
    }

    public char box5
    {
        get { return boxfive; }
        set { boxfive = value; }
    }

    public char box6
    {
        get { return boxsix; }
        set { boxsix = value; }
    }

    public char box7
    {
        get { return boxseven; }
        set { boxseven = value; }
    }

    public char box8
    {
        get { return boxeight; }
        set { boxeight = value; }
    }

    public char box9
    {
        get { return boxnine; }
        set { boxnine = value; }
    }

    public void WriteBoard()
    {
        int[,] gameBoard = {
            {1, 2, 3 },
            {4, 5,6 },
            {7, 8, 9 }
        };
        Console.WriteLine(" {0} | {1} | {2} ", gameBoard[0,0], gameBoard[0,1], gameBoard[0,2]);
        Console.WriteLine(" --------- ");
        Console.WriteLine(" {0} | {1} | {2} ", gameBoard[1,0], gameBoard[1,1], gameBoard[1,2]);
        Console.WriteLine(" --------- ");
        Console.WriteLine(" {0} | {1} | {2} ", gameBoard[2,0], gameBoard[2,1], gameBoard[2,2]);
        
    }
  
    //public void CheckWin()
    //{ 
    // 123, 456, 789, 147, 258, 369, 159, 357
    //    if ((box1 == 'X') && (box2 == 'X') && (box3 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box4 == 'X') && (box5 == 'X') && (box6 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box7 == 'X') && (box8 == 'X') && (box9 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box1 == 'X') && (box4 == 'X') && (box7 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box2 == 'X') && (box5 == 'X') && (box8 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box3 == 'X') && (box6 == 'X') && (box9 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    } // 159, 357
    //    if ((box1 == 'X') && (box5 == 'X') && (box9 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box3 == 'X') && (box5 == 'X') && (box7 == 'X'))
    //    {
    //        isWin = true;
    //        winPerson = 'X';
    //        return;
    //    }
    //    if ((box1 == 'Y') && (box2 == 'Y') && (box3 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //    if ((box4 == 'Y') && (box5 == 'Y') && (box6 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //    if ((box7 == 'Y') && (box8 == 'Y') && (box9 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //    if ((box1 == 'Y') && (box4 == 'Y') && (box7 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //    if ((box2 == 'Y') && (box5 == 'Y') && (box8 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //    if ((box3 == 'Y') && (box6 == 'Y') && (box9 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    } // 159, 357
    //    if ((box1 == 'Y') && (box5 == 'Y') && (box9 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //    if ((box3 == 'Y') && (box5 == 'Y') && (box7 == 'Y'))
    //    {
    //        isWin = true;
    //        winPerson = 'Y';
    //        return;
    //    }
    //}
    abstract class Player
    {
        public string Name { get; set; }
    public char Symbol { get; set; }
    public bool CheckIfPlayerWon(char[,] gameBoard)
    {
        int height = gameBoard.GetLength(0);
        int width = gameBoard.GetLength(1);
        if (height != width)
            throw new Exception("The board is not a square!");
        // Check rows
        for (int i = 0; i < height; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < width; j++)
            {
                if (gameBoard[i, j] == Symbol)
                    rowSum++;
            }
            if (rowSum == width)
                return true;
        }
        // Check columns
        for (int j = 0; j < width; j++)
        {
            int colSum = 0;
            for (int i = 0; i < height; i++)
            {
                if (gameBoard[i, j] == Symbol)
                    colSum++;
            }
            if (colSum == height)
                return true;
        }
        // Check diagonals
        int diagSumA = 0;
        int diagSumB = 0;
        for (int k = 0; k < width; k++)
        {
            if (gameBoard[k, k] == Symbol)
                diagSumA++;
            if (gameBoard[k, width - 1 - k] == Symbol)
                diagSumB++;
        }
        if (diagSumA == width || diagSumB == width)
            return true;
        // Otherwise, no win yet
        return false;
    }
    public bool PlaceSymbol(char c, char[,] startBoard, char[,] gameBoard)
    {
        int height = gameBoard.GetLength(0);
        int width = gameBoard.GetLength(1);
        if (height != startBoard.GetLength(0) || width != startBoard.GetLength(1))
            throw new Exception("The boards have different sizes!");
        // Try to put player's symbol at a given place, if the place is available
        for (int i = 0; i < height; i++)
            for (int j = 0; j < width; j++)
                if ((gameBoard[i, j] == c) && (gameBoard[i, j] == startBoard[i, j]))
                {
                    gameBoard[i, j] = Symbol;
                    return true;
                }
        // Otherwise, return withouth success
        return false;
    }
}



public void NotVacantError()
    {
        _error = true;
        Console.WriteLine();
        Console.WriteLine("Error: box not vacant!");
        Console.WriteLine("Press any key to try again..");
        Console.ReadKey();
        return;
    }

    public void DisplayLoss()
    {
        Console.WriteLine();
        Console.WriteLine("No one won.");
        Console.ReadKey();
        Environment.Exit(1);
    }

    private bool hasError;

    public bool _error
    {
        get { return hasError; }
        set { hasError = value; }
    }

    static void Main()
    {
        int moveCount = 0; // check loss
        char askMove; // display X or Y in question
        int selTemp;
        Program prog = new Program();
        prog._error = false;
        prog.box1 = ' ';
        prog.box2 = ' ';
        prog.box3 = ' ';
        prog.box4 = ' ';
        prog.box5 = ' ';
        prog.box6 = ' ';
        prog.box7 = ' ';
        prog.box8 = ' ';
        prog.box9 = ' ';
        prog.isY = true;
        Console.WriteLine(" -- Tic Tac Toe -- ");
        Console.Clear();
        while (!prog.isWin)
        {
            if (moveCount == 9)
            {
                prog.DisplayLoss();
            }
            if ((prog.isY) == true) // if is X
            {
                askMove = 'X';
            }
            else
            {
                askMove = 'Y';
            }
            Console.Clear();
            prog.WriteBoard();
            Console.WriteLine();
            Console.WriteLine("What box do you want to place {0} in? (1-9)", askMove);
            Console.Write("> ");
            selTemp = int.Parse(Console.ReadLine());
            switch (selTemp)
            {
                case 1:
                    if (prog.box1 == ' ')
                    {
                        prog.box1 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 2:
                    if (prog.box2 == ' ')
                    {
                        prog.box2 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 3:
                    if (prog.box3 == ' ')
                    {
                        prog.box3 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 4:
                    if (prog.box4 == ' ')
                    {
                        prog.box4 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 5:
                    if (prog.box5 == ' ')
                    {
                        prog.box5 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 6:
                    if (prog.box6 == ' ')
                    {
                        prog.box6 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 7:
                    if (prog.box7 == ' ')
                    {
                        prog.box7 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 8:
                    if (prog.box8 == ' ')
                    {
                        prog.box8 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 9:
                    if (prog.box9 == ' ')
                    {
                        prog.box9 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                default:
                    Console.WriteLine("Wrong selection entered!");
                    Console.WriteLine("Press any key to try again..");
                    Console.ReadKey();
                    prog._error = true;
                    break;
            }
            if (prog._error)
            {
                //prog.CheckWin(); // if error, just check win
                prog._error = !prog._error;
            }
            else
            {
                prog.isY = !prog.isY; // flip boolean
               // prog.CheckWin();
            }
        }
        Console.Clear();
        prog.WriteBoard();
        Console.WriteLine();
        Console.WriteLine("The winner is {0}!", prog.winPerson);
        Console.ReadKey();
    }
}