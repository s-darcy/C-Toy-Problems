using System;
using System.Collections.Generic;
using System.Text;

namespace HardToyProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            char space = ' ';
            Console.WriteLine("How many rows?");
            int numberOfRows = Int32.Parse(Console.ReadLine());
            int totalRows = numberOfRows;
            int count = 1;

            for (int row = 1; row <= totalRows; row++)
            {
                for(int j = totalRows - row; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (row*2)-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

