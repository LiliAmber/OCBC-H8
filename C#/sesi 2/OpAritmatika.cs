/*
Task :Buat Sebuah Program dimana User akan memasukkan nilai 1 , 2 & 3 yang kemudian Program bisa menghasilkan AVERAGE/Rata-Rata dari 3 Nilai yang disubmit oleh User
*/

using System;

class OpAritmatika {
    public static void Main(string[] args) {

        //===declare variables===
        int pertama, kedua, ketiga, total ;
        double rata;

        Console.WriteLine("===Menghitung Nillai===");
        Console.Write("Masukan nilai PERTAMA: ");
        pertama = int.Parse(Console.ReadLine());

        Console.Write("Masukan nilai KEDUA: ");
        kedua = int.Parse(Console.ReadLine());

        Console.Write("Masukan nilai KETIGA: ");
        ketiga = int.Parse(Console.ReadLine());

        //===count the average===
        total = pertama + kedua + ketiga;
        rata = total / 3.0;

        //===print the respon===
        Console.WriteLine("Total Nilai adalah: " + total);
        Console.WriteLine("Rata Rata Nilai adalah: " + rata);
    }
}