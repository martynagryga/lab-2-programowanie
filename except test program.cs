using System;

namespace exceptions {
    class Program {
        static void Main() {
            try {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine(checked(a + b + c));
            }
            catch (FormatException) {
                Console.WriteLine("format exception, exit");
            }
            catch (ArgumentException) {
                Console.WriteLine("argument exception, exit");
            }
            catch (OverflowException) {
                Console.WriteLine("overflow exception, exit");
            }
            catch (Exception) {
                Console.WriteLine("non supported exception, exit");
            }

        }
    }
}
