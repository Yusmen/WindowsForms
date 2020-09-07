namespace RichTextBoxExercise
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btnArr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Button();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblArr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(25, 25);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(192, 363);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // btnArr
            // 
            this.btnArr.Location = new System.Drawing.Point(308, 154);
            this.btnArr.Name = "btnArr";
            this.btnArr.Size = new System.Drawing.Size(118, 23);
            this.btnArr.TabIndex = 1;
            this.btnArr.Text = "Масив";
            this.btnArr.UseVisualStyleBackColor = true;
            this.btnArr.Click += new System.EventHandler(this.btnArr_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(308, 48);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(121, 20);
            this.txtP.TabIndex = 3;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(308, 101);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(121, 20);
            this.txtQ.TabIndex = 4;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(282, 55);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(20, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "P=";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(281, 104);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(21, 13);
            this.lblQ.TabIndex = 6;
            this.lblQ.Text = "Q=";
            this.lblQ.Click += new System.EventHandler(this.lblQ_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(540, 242);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "0";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(238, 232);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(221, 23);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "брой на числата в интервала [p,q]";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(238, 287);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(212, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "брой на четните числа";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(540, 297);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(13, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "0";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(238, 345);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(212, 23);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "сума на числата в масива";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(540, 355);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(13, 13);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "0";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(238, 395);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(212, 23);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "брой на отрицаелните числа";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(540, 395);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(13, 13);
            this.lbl4.TabIndex = 14;
            this.lbl4.Text = "0";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(238, 441);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(221, 23);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "брой на числата извън интервала [p,q]";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(540, 446);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(13, 13);
            this.lbl5.TabIndex = 16;
            this.lbl5.Text = "0";
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(238, 488);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(221, 23);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "Брой на числата равни на P";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(540, 488);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(13, 13);
            this.lbl6.TabIndex = 18;
            this.lbl6.Text = "0";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(64, 529);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(395, 23);
            this.btn7.TabIndex = 19;
            this.btn7.Text = "Най-малкият индекс на елемент от масива, чиято стойност е равна на Q";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(540, 529);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(13, 13);
            this.lbl7.TabIndex = 20;
            this.lbl7.Text = "0";
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(64, 579);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(380, 23);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "Най-малкият и най-големият елемент ";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(540, 584);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(13, 13);
            this.lbl8.TabIndex = 22;
            this.lbl8.Text = "0";
            // 
            // lblArr
            // 
            this.lblArr.AutoSize = true;
            this.lblArr.Location = new System.Drawing.Point(340, 198);
            this.lblArr.Name = "lblArr";
            this.lblArr.Size = new System.Drawing.Size(0, 13);
            this.lblArr.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 630);
            this.Controls.Add(this.lblArr);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnArr);
            this.Controls.Add(this.rtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btnArr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblArr;
    }
}

