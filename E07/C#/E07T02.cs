///////////////////////////////////////////
// 2.	Change List
///////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace E07T02 {
    public class ChangeList {

        public static void Delete(ref List<int> l, int n) {
            for (int i = 0; i < l.Count; i++){
                if (l[i] == n){
                    l.RemoveAt(i);
                }
            }
        }
        public static void Insert(ref List<int> l, int n, int i){
            //l.RemoveAt(i);
            l.Insert(i, n);
        }
        public static void Main() {

            string[] digit = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<int> li = new List<int>();
            for (int i = 0; i < digit.Length; i++) {
                li.Add(int.Parse(digit[i]));
            }

            string[] msg;
            bool exit = true;
            do{
                msg = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                
                switch(msg[0]){
                    case "Insert":
                        Insert(ref li, int.Parse(msg[1]), int.Parse(msg[2]));
                        break;
                    case "Delete":
                        Delete(ref li, int.Parse(msg[1]));
                        break;
                    case "Even":
                        string even = String.Empty;
                        for (int i = 0; i < li.Count; i++) {
                            if (li[i] % 2 == 0) {
                                even += (even == String.Empty) ? li[i]
                                    .ToString() : " " + li[i].ToString();
                            }
                        }
                        Console.WriteLine(even);

                        exit = false;
                        break;
                    case "Odd":
                        string odd = String.Empty;
                        for (int i = 0; i < li.Count; i++){
                            if (li[i] % 2 != 0){
                                odd += (odd == String.Empty) ? li[i].ToString() : " " + li[i]
                                    .ToString();
                            }
                        }
                        Console.WriteLine(odd);

                        exit = false;
                        break;
                }
            } while (exit);
        }
    }
}
