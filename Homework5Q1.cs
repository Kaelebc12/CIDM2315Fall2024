namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        int largest = GetLargestNumber();
        Console.WriteLine($"The largest number is: {largest}");
    }

    static int GetLargestNumber()
    {
        Console.Write("Enter the first integer: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        return (firstNumber > secondNumber) ? firstNumber : secondNumber;
    }
    }

