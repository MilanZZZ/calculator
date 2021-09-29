using button_press_input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Calculator_1._1
{
    public partial class Form1 : Form
    {
        
        string frst = null;
        string scnd = null;
        string op = null;
        
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op = "-";
            if (frst == null)
            {
                frst = textBox1.Text;
                
                textBox1.Clear();
                textBox2.Text = frst + "-";
            }
            else
            {

                scnd = textBox1.Text;
                textBox1.Clear();
                var clc = new calc();
                //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                textBox2.Text = frst + " - " + scnd + " = " + clc.Sub(double.Parse(frst), double.Parse(scnd));
                frst = clc.Sub(double.Parse(frst), double.Parse(scnd));


            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = "*";
            if (frst == null)
            {
                frst = textBox1.Text;
                
                textBox1.Clear();
                textBox2.Text = frst + "*";
            }
            else
            {

                scnd = textBox1.Text;
                textBox1.Clear();
                var clc = new calc();
                //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                textBox2.Text = frst + " * " + scnd + " = " + clc.Mult(double.Parse(frst), double.Parse(scnd));
                frst = clc.Mult(double.Parse(frst), double.Parse(scnd));


            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            if (frst == null)
            {
                op = "/";
                frst = textBox1.Text;
                
                textBox1.Clear();
                textBox2.Text = frst + " /";
            }
            else
            {

                scnd = textBox1.Text;
                textBox1.Clear();
                var clc = new calc();
                //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                textBox2.Text = frst + " / " + scnd + " = " + clc.Div(double.Parse(frst), double.Parse(scnd));
                frst = clc.Div(double.Parse(frst), double.Parse(scnd));


            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (frst == null)
            {
                frst = textBox1.Text;
                var clc = new calc();
                textBox2.Text = "%" + frst + " = " + clc.Perc(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
            else
            {
                var clc = new calc();
                textBox2.Text = "%" + frst + " = " + clc.Perc(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            frst = null;
            scnd = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (frst == null)
            {
                frst = textBox1.Text;
                var clc = new calc();
                textBox2.Text = "√" + frst + " = " + clc.Root(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
            else
            {
                var clc = new calc();
                textBox2.Text = "√" + frst + " = " + clc.Root(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (frst == null)
            {
                frst = textBox1.Text;
                var clc = new calc();
                textBox2.Text = frst + "²" + " = " + clc.Sqr(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
            else
            {
                var clc = new calc();
                textBox2.Text = frst + "²" + " = " + clc.Sqr(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = frst;
             scnd = null;
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (frst == null)
            {
                frst = textBox1.Text;
                var clc = new calc();
                textBox2.Text = "1/" + frst + " = " + clc.Inv(double.Parse(frst));
                frst = clc.Inv(double.Parse(frst));
                textBox1.Clear();
            }
            else
            {
                var clc = new calc();
                textBox2.Text = "1/" + frst + " = " + clc.Inv(double.Parse(frst));
                frst = clc.Sqr(double.Parse(frst));
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            op = "+";
            if (frst == null)
            {
                frst = textBox1.Text;
               
                
                textBox1.Clear();
                textBox2.Text = frst + "+";
            }
            else
            { 
               
            scnd = textBox1.Text;
                textBox1.Clear();
                var clc = new calc();
                //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                textBox2.Text =frst +  " + " + scnd + "=" + clc.Add(double.Parse(frst), double.Parse(scnd));
                frst = clc.Add(double.Parse(frst), double.Parse(scnd));


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (frst == null)
            {
                frst = textBox1.Text;

                textBox1.Clear();
                textBox2.Text = frst;
            }
            else
            {
                var clc = new calc();
                switch (op)
                {
                    case "+":
                        scnd = textBox1.Text;
                        textBox1.Clear();
                        
                        //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                        textBox2.Text = frst + " + " + scnd + "=" + clc.Add(double.Parse(frst), double.Parse(scnd));
                        frst = clc.Add(double.Parse(frst), double.Parse(scnd));
                        break;
                    case "-":
                        scnd = textBox1.Text;
                        textBox1.Clear();
                       
                        //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                        textBox2.Text = frst + " - " + scnd + " = " + clc.Sub(double.Parse(frst), double.Parse(scnd));
                        frst = clc.Sub(double.Parse(frst), double.Parse(scnd));
                        break;

                    case "*":
                        scnd = textBox1.Text;
                        textBox1.Clear();
                        
                        //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                        textBox2.Text = frst + " * " + scnd + " = " + clc.Mult(double.Parse(frst), double.Parse(scnd));
                        frst = clc.Mult(double.Parse(frst), double.Parse(scnd));
                        break;

                    case "/":
                        scnd = textBox1.Text;
                        textBox1.Clear();
                        //textBox1.Text = clc.Add(double.Parse(frst), double.Parse(scnd));
                        textBox2.Text = frst + " / " + scnd + " = " + clc.Div(double.Parse(frst), double.Parse(scnd));
                        frst = clc.Div(double.Parse(frst), double.Parse(scnd));
                        break;
                }
                }
        }
    }
}
