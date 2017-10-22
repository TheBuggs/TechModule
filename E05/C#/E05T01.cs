///////////////////////////////////////////
// Task 1.	Hello, Name!
///////////////////////////////////////////

using System;

namespace E05T01 {
    public class HelloName {

        public static void Hello(string name) {

            Console.WriteLine("Hello, {0}!", name);
        }
        public static void Main() {

            string name = Console.ReadLine();
            Hello(name);
        }
    }
}
