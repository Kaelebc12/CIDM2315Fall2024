namespace Homework3Q3;

class Program
{
    static void Main(string[] args)
    {
       // Input the integer N
        Console.Write("Assign an int to N: ");
        int N = int.Parse(Console.ReadLine());

        // Print the square pattern
        for (int i = 1; i <= N; i++)  // Loop for each row
        {
            for (int j = 1; j <= N; j++)  // Loop for each column
            {
                // Print '*' if column index is less than or equal to row index
                if (j <= i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");  // Print space for other positions
                }
            }
            Console.WriteLine();  // Move to the next line after printing all columns
        }
    }
}
