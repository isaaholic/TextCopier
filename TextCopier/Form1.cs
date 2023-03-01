using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCopier
{
    public partial class Form1 : Form
    {
        Thread thread = null;
        bool isSuspend = false;
        public Form1()
        {
            InitializeComponent();
            thread = new Thread(Copy);
        }

        private async void Copy()
        {
            string srcPath = Fromtxtbox.Text;
            string destPath = Totxtbox.Text;

            if (!File.Exists(srcPath))
            {
                MessageBox.Show("File not exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FileStream fsRead = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
                {
                    var len = 10;
                    var fileSize = fsRead.Length;
                    byte[] buffer = new byte[len];

                    do
                    {
                        len = fsRead.Read(buffer, 0, buffer.Length);
                        fsWrite.Write(buffer, 0, len);

                        fileSize -= len;

                        Thread.Sleep(5);

                    } while (len != 0);
                }
            }

            await Task.Delay(2000);
        }


        private void FromFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|";
            fileDialog.ShowDialog();
            Fromtxtbox.Text = fileDialog.FileName;
        }

        private void ToFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|";
            fileDialog.ShowDialog();
            Totxtbox.Text = fileDialog.FileName;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            thread.Start();
            while (prBar.Value != prBar.Maximum)
            {
                if (isSuspend)
                    return;
                prBar.Value += 20;
                Thread.Sleep(1000);
            }

        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();
                isSuspend = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Resume();
                isSuspend = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SuspendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Suspend();
                isSuspend = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
