using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configurazione del builder per leggere il file config.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json");

            IConfiguration configuration = builder.Build();

            // Lettura delle directory dal file di configurazione
            List<string> directories = configuration.GetSection("Directories").Get<List<string>>();

            // Stampa delle directory
            Console.WriteLine("Directories:");
            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }
            //var PercorsoFile = @"C:\Users\Moretti\Desktop\CartellaTest\config.json";

            //var CartellaBackup = @"C:\Users\Moretti\Desktop\CartellaTest\backup";

            //if (!File.Exists(PercorsoFile))
            //{
            //    Console.WriteLine("Il file non esiste.");
            //    return;
            //}


            //if (!Directory.Exists(CartellaBackup))
            //{
            //    Directory.CreateDirectory(CartellaBackup);
            //}

            //string nomeFile = Path.GetFileName(PercorsoFile);
            //string destinazioneBackup = Path.Combine(CartellaBackup, nomeFile);

            ////        string[] file = Directory.GetFiles(PercorsoFile);


            //File.Copy(PercorsoFile, destinazioneBackup);


        }
    }
}
