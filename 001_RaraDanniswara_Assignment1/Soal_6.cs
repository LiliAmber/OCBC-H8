using System;

class Soal_6 {

    public static void Main(string[] args) {

        string input = "", reverseStr = "";

        Console.Write("enter the words : ");
        input = Console.ReadLine();

        for(int i  = input.Length - 1; i >= 0; i --) {
            reverseStr += input[i];
        }

        // Console.WriteLine(reverseStr);
        Console.WriteLine($"reversed words : {reverseStr}");
        
        if(input == reverseStr) {
            Console.WriteLine("this is palindrome");
        }
        else {
           Console.WriteLine("this is not palindrome"); 
        }
        
    }
}