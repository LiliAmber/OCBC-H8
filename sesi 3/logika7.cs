using System;

public class logika7 {
    public static void Main(string[] args) {

        //==struktur for loop==
        //(init; condition; increment)

        int start, end;

        Console.Write("mulai iterasi di angka: ");
        start = int.Parse(Console.ReadLine());

        Console.WriteLine("selesai iterasi di angka : ");
        end = int.Parse(Console.ReadLine());

        for(int a = start; a <= end; a = a + 1) {
            Console.WriteLine("Iterasi ke - " + a);
        }
    }
}