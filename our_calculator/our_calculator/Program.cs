using System;

namespace our_calculator
{
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

                
              

                

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert the numbers");
                Console.ForegroundColor = ConsoleColor.White;
                int n = Convert.ToInt32(Console.ReadLine());
                int k = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
