using System;

namespace sampleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //===declare variable===
            string fname , lname, address, birthdate ;
            int umur;

            Console.WriteLine("Hello World!");
            Console.Write("Masukan nama pertama: ");
            fname = Console.ReadLine();

            Console.Write("Masukan nama kedua: ");
            lname = Console.ReadLine();

            Console.Write("Masukan alamat: ");
            address = Console.ReadLine();

            Console.Write("Masukan tanggal lahir: ");
            birthdate = Console.ReadLine();

            Console.Write("Masukan umur: ");
            umur = int.Parse(Console.ReadLine());

            //===print the respon===
            Console.WriteLine("===Output===");
            // Console.WriteLine("nama lengkap anda " +fname+ " " +lname);
            // Console.WriteLine("alamat anda " +address);
            // Console.WriteLine("tanggal lahir anda " +birthdate);
            // Console.WriteLine("umur anda " +umur);
            Console.WriteLine($"nama lengkap anda {fname} {lname}, alamat anda {address}, tanggal lahir anda {birthdate}, umur anda {umur}");
        }
    }
}
