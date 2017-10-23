///////////////////////////////////////////
// 7. Max Sequence of Increasing Elements
///////////////////////////////////////////

using System;

namespace E06T07 {
    public class MaxSequenceOfIncreasingElements {
        public static string GetEqualElements(string str) {

            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] digit = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                digit[i] = int.Parse(arr[i]);
            }

            int start = 0;
            int count = 0;

            for (int i = 0; i < digit.Length; i++) {
                int temp = 2;
                for (int j = i; j < digit.Length - 1; j++) {
                    if (!(digit[j] + 1 == digit[j + 1])) {
                        i = j;
                        break;
                    }

                    if (temp > count) {
                        start = i;
                        count = temp;
                    }
                    temp++;
                }
            }

            string[] result = new string[count];
            for (int i = 0; i < count; i++) {
                result[i] = arr[start + i].ToString();
            }

            return String.Join(" ", result);
        }
        public static void Main() {

            Console.WriteLine(GetEqualElements(Console.ReadLine()));
        }
    }
}
