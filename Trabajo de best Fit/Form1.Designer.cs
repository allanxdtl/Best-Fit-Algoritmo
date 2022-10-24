namespace Trabajo_de_best_Fit
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEspacio5 = new System.Windows.Forms.Label();
            this.lblEspacio4 = new System.Windows.Forms.Label();
            this.lblEspacio3 = new System.Windows.Forms.Label();
            this.lblEspacio2 = new System.Windows.Forms.Label();
            this.lblEspacio1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(36, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 144);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procesos entrantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memoria";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox2.Location = new System.Drawing.Point(248, 57);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(241, 104);
            this.listBox2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "pausa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "resume";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "10kb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "20kb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "30kb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "35kb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "45kb";
            // 
            // lblEspacio5
            // 
            this.lblEspacio5.AutoSize = true;
            this.lblEspacio5.Location = new System.Drawing.Point(496, 141);
            this.lblEspacio5.Name = "lblEspacio5";
            this.lblEspacio5.Size = new System.Drawing.Size(116, 20);
            this.lblEspacio5.TabIndex = 15;
            this.lblEspacio5.Text = "vale estuvo aqui";
            // 
            // lblEspacio4
            // 
            this.lblEspacio4.AutoSize = true;
            this.lblEspacio4.Location = new System.Drawing.Point(496, 117);
            this.lblEspacio4.Name = "lblEspacio4";
            this.lblEspacio4.Size = new System.Drawing.Size(116, 20);
            this.lblEspacio4.TabIndex = 14;
            this.lblEspacio4.Text = "vale estuvo aqui";
            // 
            // lblEspacio3
            // 
            this.lblEspacio3.AutoSize = true;
            this.lblEspacio3.Location = new System.Drawing.Point(496, 97);
            this.lblEspacio3.Name = "lblEspacio3";
            this.lblEspacio3.Size = new System.Drawing.Size(116, 20);
            this.lblEspacio3.TabIndex = 13;
            this.lblEspacio3.Text = "vale estuvo aqui";
            // 
            // lblEspacio2
            // 
            this.lblEspacio2.AutoSize = true;
            this.lblEspacio2.Location = new System.Drawing.Point(496, 77);
            this.lblEspacio2.Name = "lblEspacio2";
            this.lblEspacio2.Size = new System.Drawing.Size(116, 20);
            this.lblEspacio2.TabIndex = 12;
            this.lblEspacio2.Text = "vale estuvo aqui";
            // 
            // lblEspacio1
            // 
            this.lblEspacio1.AutoSize = true;
            this.lblEspacio1.Location = new System.Drawing.Point(496, 57);
            this.lblEspacio1.Name = "lblEspacio1";
            this.lblEspacio1.Size = new System.Drawing.Size(116, 20);
            this.lblEspacio1.TabIndex = 11;
            this.lblEspacio1.Text = "vale estuvo aqui";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ajustar tiempo en segundos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 27);
            this.textBox1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Ajustar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEspacio5);
            this.Controls.Add(this.lblEspacio4);
            this.Controls.Add(this.lblEspacio3);
            this.Controls.Add(this.lblEspacio2);
            this.Controls.Add(this.lblEspacio1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Algoritmo Best Fit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblEspacio5;
        private Label lblEspacio4;
        private Label lblEspacio3;
        private Label lblEspacio2;
        private Label lblEspacio1;
        private Label label8;
        private TextBox textBox1;
        private Button button3;
    }
}