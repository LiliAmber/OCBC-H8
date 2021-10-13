using System;

public class OverChild: OverRideParent {

    public override void penjumlahanPerkalian()
    {
        onsole.WriteLine("===Overiding 2===");
        Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
        Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2);
    }
}