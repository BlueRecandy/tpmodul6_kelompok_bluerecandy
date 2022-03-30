using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_bluerecandy
{
    internal class DataMahasiswa_1302204090
    {

        private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../tp6_1_1302204090.json");

        public void ReadJSON()
        {
            var jsonFile = File.OpenText(GetJsonPath);

            Dictionary<string, dynamic> json = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonFile.ReadToEnd(), new JsonSerializerOptions()
            {
                WriteIndented = true,
            });

            // “Nama <nama depan + belakang> dengan nim <nim> dari fakultas <fakultas>”
            Console.WriteLine($"Nama {json["nama"]} dengan nim {json["nim"]} dari fakultas {json["fakultas"]}");
        }

    }
}
