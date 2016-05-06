namespace gmTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicBox1 = new System.Windows.Forms.GroupBox();
            this.pausebutton1 = new System.Windows.Forms.Button();
            this.stopbutton1 = new System.Windows.Forms.Button();
            this.volumeControl = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.musicBox5 = new System.Windows.Forms.GroupBox();
            this.pausebutton5 = new System.Windows.Forms.Button();
            this.stopButton5 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.musicBox4 = new System.Windows.Forms.GroupBox();
            this.pausebutton4 = new System.Windows.Forms.Button();
            this.stopButton4 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.musicBox3 = new System.Windows.Forms.GroupBox();
            this.pausebutton3 = new System.Windows.Forms.Button();
            this.stopButton3 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.musicBox2 = new System.Windows.Forms.GroupBox();
            this.pausebutton2 = new System.Windows.Forms.Button();
            this.stopButton2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.randomBox = new System.Windows.Forms.GroupBox();
            this.randomSaveButton = new System.Windows.Forms.Button();
            this.randomDescBox = new System.Windows.Forms.TextBox();
            this.randomNameLabel = new System.Windows.Forms.TextBox();
            this.newRandomItem = new System.Windows.Forms.Button();
            this.randomListBox = new System.Windows.Forms.ListBox();
            this.rerollRandomButton = new System.Windows.Forms.Button();
            this.notesBox = new System.Windows.Forms.GroupBox();
            this.notesPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.musicBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.musicBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.musicBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.musicBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.musicBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.randomBox.SuspendLayout();
            this.notesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(187, 573);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "d20.png");
            this.imageList1.Images.SetKeyName(1, "arrow.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCampaignToolStripMenuItem,
            this.loadCampaignToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCampaignToolStripMenuItem
            // 
            this.saveCampaignToolStripMenuItem.Name = "saveCampaignToolStripMenuItem";
            this.saveCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveCampaignToolStripMenuItem.Text = "Save Campaign";
            // 
            // loadCampaignToolStripMenuItem
            // 
            this.loadCampaignToolStripMenuItem.Name = "loadCampaignToolStripMenuItem";
            this.loadCampaignToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadCampaignToolStripMenuItem.Text = "Load Campaign";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // musicBox1
            // 
            this.musicBox1.Controls.Add(this.pausebutton1);
            this.musicBox1.Controls.Add(this.stopbutton1);
            this.musicBox1.Controls.Add(this.volumeControl);
            this.musicBox1.Controls.Add(this.progressBar1);
            this.musicBox1.Location = new System.Drawing.Point(3, 3);
            this.musicBox1.Name = "musicBox1";
            this.musicBox1.Size = new System.Drawing.Size(219, 108);
            this.musicBox1.TabIndex = 2;
            this.musicBox1.TabStop = false;
            // 
            // pausebutton1
            // 
            this.pausebutton1.Location = new System.Drawing.Point(6, 72);
            this.pausebutton1.Name = "pausebutton1";
            this.pausebutton1.Size = new System.Drawing.Size(88, 23);
            this.pausebutton1.TabIndex = 4;
            this.pausebutton1.Text = "Play";
            this.pausebutton1.UseVisualStyleBackColor = true;
            this.pausebutton1.Click += new System.EventHandler(this.pausebutton1_Click);
            // 
            // stopbutton1
            // 
            this.stopbutton1.Enabled = false;
            this.stopbutton1.Location = new System.Drawing.Point(123, 72);
            this.stopbutton1.Name = "stopbutton1";
            this.stopbutton1.Size = new System.Drawing.Size(88, 23);
            this.stopbutton1.TabIndex = 3;
            this.stopbutton1.Text = "Stop";
            this.stopbutton1.UseVisualStyleBackColor = true;
            this.stopbutton1.Click += new System.EventHandler(this.stopbutton1_Click);
            // 
            // volumeControl
            // 
            this.volumeControl.Location = new System.Drawing.Point(170, 17);
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(43, 20);
            this.volumeControl.TabIndex = 1;
            this.volumeControl.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.volumeControl.ValueChanged += new System.EventHandler(this.volumeChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 43);
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.musicBox5);
            this.panel1.Controls.Add(this.musicBox4);
            this.panel1.Controls.Add(this.musicBox3);
            this.panel1.Controls.Add(this.musicBox2);
            this.panel1.Controls.Add(this.musicBox1);
            this.panel1.Location = new System.Drawing.Point(745, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 573);
            this.panel1.TabIndex = 7;
            // 
            // musicBox5
            // 
            this.musicBox5.Controls.Add(this.pausebutton5);
            this.musicBox5.Controls.Add(this.stopButton5);
            this.musicBox5.Controls.Add(this.numericUpDown4);
            this.musicBox5.Controls.Add(this.progressBar5);
            this.musicBox5.Location = new System.Drawing.Point(3, 459);
            this.musicBox5.Name = "musicBox5";
            this.musicBox5.Size = new System.Drawing.Size(219, 108);
            this.musicBox5.TabIndex = 5;
            this.musicBox5.TabStop = false;
            // 
            // pausebutton5
            // 
            this.pausebutton5.Location = new System.Drawing.Point(6, 72);
            this.pausebutton5.Name = "pausebutton5";
            this.pausebutton5.Size = new System.Drawing.Size(88, 23);
            this.pausebutton5.TabIndex = 4;
            this.pausebutton5.Text = "Play";
            this.pausebutton5.UseVisualStyleBackColor = true;
            this.pausebutton5.Click += new System.EventHandler(this.pausebutton1_Click);
            // 
            // stopButton5
            // 
            this.stopButton5.Enabled = false;
            this.stopButton5.Location = new System.Drawing.Point(123, 72);
            this.stopButton5.Name = "stopButton5";
            this.stopButton5.Size = new System.Drawing.Size(88, 23);
            this.stopButton5.TabIndex = 3;
            this.stopButton5.Text = "Stop";
            this.stopButton5.UseVisualStyleBackColor = true;
            this.stopButton5.Click += new System.EventHandler(this.stopbutton1_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(170, 17);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown4.TabIndex = 1;
            this.numericUpDown4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(6, 43);
            this.progressBar5.Maximum = 500;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(207, 23);
            this.progressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar5.TabIndex = 0;
            // 
            // musicBox4
            // 
            this.musicBox4.Controls.Add(this.pausebutton4);
            this.musicBox4.Controls.Add(this.stopButton4);
            this.musicBox4.Controls.Add(this.numericUpDown3);
            this.musicBox4.Controls.Add(this.progressBar4);
            this.musicBox4.Location = new System.Drawing.Point(3, 345);
            this.musicBox4.Name = "musicBox4";
            this.musicBox4.Size = new System.Drawing.Size(219, 108);
            this.musicBox4.TabIndex = 5;
            this.musicBox4.TabStop = false;
            // 
            // pausebutton4
            // 
            this.pausebutton4.Location = new System.Drawing.Point(6, 72);
            this.pausebutton4.Name = "pausebutton4";
            this.pausebutton4.Size = new System.Drawing.Size(88, 23);
            this.pausebutton4.TabIndex = 4;
            this.pausebutton4.Text = "Play";
            this.pausebutton4.UseVisualStyleBackColor = true;
            this.pausebutton4.Click += new System.EventHandler(this.pausebutton1_Click);
            // 
            // stopButton4
            // 
            this.stopButton4.Enabled = false;
            this.stopButton4.Location = new System.Drawing.Point(123, 72);
            this.stopButton4.Name = "stopButton4";
            this.stopButton4.Size = new System.Drawing.Size(88, 23);
            this.stopButton4.TabIndex = 3;
            this.stopButton4.Text = "Stop";
            this.stopButton4.UseVisualStyleBackColor = true;
            this.stopButton4.Click += new System.EventHandler(this.stopbutton1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(170, 17);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown3.TabIndex = 1;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(6, 43);
            this.progressBar4.Maximum = 500;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(207, 23);
            this.progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar4.TabIndex = 0;
            // 
            // musicBox3
            // 
            this.musicBox3.Controls.Add(this.pausebutton3);
            this.musicBox3.Controls.Add(this.stopButton3);
            this.musicBox3.Controls.Add(this.numericUpDown2);
            this.musicBox3.Controls.Add(this.progressBar3);
            this.musicBox3.Location = new System.Drawing.Point(3, 231);
            this.musicBox3.Name = "musicBox3";
            this.musicBox3.Size = new System.Drawing.Size(219, 108);
            this.musicBox3.TabIndex = 4;
            this.musicBox3.TabStop = false;
            // 
            // pausebutton3
            // 
            this.pausebutton3.Location = new System.Drawing.Point(6, 72);
            this.pausebutton3.Name = "pausebutton3";
            this.pausebutton3.Size = new System.Drawing.Size(88, 23);
            this.pausebutton3.TabIndex = 4;
            this.pausebutton3.Text = "Play";
            this.pausebutton3.UseVisualStyleBackColor = true;
            this.pausebutton3.Click += new System.EventHandler(this.pausebutton1_Click);
            // 
            // stopButton3
            // 
            this.stopButton3.Enabled = false;
            this.stopButton3.Location = new System.Drawing.Point(123, 72);
            this.stopButton3.Name = "stopButton3";
            this.stopButton3.Size = new System.Drawing.Size(88, 23);
            this.stopButton3.TabIndex = 3;
            this.stopButton3.Text = "Stop";
            this.stopButton3.UseVisualStyleBackColor = true;
            this.stopButton3.Click += new System.EventHandler(this.stopbutton1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(170, 17);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 43);
            this.progressBar3.Maximum = 500;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(207, 23);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 0;
            // 
            // musicBox2
            // 
            this.musicBox2.Controls.Add(this.pausebutton2);
            this.musicBox2.Controls.Add(this.stopButton2);
            this.musicBox2.Controls.Add(this.numericUpDown1);
            this.musicBox2.Controls.Add(this.progressBar2);
            this.musicBox2.Location = new System.Drawing.Point(3, 117);
            this.musicBox2.Name = "musicBox2";
            this.musicBox2.Size = new System.Drawing.Size(219, 108);
            this.musicBox2.TabIndex = 3;
            this.musicBox2.TabStop = false;
            // 
            // pausebutton2
            // 
            this.pausebutton2.Location = new System.Drawing.Point(6, 72);
            this.pausebutton2.Name = "pausebutton2";
            this.pausebutton2.Size = new System.Drawing.Size(88, 23);
            this.pausebutton2.TabIndex = 4;
            this.pausebutton2.Text = "Play";
            this.pausebutton2.UseVisualStyleBackColor = true;
            this.pausebutton2.Click += new System.EventHandler(this.pausebutton1_Click);
            // 
            // stopButton2
            // 
            this.stopButton2.Enabled = false;
            this.stopButton2.Location = new System.Drawing.Point(123, 72);
            this.stopButton2.Name = "stopButton2";
            this.stopButton2.Size = new System.Drawing.Size(88, 23);
            this.stopButton2.TabIndex = 3;
            this.stopButton2.Text = "Stop";
            this.stopButton2.UseVisualStyleBackColor = true;
            this.stopButton2.Click += new System.EventHandler(this.stopbutton1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(170, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 43);
            this.progressBar2.Maximum = 500;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(207, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 0;
            // 
            // randomBox
            // 
            this.randomBox.Controls.Add(this.randomSaveButton);
            this.randomBox.Controls.Add(this.randomDescBox);
            this.randomBox.Controls.Add(this.randomNameLabel);
            this.randomBox.Controls.Add(this.newRandomItem);
            this.randomBox.Controls.Add(this.randomListBox);
            this.randomBox.Controls.Add(this.rerollRandomButton);
            this.randomBox.Location = new System.Drawing.Point(193, 27);
            this.randomBox.Name = "randomBox";
            this.randomBox.Size = new System.Drawing.Size(546, 564);
            this.randomBox.TabIndex = 8;
            this.randomBox.TabStop = false;
            this.randomBox.Text = "groupBox1";
            this.randomBox.Visible = false;
            // 
            // randomSaveButton
            // 
            this.randomSaveButton.Location = new System.Drawing.Point(6, 536);
            this.randomSaveButton.Name = "randomSaveButton";
            this.randomSaveButton.Size = new System.Drawing.Size(120, 22);
            this.randomSaveButton.TabIndex = 6;
            this.randomSaveButton.Text = "Save Changes";
            this.randomSaveButton.UseVisualStyleBackColor = true;
            this.randomSaveButton.Click += new System.EventHandler(this.saveRandom);
            // 
            // randomDescBox
            // 
            this.randomDescBox.Location = new System.Drawing.Point(132, 58);
            this.randomDescBox.Multiline = true;
            this.randomDescBox.Name = "randomDescBox";
            this.randomDescBox.Size = new System.Drawing.Size(408, 500);
            this.randomDescBox.TabIndex = 5;
            this.randomDescBox.TextChanged += new System.EventHandler(this.randomDataChanged);
            // 
            // randomNameLabel
            // 
            this.randomNameLabel.Location = new System.Drawing.Point(132, 21);
            this.randomNameLabel.Name = "randomNameLabel";
            this.randomNameLabel.Size = new System.Drawing.Size(327, 20);
            this.randomNameLabel.TabIndex = 4;
            this.randomNameLabel.TextChanged += new System.EventHandler(this.randomDataChanged);
            // 
            // newRandomItem
            // 
            this.newRandomItem.Location = new System.Drawing.Point(6, 508);
            this.newRandomItem.Name = "newRandomItem";
            this.newRandomItem.Size = new System.Drawing.Size(120, 22);
            this.newRandomItem.TabIndex = 3;
            this.newRandomItem.Text = "Add to List";
            this.newRandomItem.UseVisualStyleBackColor = true;
            this.newRandomItem.Click += new System.EventHandler(this.newRandomItem_Click);
            // 
            // randomListBox
            // 
            this.randomListBox.FormattingEnabled = true;
            this.randomListBox.Location = new System.Drawing.Point(6, 19);
            this.randomListBox.Name = "randomListBox";
            this.randomListBox.Size = new System.Drawing.Size(120, 485);
            this.randomListBox.TabIndex = 1;
            this.randomListBox.SelectedIndexChanged += new System.EventHandler(this.randomListBox_SelectedIndexChanged);
            // 
            // rerollRandomButton
            // 
            this.rerollRandomButton.Location = new System.Drawing.Point(465, 19);
            this.rerollRandomButton.Name = "rerollRandomButton";
            this.rerollRandomButton.Size = new System.Drawing.Size(75, 23);
            this.rerollRandomButton.TabIndex = 0;
            this.rerollRandomButton.Text = "New Item";
            this.rerollRandomButton.UseVisualStyleBackColor = true;
            this.rerollRandomButton.Click += new System.EventHandler(this.rerollRandomButton_Click);
            // 
            // notesBox
            // 
            this.notesBox.Controls.Add(this.notesPictureBox);
            this.notesBox.Controls.Add(this.button1);
            this.notesBox.Controls.Add(this.notes);
            this.notesBox.Location = new System.Drawing.Point(193, 27);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(546, 564);
            this.notesBox.TabIndex = 9;
            this.notesBox.TabStop = false;
            this.notesBox.Text = "groupBox1";
            this.notesBox.Visible = false;
            // 
            // notesPictureBox
            // 
            this.notesPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notesPictureBox.Location = new System.Drawing.Point(420, 19);
            this.notesPictureBox.Name = "notesPictureBox";
            this.notesPictureBox.Size = new System.Drawing.Size(120, 510);
            this.notesPictureBox.TabIndex = 4;
            this.notesPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(6, 19);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notes.Size = new System.Drawing.Size(408, 539);
            this.notes.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 597);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.randomBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.musicBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.musicBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.musicBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.musicBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.musicBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.randomBox.ResumeLayout(false);
            this.randomBox.PerformLayout();
            this.notesBox.ResumeLayout(false);
            this.notesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.GroupBox musicBox1;
        private System.Windows.Forms.NumericUpDown volumeControl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pausebutton1;
        private System.Windows.Forms.Button stopbutton1;
        private System.Windows.Forms.GroupBox musicBox5;
        private System.Windows.Forms.Button pausebutton5;
        private System.Windows.Forms.Button stopButton5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.GroupBox musicBox4;
        private System.Windows.Forms.Button pausebutton4;
        private System.Windows.Forms.Button stopButton4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.GroupBox musicBox3;
        private System.Windows.Forms.Button pausebutton3;
        private System.Windows.Forms.Button stopButton3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.GroupBox musicBox2;
        private System.Windows.Forms.Button pausebutton2;
        private System.Windows.Forms.Button stopButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox randomBox;
        private System.Windows.Forms.ListBox randomListBox;
        private System.Windows.Forms.Button rerollRandomButton;
        private System.Windows.Forms.TextBox randomNameLabel;
        private System.Windows.Forms.Button newRandomItem;
        private System.Windows.Forms.TextBox randomDescBox;
        private System.Windows.Forms.Button randomSaveButton;
        private System.Windows.Forms.GroupBox notesBox;
        private System.Windows.Forms.PictureBox notesPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox notes;
    }
}