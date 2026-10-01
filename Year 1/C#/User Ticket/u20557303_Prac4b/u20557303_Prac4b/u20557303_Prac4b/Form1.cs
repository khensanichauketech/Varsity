using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20557303_Prac4b
{
    public partial class frmUserTicket : Form
    {
        public frmUserTicket()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Declaring variables and constants
            int age;
            string name = txtName.Text;
            const decimal PRICE = 200.00m;
            const decimal DISCOUNT = 20.00m;


            if (txtName.Text == "" || txtAge.Text == "") //Checking if the inputs are empty before proceeding with code.
            {
                MessageBox.Show("Please enter both your Name and Age", "Input Error");
                return; // The return; statement stops a method and sends control back to the place where the method was called.

            } else if (!txtName.Text.All(char.IsLetter)) //Checking if the input in name is all letters.
            {
                MessageBox.Show("Please enter Name only", "Name Error");
                return;

            } else if (!int.TryParse(txtAge.Text, out age)) //Checking if the input in Age is all integers and if so, the value is assigned to age.
            {
                MessageBox.Show("Please enter digits only.", "Age Error");
                return;

            } else if (age < 16) //Checking if the user is under 16 years of age.
            {
                MessageBox.Show("You must be at least 16 years old to purchase a ticket.\nSorry.", "You are too young");
                return;
            }
           

            if (age >= 16 && radYes.Checked) // If the user is 16 years old and above and has checked Yes, this code will proceed.
            {
                rtbDisplay.Text =
                    "Ticket Details:\n" +
                    "Name: " + name + "\n" +
                    "Age: " + age + "\n" +
                    "Student Status: UP Student" + "\n" +
                    "\n" +
                    "\n" +
                    "Subtotal Price: R" + PRICE + "\n" +
                    "Discount: R" + DISCOUNT + "\n" +
                    "Final Price: R" + (PRICE - DISCOUNT);
                return;

            } else if (age >= 16 && radNo.Checked) // If the user is 16 years old and above and has checked No, this code will proceed.
            {
                rtbDisplay.Text =
                    "Ticket Details:\n" +
                    "Name: " + name + "\n" +
                    "Age: " + age + "\n" +
                    "Student Status: Non-UP Student" + "\n" +
                    "\n" +
                    "\n" +
                    "Subtotal Price: R" + PRICE + "\n" +
                    "Discount: R" + (DISCOUNT - DISCOUNT) + "\n" +
                    "Final Price: R" + PRICE;
                return;

            }
        }
    }
}
