using System;
using System.Text.Json;
class KuliahMahasiswa_1302213003
{
 
    public void ReadJSON()
    {
        string JSONfolder = File.ReadAllText("C:\\Users\\marsy\\Downloads\\KPL\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tp7_2_1302213003.json");
        DaftarMataKuliah matkul = JsonSerializer.Deserialize<DaftarMataKuliah>(JSONfolder);

        Console.WriteLine(" ");
        Console.WriteLine("Daftar mata kuliah yang diambil");

        int i = 1;
        Console.WriteLine(" ");
        foreach (MataKuliah mataKuliah in matkul.courses)
        {
            Console.WriteLine("MK " + i + " " + mataKuliah.code + " - " + mataKuliah.name);
            i++;
        }

    }
    public class DaftarMataKuliah
    {
        public List<MataKuliah> courses { get; set; }

        public DaftarMataKuliah() { }

        public DaftarMataKuliah(List<MataKuliah> mataKuliah)
        {
            this.courses = mataKuliah;
        }
    }

    public class MataKuliah
    {
        public string code { get; set; }

        public string name { get; set; }

        public MataKuliah() { }

        public MataKuliah(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
