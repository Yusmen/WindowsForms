using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_5_4
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
            int h = 100, red, green, blue;
            Random r = new Random();
            Point A,B;
            for (int i = 1; i <= 10; i++)
            {
                int w = r.Next() % 20 + 10;
                red = r.Next() % 256;
                green = r.Next() % 256;
                blue = r.Next() % 256;
                Pen pen = new Pen(Color.FromArgb(red, green, blue), w);
                A = new Point(100, h);
                B = new Point(600, h);
                g.DrawLine(pen, A, B);
                h = h + w / 2;
                //Thread.Sleep(100);


            }
        }
    }
}
