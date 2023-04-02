using System;
using System.Text.Json;

public class KuliahMahasiswa13022130061
{
    public matkul ReadJSON(string filename)
    {
        string path = "C:\\Sekolah\\Kuliah\\Semester 4\\Konstruksi Perangkat Lunak Praktikum\\TPM7\\kelompokKPL\\tpmodul7__kelompok_7";
        string locate = path + "\\" + filename;
        string read = File.ReadAllText(locate);
        return JsonSerializer.Deserialize<matkul>(read);
    }
}

public class matkul
{
    public List<course> courses { get; set; }

    public matkul()
    {

    }

    public matkul(List<course> courses)
    {
        this.courses = courses;
    }
}

public class course
{

    public string code {  get; set; }
    public string name { get; set; }

    public course()
    {

    }

    public course(string code, string name)
    {
        this.name = name;
        this.code = code;
    }
}
