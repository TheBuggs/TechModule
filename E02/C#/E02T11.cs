/////////////////////////////////////////////////
// Problem 11.	5 Different Numbers
/////////////////////////////////////////////////
using System;

namespace Е02Т11 {
	
    public class DifferentNumbers {
		
        public static void Swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
		
        public static void Main() {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (m - n < 0) {
                Swap(ref n, ref m);
            }

            if (m - n < 5) {
                Console.WriteLine("No");
            } else {
                string result = String.Empty;
                
				for (int index1 = n; index1 <= m - 4; index1++) {
                    
					for (int index2 = index1 + 1; index2 <= m - 3; index2++) {
                        
						for (int index3 = index2 + 1; index3 <= m - 2; index3++) {
                            
							for (int index4 = index3 + 1; index4 <= m - 1; index4++) {
                                
								for (int index5 = index4 + 1; index5 <= m; index5++) {
                                    result += index1 + " " + index2 + " " + index3 + " " + index4 + " " + index5 + "\n";
                                }
                            }
                        }
                    }
                }
				
                Console.WriteLine(result);
            }
         
        }
    }
}
