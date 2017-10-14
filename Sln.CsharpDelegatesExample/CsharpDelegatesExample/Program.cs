using System;

delegate T CommonMathOperationDelegates<T>(T Num1, T Num2);

namespace CsharpDelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonMethods oCommonMethods = new CommonMethods();

            CommonMathOperationDelegates<int> Addition = new CommonMathOperationDelegates<int>(oCommonMethods.AdditionNum);
            CommonMathOperationDelegates<int> Subtraction = new CommonMathOperationDelegates<int>(oCommonMethods.SubtractionNum);
            CommonMathOperationDelegates<int> Multiplication = new CommonMathOperationDelegates<int>(oCommonMethods.MultiplicationNum);
            CommonMathOperationDelegates<int> Division = new CommonMathOperationDelegates<int>(oCommonMethods.DivisionNum);

            Console.Write("Enter First Number: ");
            int X = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int Y = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("*****************************************");
            Console.WriteLine("Addition: " + Addition(X, Y));
            Console.WriteLine("Subtraction: " + Subtraction(X, Y));
            Console.WriteLine("Multiplication: " + Multiplication(X, Y));
            Console.WriteLine("Division: " + Division(X, Y));

            Console.ReadLine();
        }
    }
}
