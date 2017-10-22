using System;

namespace Е06Т11 {
    public class EqualSums {
        public static string GetItemIndex(string str) {

            string[] numbers = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length == 1) {
                return "0".ToString();
            }

            for (int index = 0; index < numbers.Length; index++) {
                int sumLeft  = 0;

                for (int i = 0; i < index; i++) {
                    sumLeft += int.Parse(numbers[i]);
                    int sumRight = 0;

                    for (int j = numbers.Length - 1; j > index; j--){         
                        sumRight += int.Parse(numbers[j]);
                    }

                    if (sumLeft == sumRight) {
                        return index.ToString();
                    }
                }
            }
            return "no";
        }
        public static void Main() {

            Console.WriteLine(GetItemIndex(Console.ReadLine()));

        }
    }
}
