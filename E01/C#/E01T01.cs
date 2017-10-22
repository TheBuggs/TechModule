using System;

namespace E01T01{
    public class DebitCardNumber{
        public static void Main(){
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", arr[0], arr[1], arr[2], arr[3]);
        }
    }
}
