using System;

namespace TryAndCatchC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("cannot divide by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Incorrect Format");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception");
                    }
            finally
            {
                Console.WriteLine("This is called anyway!");
            }

            

            Console.ReadKey();

        }
    }
}
