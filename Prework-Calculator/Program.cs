using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add");
            Console.Write("First number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Add(num1, num2).ToString());

            Console.WriteLine("Subtract");
            Console.Write("First number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(num1, num2).ToString());

            Console.WriteLine("Multiply");
            Console.Write("First number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Multiply(num1, num2).ToString());

            Console.WriteLine("Divide");
            Console.Write("First number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Divide(num1, num2).ToString());

            System.Threading.Thread.Sleep(5000);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static float Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
