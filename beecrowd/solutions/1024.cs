using System;
using System.Text;

class URI {
    static byte[] MoveAscii(char[] arrayChar) {
        byte[] ascii = Encoding.ASCII.GetBytes(arrayChar);
        byte[] new_vector = ascii;
        int half = ascii.Length / 2;
        for (int x = 0; x < ascii.Length; x++) {
            if ((ascii[x] >= 65 && ascii[x] <= 90) || (ascii[x] >= 97 && ascii[x] <= 122)) {
                new_vector[x] = (byte) (ascii[x] + 3);
            } else {
                new_vector[x] = ascii[x];
            }
            if (x >= half) {
                new_vector[x] = (byte) (ascii[x] - 1);
            }
        }
        return new_vector;
    }
    static void PrintByteArray(byte[] my_array) {
        for (int x = 0; x < my_array.Length; x++) {
            Console.Write((char) my_array[x]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args) { 
        var num_lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < num_lines; i++) {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            byte[]new_vector = MoveAscii(input);
            PrintByteArray(new_vector);
        }
    }
}
