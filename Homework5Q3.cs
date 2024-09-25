namespace Homework5Q3;

class Program
{
    static void Main(string[] args)
    {
          createAccount();
    }

    static bool checkAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        Console.Write("Re-enter password: ");
        string confirmPassword = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear;

        
        while (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear > DateTime.Now.Year)
        {
            Console.Write("Invalid input. Please enter a valid birth year: ");
        }

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
