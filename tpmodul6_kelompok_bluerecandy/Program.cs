using System;
using System.IO;

namespace tpmodul6_kelompok_bluerecandy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo DataMahasiswa Fathan
            DataMahasiswa_1302204090 data = new DataMahasiswa_1302204090();
            data.ReadJSON();

            // Demo KuliahMahasiswa Fathan
            KuliahMahasiswa_1302204090 kuliah = new KuliahMahasiswa_1302204090();
            kuliah.ReadJSON();

            // Demo DataMahasiswa Lutfi
            DataMahasiswa_1302204066 data2 = new DataMahasiswa_1302204066();
            data2.ReadJSON();

            // Demo KuliahMahasiswa Lutfi
            KuliahMahasiswa_1302204066 kuliah2 = new KuliahMahasiswa_1302204066();
            kuliah2.ReadJSON();
        }
    }
}
