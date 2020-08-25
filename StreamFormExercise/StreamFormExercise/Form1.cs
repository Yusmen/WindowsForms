using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamFormExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOf2 = 0;
            int numberOf3 = 0;
            int numberOf4 = 0;
            int numberOf5 = 0;
            int numberOf6 = 0;
            string line = string.Empty;
            using (var reader = new StreamReader("student.txt"))//прочитане на файла 
            {
                while (true)
                {
                    line = reader.ReadLine();//прочитане на един ред
                    if (line == null)//проверка ако този ред е празен
                    {
                        break;
                    }
                    //преброяване на оценките
                    if (line == "2") 
                    {
                        numberOf2++;
                    }
                    if (line == "3") 
                    { 
                        numberOf3++;
                    }
                    if (line == "4") 
                    {
                        numberOf4++; 
                    }
                    if (line == "5") 
                    {
                        numberOf5++;
                    }
                    if (line == "6") 
                    {
                        numberOf6++; 
                    }


                }
            }

            double average = (numberOf2 * 2 + numberOf3 * 3 + numberOf4 * 4 + numberOf5 * 5 + numberOf6 * 6) 
           / (numberOf2 + numberOf3 + numberOf4 + numberOf5  + numberOf6);//изчисляване на средния успех
          
            lbl2.Text = numberOf2.ToString();
            lbl4.Text = numberOf3.ToString();
            lbl6.Text = numberOf4.ToString();
            lbl8.Text = numberOf5.ToString();
            lbl10.Text = numberOf6.ToString();
            lbl12.Text = $"{average:f2}";
        }
    }
}
