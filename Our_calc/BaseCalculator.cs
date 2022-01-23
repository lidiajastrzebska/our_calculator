using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_calc
{
    internal class BaseCalculator
    {
        public int Add(int n, int k)
        {
            return n + k;
        }
        public int Sub(int n, int k)
        {
            return n - k;
        }
        public int Mult(int n, int k)
        {
            return n * k;
        }
        public int Div(int n, int k)
        {
            return n / k;
        }
    }
}
