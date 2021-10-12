/*
Tipe Data String Tipe Data yang digunakan untuk mengolah sekumpulan karakter.
Contoh kali ini kita akan membuat program PendaftaranPenduduk sederhana

*/

using System;

class String {
    static void Main(string[] args) {
        //===membuat variabel kosong===
        string nama, alamat;
        int umur;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukan alamat: ");
        // var alamat = Console.ReadLine();
        alamat = Console.ReadLine();
        Console.Write("Masukan umur: ");
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