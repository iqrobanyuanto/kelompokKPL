using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7__kelompok_7
{
    public class KuliahMahasiswa1302213117
    {
        public List<Course> courses { get; set; }
        public void ReadJSON()
        {
            string folder = "D:\\Telkom University\\Semester 4\\Konstruksi Perangkat Lunak\\Tubes Kelompok\\kelompokKPL\\tpmodul7__kelompok_7";
            string hasilBaca = File.ReadAllText(folder + "\\tp7_2_1302213117.json");
            KuliahMahasiswa1302213117 data = JsonSerializer.Deserialize<KuliahMahasiswa1302213117>(hasilBaca);
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine("MK "+(i+1)+" " + data.courses[i].code + " - " + data.courses[i].name);
            }
        }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
        public Course() { }
        public Course(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
