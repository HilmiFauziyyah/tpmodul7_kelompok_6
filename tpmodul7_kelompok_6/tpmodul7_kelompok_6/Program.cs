﻿using tpmodul7_kelompok_6;

internal class Program
{
    private static void Main(string[] args)
    {
        Datamahasiswa_1302210081 Hilmi = new Datamahasiswa_1302210081();
        Hilmi.ReadJSON();

        KuliahMahasiswa_1302210081 Fauziyyah = new KuliahMahasiswa_1302210081();
        Fauziyyah.ReadJSON();
    }
}