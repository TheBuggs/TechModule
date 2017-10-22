using System;

namespace E02T01
{
    public class X
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            // With one loop
            String resultOne = String.Empty;
            for (int index = 0; index < number; index++) {
                string temp = new String(' ', number);
                temp.Insert(index, "x");
                temp.Insert(number - index, "x");
                resultOne += temp;
            }

            // With two loops
            String resultTwo = String.Empty;
            for (int row = 0; row < number; row++) {
                for (int column = 0; column < number; column++) {
                    if (row == column || number - column == row + 1){
                        resultTwo += "x";
                    }
                    else {
                        resultTwo += " ";
                    }
                }
                resultTwo += "\n";
            }
            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);
        }
    }
}
