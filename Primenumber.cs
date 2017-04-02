using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Primenumber
    {
        public static void Main(String []args)
        {
            int num,i;
            Console.WriteLine("ENTER THE NUMBER TO CHECK IF PRIME OR NOT");
            num=int.Parse(Console.ReadLine());
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    break;
                }

            } 
         if(i==num)
            {
                Console.WriteLine("prime number");
            }
            Console.Read();
        }
        }

    }

