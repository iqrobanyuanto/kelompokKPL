using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7__kelompok_7
{
    internal class DataMahasiswa1302210095
    {
        public void ReadJSON(string filename)
        {
            //generate file path
            string path = "\\" + filename;

            //membaca file json
            string read = File.ReadAllText(path);

            //mengubah file json yang sudah di baca menjadi object
            Mahasiswa1302210095 obj = JsonSerializer.Deserialize<Mahasiswa1302210095>(read);

            Console.WriteLine(
                "Nama " + obj.nama.depan + " " + obj.nama.belakang +
                " dengan nim " + obj.nim +
                " dari fakultas " + obj.fakultas 
                );

        }
    }
}


struct Mahasiswa1302210095
{
    public Nama1302210095 nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }
    
    public Mahasiswa1302210095()
    {
        this.nama = new Nama1302210095();
        this.nim = 0;
        this.fakultas = "";
    }

    public Mahasiswa1302210095(Nama1302210095 nama, int nim, string fakultas)
    {
        this.nama = nama;
        this.nim = nim;
        this.fakultas = fakultas;
    }
}

struct Nama1302210095
{
    public string depan { get; set; }
    public string belakang { get; set; }

    public Nama1302210095()
    {
        this.depan = "";
        this.belakang = "";
    }

    public Nama1302210095(string depan, string belakang)
    {
        this.depan = depan;
        this.belakang = belakang;
    }
}
