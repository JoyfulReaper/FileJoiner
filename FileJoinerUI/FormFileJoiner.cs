/*
MIT License

Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using FileJoinerLibrary;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileJoinerUI
{
    public partial class FormFileJoiner : Form
    {
        private readonly BindingList<FileInfo> filesToJoin = new BindingList<FileInfo>();

        private string outputPath = Environment.CurrentDirectory;

        public FormFileJoiner()
        {
            InitializeComponent();

            SetupData();
        }

        private void SetupData()
        {
            listBoxFiles.DataSource = filesToJoin;
            listBoxFiles.DisplayMember = "Name";

            lblOutputFolder.Text = outputPath;
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            //openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Text Files (*.txt;*.sql)|*.txt;*.sql;|All Files(*.*)|*.*|Programming stuff (*.cs;*.c;*.cpp*;*.h;*.hpp*.sql;*.cc)|*.cs;*.c;*.cpp*;*.h;*.hpp*.sql;*.cc";
            openFileDialog.FilterIndex = 2;
            //openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileNames = openFileDialog.FileNames;

                foreach (string f in fileNames)
                {
                    FileInfo file = new FileInfo(f);
                    if (filesToJoin.FirstOrDefault(e => e.FullName == file.FullName) == null)
                    {
                        filesToJoin.Add(file);
                    }
                    else
                    {
                        MessageBox.Show($"{file.Name}: File has already been added, skipping.");
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedItems = listBoxFiles.SelectedItems;

            for (int i = 0; i < selectedItems.Count; i++)
            {
                var removeItem = filesToJoin.FirstOrDefault(e => e.FullName == ((FileInfo)(selectedItems[i])).FullName);
                if (removeItem != null)
                {
                    filesToJoin.Remove(removeItem);
                }
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            if (filesToJoin.Count <= 0)
            {
                MessageBox.Show("No files have been selected");
                return;
            }

            if (File.Exists($"{ outputPath}\\{ textBoxOutputFileName.Text}"))
            {
                var result = MessageBox.Show($"{textBoxOutputFileName.Text}: Output file exists. Over write file?", "Over write file?", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            btnJoin.Enabled = false;

            if (checkBoxAllTextFiles.Checked)
            {
                int numNewLine = 0;
                if (checkBoxNewLines.Checked)
                {
                    if (!int.TryParse(textBoxNewLines.Text, out numNewLine) || numNewLine < 0)
                    {
                        MessageBox.Show("Please enter a valid number of NewLines");
                        return;
                    }
                }

                FileJoiner.JoinTextFiles(filesToJoin.ToList(), numNewLine, $"{outputPath}\\{textBoxOutputFileName.Text}");
            }
            else
            {
                FileJoiner.JoinFiles(filesToJoin.ToList(), $"{outputPath}\\{textBoxOutputFileName.Text}");
            }

            btnJoin.Enabled = true;

            MessageBox.Show("Join completed!");
        }

        private void checkBoxAllTextFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllTextFiles.Checked)
            {
                checkBoxNewLines.Enabled = true;

                textBoxNewLines.Enabled = true;
            }
            else
            {
                checkBoxNewLines.Checked = false;
                checkBoxNewLines.Enabled = false;

                textBoxNewLines.Enabled = false;
            }
        }

        private void btnSetOuputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputPath = folderBrowserDialog.SelectedPath;
                lblOutputFolder.Text = outputPath;
            }
        }

        private void btnClearFiles_Click(object sender, EventArgs e)
        {
            filesToJoin.Clear();
        }

        private void btnFileUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void MoveItem(int direction)
        {
            FileInfo selected = (FileInfo)listBoxFiles.SelectedItem;

            if (selected == null || listBoxFiles.SelectedIndex < 0)
            {
                return;
            }

            int newIndex = listBoxFiles.SelectedIndex + direction;

            if(newIndex < 0 || newIndex >= listBoxFiles.Items.Count)
            {
                return;
            }
  
            filesToJoin.Remove(selected);
            filesToJoin.Insert(newIndex, selected);

            listBoxFiles.ClearSelected();
            listBoxFiles.SelectedIndex = newIndex;
        }

        private void btnFileDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }
    }
}
