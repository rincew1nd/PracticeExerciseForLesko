namespace Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FolderList = new System.Windows.Forms.TreeView();
            this.FileList = new System.Windows.Forms.ListView();
            this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu.SuspendLayout();
            this.FolderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderList
            // 
            this.FolderList.Location = new System.Drawing.Point(12, 12);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(180, 250);
            this.FolderList.TabIndex = 0;
            this.FolderList.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FolderView_BeforeExpand);
            this.FolderList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.FolderList_MouseClick);
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(198, 12);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(278, 250);
            this.FileList.TabIndex = 1;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.List;
            this.FileList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileList_MouseClick);
            this.FileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileList_MouseDoubleClick);
            // 
            // FileMenu
            // 
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(108, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteFileMenuItem);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyFileMenuItem);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteFileMenuItem);
            // 
            // FolderMenu
            // 
            this.FolderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.FolderMenu.Name = "FileMenu";
            this.FolderMenu.Size = new System.Drawing.Size(108, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.OpenFolderMenuItem);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.DeleteFolderMenuItem);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Text = "Copy";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.CopyFolderMenuItem);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem4.Text = "Paste";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.PasteFolderMenuItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 274);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.FolderList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FileMenu.ResumeLayout(false);
            this.FolderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FolderList;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ContextMenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FolderMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

