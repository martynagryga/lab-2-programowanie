using System;

namespace HFLOOR {
    class Program {
        static void Main() {
            int nrOfCases = int.Parse(Console.ReadLine());
            for (int a = 0; a < nrOfCases; a++) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int xSize = int.Parse(input[0]);
                int ySize = int.Parse(input[1]);
                char[][] arr = new char[xSize][];

                for (int i = 0; i < xSize; i++) {
                    arr[i] = new char[ySize];
                    arr[i] = Console.ReadLine().ToCharArray();
                }

                int guests = 0;
                int rooms = 0;

                for (int i = 0; i < xSize; i++) {
                    for (int j = 0; j < ySize; j++) {
                        if (arr[i][j] == '-' || arr[i][j] == '*') {
                            rooms += 1;
                            CheckNeighbours(arr, i, j, ref guests);
                        }
                    }
                }
                Console.WriteLine((1f*guests / rooms).ToString("F"));
            }
        }

        static void CheckNeighbours(char[][] arr, int x, int y, ref int guests) {
            if (arr[x][y] == 'v' || arr[x][y] == '#') return;
            if (arr[x][y] == '*') guests += 1;

            arr[x][y] = 'v';
            CheckNeighbours(arr, x + 1, y, ref guests);
            CheckNeighbours(arr, x - 1, y, ref guests);
            CheckNeighbours(arr, x, y + 1, ref guests);
            CheckNeighbours(arr, x, y - 1, ref guests);
        }
    }
}
