using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixth_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature();
        }
        static void Temperature()
        {
            while (true)
            {
                int choice = 0;
                Console.WriteLine(
                    "\n1.Fahrenheit to Celsius" +
                    "\n2.Celsius to Fahrenheit" +
                    "\n3.Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\nEnter temperature");
                            int temp = int.Parse(Console.ReadLine());
                            int result = (temp - 32) * 5 / 9;
                            Console.WriteLine("Temperature = " + result + " °C");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nEnter temperature");
                            int temp = int.Parse(Console.ReadLine());
                            int result = (temp * 9 / 5) + 32;
                            Console.WriteLine("Temperature = " + result + " °F");
                            break;
                        }
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error Choice");
                        break;
                }
            }
        }
    }
}