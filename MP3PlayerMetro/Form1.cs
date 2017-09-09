using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3PlayerMetro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
      
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, paths;

        private void metroTile1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        private void metroOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                    metroTextBox1.Text = openFileDialog1.SafeFileName;
                    openFileDialog1.ShowDialog();
                }
            }
            else
            {
                metroTextBox1.Text = "Nazwa pliku nie jest określona";
            }
         
        }

        private void metroResume_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void metroPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void metroStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = metroTrackBar1.Value;
        }

        private void metroPrevious_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }

        private void metroNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }
    }
}
