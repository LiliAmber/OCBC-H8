/*
Statement If-ElseStatement Else adalah pengikut dari Statement IF, apabila Statement IF adalah statement Utama maka statement Else adalah statement kedua atau statement Opsional.
Statement Else akan dieksekusi apabila Statement IF tidak mendapatkan hasil atau mempunyai hasil Salah.
if (condition) {  //statements}else { //statements}
Compiler akan menguji kondisi:– Apabila statement bernilai true, maka kode di dalam pernyataan IF akan dieksekusi.– A
pabila statement bernilai false, maka kode dalam pernyataan Else akan dieksekusi.

*/

using System;

public class logika2 {
    public static void Main(string[] args) {

        string name;
        int nilai;

        Console.Write("Masukan Nama: ");
        name = Console.ReadLine();

        Console.Write("Masukan Nilai: ");
        nilai = int.Parse(Console.ReadLine());

        if(nilai < 60) {
            Console.WriteLine("Nilai Kamu C");
        }
        else if(nilai < 80) {
            Console.WriteLine("Nilai Kamu B");
        }
        else {
            Console.WriteLine("Nilai Kamu A");
        }
    }
}