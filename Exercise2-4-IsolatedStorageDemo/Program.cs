using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_4_IsolatedStorageDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //GetUserStoreForAssembly смотрит на \IsolatedStorage\***\AssemFiles
            //GetUserStoreForDomain   смотрит на \IsolatedStorage\***\***\Files
            var userStorage = IsolatedStorageFile.GetUserStoreForDomain();

            //Поток смотрит на папку \IsolatedStorage\***\***\Files
            //У IsolatedStorageFileStream нет конструктора с параметром типа IsolatedStorageFile
            //Скорее всего для создания и чтения можно было бы просто использовать Stream(Reader\Writer)
            var userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, FileAccess.Write);

            var userWriter = new StreamWriter(userStream);
            userWriter.WriteLine("User Prefs");
            userWriter.Close();

            var files = userStorage.GetFileNames("UserSettings.set");
            if (files.Length > 0)
            {
                var userReadStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, FileAccess.Read);
                Console.WriteLine(new StreamReader(userReadStream).ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
