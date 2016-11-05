using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2_FileDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stream = File.CreateText("demo_file.txt");
            stream.WriteLine($"Today date: {DateTime.Today}");
            stream.WriteLine($"Current directory: {Environment.CurrentDirectory}");
            stream.WriteLine("This is my new file.\r\nDo you like this format?");
            stream.Close();

            Process.Start("notepad.exe", "demo_file.txt");
        }
    }
}
