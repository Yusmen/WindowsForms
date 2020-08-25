using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_4
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
            for (int i = 1; i <= 10; i++) 
            {
                int w = r.Next() % 20 + 10;
                red = r.Next() % 256;
                green = r.Next() % 256;
                blue = r.Next(200,256) % 256;
                Pen pen = new Pen(Color.FromArgb(red, green, blue), w);
                g.DrawLine(pen, 100, h,600, h);
                h = h + w / 2;
                //Thread.Sleep(100);


            }
        }


    }
}
