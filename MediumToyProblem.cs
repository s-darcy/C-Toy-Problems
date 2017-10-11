using System;

namespace MediumToyProblem
{
    class Program
    {
        public static void Main(string[] args)
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
