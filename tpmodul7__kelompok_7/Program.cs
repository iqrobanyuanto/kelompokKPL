
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


        Console.WriteLine("Tugas 1 - Iqro Banyuanto");
        DataMahasiswa1302213061 dat = new DataMahasiswa1302213061();
        Mahasiswa run = dat.ReadJSON<Mahasiswa>("tp7_1_1302213061.json");
        Console.WriteLine("Nama "+run.nama.depan + " "+ run.nama.belakang+" dengan nim "+ run.nim+" dari fakultas "+ run.fakultas);
        Console.WriteLine("\nTugas 2 - Iqro Banyuanyo");
        KuliahMahasiswa13022130061 dat2 = new KuliahMahasiswa13022130061();
        matkul run2 = dat2.ReadJSON("tp7_2_1302213061.json");
        for(int i = 0; i < run2.courses.Count; i++)
        {
            Console.WriteLine("MK "+(i+1)+" "+run2.courses[i].code+" - "+ run2.courses[i].name);
        }


        Console.WriteLine("Tugas JSON Deserialization 1 - Alif Taufiqurrahman");
        DataMahasiswa1302213011 dataMhs = new DataMahasiswa1302213011();
        dataMhs.ReadJSON();

        Console.WriteLine("Tugas JSON Deserialization 2 - Alif Taufiqurrahman");
        KuliahMahasiswa1302213011 kuliah = new KuliahMahasiswa1302213011();
        kuliah.ReadJSON();
        

        Console.WriteLine("Tugas JSON Deserialization 1 - Deva Angela Felisitas");
        DataMahasiswa1302213111 dataMahasiswa = new DataMahasiswa1302213111();
        dataMahasiswa.ReadJSON();



     }
}

