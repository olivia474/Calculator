using System.ComponentModel;
using System.Data.Common;

namespace Calculator;
class Program
{

    static void PrintWelcomeMessage() {

        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("=========================="); }

    static void PerformOneCalculation() {

        Console.Write("Please enter the operator: +, -, *, /: ");
        string? Operator = Console.ReadLine();
        
        Console.Write("Please enter the first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Please enter the second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine()); 
    
        if(Operator == "+") {
            double equation = firstNumber + secondNumber;
            Console.WriteLine("The answer is: " + equation);
        }

        else if(Operator == "-") {
            double equation = firstNumber - secondNumber;
            Console.WriteLine("The answer is: " + equation);
        }

        else if(Operator == "*"){
            double equation = firstNumber * secondNumber;
            Console.WriteLine("The answer is: " + equation);
        }

        else if(Operator == "/") {
            double equation = firstNumber / secondNumber;
            Console.WriteLine("The answer is: " + equation);
        }

        else {
            Console.WriteLine("Error");
        }

        Console.ReadLine();
    }
    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        PerformOneCalculation();
    
    }
}