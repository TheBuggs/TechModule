///////////////////////////////////////////
// 3.	Search for a Number
///////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace E07T03 {
    public class SearchForANumber {
        public static void Main() {

            string[] sDigit = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> li = new List<int>();

            for (int i = 0; i < sDigit.Length; i++) {
                li.Add(int.Parse(sDigit[i]));
            }

            string[] sComm = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] iComm = new int[sComm.Length];

            for (int i = 0; i < sComm.Length; i++) {
                iComm[i] = int.Parse(sComm[i]);
            }

            string result = String.Empty;

            result = "NO!";
            for (int i = iComm[1]; i < iComm[0]; i++) {
                if (li[i] == iComm[2]) {
                    result = "YES!";
                }
            }

            Console.WriteLine(result);
        }
    }
}
