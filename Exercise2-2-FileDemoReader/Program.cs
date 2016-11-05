using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2_FileDemoReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise2_2_FileDemo.Program.Main(null);

            var reader = File.OpenText("demo_file.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            Console.ReadKey();
        }
    }
}
