using System;

namespace E06T02 {
	
    public class RotateAndSum {
		
        public static string RotateOffsetOneAndSum(string str, int rows) {

            string[] arr = str.Split(' ');

            int[] number = new int[arr.Length];
            int[] sum    = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) {
                number[i] 	= int.Parse(arr[i]);
                sum[i] 		= 0;
            }

            for (int i = 1; i <= rows; i++) {
                for (int j = 0; j < number.Length; j++) {
                    sum[j] += number[ (number.Length + j - i%number.Length) % number.Length ];  
                }   
            }

            return String.Join(" ", sum);
        }
        public static void Main() {

            string numbers = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine(RotateOffsetOneAndSum(numbers, rows)); 
        }
    }
}
