using System;
using System.Text.Json;

public class KuliahMahasiswa1302213111
{
	public void ReadJSON()
	{
		string jsonString = File.ReadAllText("D:\\SEMESTER 4\\KPL (Konstruksi Perangkat Lunak)\\Praktikum\\TPmod7\\kelompokKPL\\tpmodul7__kelompok_7\\tp7_2_1302213111.json");

		MataKuliah matakuliah = JsonSerializer.Deserialize<MataKuliah>(jsonString);
		int count = matakuliah.courses.Count;
		for(int i = 0; i < count; i++)
		{
			Course courses = matakuliah.courses[i];
			Console.WriteLine("MK " + (i + 1) +" "+ courses.code +" "+ courses.name);
		}
	}
}

public class MataKuliah
{
	public List<Course> courses { get; set; }

	public MataKuliah() { }

	public MataKuliah(List<Course> courses)
	{
		this.courses = courses;
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
