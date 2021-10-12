/*
Do..while
Padafordanwhilekondisi di evaluasi atau dicek diawal atau sebelum iterasi di mulai.do..while, 
melakukan evaluasi kondisi pada akhir iterasi.do..while sendiri mirip sekali dengan while yang membedakannya hanyalah posisi evaluasi atau pengecekan kondisinya.
Karena do..while melakukan evaluasi pada akhir iterasi atau loop, maka dipastikan pasti akan menjalankan setidaknya satu kali iterasi.

do{   kode;} while( condition );


===tugas===
inputan nilai = 1;
input start loop = 1
input end = 10
input (+, *, -)

loop I=1 s/d 10

jika + hasilnya
i=1 output 1+(1 / inputan nilai)
i=2 output 2+(1 / inputan nilai)
dst

jika - hasilnya
i=1 output 1-(1 / inputan nilai)
i=2 output 2-(1 / inputan nilai)
dst

jika * hasilnya
i=1 output 1*(1 / inputan nilai)
i=2 output 2*(1 / inputan nilai)
dst

jika / hasilnya
i=1 output 1/(1 / inputan nilai)
i=2 output 2/(1 / inputan nilai)
*/

using System;

public class logika8 {
    public static void Main() {

        int i, end;
        string opt;

        Console.Write("masukan angka mulai : ");
        i = int.Parse(Console.ReadLine());

        Console.Write("masukan operator : ");
        opt = Console.ReadLine();

        Console.Write("masukan angka berhenti : ");
        end = int.Parse(Console.ReadLine());

        do {
            // Console.WriteLine("i = {0}", i);
            // i++;
            switch(opt) {

                case "+" : {
                    Console.WriteLine("i = {0}", i); 
                    i++;
                    break;
                }
                case "*" : {
                    Console.WriteLine("i = {0}", i); 
                    i = i * (i + 1);
                    break;
                }
                default: {
                    Console.WriteLine("operator salah");
                    break;
                }
            }

            if(i > 9)
                break;

        } while (i <= end);
    }
}