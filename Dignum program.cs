using System;

namespace ledReader {
    class Program {
        static void Main() {
            while (true) {
                string[] digits = new string[3];

                digits[0] = Console.ReadLine();
                if (string.IsNullOrEmpty(digits[0])) break;
                digits[1] = Console.ReadLine();
                digits[2] = Console.ReadLine();

                int n = digits[0].Length / 3;

                for (int i = 0; i < n; i++) {
                    // 1,2,3,4,5,6,7,8,9,0
                    if (digits[0][1 + i * 3] == ' ') {
                        if (digits[1][i * 3] == '|') {
                            Console.Write("4");
                        }
                        else Console.Write("1");
                    }
                    // 2,3,5,6,7,8,9,0
                    else if (digits[1][i * 3] == ' ') {
                        if (digits[2][i * 3] == '|') {
                            Console.Write("2");
                        }
                        else {
                            if (digits[2][1 + i * 3] == '_') {
                                Console.Write("3");
                            }
                            else Console.Write("7");
                        }
                    }
                    // 5,6,8,9,0
                    else if (digits[1][2 + i * 3] == ' ') {
                        if (digits[2][i * 3] == ' ') {
                            Console.Write("5");
                        }
                        else Console.Write("6");
                    }
                    // 8,9,0
                    else if (digits[2][i * 3] == '|') {
                        if (digits[1][1 + i * 3] == '_') {
                            Console.Write("8");
                        }
                        else Console.Write("0");
                    }
                    // 9
                    else {
                        Console.Write("9");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
