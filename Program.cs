using System.ComponentModel;
using System.Data.Common;

namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        PerformOneCalculation();

    }
    static void PrintWelcomeMessage() {
        
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("=========================="); 
        }
    static void PerformOneCalculation() {

        Console.Write("Please enter the operator: +, -, *, /: ");
        string? Operator = Console.ReadLine(); 

        Console.Write("How many numbers do you want to " + Operator + ":");
        int numbers = Convert.ToInt32(Console.ReadLine());

        int result = 0;
       
        for(int i= 0; i < numbers; i++) {
            Console.Write("Please enter number " + (i+1) + ":");
            int number = Convert.ToInt32(Console.ReadLine());
        
        if(Operator == "+") {
            result+=number;
        }

        else if(Operator == "-") {
            result-=number;
        }

        else if(Operator == "*") {
            result*=number;
        }

        else if(Operator == "/") {
            result/=number;
        }
        
        else {
            Console.WriteLine("Error");
        }
       }

        Console.WriteLine("The result is: " + result);
        
        Console.ReadLine();
   }
}