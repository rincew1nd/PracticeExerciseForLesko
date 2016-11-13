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
            _folderViewController.SetViewObject(FoldersView);
        }

        private void FoldersView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            _folderViewController.UpdateNode(e.Node, true);
        }

        private void FoldersView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _folderViewController.UpdateNode(FoldersView.SelectedNode, true);
        }

        private void FileList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (FileList.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    FileMenu.Show(Cursor.Position);
                }
            }
        }

        private void FileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var node = FileList.SelectedItems[0] as FileNode;
            if (node != null)
                StartProcess(node.Path);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null)
                StartProcess(clickedElement.Path);
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null)
                if (MessageBox.Show(
                        "Do you want to delete file?",
                        "Confirmation",
                        MessageBoxButtons.YesNo
                    ) == DialogResult.Yes)
                {
                    File.Delete(clickedElement.Path);
                    _fileViewController.UpdateFileList(Path.GetDirectoryName(clickedElement.Path));
                }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null)
                CopyFilePath = clickedElement.Path;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null && CopyFilePath != null)
            {
                var newPath = Path.GetDirectoryName(clickedElement.Path) + Path.DirectorySeparatorChar +
                    Path.GetFileName(CopyFilePath);
                File.Copy(CopyFilePath, MakeUnique(newPath).FullName);
                CopyFilePath = null;
                _fileViewController.UpdateFileList(Path.GetDirectoryName(clickedElement.Path));
            }
        }

        private void StartProcess(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception)
            {
                
            }
        }

        public FileInfo MakeUnique(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            for (int i = 1; ; ++i)
            {
                if (!File.Exists(path))
                    return new FileInfo(path);

                path = Path.Combine(dir, fileName + " " + i + fileExt);
            }
        }
    }
}
