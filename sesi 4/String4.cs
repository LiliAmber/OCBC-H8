using System;

class String4 {

    static void  Main() {
        string stringAwal = "C# membuat string mudah.";

        //==menciptakan sebuah substring.
        string substr = stringAwal.Substring(5, 12);

        Console.WriteLine("stringAwal : " + stringAwal);
        Console.WriteLine("substring : " + substr);
    }
}