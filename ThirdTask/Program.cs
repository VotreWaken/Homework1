using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateNumber();
        }
        static void CreateNumber()
        {
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter a {i + 1} Number:");
                int n1 = Int32.Parse(Console.ReadLine());
                s += n1.ToString();
            }
            Console.WriteLine($"Result: {s}");
        }
    }
}