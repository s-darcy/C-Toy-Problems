using System;


namespace EasyToyProblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please type a number into the console.");
            string textResponse = Console.ReadLine();
            bool response = Int32.TryParse(textResponse, out int number);
            

            if (number < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else if (number >= 10)
            {
                Console.WriteLine("This number is big enough");
            }
        }
    }
}
