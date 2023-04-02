using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace tpmodul7_kelompok_6
{
    public class Datamahasiswa_1302210081
    {
        public Mahasiswa nama {  get; set; }

        public int nim { get; set; }

        public string fakultas { get; set; }
        public Datamahasiswa_1302210081() { }

        public Datamahasiswa_1302210081(Mahasiswa nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public void ReadJSON()
        {
            string file = ("C:\\Users\\Hilmi Fauziyyah S\\Documents\\TP\\KPL\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tp7_1_1302210081.json");
            string JSON = File.ReadAllText(file);
            Datamahasiswa_1302210081 M = JsonSerializer.Deserialize<Datamahasiswa_1302210081>(JSON);
            Console.WriteLine($"Nama {M.nama.depan + " " + M.nama.belakang} dengan NIM {M.nim} dari Fakultas {M.fakultas}");
        }
    }
    
    public class Mahasiswa
    {
        public string depan { get; set; } = string.Empty;
        public string belakang { get; set; } = string.Empty;
        public Mahasiswa() { }

        public Mahasiswa(string depan, string belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }

}

    
