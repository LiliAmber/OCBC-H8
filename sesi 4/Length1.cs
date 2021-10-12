using System;

class Lenght1 {

    static void Main() {

        int[] angka = new int[10];

        Console.WriteLine("Panjang array angka adalah " + angka.Length);

        //==menggunakan Length untuk menginisialisasi angka.
        for(int i = 0; i < angka.Length; i++) 
            angka[i] = i * i;
        
        //==sekarang menggunakan Length untuk menampilkan angka.
        Console.Write("Berikut adalah array angka: ");
        for(int i = 0; i < angka.Length; i++) 
            Console.Write(angka[i] + " ");
        

        Console.WriteLine();
    }
}