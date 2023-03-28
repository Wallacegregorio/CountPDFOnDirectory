using System.IO;
using System.Linq;

namespace CountPDFOnDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\walla\Downloads\01 - recapitulacao-de-logica-de-programacao";
            int count = Directory.GetFiles(path).Where(File => File.ToLower().EndsWith(".pdf")).Count();

            Console.WriteLine($"Número de arquivos PDF em {path}: {count}");
        }
    }
}