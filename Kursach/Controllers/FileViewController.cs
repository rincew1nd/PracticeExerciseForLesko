using System;
using System.IO;
using System.Windows.Forms;
using Kursach.Models;
using Kursach.Properties;

namespace Kursach.Controllers
{
    public class FileViewController
    {
        private static FileViewController _instance;
        private ListView _fileView;

        public static FileViewController GetInstance()
        {
            return _instance ?? (_instance = new FileViewController());
        }
        
        private FileViewController() { }
        public void SetViewObject(ListView fileView)
        {
            _fileView = fileView;
        }

        public void UpdateFileList(string path)
        {
            _fileView.Items.Clear();
            var di = new DirectoryInfo(path);
            foreach (var fileInfo in di.GetFiles())
            {
                _fileView.Items.Add(new FileNode(fileInfo.Name, fileInfo.FullName));
            }
        }
    }
}
