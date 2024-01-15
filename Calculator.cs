using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to my calculator!");
            
            while (true)  // Start an infinite loop
            {
                int number1;
                int number2;

                int result = 0;

                string answer;

                
                Console.WriteLine("Please enter the first number or 'q' to quit:");

                answer = Console.ReadLine();

                if (answer.ToLower() == "q")
                {
                    Console.WriteLine("See you later!");
                    break; // Exit if 'q' is entered

                }

                number1 = Convert.ToInt32(answer);

                Console.WriteLine("Please enter the second number:");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or d for division.");

                answer = Console.ReadLine();

                switch (answer.ToLower())

                {
                    case "a":
                        result = number1 + number2;
                        break;
                    case "s":
                        result = number1 - number2;
                        break;
                    case "m":
                        result = number1 * number2;
                        break;
                    case "d":
                        // Check for division by zero
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue; // Skip the rest and start the next iteration
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter a valid letter.");
                        continue; // Skip the rest and start the next iteration
                }

                Console.WriteLine("The result is: " + result);
            }
        }
    }
}
