using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace u20557303_Prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudNumber1.Value = 0;
            nudNumber2.Value = 0;
            lblAnswer.Text = string.Empty;
        }

        private void Add()
        {
            double num1 = (double)nudNumber1.Value;
            double num2 = (double)nudNumber2.Value;

            lblAnswer.Text = (num1 + num2).ToString();
        }

        private void Subtract()
        {
            double num1 = (double)nudNumber1.Value;
            double num2 = (double)nudNumber2.Value;

            lblAnswer.Text = (num1 - num2).ToString();
        }

        private void Multiply()
        {
            double num1 = (double)nudNumber1.Value;
            double num2 = (double)nudNumber2.Value;

            lblAnswer.Text = (num1 * num2).ToString();
        }

        private void Divide()
        {
            double num1 = (double)nudNumber1.Value;
            double num2 = (double)nudNumber2.Value;

            if (num2 == 0)
            {
                MessageBox.Show("Can't divide by 0.", "Error");
                lblAnswer.Text = string.Empty;
                return;
            }

            lblAnswer.Text = (num1 / num2).ToString();
        }
    }
}

