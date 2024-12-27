using System;
using System.Text;

class URI {
    static string ShiftWord(int number, string word) {
        byte []byteArray = Encoding.ASCII.GetBytes(word.ToCharArray());
        for (int i = 0; i < byteArray.Length; i++) {
            var reffValue = byteArray[i] - number;
            if (reffValue < 65) {
                var diff = 65 - reffValue;
                reffValue = 91 - diff;
            }
            byteArray[i] = (byte) reffValue;
        }
        return Encoding.ASCII.GetString(byteArray);
    }
    static void Main(string[] args) { 
        int numOfInputs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfInputs; i++) {
            string input = Console.ReadLine();
            int shiftNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ShiftWord(shiftNumber, input));
        }
    }
}