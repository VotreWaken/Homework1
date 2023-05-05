using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleNumber();
        }

        static void MultipleNumber()
        {
            Console.WriteLine("Enter a Number Between 1 and 100: ");
            Console.WriteLine("Enter 0 To Exit");
            int value;
            do
            {
                value = Int32.Parse(Console.ReadLine());
                if (value == 0)
                {
                    return;
                }
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Error Number out of Range");
                }
                else if (value % 3 == 0 && value % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (value % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (value % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(value);
                }
            } while (value != 0);
        }
    }
}
