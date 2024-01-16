using System.Numerics;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp7
{
        public class Calculator
        {
            static void Main(string[] args)
            {
                char z;
                do
                {
                    int x = 0, y = 0;
                    Console.Write("Enter the first number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Choose an operation (+, -, *, /): ");
                    char operation = Convert.ToChar(Console.ReadLine());

                    PerformOperation(x, y, operation);

                    Console.WriteLine("\nDo you want to perform another calculation? (y/n)");
                    z = Convert.ToChar(Console.ReadLine());
                } while (z == 'y' || z == 'Y');
            }

            static void PerformOperation(int x, int y, char operation)
            {
                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"Addition of {x} and {y} is {x + y}");
                        break;
                    case '-':
                        Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
                        break;
                    case '*':
                        Console.WriteLine($"Multiplication of {x} and {y} is {x * y}");
                        break;
                    case '/':
                        if (y != 0)
                            Console.WriteLine($"Division of {x} by {y} is {x / (double)y}");
                        else
                            Console.WriteLine("Cannot divide by zero!");
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                        break;
                        //Testing 1 2 3
                }
            }
        }
    
}
