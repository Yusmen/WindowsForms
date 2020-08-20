using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture2
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
            Pen pen = new Pen(Color.IndianRed, 3);
            Pen pen1 = new Pen(Color.Black, 3);
            Pen pen2 = new Pen(Color.Gray, 3);
            Pen pen3 = new Pen(Color.SandyBrown, 3);
            Pen pen4 = new Pen(Color.DarkRed, 5);
            Brush b = new SolidBrush(Color.Black);
            Brush b1 = new SolidBrush(Color.White);
            Brush b2 = new SolidBrush(Color.IndianRed);
            Brush b3 = new SolidBrush(Color.Yellow);
            Brush b4 = new SolidBrush(Color.Gray);
            Brush b5 = new SolidBrush(Color.SandyBrown);
            Brush b6 = new SolidBrush(Color.Green);
            Brush b7 = new SolidBrush(Color.DarkRed);
            Brush b8 = new SolidBrush(Color.LightYellow);
            g.FillRectangle(b, 0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            g.FillEllipse(b1, 300, 390, 800, 500);
            g.FillEllipse(b1, 0, 400, 500, 240);
            g.FillRectangle(b1, 0, 450, 100, 500);
            int side = 350;
            int x1 = 75, y1 = 180;
            int x2 = x1 + side, y2 = y1;
            int x3 = (x1 + x2) / 2;
            int h = (x2 - x1) / 2;
            int y3 = y1 - h;
            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);
            Point C = new Point(x3, y3);
            Point[] points = { A, B, C };
            g.FillRectangle(b3, 150, 150, 200, 300);
            g.FillPolygon(b2, points);
            g.FillRectangle(b1, 170, 240, 50, 50);
            g.DrawRectangle(pen, 170, 240, 50, 50);
            g.FillRectangle(b1, 280, 240, 50, 50);
            g.DrawRectangle(pen, 280, 240, 50, 50);
            g.FillRectangle(b2, 220, 350, 60, 100);
            g.DrawLine(pen, 170, 265, 220, 265);
            g.DrawLine(pen, 280, 265, 330, 265);
            g.DrawLine(pen, 305, 240, 305, 290);
            g.DrawLine(pen, 195, 240, 195, 290);
            g.FillRectangle(b4, 170, 20, 30, 80);
            g.FillEllipse(b1, 480, 330, 100, 90);
            g.FillEllipse(b1, 490, 260, 80, 70);
            g.FillEllipse(b1, 500, 210, 60, 50);
            g.DrawArc(pen1, 520, 230, 20, 20, 0, 180);
            g.FillEllipse(b, 525, 300, 10, 10);
            g.FillEllipse(b, 525, 340, 10, 10);
            g.FillEllipse(b, 520, 220, 10, 10);
            g.FillEllipse(b, 530, 220, 10, 10);
            g.FillEllipse(b, 525, 360, 10, 10);
            g.FillRectangle(b5, 675, 360, 30, 50);
            DrawTrinagle(b6, 600, 380, 180, g);
            DrawTrinagle(b6, 615, 330, 150, g);
            DrawTrinagle(b6, 625, 280, 130, g);
            DrawTrinagle(b6, 640, 230, 100, g);
            DrawTrinagle(b6, 655, 180, 70, g);
            g.FillEllipse(b1, 650, 5, 100, 100);
            g.FillEllipse(b, 670, 5, 80, 80);
            Point location = new Point(665, 100);
            Size size = new Size(50, 50);
            Rectangle rectangle = new Rectangle(location, size);
            PointF[] points2 = StarPoints(5, rectangle);
            g.FillPolygon(b3, points2);
            g.FillEllipse(b3, 681, 116, 18, 18);
            Font font = new Font("Blackadder ITC", 30, FontStyle.Italic | FontStyle.Bold);
            string line = "    Merry" + Environment.NewLine + "Christmas!";
            g.DrawString(line, font, b6, new Point(150, 450));
        
            g.FillRectangle(b4, 505, 178, 50, 40);
            g.DrawLine(pen2, 490, 200, 505, 200);
            g.DrawLine(pen2, 490, 210, 505, 210);
            g.DrawLine(pen2, 490, 200, 490, 210);
            g.DrawLine(pen2, 550, 200, 570, 200);
            g.DrawLine(pen2, 550, 210, 570, 210);
            g.DrawLine(pen2, 570, 200, 570, 210);
            g.DrawLine(pen3, 460, 330, 500, 280);
            g.DrawLine(pen3, 590, 330, 560, 280);
            g.FillEllipse(b7, 480, 440, 100, 80);
            g.FillEllipse(b7, 480, 440, 50, 80);
            g.FillEllipse(b7, 470, 460, 70, 70);
            g.FillEllipse(b7, 470, 470, 70, 70);
            g.FillEllipse(b7, 500, 470, 70, 70);
            g.FillEllipse(b7, 500, 460, 70, 70);
            g.FillEllipse(b7, 520, 460, 70, 70);
            g.FillEllipse(b7, 520, 490, 50, 50);
            DrawTrinagle1(b7, 500, 420, 40, g);
            g.DrawLine(pen1, 510, 440, 530, 440);
            //Дядо мраз
            g.FillEllipse(b7, 660, 410, 70, 100);
            g.FillRectangle(b7, 680, 500, 15, 30);
            g.FillRectangle(b7, 700, 500, 15, 30);
            g.FillRectangle(b, 700, 535, 15, 15);
            g.FillRectangle(b, 680, 535, 15, 15);
            g.FillEllipse(b, 670, 535, 15, 15);
            g.FillEllipse(b, 710, 535, 15, 15);
            g.FillEllipse(b, 690, 485, 15, 15);
            g.FillRectangle(b, 660, 465, 70, 10);
            g.FillEllipse(b1, 690, 465, 13, 13);
            g.FillRectangle(b8, 680, 355, 38, 38);
            g.FillEllipse(b1, 705, 380, 25, 25);
            g.FillEllipse(b1, 705, 375, 25, 25);
            g.FillEllipse(b1, 700, 395, 25, 25);
            g.FillEllipse(b1, 690, 398, 25, 25);
            g.FillEllipse(b1, 685, 400, 25, 25);
            g.FillEllipse(b1, 670, 400, 25, 25);
            g.FillEllipse(b1, 660, 390, 25, 25);
            g.FillEllipse(b1, 660, 380, 25, 25);
            g.FillEllipse(b1, 655, 370, 25, 25);
            g.FillEllipse(b1, 683, 388, 25, 25);
            g.FillEllipse(b1, 655, 357, 25, 25);
            g.FillEllipse(b1, 705, 357, 25, 25);
            DrawTrinagle(b7, 665, 360, 65, g); 
            g.FillEllipse(b1, 683, 295, 25, 25);
            g.FillEllipse(b, 683, 365, 10, 10);
            g.FillEllipse(b, 700, 365, 10, 10);
            g.FillRectangle(b, 695, 385, 5, 8);
            g.DrawArc(pen1, 688, 390, 20, 20, 0, 180);
            g.DrawLine(pen4, 640, 480, 665, 440);
            g.DrawLine(pen4, 745, 480, 725, 440);
            g.FillEllipse(b, 628, 480, 15, 15);
            g.FillEllipse(b, 740, 480, 15, 15);
            g.FillEllipse(b, 690, 440, 15, 15);
            
            //Дядо мраз

            Random r = new Random();
            int a = 0;
            int c = 0;          
            for (int i = 0; i < 2000; i++) 
            {
                a=r.Next(0, 800);
                c=r.Next(0, 800);
                g.FillEllipse(b1, a, c,3,3);

            }

        }
        public void DrawTrinagle(Brush brush, int X1, int Y1, int s, Graphics g)
        {
            int side = s;
            int x1 = X1;
            int y1 = Y1;
            int x2 = x1 + side;
            int y2 = y1;
            int  x3 = (x1 + x2) / 2;
            int h = (int)((side * Math.Sqrt(3)) / 2);
            int y3 = y1 - h;
            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);
            Point C = new Point(x3, y3);
            Point[] points2 = { A, B, C };
            g.FillPolygon(brush, points2);

        }
        public void DrawTrinagle1(Brush brush, int X1, int Y1, int s, Graphics g)
        {
            int side = s;
            int x1 = X1;
            int y1 = Y1;
            int x2 = x1 + side;
            int y2 = y1;
            int x3 = (x1 + x2) / 2;
            int h = (int)((side * Math.Sqrt(3)) / 2);
            int y3 = y1 + h;
            Point A = new Point(x1, y1);
            Point B = new Point(x2, y2);
            Point C = new Point(x3, y3);
            Point[] points2 = { A, B, C };
            g.FillPolygon(brush, points2);

        }
        private PointF[] StarPoints(int numPoints, Rectangle bounds)
        {
           
            PointF[] pts = new PointF[numPoints];
            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / numPoints;
            for (int i = 0; i < numPoints; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
    }
}
