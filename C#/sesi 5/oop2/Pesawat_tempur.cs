using System;

public class Pesawat_Tempur : Pesawat { //==instance pesawat==//
    public void terbangTinggi() {

       Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda{1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
    }
}