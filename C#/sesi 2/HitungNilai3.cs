/*
Praktik sesi ini kita hanya akan menggunakan semua perbandingan dengan menggunakan source-code HitungNilai2 dan menggunakan seluruh operator yang ada pada tabel diatas.

*/

using System;

class HitungNilai3 {
    public static void Main(String[] args) {

        //===variables declare===
        int nilai1, nilai2 = 0;

        Console.WriteLine("jumlah nilai1 = ");
        nilai1 = int.Parse(Console.ReadLine());

        Console.WriteLine("jumlah nilai2 = ");
        nilai2 = int.Parse(Console.ReadLine());

        //==print the result==
        Console.WriteLine("Hasil perbandingan: ");
        Console.WriteLine($"nilai1 > nilai2: {nilai1 > nilai2}");
        Console.WriteLine($"nilai1 >= nilai2: {nilai1 >= nilai2}");

        Console.WriteLine($"nilai1 < nilai2 : {nilai1 < nilai2}");
        Console.WriteLine($"nilai1 <= nilai2 : {nilai1 <= nilai2}");

        Console.WriteLine($"nilai1 == nilai2 : {nilai1 == nilai2}");
        Console.WriteLine($"nilai1 != nilai2 : {nilai1 != nilai2}");
    }
}