using System;

class Soal_1 {

    public static void Main(string[] args) {

        //==buat dictionary, tinggi segitiga==
        int height;
        string dictionary = "abcdefghijklmnopqrstuvwxyz";

        Console.Write($"enter the height : ");
        height = int.Parse(Console.ReadLine());

        //==loop ubtuk membuat baris sebanyak nilai tinggi==
        for(int i = 0; i <= height; i++){

            //==loop untuk spasi==
            for(int j = 0; j < height - i; j++) {      
                Console.Write(" "); 
                // Console.WriteLine(dictionary[j]);     
            }

            //==segitiga rata kanan==
            for(int j = 0; j < i; j++) {      
                Console.Write(dictionary[j]);      
            }

            //==segitiga sama kaki==
            for(int k = i - 2; k >= 0; k--) {      
                Console.Write(dictionary[k]);      
            }

            //==make a new line==
            Console.WriteLine("");
        }
    }   
}
