using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            pbSaved.Maximum = 0;
            pbSaved.Maximum = txtImages.Text.Split('\n').Count();
            btnSave.Enabled = false;

            foreach (var item in txtImages.Text.Split('\n'))
            {
                count++;
                using (WebClient client = new WebClient())
                {
                    client.DownloadFileCompleted += DownloadCompleted;
                    client.DownloadFileAsync(new Uri(txtUrl.Text+item), txtDestino.Text +"\\" + txtNombre.Text+count + (rbJPG.Checked? ".jpg":".png"));
                }
            }
            /*using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\loren\Desktop\", "Entradas.txt")))
            {
                foreach (string line in txtImages.Text.Split('\n'))
                {
                    count++;
                    outputFile.WriteLine(line.Remove((line.Count() - 1)) + ";" + count);
                }
            }*/
        }

        public void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pbSaved.Value++;
            if(pbSaved.Value == pbSaved.Maximum)
            {
                btnSave.Enabled = true;
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtDestino.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
