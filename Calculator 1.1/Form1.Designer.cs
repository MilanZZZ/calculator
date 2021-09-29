namespace Calculator_1._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.pos_neg = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.perc = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 1, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 34);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(360, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 21);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(396, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 76);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(114, 608);
            this.button0.Margin = new System.Windows.Forms.Padding(1);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(105, 64);
            this.button0.TabIndex = 3;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button3_Click);
            // 
            // pos_neg
            // 
            this.pos_neg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pos_neg.FlatAppearance.BorderSize = 0;
            this.pos_neg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos_neg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_neg.Location = new System.Drawing.Point(8, 608);
            this.pos_neg.Margin = new System.Windows.Forms.Padding(1);
            this.pos_neg.Name = "pos_neg";
            this.pos_neg.Size = new System.Drawing.Size(105, 64);
            this.pos_neg.TabIndex = 4;
            this.pos_neg.Text = "+/-";
            this.pos_neg.UseVisualStyleBackColor = false;
            // 
            // button_point
            // 
            this.button_point.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_point.FlatAppearance.BorderSize = 0;
            this.button_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_point.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_point.Location = new System.Drawing.Point(221, 608);
            this.button_point.Margin = new System.Windows.Forms.Padding(1);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(105, 64);
            this.button_point.TabIndex = 5;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = false;
            this.button_point.Click += new System.EventHandler(this.button3_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.SkyBlue;
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(328, 608);
            this.equals.Margin = new System.Windows.Forms.Padding(1);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(105, 64);
            this.equals.TabIndex = 6;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Addition.FlatAppearance.BorderSize = 0;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addition.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(328, 542);
            this.Addition.Margin = new System.Windows.Forms.Padding(1);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(105, 64);
            this.Addition.TabIndex = 10;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(221, 542);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 64);
            this.button8.TabIndex = 9;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(8, 542);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 64);
            this.button9.TabIndex = 8;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button3_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(114, 542);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 64);
            this.button10.TabIndex = 7;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button3_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Subtraction.FlatAppearance.BorderSize = 0;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtraction.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction.Location = new System.Drawing.Point(328, 476);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(1);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(105, 64);
            this.Subtraction.TabIndex = 14;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(221, 476);
            this.button12.Margin = new System.Windows.Forms.Padding(1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 64);
            this.button12.TabIndex = 13;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button3_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(8, 476);
            this.button13.Margin = new System.Windows.Forms.Padding(1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(105, 64);
            this.button13.TabIndex = 12;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button3_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(114, 476);
            this.button14.Margin = new System.Windows.Forms.Padding(1);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(105, 64);
            this.button14.TabIndex = 11;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button3_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multiplication.FlatAppearance.BorderSize = 0;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(328, 410);
            this.multiplication.Margin = new System.Windows.Forms.Padding(1);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(105, 64);
            this.multiplication.TabIndex = 18;
            this.multiplication.Text = "×";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(221, 410);
            this.button16.Margin = new System.Windows.Forms.Padding(1);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(105, 64);
            this.button16.TabIndex = 17;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button3_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(8, 410);
            this.button17.Margin = new System.Windows.Forms.Padding(1);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(105, 64);
            this.button17.TabIndex = 16;
            this.button17.Text = "7";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button3_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(114, 410);
            this.button18.Margin = new System.Windows.Forms.Padding(1);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(105, 64);
            this.button18.TabIndex = 15;
            this.button18.Text = "8";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button3_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.WhiteSmoke;
            this.division.FlatAppearance.BorderSize = 0;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(328, 344);
            this.division.Margin = new System.Windows.Forms.Padding(1);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(105, 64);
            this.division.TabIndex = 22;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.button19_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.WhiteSmoke;
            this.root.FlatAppearance.BorderSize = 0;
            this.root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.root.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root.Location = new System.Drawing.Point(221, 344);
            this.root.Margin = new System.Windows.Forms.Padding(1);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(105, 64);
            this.root.TabIndex = 21;
            this.root.Text = "√x";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.button20_Click);
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inv.FlatAppearance.BorderSize = 0;
            this.inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv.Location = new System.Drawing.Point(8, 344);
            this.inv.Margin = new System.Windows.Forms.Padding(1);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(105, 64);
            this.inv.TabIndex = 20;
            this.inv.Text = "1/x";
            this.inv.UseVisualStyleBackColor = false;
            this.inv.Click += new System.EventHandler(this.button21_Click);
            // 
            // sqr
            // 
            this.sqr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sqr.FlatAppearance.BorderSize = 0;
            this.sqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqr.Location = new System.Drawing.Point(114, 344);
            this.sqr.Margin = new System.Windows.Forms.Padding(1);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(105, 64);
            this.sqr.TabIndex = 19;
            this.sqr.Text = "x²";
            this.sqr.UseVisualStyleBackColor = false;
            this.sqr.Click += new System.EventHandler(this.button22_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(328, 278);
            this.backspace.Margin = new System.Windows.Forms.Padding(1);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(105, 64);
            this.backspace.TabIndex = 26;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.button23_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c.FlatAppearance.BorderSize = 0;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(221, 278);
            this.c.Margin = new System.Windows.Forms.Padding(1);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(105, 64);
            this.c.TabIndex = 25;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.button24_Click);
            // 
            // perc
            // 
            this.perc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.perc.FlatAppearance.BorderSize = 0;
            this.perc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perc.Location = new System.Drawing.Point(8, 278);
            this.perc.Margin = new System.Windows.Forms.Padding(1);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(105, 64);
            this.perc.TabIndex = 24;
            this.perc.Text = "%";
            this.perc.UseVisualStyleBackColor = false;
            this.perc.Click += new System.EventHandler(this.button25_Click);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ce.FlatAppearance.BorderSize = 0;
            this.ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ce.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.Location = new System.Drawing.Point(114, 278);
            this.ce.Margin = new System.Windows.Forms.Padding(1);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(105, 64);
            this.ce.TabIndex = 23;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.button26_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 17);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 672);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.c);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.division);
            this.Controls.Add(this.root);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.button_point);
            this.Controls.Add(this.pos_neg);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button pos_neg;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button inv;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button perc;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.TextBox textBox2;
    }
}

