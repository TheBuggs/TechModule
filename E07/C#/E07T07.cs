///////////////////////////////////////////////////////////
// 7.	Bomb Numbers
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace E07T07 {
    public class Program {
        public static void Main() {
            string[] str = Console.ReadLine()
                .Split(new char[] { ' ' });
            string[] com = Console.ReadLine()
                .Split(new char[] { ' ' });

            List<int> num = new List<int>();

            int sum = 0;
            for (int i = 0; i < str.Length; i++) {
                num.Add(int.Parse(str[i]));
            }

            int[] bomb = new int[com.Length];
            for (int i = 0; i < com.Length; i++) {
                bomb[i] = int.Parse(com[i]);
            }
            for (int i = 0; i < num.Count; i++) {
                if (num[i] == bomb[0]) {
                    int n = i;
                    int j = i - 1;
                    while (j >= 0 && j >= n - bomb[1]) {
                        num.RemoveAt(j);
                        i--;
                        j--;
                    }

                    j = i + 1;
                    i = n;
                    while (j < num.Count && j < n + bomb[1]) {
                        num.RemoveAt(j);
                        i--;
                        j++;
                    }
                    sum -= bomb[0];
                }
            }

            for (int i = 0; i < num.Count; i++) {
                sum += num[i];
            }
            Console.WriteLine(sum.ToString());
           
        }
    }
}
