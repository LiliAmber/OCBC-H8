/*
NOTtruefalsefalsetrueLogika AND, OR, dan NOT nantinya akan banyak kita pakai dalam membuat logika di program.Nah sekarang kita coba implementasikan dalam program C# dengan Logika AND, Dimana Kondisi Program akan mengizinkan user sign in:
* jika :Usia : > 18 dan Password : OCBC => Welcome To The OCBC

*Disclaimer : Untuk Penggunaan case ini kita akan menggunakan percabangan IF-ELSE, All detail terkait Logika Pemogramman akan kita bahas di sesi 3 ya. Untuk Sekarang cukupikutidulu.

*/

using System;

class HitungNilai4 {
    public static void Main(String[] args) {

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Password: ");
        string password = Console.ReadLine();

        //==pernyataan 1==
        bool isAdult = age > 18;
        //==pernyataan 2==
        bool isPasswordValid = password == "OCBC";

        //==implementasi logika AND==
        if(isAdult && isPasswordValid) {
            Console.WriteLine("WELCOME TO THE CLUB!");
        } else {
            Console.WriteLine("Sorry, try again!");
        }

    }
}