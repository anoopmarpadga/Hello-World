using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter the number till where the * series to be printed");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The Output is");
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }


                Console.ReadLine();
            }

        }
    }
}

