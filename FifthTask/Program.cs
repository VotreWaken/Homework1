using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seasons();
        }
        static void Seasons()
        {
            Console.WriteLine("Enter Date (in 00.00.0000) ");
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy", null);

            string season = "";
            if (date.Month == 12 || date.Month <= 2)
            {
                season = "Winter";
            }
            else if (date.Month >= 3 && date.Month <= 5)
            {
                season = "Spring";
            }
            else if (date.Month >= 6 && date.Month <= 8)
            {
                season = "Summer";
            }
            else if (date.Month >= 9 && date.Month <= 11)
            {
                season = "Autumn";
            }

            string dayOfWeek = date.ToString("dddd");
            Console.WriteLine($"{season} {dayOfWeek}");
            Console.Read();
        }
    }
}