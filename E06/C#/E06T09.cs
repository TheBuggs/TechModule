///////////////////////////////////////////
// 9.	Index of Letters
///////////////////////////////////////////

using System;

namespace E06T09 {
    public class IndexOfLettersr {
        public static string GetIndexOfLetter(string str) {

            string result = String.Empty;
            char[] arr = str.ToCharArray();

            for (int i = 0; i < str.Length; i++) {
                result += arr[i] + " -> "+ ((int)(arr[i] - 97)).ToString() + "\n";
            }
            return result;
        }
        public static void Main() {

            Console.WriteLine(GetIndexOfLetter(Console.ReadLine()));
        }
    }
}
