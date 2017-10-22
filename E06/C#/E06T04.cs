using System;
using System.Collections.Generic;

namespace E06T04{

    public class SieveOfEratosthenes {
        public static List<int> Primes(int n) {
           
            bool[] prime = new bool[n];

            for (int i = 0; i < n; i++) {
                prime[i] = true;
            } 
           
            int limit = (int)Math.Sqrt(n);

            List<int> number = new List<int>();

            for (int i = 2; i < limit + 1; i++) {
                if (prime[i] == true) {
                    for (int j = i*i; j < n ; j += i) {
                        prime[j] = false;
                    }
                }
            }

            for (int i = 2, j = 0; i < n; i++) {
                if (prime[i]) {
                    number.Add(i);
                }
            }

            return number;
        }
        public static void Main(){

            int limit = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(" ", Primes(limit)));
        }
    }
}
