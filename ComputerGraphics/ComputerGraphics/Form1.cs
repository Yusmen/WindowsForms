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

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int a = 256, freq = 10;
            Random c = new Random();
            for (int i = 1; i <= 1000; i++) 
            {
                g.Clear(Color.FromArgb(c.Next() % a, c.Next() % a, c.Next() % a));
                Thread.Sleep(50);
                


            }
        }
    }
}
