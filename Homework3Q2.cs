namespace Homework3Q2;

class Program
{
    static void Main(string[] args)
    {
   // Input the integer N
        Console.Write("Assign an int value to N: ");
        int N = int.Parse(Console.ReadLine());

        // Print the square pattern
        for (int i = 0; i < N; i++)  // Loop for each row
        {
            for (int j = 0; j < N; j++)  // Loop for each column
            {
                Console.Write("#");  // Print # character
            }
            Console.WriteLine();  // Move to the next line after printing all columns
        }
}
}

