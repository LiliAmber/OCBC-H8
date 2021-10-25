using System; 

class sesi4 {

    public static void Main() {
        int x = 4;
        int y = 2;

        // Kendaraan mobil = new Kendaraan();

        int[] aAngka = new int[5];
        string[] aNama = new string[] {"Joni", "Meri", "David"};
        object[] aObj = {20.33, "Lorem ipsum", DateTime.Now, true, "D"};

        Console.WriteLine($"{x} \n {y}");
        Console.WriteLine(aAngka);
        Console.WriteLine(aNama);
        Console.WriteLine(aObj);
    }
}
