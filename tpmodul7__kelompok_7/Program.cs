using System;
using System.Text.Json;

public class Program
{
     public static void Main(string[] args)
     {
         DataMahasiswa1302213061 dat = new DataMahasiswa1302213061();
        Mahasiswa run = dat.ReadJSON<Mahasiswa>("tp7_1_1302213061.json");
        Console.WriteLine(run.nama.depan + " "+ run.nama.belakang);
        Console.WriteLine(run.nim);
        Console.WriteLine(run.fakultas);
    }
}