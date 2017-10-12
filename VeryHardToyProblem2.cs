using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryHardToyProbem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
              "Need help converting a unit of measurement?\r\n" +
              "Please type the one of the following letters below and then type your number to convert.\r\n" +
              "'I' to convert from inches to centimeters.\r\n" +
              "'G' tp convert from gallons to liters.\r\n" +
              "'M' to convert from mile to kilometer.\r\n" +
              "'P' to convert from pound to kilogram.\r\n"
               );

            Console.Write("Please enter a letter: ");
            string letter = Console.ReadLine();
            Console.Write("Please enter a number to convert: ");
            string value = Console.ReadLine();

            char charLetter = Convert.ToChar(letter);
            int intVal = Int32.Parse(value);

            switch (charLetter)
            {
                case 'I':
                    double centimeters = intVal * 2.54;
                    Console.WriteLine(centimeters + "cm");
                    break;
                case 'G':
                    double liters = intVal * 3.785;
                    Console.WriteLine(liters + "L");
                    break;
                case 'M':
                    double kilometers = intVal * 1.609;
                    Console.WriteLine(kilometers + "km");
                    break;
                case 'P':
                    double kilogram = intVal * 0.4535;
                    Console.WriteLine(kilogram + "kg");
                    break;
                default:
                    Console.WriteLine("Invalid letter. Please type: I, G, M, or P");
                    break;
            }
        }
    }
}

