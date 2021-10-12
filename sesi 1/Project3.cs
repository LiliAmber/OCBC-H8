/*
Tipe Data String Tipe Data yang digunakan untuk mengolah sekumpulan karakter.
Contoh kali ini kita akan membuat program PendaftaranPenduduk sederhana

*/

using System;

class Project3 {
    static void Main(string[] args) {
        //===membuat variabel kosong===
        string nama;
        int umur;

        Console.WriteLine("=== PROGRA, PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukan alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Maukan umur: ");
        umur  = int.Parse(Console.ReadLine());

        //===Print the respon===
        Console.WriteLine();
        Console.WriteLine("Terimakasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur} tahun");
        Console.WriteLine("SUDAH DISIMPAN!");
    }
}