namespace Homework8;

using System;

public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    // Constructor to assign ID, name, and age
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    // Method to change customer ID
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    // Method to print customer information
    public void PrintCusInfo()
    {
        Console.WriteLine($"ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    // Method to compare age with another customer
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine("Both customers are of the same age.");
        }
    }
}

class Program
{
    // Ensure Main is static and has the correct signature
    static void Main(string[] args)
    {
        // Create two customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        // Print their information
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        Console.WriteLine();

        // Update customers' IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        // Print their information again
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        Console.WriteLine();

        // Compare their ages
        customer1.CompareAge(customer2);
    }
}

      