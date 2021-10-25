using System;

class Soal_3 {

    public static void Main(string[] args) {

        //==faktorial, no zero include==
        int input;
        int factorial = 1;

        Console.Write("enter any number : ");
        input = int.Parse(Console.ReadLine());

        for(int i = 1; i <= input; i++) {
            // Console.WriteLine(i);
            factorial *= i;
        }

        // Console.WriteLine(factorial);
        Console.WriteLine($"factorial of {input} is : {factorial}");
    }
}