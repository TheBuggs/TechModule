///////////////////////////////////////////
// 8.	Most Frequent Number
///////////////////////////////////////////

using System;

namespace E06T08 {
    public class MostFrequentNumber {
        public static string GetEqualElements(string str) {

            string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            ushort[] digit = new ushort[arr.Length];

            for (ushort i = 0; i < arr.Length; i++) {
                digit[i] = ushort.Parse(arr[i]);
            }
  
            for (ushort i = 0; i < digit.Length - 1; i++) {
                ushort temp = 0;
                for (ushort j = (ushort)(i + 1); j < digit.Length; j++) {
                    if (digit[i] > digit[j]) {
                        temp = digit[i];
                        digit[i] = digit[j];
                        digit[j] = temp;
                    }
                }
            }

            int start = 0;
            int count = 0;

            for (int i = 0; i < digit.Length - 1; i++){
                int temp = 2;
                for (int j = i; j < digit.Length - 1; j++){
                    if (!(digit[j] == digit[j + 1])){
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
            return digit[start].ToString();
        }
        public static void Main() {

            Console.WriteLine(GetEqualElements(Console.ReadLine()));
        }
    }
}
