using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20557303_Prac3c
{
    public partial class frmGymFeeCalculator : Form
    {
        public frmGymFeeCalculator()
        {
            InitializeComponent();
        }

        // Declaring a global constant
        const decimal VAT = 0.15m;

        private void frmGymFeeCalculator_Load(object sender, EventArgs e)
        {
            // Load immediatly with the form
            rtbOutput.Enabled = false;
            nudMonthlyBaseFee.DecimalPlaces = 2;
            nudTrainingSessionRate.DecimalPlaces = 2;
            nudMonthlyBaseFee.Maximum = 1000;
            nudTrainingSessionRate.Maximum = 1000;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declaring local variables
            decimal total;
            decimal totalVat;
            decimal baseFee = nudMonthlyBaseFee.Value;
            decimal sessionRate = nudTrainingSessionRate.Value;
            decimal numberSessions = nudNumberOfSessions.Value;

           // Fee excluding VAT
            total = baseFee + (sessionRate * numberSessions);

            // The VAT
            totalVat = total * VAT;

            //Fee including VAT
            decimal totalIncluding = totalVat + total;

            // The output
            rtbOutput.Text =
                "Total ex. VAT: R" + Math.Round(total, 2) + "\n" +
                "VAT: R" + Math.Round(totalVat, 2) + "\n" +
                "Total inc VAT: R" + Math.Round(totalIncluding, 2);

        }
    }
}
