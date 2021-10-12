/*
Task : Buat Fungsi Login sederhana dengan “Username” & “Password” dimana :Jika kondisi benar maka sistem akan menampilkan Anda Berhasil Login,
Apabila salah satu data input salah baik itu username atau password maka sistem akan menampilkan Username atau Password anda salah.
*/

using System;

public class logika3 {
    public static void Main(string[] args) {

        //===variable declare==
        // string Password;
        string Username, Password;

        //==digunakan untuk menginput value dari username dan password
        Console.Write("Userbame: ");
        Username = Console.ReadLine();
        
        Console.Write("Password: ");
        Password = Console.ReadLine();

        //==logika percabangan(sesuai case)
        if(Username == "ocbc" && Password == "bootcamp") {
            Console.WriteLine("Anda berhasil login");
        }
        else {
            Console.WriteLine("Username atau Password salah");
        }
    }
}