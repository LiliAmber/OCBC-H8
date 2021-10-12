using System;

public class logika1 {
    public static void Main(string[] args) {
        // int a = 92;
        // int b = 53;
        int a, b ;

        Console.Write("Masukan Nilai Pertama : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Masukan Nilai Kedua : ");
        b = int.Parse(Console.ReadLine());

        if(a > b) {
            Console.WriteLine("Nilai pertama lebih besar daripada nilai kedua");
        }
        else if(a < b) {
            Console.WriteLine("Nilai pertama lebih kecil daripada nilai kedua");
        }
        else if(a == b) {
            Console.WriteLine("Nilai pertama sama dengan nilai kedua");
        }
    }
}