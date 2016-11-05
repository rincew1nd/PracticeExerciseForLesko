using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_3_DecompressionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise2_3_CompressionDemo.Program.CompressFile(@"C:\globdata.ini", @"C:\globdata.ini.gz");
            UncompressFile(@"C:\globdata.ini.gz", @"C:\globdata.ini.test");
            Console.ReadKey();
        }

        public static void UncompressFile(string inFilename, string outFilename)
        {
            try
            {
                var sourceFile = File.Open(inFilename, FileMode.Open);
                var destFile = File.Create(outFilename);
                var compStream = new GZipStream(sourceFile, CompressionMode.Decompress);

                var theByte = compStream.ReadByte();
                while (theByte != -1)
                {
                    destFile.WriteByte((byte)theByte);
                    theByte = compStream.ReadByte();
                }

                compStream.Close();
                sourceFile.Close();
                destFile.Close();

                Console.WriteLine($"\"{inFilename}\" разархивирован в \"{outFilename}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
