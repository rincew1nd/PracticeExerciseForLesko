using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2_ChangeEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStream = File.OpenText("d:\\boot.ini");
            var newFileStream = new StreamWriter(File.Create("d:\\boot-utf7.txt"), Encoding.UTF7);

            newFileStream.Write(fileStream.ReadToEnd());

            newFileStream.Close();
            fileStream.Close();
        }
    }
}
