using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7__kelompok_7
{
    public class DataMahasiswa1302213117
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
        public void ReadJSON()
        {
            string folder = "D:\\Telkom University\\Semester 4\\Konstruksi Perangkat Lunak\\Tubes Kelompok\\kelompokKPL\\tpmodul7__kelompok_7";
            string hasilBaca = File.ReadAllText(folder + "\\tp7_1_1302213117.json");
            DataMahasiswa1302213117 data = JsonSerializer.Deserialize<DataMahasiswa1302213117>(hasilBaca);
            Console.WriteLine("Nama " + data.nama.depan + " " + data.nama.belakang + " dengan nim " + data.nim + " dari fakultas " + data.fakultas);
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
}


