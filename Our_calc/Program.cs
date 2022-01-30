using Our_calc;
using System;

namespace Our_calc;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            BaseCalculator bul1 = new BaseCalculator();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose the number");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Simple Calculator");
            Console.WriteLine("2. Advanced Calculator");
            Console.WriteLine("3. TXT");
            string calculator = Console.ReadLine();
            switch (calculator)
            {
                case "1":
                    Console.WriteLine("insert first number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("insert second number");
                    int k = Convert.ToInt32(Console.ReadLine());
                    int result;

                    Console.WriteLine("Choose operation");
                    Console.WriteLine("1. addition");
                    Console.WriteLine("2. subtraction");
                    Console.WriteLine("3. multiplication");
                    Console.WriteLine("4. divide");

                    Console.WriteLine("Choose action");
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "1":
                            result = n + k;
                            Console.WriteLine("result=" + result);
                            break;
                        case "2":
                            result = n - k;
                            Console.WriteLine("result=" + result);
                            break;
                        case "3":
                            result = n * k;
                            Console.WriteLine("result=" + result);
                            break;
                        case "4":
                            result = n / k;
                            Console.WriteLine("result=" + result);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
            }
        }
    }
}

