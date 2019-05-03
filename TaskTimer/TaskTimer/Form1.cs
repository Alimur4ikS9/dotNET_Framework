using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seconds = 0;

       

        private void button1_Click(object sender, EventArgs e)
        {
            TaskManager tm = new TaskManager();
            flowLayoutPanel1.Controls.Add(tm);
            tm.name(textBox1.Text);
            if (checkBox1.Checked)
            {
                tm.goal(0, 0);
            }
            else
            {
                tm.goal((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            if (checkBox2.Checked) tm.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawPie();
            timer1.Start();
        }

        private void drawPie()
        {
            chart1.Series["Series1"].Points.Clear();
            foreach (TaskManager element in flowLayoutPanel1.Controls)
            {
                chart1.Series["Series1"].Points.AddXY(element.getName(), element.getTime());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timer1 = TimeSpan.FromSeconds(seconds);
            string timerstr = timer1.ToString(@"hh\:mm\:ss");
            label11.Text = timerstr;
            if (seconds % 10 == 0)
            {
                drawPie();
            }
            seconds++;
        }
/*
        public void hoverTask()
        {
            if (flowLayoutPanel1.MouseHover)
            {

            }
            //flowLayoutPanel1.Controls.
        }
  */
    }
}
