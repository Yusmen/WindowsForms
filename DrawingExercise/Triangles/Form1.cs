using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
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
            Pen pen = new Pen(Color.Red, 2);
            int x1 = 100, y1 = 500, side = 500;
            int x2 = x1 + side , y2=y1;
            int h = (int)(side * Math.Sqrt(3) / 2);
            int x3 = (x1 + x2) / 2, y3 = y1 - h;
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x1, y1);
            for (int i = 1; i <= 6; i++) 
            {
                int x = x1, y = y1;
                x1 = (x1 + x2) / 2;
                y1 = (y1 + y2) / 2;
                x2 = (x2 + x3) / 2;
                y2 = (y2 + y3) / 2;
                x3 = (x3 + x) / 2;
                y3 = (y3 + y) / 2;
                g.DrawLine(pen, x1, y1, x2, y2);
                g.DrawLine(pen, x2, y2, x3, y3);
                g.DrawLine(pen, x3, y3, x1, y1);


            }


        }
    }
}
