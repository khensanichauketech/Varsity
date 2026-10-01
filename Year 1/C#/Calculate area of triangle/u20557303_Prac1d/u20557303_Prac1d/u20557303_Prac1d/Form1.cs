using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20557303_Prac1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nudArea.Enabled = false;
        }

        private void nudBase_ValueChanged(object sender, EventArgs e)
        {
            this.nudBase.Minimum = 0;
            this.nudBase.Maximum = 10;
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            this.nudHeight.Minimum = 0;
            this.nudHeight.Maximum = 10;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Base = this.nudBase.Value;
            decimal Height = this.nudHeight.Value;
            decimal Answer = (Base * Height) / 2;
            this.nudArea.Value = Answer;
        }

        private void nudArea_ValueChanged(object sender, EventArgs e)
        {
            this.nudArea.DecimalPlaces = 1;
        }
    }
}
