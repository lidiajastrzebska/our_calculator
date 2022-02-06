using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_calc
{
    internal class AdvancedCalculator
    {
        public int Factorial(int n)
        {
            int result=1;
            Console.WriteLine("Put number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
