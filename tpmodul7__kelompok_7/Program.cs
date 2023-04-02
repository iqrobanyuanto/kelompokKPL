
﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;
using tpmodul7__kelompok_7;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa1302213117 mhs = new DataMahasiswa1302213117();
        DataMahasiswa1302213117 data = mhs.ReadJSON();
        Console.WriteLine(data.nama.depan + " " + data.nama.belakang);
        Console.WriteLine(data.nim);
        Console.WriteLine(data.fakultas);
    }
}


