using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    class Utils
    {
        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="path"></param>
        public static void StartProcess(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Сохранить файл с уникальным именем при копировании
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FileInfo MakeUnique(string path)
        {
            var dir = Path.GetDirectoryName(path);
            var fileName = Path.GetFileNameWithoutExtension(path);
            var fileExt = Path.GetExtension(path);

            for (var i = 1; ; ++i)
            {
                if (!File.Exists(path))
                    return new FileInfo(path);

                path = Path.Combine(dir, fileName + " " + i + fileExt);
            }
        }

        /// <summary>
        /// Путь - директория? (или же файл)
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsDirectory(string path)
        {
            var attrib = File.GetAttributes(path);
            return attrib.HasFlag(FileAttributes.Directory);
        }

        /// <summary>
        /// Скопировать директорию
        /// </summary>
        /// <param name="sourceDir"></param>
        /// <param name="targetDir"></param>
        public static void CopyDirectory(string sourceDir, string targetDir)
        {
            if (Directory.Exists(sourceDir))
                RecursiveDirectoryCopy(sourceDir, targetDir);
        }

        /// <summary>
        /// Рекурсивное копирование директории
        /// </summary>
        /// <param name="sourceDir"></param>
        /// <param name="targetDir"></param>
        private static void RecursiveDirectoryCopy(string sourceDir, string targetDir)
        {
            // Составляем новый путь до папок и создаём
            var targetDirWithFolderName = targetDir + Path.DirectorySeparatorChar + Path.GetFileName(sourceDir);
            if (!Directory.Exists(targetDirWithFolderName))
                Directory.CreateDirectory(targetDirWithFolderName);

            // Получаем список директорий из копируемой папки и запускаем рекурсию
            var directories = Directory.GetDirectories(sourceDir);
            foreach (var directory in directories)
                RecursiveDirectoryCopy(directory, targetDirWithFolderName);
            
            // Получаем список файлов в копируемой папке и копируем в новую
            var files = Directory.GetFiles(sourceDir);
            foreach (string s in files)
            {
                var fileName = Path.GetFileName(s);
                var destFile = Path.Combine(targetDirWithFolderName, fileName);
                if (File.Exists(destFile))
                {
                    if (MessageBox.Show(
                            $"Файл {destFile} уже существует.\n" +
                            $"Перезаписать файлом {sourceDir + Path.DirectorySeparatorChar + fileName}?",
                            "Конфликт",
                            MessageBoxButtons.YesNo
                        ) == DialogResult.No)
                        continue;
                }
                File.Copy(s, destFile, true);
            }
        }
    }
}
