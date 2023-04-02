using System;
using System.Text.Json;

public class KuliahMahasiswa1302213011
{
	public void ReadJSON()
	{
		String jsonString = File.ReadAllText("C:\\Users\\alift\\OneDrive\\Documents\\GitHub\\kelompokKPL\\tpmodul7__kelompok_7\\tp7_2_1302213011.json");

		Kuliah course = JsonSerializer.Deserialize<Kuliah>(jsonString);

		Console.WriteLine("Daftar mata kuliah yang diambil:");

		int i = 1;

		foreach(Course courses in course.courses)
		{
			Console.WriteLine("MK {0:d} {1:s} - {2:s}",i,courses.code,courses.name);
			i++;
		}
	}
}

public class Kuliah
{
	public List<Course> courses {  get; set; }

	public Kuliah() { }

	public Kuliah(List<Course> courses)
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