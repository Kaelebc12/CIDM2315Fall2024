namespace Homework5Q2;

class Program
{
    static void Main(string[] args)
    {
        int largest = GetLargestOfFour();
        Console.WriteLine($"The largest number is: {largest}");
    }

    static int GetLargestOfFour()
    {
        Console.Write("Enter the first integer: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third integer: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the fourth integer: ");
        int fourthNumber = Convert.ToInt32(Console.ReadLine());

        int largestFirstPair = GetLargestNumber(firstNumber, secondNumber);
        int largestSecondPair = GetLargestNumber(thirdNumber, fourthNumber);

        return GetLargestNumber(largestFirstPair, largestSecondPair);
    }

    static int GetLargestNumber(int a, int b)
    {
        return (a > b) ? a : b;
    }
    }

