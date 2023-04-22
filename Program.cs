using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Laura Salcedo";
            string Location = "Bogotá, Colombia";

            Console.WriteLine($"My name is {Name}");

            Console.WriteLine($"I am from {Location}");

            DateTime Date = DateTime.Now;
            Console.WriteLine(Date.ToString("MM/dd/yyyy"));


            DateTime Christmas = new DateTime(2023, 12, 24);
            var daysTillChristmas = Math.Round((Christmas - Date).TotalDays, 0);
            Console.WriteLine($"Christmas is {daysTillChristmas} days away");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Width of a Window:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Height of a Window:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        }
    }
}
