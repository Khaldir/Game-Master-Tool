using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gmTool
{
    public partial class MainForm : Form
    {
        public string filePath;

        private void sharedInit()
        {
            InitializeComponent();
            PopulateTreeView();
            WMPLib.WindowsMediaPlayer audioPlayer = new WMPLib.WindowsMediaPlayer();
        }
    

        public MainForm(string fPath, string fName)
        {
            sharedInit();
            filePath = fPath;
            Text = fName;
        }

        public MainForm()
        {
            sharedInit();
            filePath = null;
            Text = "New Campaign";
        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void pausePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
