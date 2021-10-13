using System;

public class Pesawat {

    public string nama;
    private string _ketinggian;
    public string jumlahPenumpang;
    public int jumlahRoda;

    //==setter & getter==
    public string ketinggian {
        get { return _ketinggian; }
        set { _ketinggian = value; }
    }

    public void terbang() {

        Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
    }

    public void sudahTerbang() {
        //==panggil var setternya==
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
    }
}