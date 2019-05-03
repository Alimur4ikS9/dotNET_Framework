using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PaintOOP
{
    public partial class Shape : UserControl
    {
        public Shape()
        {
            InitializeComponent();
        }
        private ShapeType shape = ShapeType.Rectangle;
        private GraphicsPath path = null;
        public enum ShapeType {Rectangle, Circle, Triangle};

        public ShapeType Type
        {
            get { return shape; }
            set {
                shape = value;
                create();
            }
        }

        private void create()
        {
            path = new GraphicsPath();
            switch (shape)
            {
                case ShapeType.Rectangle:
                    path.AddRectangle(this.ClientRectangle);
                    break;
                case ShapeType.Circle:
                    path.AddEllipse(this.ClientRectangle);
                    break;
                case ShapeType.Triangle:
                    Point p1 = new Point(this.Width/2, 0);
                    Point p2 = new Point(0, this.Height);
                    Point p3 = new Point(this.Width, this.Height);
                    Point[] points = { p1, p2, p3};
                    path.AddPolygon(points);
                    break;
            }
            this.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if( path != null)
            {
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
                e.Graphics.DrawPath(new Pen(this.ForeColor, 4), path);
            }
        }

        
        protected override void OnResize(EventArgs e)
        {
            create();
            this.Invalidate();
        }
    }
}
