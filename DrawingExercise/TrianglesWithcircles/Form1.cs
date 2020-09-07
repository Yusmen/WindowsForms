using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrianglesWithcircles
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
            int n = 1, m = 30;
            int x1 = 100, y1 = 500, side = 500;   
            int x2 = x1 + side, y2 = y1;     
            int h = (int)(side * Math.Sqrt(3) / 2);     
            int x3 = (x1 + x2) / 2, y3 = y1 - h;      
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x1, y1);
            for (int i = 1; i <= 5; i++)
            {
                int x = x1, y=y1;
                x1 = (n * x1 + m * x2) / (m + n);
                y1 = (n * y1 + m * y2) / (m + n);
                x2 = (n * x2 + m * x3) / (m + n);
                y2 = (n * y2 + m * y3) / (m + n);
                x3 = (n * x3 + m * x) / (m + n);
                y3 = (n * y3 + m * y) / (m + n);
                g.DrawLine(pen, x1, y1, x2, y2);
                g.DrawLine(pen, x2, y2, x3, y3);
                g.DrawLine(pen, x3, y3, x1, y1);

            }


        }
    }
}
