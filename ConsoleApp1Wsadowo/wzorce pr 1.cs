using System;

class Program
{
    private char[,] box = new char[3, 3];
    private int moveCount = 0;

    Program()
    {
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                box[i, j] = ' ';
            }
        }
    }

    public bool SelectField(int x, int y)
    {
        if (box[x,y] == ' ')
        {
            box[x, y] = (moveCount % 2 == 0) ? 'X' : 'Y';
            ++moveCount;
            return true;
        }
        return false;
    }

    public void WriteBoard()
    {
        Console.WriteLine(" {0} | {1} | {2} ", box[0,0], box[0,1], box[0,2]);
        Console.WriteLine(" --------- ");
        Console.WriteLine(" {0} | {1} | {2} ", box[1,0], box[1,1], box[1,2]);
        Console.WriteLine(" --------- ");
        Console.WriteLine(" {0} | {1} | {2} ", box[2,0], box[2,1], box[2,2]);
    }

    public char CheckWin()
    {
        char[] myArray = { 'X', 'Y' };
        foreach (char letter in myArray)
        {
            if (((box[0,0] == letter) && (box[0,1] == letter) && (box[0,2] == letter)) ||
                ((box[1,0] == letter) && (box[1,1] == letter) && (box[1,2] == letter)) ||
                ((box[2,0] == letter) && (box[2,1] == letter) && (box[2,2] == letter)) ||
                ((box[0,0] == letter) && (box[1,0] == letter) && (box[2,0] == letter)) ||
                ((box[0,1] == letter) && (box[1,1] == letter) && (box[2,1] == letter)) ||
                ((box[0,2] == letter) && (box[1,2] == letter) && (box[2,2] == letter)) ||
                ((box[0,0] == letter) && (box[1,1] == letter) && (box[2,2] == letter)) ||
                ((box[0,2] == letter) && (box[1,1] == letter) && (box[2,0] == letter)))
            {
                return letter;
            }
        }
        return '\0';
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

    private bool hasError = false;

    public bool _error
    {
        get { return hasError; }
        set { hasError = value; }
    }

    static void Main()
    {
        Program prog = new Program();
        Console.WriteLine(" -- Tic Tac Toe -- ");
        Console.Clear();

        char winPerson = '\0';
        while (winPerson == '\0')
        {
            if (moveCount == 9)
            {
                prog.DisplayLoss();
            }

            Console.Clear();
            prog.WriteBoard();
            Console.WriteLine();
            Console.WriteLine("What box do you want to place {0} in? (1-9)", askMove);
            Console.Write("> ");

            int selTemp = int.Parse(Console.ReadLine());
            if (selTemp >= 1 && selTemp <= 9)
            {
                if (!prog.SelectField((selTemp - 1) / 3, (selTemp - 1) % 3))
                {
                    prog.NotVacantError();
                }
            }
            else
            {
                Console.WriteLine("Wrong selection entered!");
                Console.WriteLine("Press any key to try again..");
                Console.ReadKey();
            }

            winPerson = prog.CheckWin();
        }
        Console.Clear();
        prog.WriteBoard();
        Console.WriteLine();
        Console.WriteLine("The winner is {0}!", prog.winPerson);
        Console.ReadKey();
    }
}