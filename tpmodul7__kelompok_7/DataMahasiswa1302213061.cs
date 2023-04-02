using System;
using System.ComponentModel;
using System.Text.Json;

public class DataMahasiswa1302213061
{
	public tipe ReadJSON<tipe>(string filename)
	{
		string path = "C:\\Sekolah\\Kuliah\\Semester 4\\Konstruksi Perangkat Lunak Praktikum\\TPM7\\kelompokKPL\\tpmodul7__kelompok_7";
		string locate = path + "\\" + filename;
		string read = File.ReadAllText(locate);
		return JsonSerializer.Deserialize<tipe>(read);
	}
}

public class Mahasiswa
{
	public Nama nama { get; set; }
	public int nim { get; set; }
    public string fakultas { get; set; }

    public Mahasiswa() 
	{	
	}
    public Mahasiswa(Nama nama, int nim, string fakultas)
    {
		this.nama = nama;
		this.nim = nim;
		this.fakultas = fakultas;
    }
}

public class Nama
{
	public string depan { get; set; }
	public string belakang { get; set; }
	public Nama()
	{

	}
    public Nama(string depan, string belakang)
    {
		this.depan = depan;
		this.belakang = belakang;
    }

}
