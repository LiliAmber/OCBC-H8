/*
Percabangan IF..ELSE..IF ini dapat digunakan untuk menetapkan output sesuai kondisi.
Contohnya pada sebuah program pendidikan yang mengkategorikan nilai angka menjadi grade. 
Misalkan nilai murid tersebut 80 maka akan mendapatkan grade B dan begitu seterusnya.
*/

using System;

public class logika4 {
    public static void Main(string[] args) {

        //==variable declare==
        double nilai;

        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());

        //==if else if statement==
        if(nilai >= 85) {
            Console.WriteLine("Kamu mendapat grade A");
        }
        else if(nilai >= 65) {
            Console.WriteLine("Kamu mendapat grade B");
        }
        else if(nilai >= 45) {
            Console.WriteLine("Kamu mendapat grade C");
        }
        else if(nilai >= 25) {
            Console.WriteLine("Kamu mendapat grade D");
        }
    }
}