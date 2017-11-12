/////////////////////////////////////////////////////////////
// Problem. 14  Magic Letter
/////////////////////////////////////////////////////////////

using System;

namespace E02T14 {
    public class Program {
        public static void Main() {
            char[] letter = new char[3];

            for (int i = 0; i < 3; i++) {
               letter[i] = char.Parse(Console.ReadLine());
            }

            short[] pos = { (short)letter[0], (short)letter[1], (short)letter[2] };

            string result = String.Empty;

            for (short i = pos[0]; i <= pos[1]; i++) {

                for (short j = pos[0]; j <= pos[1]; j++) {

                    for (short k = pos[0]; k <= pos[1]; k++){

                        if (i == pos[2] || j == pos[2] || k == pos[2]) {
                            continue;
                        }
                        
                            result += (char)i;
                            result += (char)j;
                            result += (char)k + " ";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
