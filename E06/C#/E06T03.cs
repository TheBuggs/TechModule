using System;
using System.Text.RegularExpressions;

namespace E06T03 {
    public class FoldAndSum {

        public static string FoldSum(string text) {

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            string temp = regex.Replace(text, " ");

            string[] word   = temp.Split(' ');
            int[] digit     = new int[word.Length];

            for (int i = 0; i < word.Length; i++) {
                digit[i] = int.Parse(word[i]);
            }

            int quard = digit.Length / 4;
            int[] sum = new int[quard * 2];

            for (int i = 1, j = 1 * quard, k = digit.Length + quard - 1; j < 3 * quard; j++, i++, k--) {
                sum[j - quard] = digit[j] + digit[ quard - i >= 0 ? quard - i: k];
            }

            return String.Join(" ", sum);
        }
        public static void Main() {
            string text = Console.ReadLine();
            Console.WriteLine(FoldSum(text));
        }
    }
}
