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
using System.Timers;



namespace gmTool
{
    public partial class MainForm : Form
    {
        private string filePath;

        //Button Arrays
        Button[] stopButtons = new Button[5];
        
        
        //Music
        private WMPLib.WindowsMediaPlayer[] audioArray = new WMPLib.WindowsMediaPlayer[5];
        private double[] pauseTime = new double[5];
        private int musicCount;

        //Random Lists
        List<string> randomDescriptions = new List<string>();
        private int oldIndex = -1;
        private string[] oldData = { "", "" };

        private void sharedInit()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer audioPlayer = new WMPLib.WindowsMediaPlayer();
            stopButtons[0] = stopbutton1;
            stopButtons[1] = stopButton2;
            stopButtons[2] = stopButton3;
            stopButtons[3] = stopButton4;
            stopButtons[4] = stopButton5;
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
                    if (file.Extension == ".txt" || file.Extension == ".mp3" || file.Extension == ".rdm")
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

        void updateProgress(int index)
        {
            double percent = ((double)audioArray[index].controls.currentPosition / audioArray[index].controls.currentItem.duration) * 500;
            switch (index)
            {
                case 0: progressBar1.Value = (int)percent; break;
                case 1: progressBar2.Value = (int)percent; break;
                case 2: progressBar3.Value = (int)percent; break;
                case 3: progressBar4.Value = (int)percent; break;
                case 4: progressBar5.Value = (int)percent; break;
            }
        }

        
        private void myEvent(object source, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (audioArray[i] != null)
                {
                    updateProgress(i);
                }
            }
        }

        void Player_PlayStateChange(int NewState)
        {

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
                    // Create a timer
                    System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
                    // Tell the timer what to do when it elapses
                    myTimer.Tick += new EventHandler(myEvent);
                    // Set it to go off every second
                    myTimer.Interval = 500;
                    // And start it        
                    myTimer.Enabled = true;


                    audioArray[musicCount] = new WMPLib.WindowsMediaPlayer();

                    audioArray[musicCount].PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
                    audioArray[musicCount].URL = selectedPath;
                    audioArray[musicCount].controls.play();
                    
                    stopButtons[musicCount].Enabled = true;
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
                    newitem.DropDownItems.Add("Play/Pause");
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
                    notesBox.Visible = false;
                    randomBox.Visible = true;
                    // HIDE ALL OTHER MAIN PANELS
                    oldIndex = -1;
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

                //Notes
                if (selectedPath.Substring(selectedPath.Length - 4) == ".txt")
                {
                    randomBox.Visible = false;
                    notesBox.Visible = true;
                    notesBox.Text = selectedItem.Name;

                    notes.Clear();
                    using (StreamReader r = new StreamReader(selectedPath))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            notes.AppendText(line);
                            notes.AppendText("\n");
                        }
                    }
                    string imageFile = selectedPath.Substring(0, selectedPath.Length - 4) + ".png";
                    if (File.Exists(imageFile))
                    {
                        loadNotesImage(imageFile);
                    }
                    else
                    {
                        imageFile = selectedPath.Substring(0, selectedPath.Length - 4) + ".jpg";
                        if (File.Exists(imageFile))
                        {
                            loadNotesImage(imageFile);
                        }
                        else
                        {
                            imageFile = selectedPath.Substring(0, selectedPath.Length - 4) + ".bmp";
                            if (File.Exists(imageFile))
                            {
                                loadNotesImage(imageFile);
                            }
                        }
                    }
                }
            }
        }

        private void loadNotesImage(string filePath)
        {
            notesPictureBox.Load(filePath);
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
            Button item = (Button)sender;
            string name = item.Name;
            int index = Int32.Parse(name.Substring(name.Length - 1))-1;

            pause(index);
        }

        private void stopbutton1_Click(object sender, EventArgs e)
        {
            Button item = (Button)sender;
            string name = item.Name;
            int index = Int32.Parse(name.Substring(name.Length - 1)) - 1;
            item.Enabled = false;

            audioArray[index].controls.stop();
            audioArray[index] = new WMPLib.WindowsMediaPlayer();
        }

        private void randomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oldIndex != randomListBox.SelectedIndex)
            {
                saveRandom(oldIndex);
                randomNameLabel.Text = randomListBox.Items[randomListBox.SelectedIndex].ToString();
                randomDescBox.Text = randomDescriptions[randomListBox.SelectedIndex];
                oldIndex = randomListBox.SelectedIndex;
                randomDataChanged();
            }
        }

        private void randomDataChanged()
        {
            oldData[0] = randomNameLabel.Text;
            oldData[1] = randomDescBox.Text;
        }

        private void rerollRandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomListBox.SelectedIndex = rnd.Next(randomListBox.Items.Count);
        }

        private void newRandomItem_Click(object sender, EventArgs e)
        {
            randomListBox.Items.Add("New");
            randomDescBox.Clear();
            randomDescriptions.Add("New Item");
            randomListBox.SelectedIndex = randomListBox.Items.Count - 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void saveRandom(object sender, EventArgs e)
        {
            randomDescriptions[randomListBox.SelectedIndex] = randomDescBox.Text;
            randomListBox.Items[randomListBox.SelectedIndex] = randomNameLabel.Text;
            saveRandomFile();
        }
        private void saveRandom(int index)
        {
            if (index != -1)
            {
                randomDescriptions[index] = oldData[1];
                randomListBox.Items[index] = oldData[0];
            }
            
        }
        private void saveRandomFile()
        {
            FileInfo selectedItem = (FileInfo)treeView1.SelectedNode.Tag;
            string selectedPath = selectedItem.DirectoryName;
            selectedPath = selectedPath + @"\" + selectedItem.Name;

            System.IO.StreamWriter file = new System.IO.StreamWriter(selectedPath);
            for (int i = 0; i < randomDescriptions.Count; i++)
            {
                file.WriteLine(randomListBox.Items[i]);
                file.WriteLine(randomDescriptions[i]);
            }
            file.Close();
        }

        private void randomDataChanged(object sender, EventArgs e)
        {
            randomDataChanged();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileInfo selectedItem = (FileInfo)treeView1.SelectedNode.Tag;
            string selectedPath = selectedItem.DirectoryName;
            selectedPath = selectedPath + @"\" + selectedItem.Name;

            System.IO.StreamWriter file = new System.IO.StreamWriter(selectedPath);
            foreach (string line in notes.Lines)
                file.WriteLine(line);

            file.Close();
        }

        private void progressBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
