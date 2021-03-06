using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_bluerecandy
{
    internal class KuliahMahasiswa_1302204090
    {

        // Mendapatkan path dari file json
        private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../tp6_2_1302204090.json");

        public void ReadJSON()
        {
            // Membuka file json
            var jsonFile = File.OpenText(GetJsonPath);

            // Deserialize json kedalam bentuk Dictionary
            var json = JsonSerializer.Deserialize<IEnumerable<Dictionary<string, dynamic>>>(jsonFile.ReadToEnd(), new JsonSerializerOptions()
            {
                WriteIndented = true,
            });

            int count = 1;

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            foreach (var mk in json)
            {
                Console.WriteLine($"MK{count} {mk["kode_mk"]} - {mk["nama_mk"]}");
                count++;
            }

        }
    }
}
