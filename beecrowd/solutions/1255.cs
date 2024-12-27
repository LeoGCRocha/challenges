using System.Text;
using System;
using System.Collections.Generic;

class URI {
    static void Main(string[] args) {
        int line_numbers = int.Parse(Console.ReadLine());
        for (int i = 0; i < line_numbers; i++) {
            Dictionary<char, int> frequencies_of_numbers = new Dictionary<char, int>();
            string input = Console.ReadLine().ToLower().Replace(" ", "");
            foreach (char eachchar in input) {
                if (!frequencies_of_numbers.ContainsKey(eachchar)) {
                    frequencies_of_numbers.TryAdd(eachchar, 0);
                }
                frequencies_of_numbers[eachchar] += 1;
            }
            StringBuilder max_chars = new StringBuilder();
            int max_occur = 0;
            foreach (char eachchar in frequencies_of_numbers.Keys) {
                if (frequencies_of_numbers[eachchar] > max_occur) {
                    max_occur = frequencies_of_numbers[eachchar];
                    max_chars.Clear(); // Clear list of char
                    max_chars.Append(eachchar); // Add a new char
                } else if (frequencies_of_numbers[eachchar] == max_occur) {
                    max_chars.Append(eachchar); // Add char at the end of the list
                }
            }
            char[] sorted = max_chars.ToString().ToCharArray();
            Array.Sort(sorted);
            foreach (char current in sorted) {
                Console.Write(current);
            }
            Console.WriteLine();
        }

    }
}
