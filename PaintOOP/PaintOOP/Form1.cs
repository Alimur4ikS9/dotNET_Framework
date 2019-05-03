using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color colour;
        bool isDrag = false;
        bool isResize = false;
     
        Point clicked = Point.Empty;

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            Control current = (Control)sender;
            clicked = e.Location;
            if ((e.X + 5) > current.Width || (e.Y + 5) > current.Height)
            {
                isResize = true;
            }
            else isDrag = true;
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            Control current = (Control)sender;
            label1.Text = Cursor.Position.ToString();
            if (isDrag)
            {
                current.Left = e.X - clicked.X + current.Left;
                current.Top = e.Y - clicked.Y + current.Top;
            }
            else if (isResize)
            {
                if (current.Cursor == Cursors.SizeNWSE)
                {
                    current.Width = e.X;
                    current.Height = e.Y;
                }
                if (current.Cursor == Cursors.SizeNESW)
                {
                    current.Width = e.X;
                    current.Height = e.Y;
                }
                else if (current.Cursor == Cursors.SizeNS)
                {
                    current.Height = e.Y;
                    if (e.Y < current.Height)
                    {
                        
                    }
                }
                else if (current.Cursor == Cursors.SizeWE)
                {
                    if ((e.X + 5) > current.Left)
                    {
                        //label1.Text = "hi"+ " " +e.X;
                        current.Left = e.X;
                        
                    }else if ((e.X + 5) > current.Width)
                    {
                        current.Width = e.X;
                    }
                    
                }
            }
            else
            {
                if ((e.X + 5) > current.Width && (e.Y + 5) > current.Height)
                {
                    current.Cursor = Cursors.SizeNWSE;
                }
                else if ((e.X + 5) > current.Width && ((e.Y + 5) > 0 && (e.Y + 5) < 10))
                {
                    current.Cursor = Cursors.SizeNESW;
                }
                else if ((e.Y + 5) > current.Height || ((e.Y + 5) > 0 && (e.Y + 5) < 10))
                {
                    current.Cursor = Cursors.SizeNS;
                }
                else if ((e.X + 5) > current.Width || ((e.X + 5) > 0 && (e.X + 5) < 10))
                {
                    current.Cursor = Cursors.SizeWE;
                }
               
                else
                {
                    current.Cursor = Cursors.Arrow;
                }
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
            isResize = false;
        }

        void manageShapes(Shape.ShapeType sht)
        {
            Shape newShape = new Shape();
            newShape.Location = new Point(100, 100);
            newShape.Size = new Size(50, 50);
            newShape.ForeColor = colorDialog1.Color;
            newShape.Type = sht;
            newShape.MouseDown += new MouseEventHandler(_MouseDown);
            newShape.MouseMove += new MouseEventHandler(_MouseMove);
            newShape.MouseUp += new MouseEventHandler(_MouseUp);
            newShape.BackColor = Color.Red;
            Cursor.Clip = new Rectangle(this.Location, this.Size);
            
            this.Controls.Add(newShape);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageShapes(Shape.ShapeType.Rectangle);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageShapes(Shape.ShapeType.Circle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manageShapes(Shape.ShapeType.Triangle);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void forecolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colour = colorDialog1.Color;
            }
        }
    }
}
