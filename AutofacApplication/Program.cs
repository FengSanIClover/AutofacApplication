using Services;
using System;
// 引用參考
using Autofac;
using Interfaces;

namespace AutofacApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autofac-超簡易計算機");

            Console.WriteLine("輸入計算方式，ex:1+1");

            // 取得 註冊好組件的 Autofac Container
            var container = ContainerConfig.Congigure();

            // Container 解析 計算機介面，取得註冊的 BasicCalculatorService
            var calculator = container.Resolve<ICalculatorService>();

            // 執行計算方法
            var calcResult = calculator.Calculate(Console.ReadLine());

            // 顯示執行結果
            Console.WriteLine($"執行結果為: {calcResult}");

            Console.ReadLine();
        }
    }
}
