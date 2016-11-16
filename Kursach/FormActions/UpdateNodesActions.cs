using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Models;

namespace Kursach
{
    public partial class Form1 
    {
        /// <summary>
        /// Обновить список папок при раскрытии ноды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            _folderViewController.UpdateNode(e.Node, true);
        }

        /// <summary>
        /// Раскрыть меню для файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Раскрыть меню для папки или обновить список файлов в папке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderList_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FolderList.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Right)
            {
                FolderMenu.Show(Cursor.Position);
            } else if (e.Button == MouseButtons.Left)
            {
                _folderViewController.UpdateNode(e.Node, true);
            }
        }

        /// <summary>
        /// Открыть выбранный файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var node = FileList.SelectedItems[0] as FileNode;
            if (node != null)
                Utils.StartProcess(node.Path);
        }
    }
}
