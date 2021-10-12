using System;

class tryArray {

    public static void Main(String[] args) {

        string [] example = new string [4]
        {"Motherboard", "Processors", "Power Supply", "Video Card"};

        // Console.WriteLine($"{example}");
        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");

        foreach (string i in example) {
            Console.WriteLine(i);
        }
        
        Console.Write("Press any key to continue ...");
        
    }
}