/////////////////////////////////////////////////////////////
//Problem 1.	Anonymous Downsite
/////////////////////////////////////////////////////////////

using System;
using System.Numerics;

namespace E01BT01 {
    public class Program {
        public static void Main() {

            ushort n = ushort.Parse(Console.ReadLine());
            ushort m = ushort.Parse(Console.ReadLine());

            Decimal total = 0;                               // Use BigDecimal
            string result = String.Empty;
            
            for (int i = 0; i < n; i++) {

                string[] words = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                total += int.Parse(words[1]) * decimal.Parse(words[2]);
                result += words[0] + "\n";

            }

            BigInteger val = new BigInteger(1);
            for (int i = 0; i < n; i++)
                val *= m;

            Console.WriteLine("{0}Total Loss: {1:F20}\nSecurity Token: {2}", result, total, val);
        }
    }
}
