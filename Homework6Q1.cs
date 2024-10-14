namespace Homework6;

public class Professor
{
        public string profName;
        public string classTeach;
        public double salary {get;set;}
              public void SetSalary (double salary_amount)
        {
            if( salary_amount >= 0)
            {
                salary = salary_amount;
            }
            else
           {
            Console.WriteLine("Enter a positive salary");
           }
        }
        public double GetSalary()
        {
            return salary;
        }
}
public class Student
{
    public string studentName;
    public string classEnroll;
    public double studentGrade {get;set;}
    public void SetGrade(double newGrade)
    {
        if(newGrade >= 0 && newGrade <= 100)
        {
            studentGrade = newGrade;
        }
        else
        {
            Console.WriteLine("Grade must be within 0-100.");
        }
    }
    public double GetGrade()
    {
        return studentGrade;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Professor Alice = new Professor
        {
            profName = "Alice",
            classTeach = "Java",
            salary = 9000
        };
        Professor Bob = new Professor
        {
            profName = "Bob",
            classTeach = "Math",
            salary = 8000
        };
        Student Lisa = new Student
        {
            studentName = "Lisa",
            classEnroll = "Java",
            studentGrade = 90
        };
        Student Tom = new Student
        {
            studentName = "Tom",
            classEnroll = "Math",
            studentGrade = 80
        };
        Console.WriteLine("Professor " + Alice.profName + "teaches " + Alice.classTeach + ", and the salary is: "+ Alice.salary);
        Console.WriteLine("Professor " + Bob.profName + "teaches " + Bob.classTeach + ", and the salary is: "+ Bob.salary);

        Console.WriteLine("Student " + Lisa.studentName + "enrolls " + Lisa.classEnroll + ", and the grade is: "+ Lisa.studentGrade);
        Console.WriteLine("Student " + Tom.studentName + "enrolls " + Tom.classEnroll + ", and the grade is: "+ Tom.studentGrade);
        Console.WriteLine("The salary difference between Alice and Bob is: " + (Alice.salary - Bob.salary));
        Console.WriteLine("The total grade of Lisa and tom is: " + (Lisa.studentGrade + Tom.studentGrade));
    }
}