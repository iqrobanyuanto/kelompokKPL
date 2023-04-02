
﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;

public class Program
{
     public static void Main(string[] args)
     {
        Console.WriteLine("Tugas JSON Deserialization 2 - Deva Angela Felisitas"+Environment.NewLine);
        KuliahMahasiswa1302213111 daftarMatkul = new KuliahMahasiswa1302213111();
        daftarMatkul.ReadJSON();
     }
}

