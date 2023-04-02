using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_6
{
    class DataMahasiswa_1302210076
    {
        public class DataMahasiswa
        {
            public NamaLengkap nama { get; set; }

            public int nim { get; set; }

            public string fakultas { get; set; }

            public DataMahasiswa() { }

            public DataMahasiswa(NamaLengkap nama, int nim, string fakultas)
            {
                this.nama = nama;
                this.nim = nim;
                this.fakultas = fakultas;
            }
        }

        public class NamaLengkap
        {
            public string depan { get; set; }
            public string belakang { get; set; }

            public NamaLengkap() { }

            public NamaLengkap(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }

        public void ReadJSON()
        {
            string file = "C:\\Users\\ASUS\\Documents\\TP KPL\\TP MOD 7\\tpmodul7_kelompok_6\\tpmodul7_kelompok_6\\tp7_1_1302210076.json";
            string JSON = File.ReadAllText(file);
            DataMahasiswa d = JsonSerializer.Deserialize<DataMahasiswa>(JSON);
            Console.WriteLine($"Nama {d.nama.depan + " " + d.nama.belakang} dengan NIM {d.nim} dari Fakultas {d.fakultas}");

        }
    }
}
