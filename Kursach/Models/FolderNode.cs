using System.Windows.Forms;

namespace Kursach.Models
{
    public class FolderNode : TreeNode
    {
        public string Path { get; set; }

        public FolderNode(string name, string path) : base(name)
        {
            Path = path;
        }
    }
}
