using System;

class Program {

    public static void Main(string[] args) {

        //==instance obj==
        Laptop laptop1 = new Laptop();

        //==akses attribut==
        laptop1.merk = "Lenovo";
        laptop1.ram = 4;
        laptop1.memory = 512;

        //==print==
        Console.WriteLine("\n Merk Laptop adalah {0}", laptop1.merk);
        Console.WriteLine("Kapasitas ram ada {0}", laptop1.ram);
        Console.WriteLine("Kapasitas memory ada {0}", laptop1.memory);

        //==akses method==
        laptop1.Chatting();
        laptop1.Sosmed();
        laptop1.OnlineShop();

        Console.Read();
    }
}