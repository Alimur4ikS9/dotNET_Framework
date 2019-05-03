using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Color colourone, colourtwo, colourthree;

        public int Gradient(int r, int r1, int num)
        {
            int colour;
            colour = Math.Abs((r1 - r) / (num - 1));
            return colour;
        }

        public void draw(String size)
        {
            int y0, x, y, 
                width, height, m, 
                r0, g0, b0, 
                r, g, b, 
                r1, g1, b1, 
                r2, g2, b2, 
                cr, cg, cb, 
                cr1, cg1, cb1, 
                y01, x1, y1;
            int cnt = 1;
            int size1 = int.Parse(size);

            Graphics graph = pictureBox1.CreateGraphics();

            y0 = 10;
            x = 10;
            y = 10;
            y01 = 10 + 200 / size1;
            x1 = 10 + 200 / size1;
            y1 = 10 + 200 / size1;
            width = 400 / size1;
            height = 400 / size1;
            m = 400;

            r0 = colourone.R;
            g0 = colourone.G;
            b0 = colourone.B;

            r = colourone.R;
            g = colourone.G;
            b = colourone.B;

            r1 = colourtwo.R;
            g1 = colourtwo.G;
            b1 = colourtwo.B;

            r2 = colourthree.R;
            g2 = colourthree.G;
            b2 = colourthree.B;

            cr = Gradient(r, r1, size1);
            cg = Gradient(g, g1, size1);
            cb = Gradient(b, b1, size1);

            cr1 = Gradient(r, r2, size1);
            cg1 = Gradient(g, g2, size1);
            cb1 = Gradient(b, b2, size1);
            
            for (int i = 0; i < size1; i++)
            {
                Color colour;
                SolidBrush brush;
                
                for (int j = 0; j < size1; j++)
                {
                    colour = Color.FromArgb(r, g, b);
                    brush = new SolidBrush(colour);
                    if (y <= m)
                    {
                        graph.FillEllipse(brush, x, y, width, height);
                       // graph.DrawString((cnt).ToString(), new Font("Times New Roman", 200/size1),
                         //   new SolidBrush(Color.Black), new Point(x, y), new StringFormat());
                        y1 += 400 / size1;
                        y += 400 / size1;
                        if (r > r2) r -= cr1;
                        if (r < r2) r += cr1;
                        if (g > g2) g -= cg1;
                        if (g < g2) g += cg1;
                        if (b > b2) b -= cb1;
                        if (b < b2) b += cb1;
                    }
                    cnt++;
                    if (y > m) break;
                }

                cnt -= 1;
                if (r0 > r1) r0 -= cr;
                if (r0 < r1) r0 += cr;
                if (g0 > g1) g0 -= cg;
                if (g0 < g1) g0 += cg;
                if (b0 > b1) b0 -= cb;
                if (b0 < b1) b0 += cb;
                r = r0;
                g = g0;
                b = b0;

                x1 += 400 / size1;
                y1 = y01 + 400 / (2 * size1);
                y01 = y01 + 400 / (2 * size1);

                x += 400 / size1;
                y = y0 + 400 / (2 * size1);
                y0 = y0 + 400 / (2 * size1);

                m -= 400 / (2 * size1);
                cnt++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                colourone = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
                colourtwo = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
                colourthree = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Color colour = Color.FromName(dataGridView1.CurrentCell.Value.ToString());
            pictureBox1.BackColor = colour;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Color";
            System.Array colorsArray = Enum.GetValues(typeof(KnownColor));

            string[] row = new string[] { };
            dataGridView1.Rows.Add(row);

            foreach (KnownColor s in colorsArray)
            {
                row = new string[] { s.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
