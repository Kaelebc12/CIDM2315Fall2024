namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Check if the number is less than 2
        if (N < 2)
        {
            Console.WriteLine($"{N} is non-prime");
            return;
        }

        // Assume the number is prime
        bool isPrime = true;

        // Check for factors from 2 to N-1
        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Output result based on the prime check
        if (isPrime)
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }
    }
    }

