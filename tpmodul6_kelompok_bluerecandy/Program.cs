using System;
using System.IO;

namespace tpmodul6_kelompok_bluerecandy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo DataMahasiswa
            DataMahasiswa_1302204090 data = new DataMahasiswa_1302204090();
            data.ReadJSON();

            // Demo KuliahMahasiswa
            KuliahMahasiswa_1302204090 kuliah = new KuliahMahasiswa_1302204090();
            kuliah.ReadJSON();
        }
    }
}
