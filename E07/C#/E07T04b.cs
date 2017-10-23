///////////////////////////////////////////
// Имаме редица от n-брой цели числа. Да се
// най-дългата редица m със стъпка f в n.
// Редицата n е разбъркана.
// m0 + f = m1
// m1 + f = m2
// ...........
// mk + f = mk+1 
///////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace E07T04 {
    public class LongestIncreasingSubsequence {
        public static void Main() {
            string[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           

            List<int> num = new List<int>();

            for (int i = 0; i < arr.Length; i++) {
                num.Add(int.Parse(arr[i]));
            }

            // Sorted list
            for (int i = 0; i < num.Count - 1; i++) {
                for(int j = i + 1; j < num.Count; j++) {
                    if (num[i] > num[j]) {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            
            // Remove the some items
            for (int i = 0; i < num.Count - 1; i++) {
                for (int j = i + 1; j < num.Count; j++) {
                    if (num[i] == num[j]) {
                        num.RemoveAt(j);
                    }
                }
            }

            // Very slow and stupet example
            int count  = 0;
            int start  = 0;
            int step   = 0;
            int offset = 0;

            for (int i = 0; i < num.Count - 1; i++) { 
                for (int j = i + 1; j < num.Count; j++) {
                    step = num[j] - num[i];
                    for (int k = 0; k < num.Count - 1; k++) {
                        for (int s = 1, temp = 2; k + s < num.Count; s++) {
                            if (num[k] + step == num[k + s]) {
                                if (temp > count) {
                                    count = temp;
                                    start = s;
                                    offset = step;
                                }
                                temp++;
                            }
                        }
                    }
                    
                }
            }

            string result = String.Empty;
            for (int i = start; i < num.Count; i += offset) {
                if (i == start) {
                    result += num[i].ToString();
                }
                else{
                    result += " " + num[i].ToString();
                }
            }

            Console.WriteLine("{0}", result);
        }
    }
}
