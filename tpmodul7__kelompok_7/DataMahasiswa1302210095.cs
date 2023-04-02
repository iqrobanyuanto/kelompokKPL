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
        public void ReadJSON<tipe>(string filename)
        {
            //generate file path
            string path = "\\" + filename;

            //membaca file json
            string read = File.ReadAllText(path);

            //mengubah file json yang sudah di baca menjadi object
            tipe obj = JsonSerializer.Deserialize<tipe>(read);

            if(obj is int)
            {
                Console.WriteLine(
                    "Nama " + obj.nama.depan + " " + obj.nama.belakang +
                    " dengan nim " + obj.nim +
                    " dari fakultas " + obj.fakultas 
                    );
            }

        }
    }
}
