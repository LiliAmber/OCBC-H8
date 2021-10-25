using System;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //==pesawat==
            Pesawat pesawat1 = new Pesawat();
            pesawat1.nama = "GARUDAKU";
            pesawat1.ketinggian = "2500 kaki";

            pesawat1.terbang();
            pesawat1.sudahTerbang();
            Console.WriteLine("");

            //==pesawat tempur==
            Pesawat pesawat2 = new Pesawat();
            Pesawat_Tempur pswt_tempur = new Pesawat_Tempur();

            pesawat2.nama = "Helly";
            pesawat2.jumlahRoda = 3;
            pesawat2.ketinggian = "1000 kaki";

            pswt_tempur.nama = "AZ500TPU";
            pswt_tempur.jumlahRoda = 5;
            pswt_tempur.ketinggian = "200 kaki";
            pswt_tempur.jumlahPenumpang = "2 penumpang plus kopilot dan assistance";

            pesawat2.terbang();
            pswt_tempur.terbangTinggi();
            Console.WriteLine();

            //==overloading children==
            OverLoadParent datanew = new OverLoadParent();
            datanew.print("Foxy");
            datanew.print(1234567890);

            //==override children==
            OverRide.OverRideParent childNew = new OverRide.OverRideParent();
            childNew.bilangan(10, 5);
            childNew.penjumlahanPerkalian();

            childNew = new OverRide.OverChild();
            childNew.bilangan(20, 5);
            childNew.penjumlahanPerkalian();
        }
    }
}
