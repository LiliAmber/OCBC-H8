using System;

public class logika6 {
    public static void Main(string[] args) {

        //==declare variable==
        // int a = 10;
        int a;
        Console.Write("masukan angka : ");
        a = int.Parse(Console.ReadLine());

        //loop while
        //==menghasilkan TRUE jika variable a lebih kecil dari 20
        while(a < 20) {
            Console.WriteLine("Nilai a = " + a);
            a = a + 1;
        }
    }
}