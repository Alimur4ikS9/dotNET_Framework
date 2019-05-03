using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcher
{
    public partial class Form1 : Form
    {
        private string strSearchDirectory;

        public Form1()
        {
            InitializeComponent();
        }




        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            Console.ReadLine();
            /*
            
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            while (keyPressed.Key != ConsoleKey.Escape)
            {
                switch (keyPressed.Key)
                {
                    case ConsoleKey.Enter:
                        DirectoryInfo di = new DirectoryInfo(strSearchDirectory);
                        FileInfo[] fi = di.GetFiles();

                        if (textBox1.Text != "")
                        {
                            string strSearchString = textBox1.Text;
                            list_Results.Items.Clear();
                            foreach (FileInfo curFile in fi)
                            {
                                if (curFile.Name.ToUpper().IndexOf(strSearchString.ToUpper()) != -1)
                                {
                                    list_Results.Items.Add(curFile.Name)
                                }
                            }

                            textBox1.Clear();
                            textBox1.Focus();
                        }

                        break;
                }
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strSearchDirectory = fbd.SelectedPath;
                txtSearchDirectory.Text = strSearchDirectory;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strSearchDirectory = txtSearchDirectory.Text; 
        }

        private void list_Results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(strSearchDirectory);
            FileInfo[] fi = di.GetFiles();

            if (textBox1.Text != "")
            {
                string strSearchString = textBox1.Text;
                list_Results.Items.Clear();
                foreach (FileInfo curFile in fi)
                {
                    if (curFile.Name.ToUpper().IndexOf(strSearchString.ToUpper()) != -1)
                    {
                        list_Results.Items.Add(curFile.Name);
                    }
                }

                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void txtSearchDirectory_TextChanged(object sender, EventArgs e)
        {

        }
        */
    }
}
