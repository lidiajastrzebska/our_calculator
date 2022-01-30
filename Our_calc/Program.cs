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
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (option == 1)
            {
                Console.WriteLine("insert numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                int k = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose the operation");
                Console.WriteLine("1. addition");
                Console.WriteLine("2. substraction");
                Console.WriteLine("3. multiplication");
                Console.WriteLine("4. divide");
                int mathOperation = Convert.ToInt32(Console.ReadLine());
                if (mathOperation == 1)
                {
                    Console.WriteLine(bul1.Add(n, k));
                }
                if (mathOperation == 2)
                {
                    Console.WriteLine(bul1.Sub(n, k));
                }
                if (mathOperation == 3)
                {
                    Console.WriteLine(bul1.Mult(n, k));
                }
                if (mathOperation == 4)
                {
                    Console.WriteLine(bul1.Div(n, k));
                }


            }














        }
    }
}

