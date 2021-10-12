using System;

class Soal_4 {

    public static void Main(string[] args) {

        string numToStr, reverseStr = "";
        // string reverseStr = "";

        Console.Write("enter the numbers : ");
        numToStr = Console.ReadLine();

        for(int i  = numToStr.Length - 1; i >= 0; i --) {
            reverseStr += numToStr[i];
        }

        // Console.WriteLine(reverseStr);
        Console.WriteLine($"reversed numbers : {reverseStr}");
    }
}