using System;
using System.Text;

namespace HardToyProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            int numberOfRows = 6;
            StringBuilder builder = new StringBuilder();

            string[] starArray = new string[numberOfRows];
            for (var i = 0; i <= numberOfRows; i++)
            {
                var stars = builder.Append(i).Append(star, 2);
                
                
                Console.WriteLine(stars);
                
            }
        }
    }
}

