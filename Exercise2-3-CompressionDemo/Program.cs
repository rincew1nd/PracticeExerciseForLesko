using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_3_CompressionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompressFile(@"C:\globdata.ini", @"C:\globdata.ini.gz");
            Console.ReadKey();
        }

        public static void CompressFile(string inFilename, string outFilename)
        {
            try
            {
                var sourceFile = File.Open(inFilename, FileMode.Open);
                var destFile = File.Create(outFilename);
                var compStream = new GZipStream(destFile, CompressionMode.Compress);

                var theByte = sourceFile.ReadByte();
                while (theByte != -1)
                {
                    compStream.WriteByte((byte)theByte);
                    theByte = sourceFile.ReadByte();
                }

                compStream.Close();
                sourceFile.Close();
                destFile.Close();

                Console.WriteLine($"\"{inFilename}\" архивирован в \"{outFilename}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
