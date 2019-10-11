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
        public string Calculate(string inputStr)
        {
            // 取得運算符號的位置
            var symbolIndex = this.GetSymbolIndex(inputStr);

            return "";
        }
    }
}
