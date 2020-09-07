using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;
        int[] arr = { };
        private void btnArr_Click(object sender, EventArgs e)
        {
            n = rtb.Lines.Count();
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (rtb.Lines[i] != "")
                {
                    arr[i] = int.Parse(rtb.Lines[i]);
                }
                else
                {
                    break;
                }            
        
            }
            lblArr.Text = string.Join(" ", arr);
        }

        private void lblQ_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int q = int.Parse(txtQ.Text);
            int br = 0;

            for (int i = 0; i < n; i++)
            {
                if (p<q)
                {
                    if (arr[i] >= p && arr[i] <= q)
                    {
                        br++;
                    }
                }
                else
                {
                    if (arr[i] >= q && arr[i] <= p)
                    {
                        br++;
                    }
                }
                
            }
            lblResult.Text = br.ToString();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int br = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0) 
                {
                    br++;
                }
                lbl2.Text = br.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            lbl3.Text = sum.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int br = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0) 
                {
                    br++;
                }
            }
            lbl4.Text = br.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int q = int.Parse(txtQ.Text);
            int br = 0;

            for (int i = 0; i < n; i++)
            {
                if (p < q)
                {
                    if (arr[i] < p || arr[i] > q)
                    {
                        br++;
                    }
                }
                else
                {
                    if (arr[i] < q || arr[i] > p)
                    {
                        br++;
                    }
                }

            }
            lbl5.Text = br.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int br = 0;
            int p = int.Parse(txtP.Text);

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == p) 
                {
                    br++;
                }
            }
            lbl6.Text = br.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int index = 0;
            int q = int.Parse(txtQ.Text);
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == q) 
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }


            }
            lbl7.Text = index.ToString();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
         
            for (int i = 0; i < n; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];

                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
            }
            string minResult = min.ToString();
            string maxResult = max.ToString();
            lbl8.Text = minResult + "   " + maxResult;

        }
    }
}
