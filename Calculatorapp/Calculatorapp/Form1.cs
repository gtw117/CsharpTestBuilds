﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorapp
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else

            result.Text = result.Text + b.Text;
        }


        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }


        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                button12.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + "" + operation;

            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }



        private void button12_Click(object sender, EventArgs e)
        {
            equation.Text = " ";

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch

            value = Int32.Parse(result.Text);
            operation = "";

        }


        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
