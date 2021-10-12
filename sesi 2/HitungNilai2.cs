/*
Pada Sesi Kali ini kita akan membuat 2 variabel nilai : nilai1 dan nilai2 Dimana nilai1 kita akan isi ulang variable nya sebanyak 5 sedangkan nilai2 kita tambahkan 6 dari nilai semula. Contoh : 

*/

using System;

class HitungNilai2 {
    public static void Main(String[] args) {

        //===menggunakan operator = untuk mengisi nilai
        int nilai1 = 10;
        int nilai2 = 8;

        //===mengisi ulang nilai suatu variabel
        nilai1 = 15;

        Console.WriteLine($"nilai1 = {nilai1}");

        //===menggunakan += untuk mengisi dan menjumlahkan 
        nilai2 += 6;

        Console.WriteLine($"nilai2 = {nilai2}");
    }
}