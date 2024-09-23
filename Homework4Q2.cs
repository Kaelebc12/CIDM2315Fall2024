namespace Homework4Q2;

class Program
{
    
    static void Input(){
    
        Console.Write("N is: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Shape is ");
        string b = Console.ReadLine();
        
        if(a == a && b == "left"){
            for(int i = 0;  i < a; i++){
            for(int j = 0; j < a; j++){
                if(i >= j)
                    Console.Write("*");
            }
                Console.WriteLine("");
        }
    }
        else if(a == a && b == "right")
    {
        for(int i = 0;  i <= a; i++){
            for(int j = 0; j <= a - i; j++)
            {
                Console.Write(" ");
            }   
            for(int k = 1; k <=i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            }   
        }    
        else
        {
            Console.WriteLine("Please enter an integer and side.");
        }
}

    static void Main(string[] args)
    {
        Input();
    }
}

