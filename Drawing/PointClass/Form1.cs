using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointClass
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
            
            int x1 = 80, y1 = 200, side = 200;
            Point A = new Point(x1, y1);
            int x2 = side + x1, y2 = y1;
            Point B = new Point(x2, y2);
            int x3 = (x1 + x2) / 2;
            int h = (int)(side * Math.Sqrt(3) / 2), y3 = y1 - h; //когато y3=y1+h , триъгълникът е обърнат надолу
            Point C = new Point(x3, y3);
            for (int i = 0; i < 2; i++)
            {
                g.DrawLine(pen, A, B);
                g.DrawLine(pen, B, C);
                g.DrawLine(pen, C, A);
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
