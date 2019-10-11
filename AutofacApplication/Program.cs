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

            // 實體化 BasicCalculatorService 類別
            var calculator = new BasicCalculatorService();

            // 使用計算方法並取得結果
            var calcResult = calculator.Calculate(Console.ReadLine());

            // 顯示執行結果
            Console.WriteLine($"執行結果為: {calcResult}");

            Console.ReadLine();
        }
    }
}
