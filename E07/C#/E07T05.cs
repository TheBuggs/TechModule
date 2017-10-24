using System;
using System.Collections.Generic;
namespace E07T05 {
    public class Program {

        public static void Add(ref List<int> number,int index, int item) {
            number.Insert(index,item);
        }

        public static void AddMany(ref List<int> number,int index, int[] items) {
           
            for(int i = 0, j = index; i < items.Length; i++, j++) {
                number.Insert(j, items[i]);
            }
        }
 
        public static string Contains(ref List<int> number, int item) {
            string result = String.Empty;
            for (int i = 0; i < number.Count; i++) {
                if (number[i] == item) {
                    return result = i.ToString();
                }
            }
            return "-1";
        }

        public static void Remove(ref List<int> number, int index){
            number.RemoveAt(index);
        }

        public static void Shift(ref List<int> number, int index){
            List<int> li = new List<int>();
            int len = number.Count - index;
            for (int i = 0; i < len; i++) {
                li.Add(number[index + i]);
            }

            for (int i = 0; i < index; i++) {
                li.Add(number[i]);
            }
            
            number.Clear();
            for (int i = 0; i < li.Count; i++) {
                number.Add(li[i]);
            }
        }

        public static void SumPairs(ref List<int> number){
            List<int> li = new List<int>();
            int len = number.Count;
            int odd = number.Count % 2;

            for (int i = 0; i < len - 1; i+=2){
                    li.Add(number[i] + number[i + 1]);
            }
            if (odd == 1) {
                li.Add(number[len - 1]);
            }
            number.Clear();
            for (int i = 0; i < li.Count; i++) {
                number.Add(li[i]);
            }
        }

        public static string Print(ref List<int> number) {
            string result = String.Empty;
            for (int i = 0; i < number.Count; i++) {
                result += i != 0 ? ", " + number[i].ToString() : "[" + number[i].ToString();
            }
            return result += "]";
        }
        public static void Main() {
            string[] str = Console.ReadLine().Split(new char[] { ' ' });
            List<int> num = new List<int>();

            for (int i = 0; i < str.Length; i++) {
                num.Add(int.Parse(str[i]));
            }

            string result = String.Empty;
            bool exit = true;

            do {
                string[] msg = Console.ReadLine().Split(new char[] {' '});
                switch(msg[0]){
                    case "add":
                        Add(ref num, int.Parse(msg[1]), int.Parse(msg[2]));
                        break;
                    case "addMany":
                        int[] param = new int[msg.Length - 2];
                        for (int i = 0; i < msg.Length - 2; i++) {
                            param[i] = int.Parse(msg[i + 2]); 
                        }
                        AddMany(ref num, int.Parse(msg[1]), param);
                        break;
                    case "contains":
                        result += Contains(ref num, int.Parse(msg[1])) + "\n";
                        break;
                    case "remove":
                        Remove(ref num, int.Parse(msg[1]));
                        break;
                    case "shift":
                        Shift(ref num, int.Parse(msg[1]));
                        break;
                    case "sumPairs":
                        SumPairs(ref num);
                        break;
                    case "print":
                        result += Print(ref num);
                        exit = false;
                        break;
                }
            } while (exit);

            Console.WriteLine(result);
        }
    }
}
