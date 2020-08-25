using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_3_d
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
            for (int i = 0; i < 10; i++)
            {
                x1 += side;
                x2 = side + x1;
                y2 = y1;
                x3 = (x1 + x2) / 2;
                y3 = y1 - h;
                g.DrawLine(pen, x1, y1, x2, y2);
                g.DrawLine(pen, x2, y2, x3, y3);
                g.DrawLine(pen, x3, y3, x1, y1);

            }


        }
    }
}
