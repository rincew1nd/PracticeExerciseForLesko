using System;
using System.IO;
using System.Windows.Forms;
using Kursach.Models;

namespace Kursach
{
    public partial class Form1
    {
        /// <summary>
        /// Открыть папку (Expand)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFolderMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FolderList.SelectedNode as FolderNode;
            if (clickedElement != null && !clickedElement.IsExpanded)
            {
                clickedElement.Expand();
            }
        }

        /// <summary>
        /// Удалить папку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFolderMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FolderList.SelectedNode as FolderNode;
            if (clickedElement != null)
            {
                Directory.Delete(clickedElement.Path, true);
                _folderViewController.UpdateNode(clickedElement.Parent, true);
            }
        }

        /// <summary>
        /// Копировать папку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyFolderMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FolderList.SelectedNode as FolderNode;
            if (clickedElement != null)
            {
                CopyFilePath = clickedElement.Path;
            }
        }

        /// <summary>
        /// Вставить копированный файл\папку
        /// </summary>
        private void PasteFolderMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FolderList.SelectedNode as FolderNode;
            if (clickedElement != null && !string.IsNullOrEmpty(CopyFilePath))
            {
                if (Utils.IsDirectory(CopyFilePath))
                    Utils.CopyDirectory(CopyFilePath, clickedElement.Path);
                else
                    File.Copy(
                        CopyFilePath,
                        Utils.MakeUnique(
                            Path.Combine(
                                clickedElement.Path, Path.GetFileName(CopyFilePath))
                            ).FullName);
                CopyFilePath = null;
                _fileViewController.UpdateFileList(Path.GetDirectoryName(clickedElement.Path));
            }
        }
    }
}
