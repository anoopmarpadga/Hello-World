using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 0, n2 = 1, n3, num;

                Console.WriteLine("Enter the number till where the Fibonacci series should be printed");
            
num = int.Parse(Console.ReadLine());

                for (int i = 2; i < num; ++i)
                {
                    n3 = n1 + n2;
                    Console.WriteLine(" " + n3);
                    n1 = n2;
                    n2 = n3;
                }
            Console.Read();
            }
}
    }
