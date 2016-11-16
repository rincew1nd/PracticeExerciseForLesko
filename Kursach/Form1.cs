using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Controllers;
using Kursach.Models;

namespace Kursach
{
    public partial class Form1 : Form
    {
        private readonly FileViewController _fileViewController;
        private readonly FolderViewController _folderViewController;
        private string CopyFilePath;

        public Form1()
        {
            InitializeComponent();
            _fileViewController = FileViewController.GetInstance();
            _fileViewController.SetViewObject(FileList);
            _folderViewController = FolderViewController.GetInstance();
            _folderViewController.SetViewObject(FolderList);
        }
    }
}
