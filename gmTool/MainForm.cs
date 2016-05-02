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

        //Music
        private WMPLib.WindowsMediaPlayer[] audioArray = new WMPLib.WindowsMediaPlayer[5];
        private double[] pauseTime = new double[5];
        private int musicCount;

        //Random Lists
        List<string> randomDescriptions = new List<string>();

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
            pause(selectedMusicCount);
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

                    GroupBox musicBox = musicBox1;
                    switch (musicCount)
                    {
                        case 0: musicBox = musicBox1; break;
                        case 1: musicBox = musicBox2; break;
                        case 2: musicBox = musicBox3; break;
                        case 3: musicBox = musicBox4; break;
                        case 4: musicBox = musicBox5; break;
                    }
                    musicBox.Text = selectedItem.Name;

                    ToolStripMenuItem newitem = new ToolStripMenuItem("1 - " + selectedItem.Name);
                    newitem.Name = musicCount + " - " + selectedItem.Name;
                    newitem.DropDownItems.Add("Play");
                    newitem.DropDownItems[0].Click += new EventHandler(playClick);

                    newitem.DropDownItems.Add("Volume +");
                    newitem.DropDownItems.Add("Volume -");
                    newitem.DropDownItems.Add("Stop");

                    musicToolStripMenuItem.DropDownItems.Add(newitem);
                    musicCount++;
                }
                else
                {
                    randomBox.Text = selectedItem.Name;
                }

                //Random Tables
                if (selectedPath.Substring(selectedPath.Length - 4) == ".rdm")
                {

                    randomBox.Visible = true;
                    // HIDE ALL OTHER MAIN PANELS

                    randomListBox.Items.Clear();

                    randomBox.Text = selectedItem.Name;
                    randomDescriptions.Clear();
                    using (StreamReader r = new StreamReader(selectedPath))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            randomListBox.Items.Add(line);
                            line = r.ReadLine();
                            randomDescriptions.Add(line);
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pause(int index)
        {
            Button pauseButton = pausebutton1;
            switch (index)
            {
                case 0:
                    pauseButton = pausebutton1;
                    break;
                case 1:
                    pauseButton = pausebutton2;
                    break;
                case 2:
                    pauseButton = pausebutton3;
                    break;
                case 3:
                    pauseButton = pausebutton4;
                    break;
                case 4:
                    pauseButton = pausebutton5;
                    break;
            }

            if (audioArray[index].playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pauseTime[index] = audioArray[index].controls.currentPosition;
                audioArray[index].controls.pause();
                pauseButton.Text = "Play";
            }
            else if (audioArray[index].playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                audioArray[index].controls.currentPosition = pauseTime[0];
                audioArray[index].controls.play();
                pauseButton.Text = "Pause";
            }
            
        }

        private void volumeChanged(object sender, EventArgs e)
        {
            audioArray[0].settings.volume = (int)volumeControl.Value;
        }

        private void pausebutton1_Click(object sender, EventArgs e)
        {
            pause(0);
        }

        private void stopbutton1_Click(object sender, EventArgs e)
        {
            audioArray[0].controls.stop();
            audioArray[0] = new WMPLib.WindowsMediaPlayer();
        }

        private void randomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            randomNameLabel.Text = randomListBox.Items[randomListBox.SelectedIndex].ToString();
            randomDescBox.Text = randomDescriptions[randomListBox.SelectedIndex];
        }

        private void rerollRandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomListBox.SelectedIndex = rnd.Next(randomListBox.Items.Count);
        }
    }
}
