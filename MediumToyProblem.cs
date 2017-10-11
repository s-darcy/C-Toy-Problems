using System;

namespace MediumToyProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[][] fiveLines = new char[5][];
            for (var j = 0; j < 5; j++)
            {
                char[] starArray = new char[10];
                for (var i = 0; i <= 9; i++)
                {
                    char star = '*';
                    starArray[i] = star;
                    
                }
                Console.WriteLine(starArray);
            }
        }
    }
}
