using System.Text;

namespace Dz12
{
    public static class Fibonaccinumbers
    {
        public static int Fibonacci(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (n < 0)
            {
                throw new Exception("Номер числа Фібоначчі не може бути відємним");
            }

            if (n == 1) return 0;
            if (n == 2) return 1;
            if (n == 3) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть номер числа Фібоначчі:");



            if (int.TryParse(Console.ReadLine(), out int n))
            {
                try
                {
                    int result = Fibonaccinumbers.Fibonacci(n);
                    Console.WriteLine($"Число Фібоначчі для порядку {n}: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Введено некоректне число.");
            }
        }
    }
}