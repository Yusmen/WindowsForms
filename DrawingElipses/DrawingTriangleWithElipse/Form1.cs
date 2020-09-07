using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTriangleWithElipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 2);
            int side = 200;
            int x1 = 300, y1 = 300;
            int x2 = x1 + side, y2 = y1;
            int x3 = (x1 + x2) / 2;
            int h = (int)(side * Math.Sqrt(3) / 2);
            int y3 = y1 - h;
            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);
            Point C = new Point(x3, y3);
            g.DrawLine(pen, A, B);
            g.DrawLine(pen, B, C);
            g.DrawLine(pen, C, A);


         
            int d = (int)((1.0 / 3.0) * h);

            g.DrawArc(pen, x3, y1-100, 200, 200, 0, 360);
            g.DrawArc(pen, x3 - 200, y1 - 100, 200, 200, 0, 360);
            g.DrawArc(pen, x3 - 100, y1 - 100 - h, 200, 200, 0, 360);
            int bigCircleRadius = (int)(2 * (100 + (2.0 / 3.0) * h));
            g.DrawArc(pen, x3 - 200, y1 - bigCircleRadius / 2 - d, bigCircleRadius, bigCircleRadius, 0, 360);



        }
    }
}
