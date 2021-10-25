using System;

class Assignment_1 {

    public static void Main(string[] args) {

        string repeat = "N", input = "";

        do {
            Console.WriteLine(" Assignment 1 \n\n Nama : Rara Danniswara \n No.Peserta : FSDO001ONL001 \n Alamat   : Bandar Lampung");
            Console.WriteLine("");

            Console.WriteLine("===Daftar Soal===");
            Console.WriteLine("");
            Console.WriteLine(" 1. Segitiga Alphabet \n 2. Segitiga Angka \n 3. Faktorial \n 4. Reversed Number \n 5. Number to String \n 6. Palindrome");

            Console.WriteLine("");
            Console.WriteLine("Masukan angka (sesuai dengan nomor urut) untuk melihat jawban: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1" : {
                    Console.WriteLine("Anda memilih Segitiga Alphabet");
                    Console.WriteLine("");

                    int height;
                    string dictionary = "abcdefghijklmnopqrstuvwxyz";

                    Console.Write($"enter the height : ");
                    height = int.Parse(Console.ReadLine());

                    for(int i = 0; i <= height; i++){

                        for(int j = 0; j < height - i; j++) {      
                            Console.Write(" ");      
                        }

                        for(int j = 0; j < i; j++) {      
                            Console.Write(dictionary[j]);      
                        }

                        for(int k = i - 2; k >= 0; k--) {      
                            Console.Write(dictionary[k]);      
                        }

                        Console.WriteLine("");
                    }
                    break;
                }
                case "2" : {

                    Console.WriteLine("Anda memilih Segitiga Angka");
                    Console.WriteLine("");

                    int range;
        
                    Console.Write("enter the range: ");
                    range = int.Parse(Console.ReadLine());

                    for(int i = 0; i <= range; i++){

                        for(int j = 1; j <= range - i; j++) {      
                            Console.Write(" ");      
                        }

                        for(int j = 1; j <= i; j++) {      
                            Console.Write(j);      
                        }
                        
                        for(int k = i - 1; k >= 1; k --) {
                            Console.Write(k);
                        }
            
                        Console.WriteLine("");
                    }
                    break;
                }
                case "3" : {
                    
                    Console.WriteLine("Anda memilih Faktorial");
                    Console.WriteLine("");

                    int numInp;
                    int factorial = 1;

                    Console.Write("enter any number : ");
                    numInp = int.Parse(Console.ReadLine());

                    for(int i = 1; i <= numInp; i++) {
                        factorial *= i;
                    }

                    Console.WriteLine($"factorial of {numInp} is : {factorial}");
                    break;
                }
                case "4" : {

                    Console.WriteLine("Anda memilih Reversed Number");
                    Console.WriteLine("");

                    string numToStr, reverseStr = "";

                    Console.Write("enter the numbers : ");
                    numToStr = Console.ReadLine();

                    if(numToStr.Length > 0) {

                        for(int i  = numToStr.Length - 1; i >= 0; i --) {
                            reverseStr += numToStr[i];
                        }

                        Console.WriteLine($"reversed numbers : {reverseStr}");
                    }
                    else {
                        Console.WriteLine("type the number please !");
                    }

                    break;
                }
                case "5" : {

                    Console.WriteLine("Anda memilih Number to String");
                    Console.WriteLine("");

                    string sentence = "", toString = "";

                    Console.Write("enter the numbers : ");
                    sentence = Console.ReadLine();

                    char[] charArr = sentence.ToCharArray();  
                    foreach (char ch in charArr)  
                    {  
                        
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
                    }
                    Console.WriteLine(toString);
                    break;
                }
                case "6" : {

                    Console.WriteLine("Anda memilih Palindrome");
                    Console.WriteLine("");

                    string word = "", reverseStr = "";

                    Console.Write("enter the words : ");
                    word = Console.ReadLine();

                    if(word.Length > 0) {

                        for(int i  = word.Length - 1; i >= 0; i --) {
                            reverseStr += word[i];
                        }

                        Console.WriteLine($"reversed words : {reverseStr}");
                        
                        if(word == reverseStr) {
                            Console.WriteLine("this is palindrome");
                        }
                        else {
                            Console.WriteLine("this is not palindrome"); 
                        }
                    }
                    else {
                        Console.WriteLine("type your word please !");
                    }
                    break;
                }
                default: {
                    Console.WriteLine("invalid number");
                    break;
                }
            }
            //==kembali ke menu utama==
            Console.Write("Kembali ke menu awal ? Y/N : ");
            repeat = Console.ReadLine();
            repeat = repeat.ToUpper();
        } while(repeat == "Y");
    }
}