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

            // 執行計算方法，回傳執行結果
            var calcResult = GetResult(Console.ReadLine());

            // 顯示執行結果
            Console.WriteLine($"執行結果為: {calcResult}");

            Console.ReadLine();
        }

        /// <summary>
        /// 透過 子生命周期，解析組件，並取得計算結果
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        private static string GetResult(string inputStr)
        {
            // 取得 註冊好組件的 Autofac Container
            // 創建子生命周期，解析組件
            using (var scope = ContainerConfig.Congigure().BeginLifetimeScope())
            {
                // 解析組件
                var calculator = scope.Resolve<ICalculatorService>();

                // 回傳執行結果
                return calculator.Calculate(inputStr);
            }
        }
    }
}
