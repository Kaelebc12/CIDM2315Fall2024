namespace Homework3Q2;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter an integer N
        Console.Write("Enter an integer N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Print the square pattern
        for (int i = 0; i < N; i++) // Loop for rows
        {
            for (int j = 0; j < N; j++) // Loop for columns
            {
                Console.Write("* "); // Print '*' with a space
            }
            Console.WriteLine(); // Move to the next line after printing all columns in a row
        }
    }
    }

