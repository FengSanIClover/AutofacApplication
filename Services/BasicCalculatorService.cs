using Interfaces;
using System;

namespace Services
{
    /// <summary>
    /// 基礎計算機
    /// </summary>
    public class BasicCalculatorService : ICalculatorService
    {
        /// <summary>
        /// 實作 介面的 計算方法
        /// </summary>
        /// <param name="inputStr">輸入的算式</param>
        /// <returns></returns>
        public int Calculate(string inputStr)
        {
            return 0;
        }
    }
}
