namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
       // Prompt the user to input a grade
        Console.Write("Enter your grade (A, B, C, D, F): ");
        string grade = Console.ReadLine().ToUpper(); // Read input and convert to uppercase for consistency

        // Determine the GPA points based on the grade using switch statements
        int gpaPoints;

        switch (grade)
        {
            case "A":
                gpaPoints = 4;
                break;
            case "B":
                gpaPoints = 3;
                break;
            case "C":
                gpaPoints = 2;
                break;
            case "D":
                gpaPoints = 1;
                break;
            case "F":
                gpaPoints = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return; // Exit the program if the input is invalid
        }

        // Output the corresponding GPA points
        Console.WriteLine($"GPA Points: {gpaPoints}");
    }

    }

    

    

