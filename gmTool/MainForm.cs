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
        private string filePath;
        private WMPLib.WindowsMediaPlayer[] audioArray = new WMPLib.WindowsMediaPlayer[5];
        private double[] pauseTime = new double[5];
        private int musicCount;

        private void sharedInit()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer audioPlayer = new WMPLib.WindowsMediaPlayer();
        }
    

        public MainForm(string fPath, string fName)
        {
            sharedInit();
            filePath = fPath;
            PopulateTreeView(fPath);
            Text = fName;
        }

        public MainForm()
        {
            sharedInit();
            filePath = null;
            Text = "New Campaign";
        }

        private void PopulateTreeView(string fPath)
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(fPath);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
                treeView1.Nodes[0].ExpandAll();
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            TreeNode bNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 1, 1);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
               
                foreach (FileInfo file in subDir.GetFiles())
                {
                    bNode = new TreeNode(file.Name, 1, 1);
                    bNode.Tag = file;
                    bNode.ImageKey = "file";
                    aNode.Nodes.Add(bNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }

            



        }

        private void pausePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void playClick(object sender, System.EventArgs e)
        {
            ToolStripItem clickedButton = (ToolStripItem)sender;
            int selectedMusicCount = Int32.Parse(clickedButton.OwnerItem.Name.Substring(0, 1));
            if (audioArray[selectedMusicCount].playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pauseTime[selectedMusicCount] = audioArray[selectedMusicCount].controls.currentPosition;
                audioArray[selectedMusicCount].controls.pause();
            }
            else if (audioArray[selectedMusicCount].playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                audioArray[selectedMusicCount].controls.currentPosition = pauseTime[selectedMusicCount];
                audioArray[selectedMusicCount].controls.play();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            string selectedPath;
            Type itemType = treeView1.SelectedNode.Tag.GetType();
            if (itemType.Name == "FileInfo")
            {
                FileInfo selectedItem = (FileInfo)treeView1.SelectedNode.Tag;
                selectedPath = selectedItem.DirectoryName;
                selectedPath = selectedPath + @"\" + selectedItem.Name;


                //Music
                if (selectedPath.Substring(selectedPath.Length - 4) == ".mp3")
                {
                    audioArray[musicCount] = new WMPLib.WindowsMediaPlayer();
                    audioArray[musicCount].URL = selectedPath;
                    audioArray[musicCount].controls.play();

                    ToolStripMenuItem newitem = new ToolStripMenuItem("1 - " + selectedItem.Name);
                    newitem.Name = musicCount+ " - " + selectedItem.Name;
                    newitem.DropDownItems.Add("Play");
                    newitem.DropDownItems[0].Click += new EventHandler(playClick);

                    newitem.DropDownItems.Add("Volume +");
                    newitem.DropDownItems.Add("Volume -");
                    newitem.DropDownItems.Add("Stop");

                    musicToolStripMenuItem.DropDownItems.Add(newitem);
                    musicCount++;
                }
            }
        }

        


    }
}
