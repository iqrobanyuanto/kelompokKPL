using System;
using System.Text.Json;


public class DataMahasiswa1302213111
{
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\SEMESTER 4\\KPL (Konstruksi Perangkat Lunak)\\Praktikum\\TPmod7\\kelompokKPL\\tpmodul7__kelompok_7\\tp7_1_1302213111.json");

        DataMahasiswa dataMhs = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

        Console.WriteLine("Nama " + dataMhs.nama.depan + " " + dataMhs.nama.belakang + " dengan nim " + dataMhs.nim + " dari fakultas " + dataMhs.fakultas);
    }
}

public class DataMahasiswa
{
    public Nama nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }

    public DataMahasiswa() { }

    public DataMahasiswa(Nama nama, int nim, string fakultas)
    {
        this.nama = nama;
        this.nim = nim;
        this.fakultas = fakultas;
    }
}

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }

    public Nama() { }

    public Nama(string depan, string belakang)
    {
        this.depan = depan;
        this.belakang = belakang;
    }

}