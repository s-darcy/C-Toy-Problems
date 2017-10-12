using System;

namespace VeryHardToyProblem
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
                    Console.WriteLine(centimeters);
                    break;
                case 'G':
                    double gallons = intVal * 3.785;
                    Console.WriteLine(gallons);
                    break;
                case 'M':
                    double miles = intVal * 1.609;
                    Console.WriteLine(miles);
                    break;
                case 'P':
                    double pound = intVal * 0.4535; 
                    Console.WriteLine(pound);
                    break;
                default:
                    Console.WriteLine("Invalid letter. Please type: I, G, M, or P");
                    break;
            }
        }
    }
}
