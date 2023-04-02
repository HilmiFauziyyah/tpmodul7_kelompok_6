using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_6
{
    internal class DataMahasiswa_1302210022
    {
        public Mahasiswa Nama { get; set; }

        public int nim { get; set; }

        public string fakultas { get; set; }
        public  void Datamahasiswa_1302210022() { }

        public void Datamahasiswa_1302210022(Mahasiswa nama, int nim, string fakultas)
        {
            this.Nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public void ReadJSON()
        {
            string file = ("C:\\TELKOM UNIVERSITY\\SEMESTER 4\\KPL\\TP\\MOD 7\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tp7_1_1302210022.json");
            string JSON = File.ReadAllText(file);
            DataMahasiswa_1302210022 M = JsonSerializer.Deserialize<DataMahasiswa_1302210022>(JSON);
            Console.WriteLine($"Nama {M.Nama.depan + " " + M.Nama.belakang} dengan NIM {M.nim} dari Fakultas {M.fakultas}");
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
