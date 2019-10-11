using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    /// <summary>
    /// 計算機介面
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// 計算方法
        /// </summary>
        /// <param name="inputStr">輸入的算式</param>
        /// <returns></returns>
        string Calculate(string inputStr);
    }
}
