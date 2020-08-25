using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_5_3b
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
            Pen p = new Pen(Color.Black, 2);
            int side = 200, x1 = 0, y1 = 500, x2, y2, x3, y3;
            Point A, B, C;
            for (; x1 <= 800; x1 += 20)
            {
                x2 = x1 + side;
                y2 = y1;
                x3 = (x1 + x2) / 2;
                int h = (int)(side * Math.Sqrt(3) / 2);
                y3 = y1 - h;
                A = new Point(x1, y1);
                B = new Point(x2, y2);
                C = new Point(x3, y3);
                g.DrawLine(p, A, B);
                g.DrawLine(p, B, C);
                g.DrawLine(p, C, A);
                //Thread.Sleep(100);

            }
        }

    }
}
