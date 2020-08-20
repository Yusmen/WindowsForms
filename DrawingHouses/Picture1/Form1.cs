using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture1
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
            Pen p = new Pen(Color.Black, 4);
            Brush b = new SolidBrush(Color.Green);
            Brush b1 = new SolidBrush(Color.Gray);
            Brush b2 = new SolidBrush(Color.Red);
            Brush b3 = new SolidBrush(Color.Yellow);
            Brush b4 = new SolidBrush(Color.SteelBlue);
            Brush b5 = new SolidBrush(Color.White);
            Brush b6 = new SolidBrush(Color.LightGray);
            Brush b7 = new SolidBrush(Color.Black);
         
            
            int side = 400;
            int x1 = 80, y1 = 280;
            int x2 = x1 + side, y2 = y1;
            int x3 = (x1 + x2) / 2;
            int h = (x2 - x1) / 2;
            int y3 = y1 - h;
            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);
            Point C = new Point(x3, y3);
            Point[] points = { A, B,C };       
       
            g.FillRectangle(b, 0, 580, Screen.PrimaryScreen.WorkingArea.Width, 400);
            g.FillRectangle(b1, 180, 280, 200, 300);
            g.FillEllipse(b3, 20, 20, 100, 100);
            g.FillEllipse(b4, 20, 120, 100, 50);
            g.FillEllipse(b4, 250, 80, 100, 50);
            g.FillEllipse(b4, 450, 20, 100, 50);
            g.FillEllipse(b4, 480, 150, 100, 50);
            g.FillPolygon(b2, points);
            g.FillRectangle(b5, 200, 350, 30, 40);
            g.FillRectangle(b5, 330, 350, 30, 40);
            g.FillRectangle(b6, 240, 470, 80, 110);
            g.FillEllipse(b3, 20, 600, 20, 20);
            g.FillEllipse(b5, 100, 630, 20, 20);
            g.FillEllipse(b2, 200, 620, 20, 20);
            g.FillEllipse(b1, 300, 640, 20, 20);
            g.FillEllipse(b6, 400, 625, 20, 20);
            g.DrawLine(p, 240, 520, 270, 520);
            g.DrawLine(p, 270, 520, 270, 530);
            g.FillEllipse(b7, 260, 530, 20, 20);



        }
    }
}
