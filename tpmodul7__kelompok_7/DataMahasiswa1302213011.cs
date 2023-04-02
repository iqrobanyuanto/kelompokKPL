using System;
using System.Text.Json;

public class DataMahasiswa1302213011
{
	public void ReadJSON()
	{
		String jsonString = File.ReadAllText("C:\\Users\\alift\\OneDrive\\Documents\\GitHub\\kelompokKPL\\tpmodul7__kelompok_7\\tp7_1_1302213011.json");

		Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

		Console.WriteLine("Nama {0:s} {1:s} dengan nim {2:d} dari fakultas {3:s}", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);
	}
}

public class Mahasiswa
{
	public Nama nama { get; set; }
	public int nim { get; set; }
	public string fakultas { get; set; }

	public Mahasiswa() { }

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

	public Nama() { }

	public Nama(string depan, string belakang)
	{
		this.depan = depan;
		this.belakang = belakang;
	}
}
