using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fib_Memo
{
    class Program
    {


        static decimal FibMemo(uint n, decimal[] callval)
        {
            if (n < 2)
                return n;

            if (callval[n - 1] == 0)
                callval[n - 1] = FibMemo(n - 1, callval);

            if (callval[n - 2] == 0)
                callval[n - 2] = FibMemo(n - 2, callval);

            return callval[n - 1] + callval[n - 2];
        }




        static void Main(string[] args)
        {
            Write("Enter a numbre to see of element's Fibonacci: ");
            int fib = int.Parse(ReadLine());

            for (uint i = 0; i < fib; i++)
            {
                decimal[] a = new decimal[i];

                decimal result = FibMemo(i, a);

                WriteLine(i + " -th item = " + result);
            }


            ReadKey();
        }
    }
}
