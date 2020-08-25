using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_5_3d
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
            Pen pen = new Pen(Color.Black, 2);
            int x1 = 0, y1 = 200, x2 = 0, y2 = 0, x3 = 0, y3 = 0, side = 200;
            int h = (int)(side * Math.Sqrt(3) / 2);
            Point A, B, C;
            for (int i = 0; i < 10; i++)
            {
                x1 += side;
                x2 = side + x1;
                y2 = y1;
                x3 = (x1 + x2) / 2;
                y3 = y1 - h;
                A = new Point(x1, y1);
                B = new Point(x2, y2);
                C = new Point(x3, y3);
                g.DrawLine(pen, A, B);
                g.DrawLine(pen, B, C);
                g.DrawLine(pen, C, A);

            }


        }
    }
}
