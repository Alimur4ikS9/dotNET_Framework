using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class FileBrowser : Form
    {
        string strFileSearch;
        List<FileInfo> list;
        public FileBrowser()
        {
            InitializeComponent();
            list = new List<FileInfo>();
            strFileSearch = "";
        }

        private void FileBrowser_Load(object sender, EventArgs e)
        {
        }
        /*
        private void btnSearchDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //strSearchDirectory;
                this.strSearchDirectory = fbd.SelectedPath;
                srcSearchDirectory.Text = this.strSearchDirectory;
            }
        }
        */
        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            list.Clear();
            strFileSearch = txtSearchFile.Text;
            DirSearch(new DirectoryInfo(@"D:\01_Alinur_Sabit\KBTU_2.2"));
            if (list.Count > 0)
            {
                foreach(FileInfo file in list)
                {
                    lbxResults.Items.Add(file.FullName);
                }
            }
            else
            {
                MessageBox.Show("No such File");
            }
            
            /*
            DirectoryInfo di = new DirectoryInfo(strSearchDirectory);
            find(di);
            FileInfo[] fi = di.GetFiles();
            if (txtSearchFile.Text != "")
            {
                string strSearchString = txtSearchFile.Text;
                lbxResults.Items.Clear();
                foreach (FileInfo curFile in fi)
                {
                    if (curFile.Name.ToUpper().IndexOf(strSearchString.ToUpper()) != -1)
                    {
                        lbxResults.Items.Add(curFile.Name);
                    }
                }

                //txtSearchFile.Clear();
                txtSearchFile.Focus();
            }
            */
        }

        public void DirSearch(DirectoryInfo sDir)
        {
            try
            {
                foreach (FileInfo file in sDir.GetFiles())
                {
                    if (file.Name == strFileSearch)
                    {
                        list.Add(file);
                    }
                    string fileSplit = file.Name.Split('.')[0];
                    if (fileSplit == strFileSearch)
                    {
                        list.Add(file);
                    }
                }
               

                foreach (DirectoryInfo directory in sDir.GetDirectories())
                {
                    DirSearch(directory);
                }
                
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        /*
        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, txtSearchFile.Text))
                    {
                        lbxResults.Items.Add(f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            /*
            try
            {
                foreach (string file in Directory.GetFiles(sDir, txtSearchFile.Text))
                {
                    lbxResults.Items.Add(file);
                }

                foreach (string directory in Directory.GetDirectories(sDir))
                {
                    this.DirSearch(directory);
                }
            }
            catch (System.Exception ex)
            {
                lbxResults.Items.Add(ex.Message);
            }
            
        }
        */
        /*

       private void find(DirectoryInfo dir)
       {
           FileSystemInfo[] fsi = dir.GetFileSystemInfos();
           for (int i = 0; i < fsi.Length; i++)
           {
               if (fsi[i] is FileInfo)
               {
                   if (fsi[i].Name.Contains(strSearchDirectory))
                   {
                       srcSearchDirectory.Text = strSearchDirectory;
                   }
               }
               else
               {
                   find(fsi[i] as DirectoryInfo);
               }
           }
       }
       */

        private void txtSearchFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();
        }

        private void lbxResults_DoubleClick(object sender, EventArgs e)
        {
            string path = strFileSearch;
            if(path != "")
            {
            System.Diagnostics.Process.Start(path);
            }
        }
    }
}

