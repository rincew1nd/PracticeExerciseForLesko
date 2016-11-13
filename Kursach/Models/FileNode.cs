using System.Windows.Forms;

namespace Kursach.Models
{
    public class FileNode : ListViewItem
    {
        public string Path { get; set; }

        public FileNode(string name, string path) : base(name)
        {
            Path = path;
        }
    }
}
