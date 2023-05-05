using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers();
        }
        static void EvenNumbers()
        {
            Console.WriteLine("Enter First Number :");
            int number_one = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int number_two = int.Parse(Console.ReadLine());

            if (number_one > number_two)
            {
                int temp = number_one;
                number_one = number_two;
                number_two = temp;
            }
            for (int i = number_one; i <= number_two; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}