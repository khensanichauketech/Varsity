using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20557303_Prac2c
{
    public partial class frmInformationDisplay : Form
    {
        public frmInformationDisplay()
        {
            InitializeComponent();
        }

        private void frmInformationDisplay_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            this.btnShowSummary.BackColor = Color.LightPink;
            this.btnShowFullDetails.BackColor = Color.LightCyan;
            this.rtbDisplay.BackColor = Color.LightCyan;
            cbxTitle.Items.Add("Dr");
            cbxTitle.Items.Add("Prof");
            cbxTitle.Items.Add("Mr");
            cbxTitle.Items.Add("Mrs");
            cbxTitle.Items.Add("Miss");

        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            if (this.btnShowSummary.Enabled)
            {
                rtbDisplay.Clear();
                MessageBox.Show("Summary Details: \n" + cbxTitle.Text + " " + txtName.Text);
                
            }
        }

        private void cbxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowFullDetails_Click(object sender, EventArgs e)
        {
            if (this.btnShowSummary.Enabled) 
            { 
                rtbDisplay.Text = "Full User Details:\n" +
                    "Title: " + cbxTitle.Text + "\n" +
                    "Name: " + txtName.Text + "\n" +
                    "Surname: " + txtSurname.Text + "\n" +
                    "Initials: " + txtInitials.Text + "\n" +
                    "Age: " + Convert.ToString(nudAge.Value);
            }
        }
    }
}
