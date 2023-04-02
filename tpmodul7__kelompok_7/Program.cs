
﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;
using tpmodul7__kelompok_7;

public class Program
{
     public static void Main(string[] args)
     {


        Console.WriteLine("Tugas JSON Deserialization 1 - Rahma Sakti Rahrdian");
        DataMahasiswa1302210095 MhsRahma = new DataMahasiswa1302210095();
        MhsRahma.ReadJSON("tp7_1_1302210095.json");

        Console.WriteLine("Tugas JSON Deserialization 2 - Rahma Sakti Rahrdian");
        KuliahMahasiswa1302210095 MatkulRahma = new KuliahMahasiswa1302210095();
        MatkulRahma.ReadJSON("tp7_2_1302210095.json");

     }
}

