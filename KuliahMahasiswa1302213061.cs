using System;

public class KuliahMahasiswa13022130061
{
    public courses ReadJson()
    {

    }
    
}

public class courses
{
    string code {  get; set; }
    string name { get; set; }

    public courses()
    {

    }

    public courses(string code, string name)
    {
        this.name = name;
        this.code = code;
    }
}
