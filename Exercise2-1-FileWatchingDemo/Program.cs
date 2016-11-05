using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_1_FileWatchingDemo
{
    public class Program
    {
        private static FileSystemWatcher _fileWatcher;

        public static void Main(string[] args)
        {
            _fileWatcher = new FileSystemWatcher
            {
                Path = Environment.CurrentDirectory,
                Filter = "*.ini",
                NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size,
                EnableRaisingEvents = true
            };

            _fileWatcher.Changed += (sender, e) =>
            {
                Console.WriteLine($"INI file changed: {e.FullPath}");
            };

            Console.WriteLine($"Start watching {_fileWatcher.Path}");
            Console.ReadKey();
        }
    }
}
