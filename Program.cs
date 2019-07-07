using System;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter;
            int startingNumber;
            int endingNumber;

            Console.Write("This program will find the prime numbers within a certain range of numbers. Input the starting number of " +
                "the range: \n");
            startingNumber = Convert.ToInt32(Console.ReadLine());
            while (startingNumber < 0)
            {
                Console.Write("This number is below 0. Please enter in another number greater than or equal to zero: ");
                startingNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input ending number of the range : ");
            endingNumber = Convert.ToInt32(Console.ReadLine());
            while (endingNumber <= startingNumber)
            {
                Console.Write("The ending number inputed must be greater than the starting number. Please enter in a number greater to the " + 
                    "starting number: ");
                endingNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The prime numbers between " + startingNumber + " and " + endingNumber +  " are: \n");

            for (number = startingNumber; number <= endingNumber; number++)
            {
                counter = 0;
                int i;

                for (i = 2; i <= Math.Floor(Math.Sqrt(number)); i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && number != 1)
                    Console.Write(" " + number + " ");
            }
            Console.Write("\n");
        }
    }
}
