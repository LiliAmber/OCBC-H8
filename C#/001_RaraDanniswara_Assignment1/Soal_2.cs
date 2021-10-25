using System; 

class Soal_2 {

    public static void Main(string[] args) {

        int input;
        
        Console.Write("enter the range: ");
        input = int.Parse(Console.ReadLine());

        //==loop begin from 1==
        for(int i = 0; i <= input; i++){

            //==loop untuk spasi==
            for(int j = 1; j <= input - i; j++) {      
                Console.Write(" ");      
            }

            //==segitiga rata kanan==
            for(int j = 1; j <= i; j++) {      
                Console.Write(j);      
            }
            
            //==segitiga sama kaki==
            for(int k = i - 1; k >= 1; k --) {
                Console.Write(k);
            }
            //==make a new line==
            Console.WriteLine("");
        }
    }
}