// See https://aka.ms/new-console-template for more information
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302213117 mhs = new DataMahasiswa1302213117();
        DataMahasiswa1302213117 data = mhs.ReadJSON();
        Console.WriteLine(data.nama.depan +" "+data.nama.belakang);
        Console.WriteLine(data.nim);
        Console.WriteLine(data.fakultas);
    }
}
struct Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

class DataMahasiswa1302213117
{
    public Nama nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }
    
    public DataMahasiswa1302213117 ReadJSON()
    {
        string folder = "d:\\telkom university\\semester 4\\konstruksi " +
            "perangkat lunak\\tp4-kpl\\tpmod4_1302213117_regyrenandarahman" +
            "\\tpmod4_1302213117_regyrenandarahman";
        string hasilBaca = File.ReadAllText(folder+"\\tp7_1_1302213117.json");
        return JsonSerializer.Deserialize<DataMahasiswa1302213117>(hasilBaca);
    }
}
