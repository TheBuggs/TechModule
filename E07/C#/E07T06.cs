//////////////////////////////////////////////////////////
// 6.	Sum Reversed Numbers
//////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Е07Т06 {
    public class SumReversedNumbers {
        public static string SumReversNumber(string str) {

            string[] arr = str.Split(new char[] { ' ' });
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                char[] c = arr[i].ToCharArray();
                string num = String.Empty;
                for (int j = c.Length - 1; j >= 0; j--) {
                    num += c[j].ToString();
                }
                sum += int.Parse(num);
            }
            return sum.ToString();

        }
        public static void Main() {
            Console.WriteLine(SumReversNumber(Console.ReadLine()));
        }
    }
}
