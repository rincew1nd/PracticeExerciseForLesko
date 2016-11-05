using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_1_ShowFileDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory);
            ShowDirectory(directory.Parent.Parent);
            Console.ReadKey();
        }

        public static void ShowDirectory(DirectoryInfo dirInfo)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Folder: {dirInfo.FullName}\n");

            foreach (var fileInfo in dirInfo.GetFiles())
                Console.WriteLine($"File: {fileInfo.FullName}");

            foreach (var childDirInfo in dirInfo.GetDirectories())
                ShowDirectory(childDirInfo);
        }
    }
}
