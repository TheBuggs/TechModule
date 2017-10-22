using System;

namespace E06T01{
    public class LargestCommonEnd{
		
        public static int GetEqualStrings(string r, string l) {
            
			int countRight = 0;
            int countLeft  = 0;

            string[] right = l.Split(' ');
            string[] left  = r.Split(' ');

            int min = right.Length; 

            if (min > left.Length) {
                min = left.Length;
            }

            for (int i = 0; i < min; i++) {
                if (right[i] != left[i]) {
                    break;
                }
                countRight++;
            }
         
            for (int i = 0; i < min; i++){ 
                if (right[right.Length - i - 1] != left[left.Length - i - 1]){
                   break;
                }
                countLeft++;
            }

            if (countLeft > countRight) {
                return countLeft;
            }
            return countRight;
        }

        public static void Main(){
         
            String txtRight = Console.ReadLine();
            String txtLeft  = Console.ReadLine();
            
            Console.WriteLine(GetEqualStrings(txtRight, txtLeft));
        }
    }
}
