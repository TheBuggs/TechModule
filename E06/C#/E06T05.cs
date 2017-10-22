using System;

namespace E06T05 {
	
    public class CompareCharArrays {
		
        public static void Main() {

            string[] first  = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] second = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int min = Math.Min(first.Length, second.Length);

            short flagFirst  = 0;
            short flagSecond = 0;

            for (int i = 0; i < min; i++) {
                if ((short)first[i].ToCharArray()[0] < (short)second[i].ToCharArray()[0]) {
                    flagFirst = 1;
                    break;
                }

                if ((short)first[i].ToCharArray()[0] > (short)second[i].ToCharArray()[0]) {
                    flagSecond = 1;
                    break;
                }
            }

            if (flagFirst == 0 && flagSecond == 0) {
                if (first.Length == min) {
                    flagFirst = 1;
                }
                else {
                    flagSecond = 1;
                }
            }

            Console.WriteLine("{" + flagFirst.ToString() +"}\n{" + flagSecond.ToString() + "}",
                String.Join(" ", second),
                String.Join(" ", first));
        }           
    }
}
