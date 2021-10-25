using System;

class HitungNilai4 {
    public static void Main(String[] args) {

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.Write("Jenis Kelamin: ");
        string jenisKelamin = Console.ReadLine();

        Console.Write("Status Pernikahan: ");
        string isMarried = Console.ReadLine();

        //==pernyataan 1==
        bool isAdult = age > 18;
        //==pernyataan 2==
        bool isPasswordValid = password == "OCBC";
        //==pernyataan 3==
        bool isUsername = username == "rara";

        //==implementasi logika AND==
        if(isUsername && isAdult && isPasswordValid) {
            Console.WriteLine("WELCOME TO THE CLUB!");

            int pertama, kedua, ketiga, total ;
            double rata;

            Console.WriteLine("===Menghitung Nillai===");
            Console.Write("Masukan nilai PERTAMA: ");
            pertama = int.Parse(Console.ReadLine());

            Console.Write("Masukan nilai KEDUA: ");
            kedua = int.Parse(Console.ReadLine());

            Console.Write("Masukan nilai KETIGA: ");
            ketiga = int.Parse(Console.ReadLine());

            //===count the average===
            total = pertama + kedua + ketiga;
            rata = total / 3.0;

            //==print result biodata==
            Console.WriteLine("==Biodata==");
            Console.WriteLine($"umur: " +age);
            Console.WriteLine($"username: " +username);
            Console.WriteLine($"jenis kelamin: " +jenisKelamin);
            Console.WriteLine($"status nikah: " +isMarried);

            //===print the respon Op===
             Console.WriteLine("==Total Nilai==");
            Console.WriteLine("Total Nilai adalah: " + total);
             Console.WriteLine("Rata Rata Nilai adalah: " + rata);  
        } else {
            Console.WriteLine("Sorry, try again!");
        }

    }
}