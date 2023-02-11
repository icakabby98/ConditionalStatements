using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string figure = Console.ReadLine();

            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * sideA);
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse((Console.ReadLine()));
                double sideB = double.Parse((Console.ReadLine()));
                Console.WriteLine(sideA * sideB);   

            }
            else if (figure == "circle")
            {
                double radians = double.Parse((Console.ReadLine()));
                Console.WriteLine(Math.PI * Math.Pow(radians, 2));
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double higth = double.Parse((Console.ReadLine()));
                Console.WriteLine((sideA * higth) / 2 );
            }

        }
    }
}
