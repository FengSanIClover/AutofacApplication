using Services;
using System;

namespace AutofacApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autofac-超簡易計算機");

            Console.WriteLine("輸入計算方式，ex:1+1");

            var calculator = new BasicCalculatorService();

            var calcResult = calculator.Calculate(Console.ReadLine());

            Console.WriteLine($"計算結果為: {calcResult}");

            Console.ReadLine();
        }
    }
}
