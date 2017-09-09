namespace MP3PlayerMetro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.metroNext = new MetroFramework.Controls.MetroTile();
            this.metroPrevious = new MetroFramework.Controls.MetroTile();
            this.metroResume = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroOpenFile = new MetroFramework.Controls.MetroTile();
            this.metroStop = new MetroFramework.Controls.MetroTile();
            this.metroPause = new MetroFramework.Controls.MetroTile();
            this.metroPlay = new MetroFramework.Controls.MetroTile();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(39, 74);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(671, 23);
            this.metroTextBox1.TabIndex = 5;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(621, 320);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(169, 53);
            this.metroTrackBar1.TabIndex = 6;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(756, 119);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(46, 26);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // metroNext
            // 
            this.metroNext.BackColor = System.Drawing.Color.White;
            this.metroNext.CustomBackground = true;
            this.metroNext.Location = new System.Drawing.Point(438, 320);
            this.metroNext.Name = "metroNext";
            this.metroNext.Size = new System.Drawing.Size(59, 53);
            this.metroNext.TabIndex = 11;
            this.metroNext.TileImage = global::MP3PlayerMetro.Properties.Resources.if_ff_83437;
            this.metroNext.UseTileImage = true;
            this.metroNext.Click += new System.EventHandler(this.metroNext_Click);
            // 
            // metroPrevious
            // 
            this.metroPrevious.BackColor = System.Drawing.Color.White;
            this.metroPrevious.CustomBackground = true;
            this.metroPrevious.Location = new System.Drawing.Point(271, 320);
            this.metroPrevious.Name = "metroPrevious";
            this.metroPrevious.Size = new System.Drawing.Size(49, 53);
            this.metroPrevious.TabIndex = 10;
            this.metroPrevious.TileImage = global::MP3PlayerMetro.Properties.Resources.if_rew_83452;
            this.metroPrevious.UseTileImage = true;
            this.metroPrevious.Click += new System.EventHandler(this.metroPrevious_Click);
            // 
            // metroResume
            // 
            this.metroResume.BackColor = System.Drawing.Color.White;
            this.metroResume.CustomBackground = true;
            this.metroResume.Location = new System.Drawing.Point(92, 320);
            this.metroResume.Name = "metroResume";
            this.metroResume.Size = new System.Drawing.Size(53, 53);
            this.metroResume.TabIndex = 9;
            this.metroResume.TileImage = global::MP3PlayerMetro.Properties.Resources.if_media_play_pause_resume_49842;
            this.metroResume.UseTileImage = true;
            this.metroResume.Click += new System.EventHandler(this.metroResume_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.BackColor = System.Drawing.Color.White;
            this.metroTile5.CustomBackground = true;
            this.metroTile5.Location = new System.Drawing.Point(532, 320);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(57, 53);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.TileImage = global::MP3PlayerMetro.Properties.Resources.if_42_1109911;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseTileImage = true;
            // 
            // metroOpenFile
            // 
            this.metroOpenFile.BackColor = System.Drawing.Color.White;
            this.metroOpenFile.CustomBackground = true;
            this.metroOpenFile.Location = new System.Drawing.Point(716, 63);
            this.metroOpenFile.Name = "metroOpenFile";
            this.metroOpenFile.Size = new System.Drawing.Size(51, 50);
            this.metroOpenFile.TabIndex = 4;
            this.metroOpenFile.TileImage = global::MP3PlayerMetro.Properties.Resources.if_folder_83439;
            this.metroOpenFile.UseTileImage = true;
            this.metroOpenFile.Click += new System.EventHandler(this.metroOpenFile_Click);
            // 
            // metroStop
            // 
            this.metroStop.BackColor = System.Drawing.Color.White;
            this.metroStop.CustomBackground = true;
            this.metroStop.Location = new System.Drawing.Point(343, 320);
            this.metroStop.Name = "metroStop";
            this.metroStop.Size = new System.Drawing.Size(75, 53);
            this.metroStop.TabIndex = 3;
            this.metroStop.TileImage = global::MP3PlayerMetro.Properties.Resources.if_24_Stop_106221;
            this.metroStop.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroStop.UseTileImage = true;
            this.metroStop.Click += new System.EventHandler(this.metroStop_Click);
            // 
            // metroPause
            // 
            this.metroPause.BackColor = System.Drawing.Color.White;
            this.metroPause.CustomBackground = true;
            this.metroPause.Location = new System.Drawing.Point(165, 320);
            this.metroPause.Name = "metroPause";
            this.metroPause.Size = new System.Drawing.Size(75, 53);
            this.metroPause.TabIndex = 2;
            this.metroPause.TileImage = global::MP3PlayerMetro.Properties.Resources.if_pause_83447;
            this.metroPause.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroPause.UseTileImage = true;
            this.metroPause.Click += new System.EventHandler(this.metroPause_Click);
            // 
            // metroPlay
            // 
            this.metroPlay.BackColor = System.Drawing.Color.White;
            this.metroPlay.CustomBackground = true;
            this.metroPlay.Location = new System.Drawing.Point(11, 320);
            this.metroPlay.Name = "metroPlay";
            this.metroPlay.Size = new System.Drawing.Size(75, 53);
            this.metroPlay.TabIndex = 1;
            this.metroPlay.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPlay.TileImage = global::MP3PlayerMetro.Properties.Resources.if_play_83449;
            this.metroPlay.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroPlay.UseTileImage = true;
            this.metroPlay.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(671, 186);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 396);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroNext);
            this.Controls.Add(this.metroPrevious);
            this.Controls.Add(this.metroResume);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroOpenFile);
            this.Controls.Add(this.metroStop);
            this.Controls.Add(this.metroPause);
            this.Controls.Add(this.metroPlay);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Odtwarzacz MP3";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroPlay;
        private MetroFramework.Controls.MetroTile metroPause;
        private MetroFramework.Controls.MetroTile metroStop;
        private MetroFramework.Controls.MetroTile metroOpenFile;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroTile metroResume;
        private MetroFramework.Controls.MetroTile metroPrevious;
        private MetroFramework.Controls.MetroTile metroNext;
        private System.Windows.Forms.ListBox listBox1;
    }
}

