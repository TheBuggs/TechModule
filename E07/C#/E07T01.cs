///////////////////////////////////////////
// 1.	Max Sequence of Equal Elements
///////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace E07T01 {
    public class MaxSequenceOfEqualElements
    {
        public static string MaxSequence(string str) {

            string[] arr = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            List<int> li = new List<int>();

            for (int i = 0; i < arr.Length; i++) {
                li.Add(int.Parse(arr[i]));
            }

            int count = 0;
            int start = 0;

            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = i, temp = 2; li[j] == li[j + 1] && j < arr.Length - 1; j++, temp++) {
                    if (temp > count) {
                        count = temp;
                        start = i;
                    }
                }
            }

            string[] result = new string[count];
            for (int i = 0; i < count; i++) {
                result[i] = start.ToString();
            }
            return String.Join(" ", result);
        }
        public static void Main() {

            Console.WriteLine(MaxSequence(Console.ReadLine()));
        }
    }
}
