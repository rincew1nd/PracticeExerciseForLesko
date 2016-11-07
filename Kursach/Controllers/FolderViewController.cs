using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Kursach.Models;
using Kursach.Properties;

namespace Kursach.Controllers
{
    public class FolderViewController
    {
        private static FolderViewController _instance;
        private TreeView _folderView;

        public static FolderViewController GetInstance()
        {
            return _instance ?? (_instance = new FolderViewController());
        }

        private FolderViewController() { }
        public void SetViewObject(TreeView folderView)
        {
            _folderView = folderView;
            GetDrives();
        }

        public void GetDrives()
        {
            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                var node = new FolderNode(driveInfo.Name, driveInfo.RootDirectory.FullName);
                UpdateNode(node, false);
                _folderView.Nodes.Add(node);
            }
        }

        public void UpdateNode(TreeNode nodeDummy, bool lookDeeper)
        {
            var node = nodeDummy as FolderNode;
            if (node == null) return;

            node.Nodes.Clear();
            try
            {
                var directories = Directory.GetDirectories(node.Path);
                foreach (var folder in directories)
                {
                    var nodeNext = new FolderNode(Path.GetFileName(folder), folder);
                    if (lookDeeper)
                        UpdateNode(nodeNext, false);
                    node.Nodes.Add(nodeNext);
                }
                if (lookDeeper)
                    FileViewController.GetInstance().UpdateFileList(node.Path);
            }
            catch (UnauthorizedAccessException)
            {
                if (lookDeeper)
                    MessageBox.Show(string.Format(Resources.FolderUnauthorizedAccesException, node.Path));
            }
        }

    }
}
