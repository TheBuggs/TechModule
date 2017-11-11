///////////////////////////////////////////////////////////
// 1.	Phonebook
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace Е08Т01 {
    public class Phonebook {
        public static void Main() {
          
            var phonebook = new Dictionary<string, List<string>>();
           
            string result = String.Empty;
            string msg    = String.Empty;
            do {
                msg = Console.ReadLine();
                string[] word = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (word[0] == "A") {
                    if (phonebook.ContainsKey(word[1])) {
                        phonebook[word[1]].Add(word[2]);
                    } else {
                        List<string> phone = new List<string>();
                        phone.Add(word[2]);
                        phonebook[word[1]] = phone;
                    }
                }
                else if(word[0] == "S"){
                    if (phonebook.ContainsKey(word[1])) {
                        result += word[1] + " -> ";
                        foreach (string phone in phonebook[word[1]]) {
                            result += phone;
                        }
                        result += "\n";
                    }
                    else {
                        result += "Contact " + word[1] + " does not exist.\n";
                    }
                }
            } while (msg != "END");

            Console.WriteLine(result);
        }
    }
}
