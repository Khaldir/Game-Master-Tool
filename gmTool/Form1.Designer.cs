namespace gmTool
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
            this.browseButton = new System.Windows.Forms.Button();
            this.filePathDisplay = new System.Windows.Forms.TextBox();
            this.openCampaignButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(266, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // filePathDisplay
            // 
            this.filePathDisplay.Location = new System.Drawing.Point(12, 12);
            this.filePathDisplay.Name = "filePathDisplay";
            this.filePathDisplay.Size = new System.Drawing.Size(248, 20);
            this.filePathDisplay.TabIndex = 1;
            // 
            // openCampaignButton
            // 
            this.openCampaignButton.Location = new System.Drawing.Point(12, 244);
            this.openCampaignButton.Name = "openCampaignButton";
            this.openCampaignButton.Size = new System.Drawing.Size(329, 23);
            this.openCampaignButton.TabIndex = 0;
            this.openCampaignButton.Text = "New Campaign";
            this.openCampaignButton.UseVisualStyleBackColor = true;
            this.openCampaignButton.Click += new System.EventHandler(this.openCampaignButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Campaign Files (.cpn)|*.cpn";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(317, 175);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.openCampaignButton;
            this.ClientSize = new System.Drawing.Size(353, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openCampaignButton);
            this.Controls.Add(this.filePathDisplay);
            this.Controls.Add(this.browseButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Select Campaign";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filePathDisplay;
        private System.Windows.Forms.Button openCampaignButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

