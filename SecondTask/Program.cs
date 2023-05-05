using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindPercentage();
        }
        static void FindPercentage()
        {
            double value;
            do
            {
                Console.WriteLine("Enter a Number:");
                Console.WriteLine("Enter 0 To Exit");
                value = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Percentage:");
                double percentage = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {percentage} % from {value} = {Math.Round(value * (percentage / 100), 2)}");
            } while (value != 0);
        }
    }
}

