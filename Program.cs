using System.ComponentModel;

namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator!");
        
        Console.Write("Enter first radius: ");
        double radius1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter second radius: ");
        double radius2 = Convert.ToDouble(Console.ReadLine());
    
        
        double AreaOfACircle = Math.PI * radius1 * radius2;
        Console.WriteLine("Area of a Circle = " + AreaOfACircle);

        Console.ReadLine();
        

    }
}
