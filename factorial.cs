using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i, f=1;

            if (n <= 0)

            {

                Console.WriteLine("Factorial cannot be determined");
            }

            else
            {
                for (i = 1; i <= n; i++)
                {
                    f = f * i;
                }
                Console.WriteLine(f);
                Console.Read();
            }
            Console.Read();
        }

    }
}
