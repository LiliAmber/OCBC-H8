using System;

class Soal_5 {

    public static void Main(string[] args) {

        string sentence = "", toString = "";

        Console.Write("enter the numbers : ");
        sentence = Console.ReadLine();

        char[] charArr = sentence.ToCharArray();  
        foreach (char ch in charArr)  
        {  
            // Console.WriteLine(ch);  

            if(ch == '0') {
                toString += "Zero ";
            }
            else if(ch == '1') {
                toString += "One ";
            }
            else if(ch == '2') {
                toString += "Two ";
            }
            else if(ch == '3') {
                toString += "Three ";
            }
            else if(ch == '4') {
                toString += "Four ";
            }
            else if(ch == '5') {
                toString += "Five ";
            }
            else if(ch == '6') {
                toString += "Six ";
            }
            else if(ch == '7') {
                toString += "Seven ";
            }
            else if(ch == '8') {
                toString += "Eight ";
            }
            else if(ch == '9') {
                toString += "Nine ";
            }
            else {
                Console.WriteLine("no symbol and alphabet allowed");
            }

        //==error==
        //Soal_5.cs(18,23): error CS0029: Cannot implicitly convert type `string' to `char'
            // switch (ch)
            // {
            //     case "0" : {
            //         toString += "Zero";
            //         break;
            //     }
            //     case "1" : {
            //         toString += "One";
            //         break;
            //     }
            //     case "2" : {
            //         toString += "Two";
            //         break;
            //     }
            //     default: {

            //         break;
            //     }
            // }
        }

        Console.WriteLine(toString);
    }
}