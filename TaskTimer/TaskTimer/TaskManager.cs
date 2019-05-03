using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TaskTimer
{
    public partial class TaskManager : UserControl
    {
        public TaskManager()
        {
            InitializeComponent();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }

        int seconds = 0;
        const int max = Int32.MaxValue;
       

        public void timer1_Tick(object sender, EventArgs e)
        { 
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string timestr = time.ToString(@"hh\:mm\:ss");
            label2.Text = timestr;
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                SoundPlayer p = new SoundPlayer(@"D:\01_Alinur_Sabit\KBTU_2.2\NET\Labs\cartoon184.wav");
                p.PlayLooping();
                
                DialogResult result1 = MessageBox.Show("  Goal time is reached",
                "Do you want to finish task?",
                MessageBoxButtons.YesNo);
                p.Stop();

                if (result1 == DialogResult.Yes)
                {
                    MessageBox.Show("Timer was stoped");
                }
                else
                {
                    timer(0, 0);
                    goal(0, 0);
                    timer1.Start();
                    MessageBox.Show("Timer is still ticking");
                }
            }
            seconds++;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seconds = 0;
            progressBar1.Value = 0;
            timer1.Start();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Controls["flowLayoutPanel1"].Controls.Remove(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            textBox2.Text = null;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            name(textBox2.Text);
            progressBar1.Value = 0;
            timer((int)numericUpDown3.Value, (int)numericUpDown4.Value);
            goal((int)numericUpDown5.Value, (int)numericUpDown6.Value);
            timer1.Start();
            groupBox2.Visible = false;
        }

        public void name(string str)
        {
            label1.Text = str;
        }

        public void timer(int hours, int minutes)
        {
            int timerSeconds = hours * 3600 + minutes * 60;
            seconds = timerSeconds;
            TimeSpan timer = TimeSpan.FromSeconds(timerSeconds);
            string timerstr = timer.ToString(@"hh\:mm\:ss");
            label2.Text = timerstr;
            progressBar1.Maximum = max;
            progressBar1.Value = timerSeconds;
        }

        public void goal(int hours, int minutes)
        {
            if (hours == 0 && minutes == 0)
            {
                label3.Text = "Indefined";
            }
            else
            {         
                int goalSeconds = hours * 3600 + minutes * 60;
                TimeSpan goalTime = TimeSpan.FromSeconds(goalSeconds);
                string goalstr = goalTime.ToString(@"hh\:mm\:ss");
                label3.Text = goalstr;
                progressBar1.Maximum = goalSeconds;
            }
        }

        public string getName()
        {
            return label1.Text;
        }

        public int getTime()
        {
            return seconds; 
        }
    }
}

