using System;
using System.IO;
using System.Windows.Forms;
using Kursach.Models;

namespace Kursach
{
    public partial class Form1
    {
        /// <summary>
        /// Открыть выбранный файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null)
                Utils.StartProcess(clickedElement.Path);
        }

        /// <summary>
        /// Удалить выбранный файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFileMenuItem(object sender, EventArgs e)
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

        /// <summary>
        /// Копировать выбранный файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyFileMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null)
                CopyFilePath = clickedElement.Path;
        }

        /// <summary>
        /// Вставить копированный файл\папку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteFileMenuItem(object sender, EventArgs e)
        {
            var clickedElement = FileList.SelectedItems[0] as FileNode;
            if (clickedElement != null && !string.IsNullOrEmpty(CopyFilePath))
            {
                if (Utils.IsDirectory(CopyFilePath))
                    Utils.CopyDirectory(CopyFilePath, Path.GetDirectoryName(clickedElement.Path));
                else
                {
                    var newPath = Path.GetDirectoryName(clickedElement.Path) + Path.DirectorySeparatorChar +
                        Path.GetFileName(CopyFilePath);
                    File.Copy(CopyFilePath, Utils.MakeUnique(newPath).FullName);
                }
                CopyFilePath = null;
                _fileViewController.UpdateFileList(Path.GetDirectoryName(clickedElement.Path));
            }
        }
    }
}
