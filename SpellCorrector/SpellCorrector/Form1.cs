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

namespace SpellCorrector
{
    public partial class Form1 : Form
    {

        String text = "";
        String word = "";
        List<string> words = new List<string>();
        private bool button3WasClicked = false;

        public Form1()
        {
            InitializeComponent();
            words = File.ReadAllLines(@"D:\01_Alinur_Sabit\KBTU_2.2\NET\Labs\words.txt").ToList();
            /*
            FileStream theFile = File.Open(@"D:\01_Alinur_Sabit\KBTU_2.2\NET\Labs\words.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(theFile);
            words = sr.ReadToEnd().ToList();
            */
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
//            if (text == richTextBox2.Text)
//            {
//                return;
//            }

            text = richTextBox2.Text;
            int n = text.Length;
            if (!Char.IsLetter(text[n - 1]))
            {
                for (int i = n - 2; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        word = text.Substring(i, n - i - 2);
                        break;
                    }

                    if (!Char.IsLetter(text[i]))
                    {
                        word = text.Substring(i + 1, n - i - 2);
                        break;
                    }
                }

                List<string> list = new List<string>();

                int min = Int32.MaxValue;
                int spell = -1;
                int sizeOfList = words.Count;
                for (int i = 0; i < words.Count; i++)
                {
                    int distance = levenshtein(word, words[i]);

                    if (distance == 0)
                    {
                        spell = -1;
                        break;
                    }

                    if (min > distance)
                    {
                        min = distance;
                        spell = i;
                        list.Add(words[spell]);
                    }
                }

                if (checkBox1.Checked)
                {
                    if (words.Contains(word))
                    {
                        return;
                    }
                    else
                    {
                        richTextBox2.SelectionStart = text.IndexOf(word);
                        richTextBox2.SelectionLength = word.Length;
                        richTextBox2.SelectionColor = Color.HotPink;
                        return;
                        //autocorrect
                    }
                }
                else
                {
                    if (!words.Contains(word))
                    {
                        richTextBox2.SelectionStart = text.IndexOf(word);
                        richTextBox2.SelectionLength = word.Length;
                        richTextBox2.SelectionColor = Color.HotPink;
                        listBox1.DataSource = list;
                        list.Add("word");
                    }
                    
                }

                //label1.Text += word + " ";
                richTextBox2.Text = text;
                richTextBox2.SelectionStart = richTextBox2.Text.Length;

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            //string correctWord = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = text.Replace(word, textBox1.Text);
            richTextBox2.SelectionStart = text.IndexOf(word);
            richTextBox2.SelectionLength = word.Length;
            richTextBox2.SelectionColor = Color.Black;
            button3WasClicked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                button1.Enabled = false;
            }
             words.Add(word);

        }

        private void button2_Click(object sender, EventArgs e)
        {
//            List<string> w = new List<string>();
//            listBox1.DataSource = w;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static int levenshtein(String s1, String s2)
        {
            int n = s1.Length;
            int m = s2.Length;
            int[,] d = new int[n + 1, m + 1];
            if (n == 0) { return m; }
            if (m == 0) { return n; }

            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int sub = 0;
                    if (s1[i - 1] == s2[j - 1])
                    {
                        sub = 0;
                    }
                    else
                    {
                        sub = 2;
                    }

                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + sub);
                }
            }

            return d[n, m];

            //            StreamReader sr = new StreamReader(@"D:\01_Alinur_Sabit\KBTU_2.2\NET");
            //            Console.WriteLine(sr.ReadToEnd());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

/*

    */
