namespace Homework2Q3;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for a year
        Console.WriteLine("Please enter a year:");
        int year = Convert.ToInt16(Console.ReadLine());

        // Determine if the year is a leap year
        bool isLeapYear;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isLeapYear = true;
                }
                else
                {
                    isLeapYear = false;
                }
            }
            else
            {
                isLeapYear = true;
            }
        }
        else
        {
            isLeapYear = false;
        }

        // Output the result
        if (isLeapYear)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
    }

