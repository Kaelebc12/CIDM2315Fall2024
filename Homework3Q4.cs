namespace Homework3Q4;

class Program
{
    static void Main(string[] args)
    {
                // Input the integer N
        Console.Write("Assign an in to N: ");
        int N = int.Parse(Console.ReadLine());

        // Print the square pattern
        for (int i = 1; i <= N; i++)  // Loop for each row
        {
            for (int j = 1; j <= i; j++)  // Loop for each column in the current row
            {
                Console.Write(i);  // Print the row number
            }
            Console.WriteLine();  // Move to the next line after printing all columns in the current row
        }


    }
}
