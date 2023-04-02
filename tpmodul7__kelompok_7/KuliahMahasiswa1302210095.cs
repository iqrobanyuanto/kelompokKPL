using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7__kelompok_7
{
    internal class KuliahMahasiswa1302210095
    {
        public void ReadJSON(string filename)
        {
            //generate file path
            string path = @"..\\..\\..\\" + filename;

            //membaca file json
            string read = File.ReadAllText(path);

            //mengubah file json yang sudah di baca menjadi object
            Kuliah1302210095 objs = JsonSerializer.Deserialize<Kuliah1302210095>(read);

            Console.WriteLine("Daftar mata kuliah yang diambil:",objs.courses);

            
            int i = 1;
            foreach (Course1302210095 obj in objs.courses)
            {
                Console.WriteLine(
                    "MK {0:d} {1:s} - {2:s}",
                    i++,
                    obj.code,
                    obj.name
                    );
            }

        }
    }
}


public class Kuliah1302210095
{
    public List<Course1302210095> courses { get; set; }

    public Kuliah1302210095()
    {
        this.courses = new List<Course1302210095>();
    }

    public Kuliah1302210095(List<Course1302210095> courses)
    {
        this.courses = courses;
    }
}

public class Course1302210095
{
    public string code { get; set; }
    public string name { get; set; }

    public Course1302210095() { }

    public Course1302210095(string code, string name)
    {
        this.code = code;
        this.name = name;
    }
}
