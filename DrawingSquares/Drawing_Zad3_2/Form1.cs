using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Zad3_2
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
            Pen pen = new Pen(Color.Blue, 3);
            int x1 = 350, y1 = 200;
            int side = 100;
            int x2 = x1 + side, y2 = y1;
            int x3 = x2, y3 = y2 + side;
            int x4 = x1, y4 = y3;

            int br = 0;

            for (int i = 1; i <= 50; i++)
            {

                x1 += 20;
                y1 += 20;
                x2 = x1 + side - 20 * br;
                y2 = y1;
                x3 = x2;
                y3 = y2 + side - 20 * br;
                x4 = x1;
                y4 = y3;
                br += 2;
                g.DrawLine(pen, x1, y1, x2, y2);
                g.DrawLine(pen, x2, y2, x3, y3);
                g.DrawLine(pen, x3, y3, x4, y4);
                g.DrawLine(pen, x4, y4, x1, y1);

            }

        }

    }
}
