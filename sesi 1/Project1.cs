/*
Untuk Kali ini kita akan explorasi seputar tipe data numerik melalui menghitung luas persegi panjangdimana panjang = 20 dan lebar = 2.3
Expektasi pada program kita nantinya memberikan nilai akhir Luas Persegi Panjang.

*/

using System;

class Project1 {
    public static void Main(string[] args) {
        int panjang = 20;
        double lebar = 2.3;

        Console.WriteLine("Hitung Luas Persegi Panjang");
        Console.WriteLine("Luas = P x L");
        Console.WriteLine("Luas = " +panjang + "x" +lebar);
        Console.WriteLine("Luas = " +panjang * lebar);
        Console.ReadLine();
    }
}