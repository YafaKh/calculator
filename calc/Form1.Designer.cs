
namespace calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ms = new System.Windows.Forms.Button();
            this.powery = new System.Windows.Forms.Button();
            this.power2 = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.mm = new System.Windows.Forms.Button();
            this.mr = new System.Windows.Forms.Button();
            this.mc = new System.Windows.Forms.Button();
            this.mp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "standard",
            "scintific"});
            this.comboBox1.Location = new System.Drawing.Point(297, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 23);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.ce);
            this.panel1.Controls.Add(this.cl);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.mult);
            this.panel1.Controls.Add(this.div);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.eq);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 229);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(223, 112);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 44);
            this.back.TabIndex = 21;
            this.back.Text = "<--";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ce
            // 
            this.ce.Location = new System.Drawing.Point(223, 62);
            this.ce.Name = "ce";
            this.ce.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ce.Size = new System.Drawing.Size(46, 44);
            this.ce.TabIndex = 20;
            this.ce.Text = "ce";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(223, 14);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(46, 44);
            this.cl.TabIndex = 19;
            this.cl.Text = "c";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(223, 164);
            this.button19.Name = "button19";
            this.button19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button19.Size = new System.Drawing.Size(46, 44);
            this.button19.TabIndex = 18;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(171, 112);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 44);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.op_click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(171, 62);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(46, 44);
            this.mult.TabIndex = 16;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.op_click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(171, 14);
            this.div.Name = "div";
            this.div.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.div.Size = new System.Drawing.Size(46, 44);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.op_click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(171, 164);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 44);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.op_click);
            // 
            // eq
            // 
            this.eq.Location = new System.Drawing.Point(67, 164);
            this.eq.Name = "eq";
            this.eq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eq.Size = new System.Drawing.Size(98, 44);
            this.eq.TabIndex = 13;
            this.eq.Text = "=";
            this.eq.UseVisualStyleBackColor = true;
            this.eq.Click += new System.EventHandler(this.eq_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(15, 164);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(46, 44);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.bt_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 14);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 44);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.bt_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(67, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 44);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.bt_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bt_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(119, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 44);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bt_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 44);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.bt_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bt_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bt_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ms);
            this.groupBox1.Controls.Add(this.powery);
            this.groupBox1.Controls.Add(this.power2);
            this.groupBox1.Controls.Add(this.sqr);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.mm);
            this.groupBox1.Controls.Add(this.mr);
            this.groupBox1.Controls.Add(this.mc);
            this.groupBox1.Controls.Add(this.mp);
            this.groupBox1.Location = new System.Drawing.Point(297, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(19, 22);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(98, 44);
            this.ms.TabIndex = 30;
            this.ms.Text = "ms";
            this.ms.UseVisualStyleBackColor = true;
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // powery
            // 
            this.powery.Location = new System.Drawing.Point(71, 174);
            this.powery.Name = "powery";
            this.powery.Size = new System.Drawing.Size(46, 44);
            this.powery.TabIndex = 29;
            this.powery.Text = "^";
            this.powery.UseVisualStyleBackColor = true;
            this.powery.Click += new System.EventHandler(this.op_click);
            // 
            // power2
            // 
            this.power2.Location = new System.Drawing.Point(71, 124);
            this.power2.Name = "power2";
            this.power2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.power2.Size = new System.Drawing.Size(46, 44);
            this.power2.TabIndex = 28;
            this.power2.Text = "x^2";
            this.power2.UseVisualStyleBackColor = true;
            this.power2.Click += new System.EventHandler(this.power2_Click);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(71, 76);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(46, 44);
            this.sqr.TabIndex = 27;
            this.sqr.Text = "sqr";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.sqr_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(71, 226);
            this.button23.Name = "button23";
            this.button23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button23.Size = new System.Drawing.Size(46, 44);
            this.button23.TabIndex = 26;
            this.button23.Text = "!";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(19, 174);
            this.mm.Name = "mm";
            this.mm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mm.Size = new System.Drawing.Size(46, 44);
            this.mm.TabIndex = 25;
            this.mm.Text = "-m ";
            this.mm.UseVisualStyleBackColor = true;
            this.mm.Click += new System.EventHandler(this.mm_Click);
            // 
            // mr
            // 
            this.mr.Location = new System.Drawing.Point(19, 124);
            this.mr.Name = "mr";
            this.mr.Size = new System.Drawing.Size(46, 44);
            this.mr.TabIndex = 24;
            this.mr.Text = "mr";
            this.mr.UseVisualStyleBackColor = true;
            this.mr.Click += new System.EventHandler(this.mr_Click);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(19, 76);
            this.mc.Name = "mc";
            this.mc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mc.Size = new System.Drawing.Size(46, 44);
            this.mc.TabIndex = 23;
            this.mc.Text = "mc";
            this.mc.UseVisualStyleBackColor = true;
            this.mc.Click += new System.EventHandler(this.mc_Click);
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(19, 226);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(46, 44);
            this.mp.TabIndex = 22;
            this.mp.Text = "m+";
            this.mp.UseVisualStyleBackColor = true;
            this.mp.Click += new System.EventHandler(this.mp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button eq;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button powery;
        private System.Windows.Forms.Button power2;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button mm;
        private System.Windows.Forms.Button mr;
        private System.Windows.Forms.Button mc;
        private System.Windows.Forms.Button mp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ms;
    }
}

