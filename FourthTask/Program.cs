using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExchangeOfNumbers();
        }
        static void ExchangeOfNumbers()
        {
            int number = 0;

            Console.WriteLine("Enter a 6 Digit Number: ");
            number = Int32.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder().Append(number);

            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }

            if (count != 6)
            {
                Console.WriteLine("Number not contain 6 Digits: ");
                return;
            }

            Console.WriteLine("Enter First Number ");
            int r1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number ");
            int r2 = Int32.Parse(Console.ReadLine());

            char s1 = sb[r1 - 1];
            char s2 = sb[r2 - 1];

            sb[r1 - 1] = s2;
            sb[r2 - 1] = s1;

            string str = sb.ToString();
            number = Int32.Parse(str);
            Console.WriteLine($"Result: {number}");
        }
    }
}