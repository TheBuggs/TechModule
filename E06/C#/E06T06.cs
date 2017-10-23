///////////////////////////////////////////
// 6.	Max Sequence of Equal Elements
///////////////////////////////////////////

using System;

namespace E06T06 {
    public class MaxSequenceOfEqualElements {
        public static string GetEqualElements(string str) {

            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] digit = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                digit[i] = int.Parse(arr[i]);
            }

            int start = 0;
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = i + 1, temp = 2; digit[i] == digit[j]  && j < arr.Length; j++, temp++) {
                    if (count < temp) {
                        start = i;
                        count = temp;
                    }
                }
            }

            string[] result = new string[count];
            for (int i = 0; i < count; i++) {
                result[i] = arr[start].ToString();
            }

            return String.Join(" ", result);
        }
        public static void Main() {

            Console.WriteLine(GetEqualElements(Console.ReadLine()));
        }
    }
}
