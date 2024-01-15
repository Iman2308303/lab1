using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{
    public class Calc
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

                Addition(x, y);
                Subtraction(x, y);
                Multiplication(x, y);
                Division(x, y);

                Console.WriteLine("\n");
                Console.WriteLine("Do you want to enter new values? (y/n)");
                z = Convert.ToChar(Console.ReadLine());
            } while (z == 'y' || z == 'Y');
        }
        static void Addition(int x, int y)
        {
            Console.WriteLine("Addition of both numbers is {0}", (x + y));
        }
        static void Subtraction(int x, int y)
        {
            Console.WriteLine("Subtraction of both numbers is {0}", (x - y));
        }
        static void Multiplication(int x, int y)
        {
            Console.WriteLine("Multiplication of both number is {0}", (x * y));
            
        }
        static void Division(int x, int y)
        {
            Console.WriteLine("Division of both numbers is {0}", (x / y));
        }
    }
}
