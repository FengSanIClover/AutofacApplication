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

            if (symbolIndex < 0)
                return "輸入錯誤，請重新輸入!!";

            int leftNum = 0;
            int rightNum = 0;
            try
            {
                leftNum = Int32.Parse(inputStr.Substring(0, symbolIndex));
                rightNum = Int32.Parse(inputStr.Substring(symbolIndex + 1));
            }
            catch
            {
                return "輸入錯誤，請重新輸入!!";
            }

            // 取得運算符號
            var symbol = inputStr[symbolIndex];

            // 回傳計算結果
            return this.CalcResult(leftNum, symbol, rightNum);
        }

        /// <summary>
        /// 取得運算符號的位置
        /// </summary>
        /// <param name="inputStr">輸入的算式</param>
        /// <returns></returns>
        private int GetSymbolIndex(string inputStr)
        {
            for (int i = 0; i < inputStr.Length; i += 1)
            {
                // 回傳 非數值的位置
                if (!char.IsDigit(inputStr[i]))
                    return i; 
            }

            return -1;
        }

        /// <summary>
        /// 計算結果
        /// </summary>
        /// <param name="leftNum">運算符號左邊數字</param>
        /// <param name="symbol">運算符號</param>
        /// <param name="rightNum">運算符號右邊數字</param>
        /// <returns></returns>
        private string CalcResult(int leftNum, char symbol, int rightNum)
        {
            switch (symbol)
            {
                case '+':
                    return $"{leftNum + rightNum}";
                case '-':
                    return $"{leftNum - rightNum}";
                case '*':
                    return $"{leftNum * rightNum}";
                case '/':
                    return $"{leftNum / rightNum}";
                default:
                    return "尚無此計算方法";
            }
        }
    }
}
