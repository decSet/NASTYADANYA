﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASTYADANYA
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

        private void button_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            string calculatorName = ((Button)sender).Name;
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(calculatorName);
            double result = calculator.Calculate(firstValue, secondValue);
            label1.Text = Convert.ToString(result);
        }
    }
}
