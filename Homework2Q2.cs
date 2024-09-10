namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q2
        // Prompt the user for three numbers
        Console.WriteLine("Please enter the first number:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please enter the second number:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please enter the third number:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        // Initialize smallestNumber with the first number
        int smallestNumber = num1;

        // Use nested if statements to determine the smallest number
        if (num2 < smallestNumber)
        {
            smallestNumber = num2;
        }

        if (num3 < smallestNumber)
        {
            smallestNumber = num3;
        }

        // Print the smallest number
        Console.WriteLine("The smallest number is: " + smallestNumber);
    }
    }

