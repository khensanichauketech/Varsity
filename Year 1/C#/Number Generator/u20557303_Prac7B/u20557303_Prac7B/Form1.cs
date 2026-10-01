using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prac7B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rtbTextPt.Text = rtbOutput.Font.Size.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            rtbOutput.Clear();
            string oddNums = "";

            // START HERE
           
            int rows = Convert.ToInt32(nudRows.Value);
            int cols = Convert.ToInt32(nudCols.Value);
            int value;
            string answer = string.Empty;


            // END HERE

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= cols; j++)
                {

                    // START HERE
                    value = i * j;
                    answer = Convert.ToString(value);
                    rtbOutput.SelectionBackColor = Color.White;

                    if (chkHighlightOdd.Checked && value % 2 != 0)
                    {

                        rtbOutput.SelectionBackColor = Color.Yellow;
                        oddNums += Convert.ToString(value) + ", ";
                    }

                    rtbOutput.AppendText(answer + "\t");

                    // END HERE
                }

                rtbOutput.AppendText("\n");
            }

            rtbOutput.AppendText("\nODD NUMS:\n" + oddNums);
        }
    }
}
