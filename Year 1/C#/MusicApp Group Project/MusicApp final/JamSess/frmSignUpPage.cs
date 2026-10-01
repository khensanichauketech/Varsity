using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace JamSess
{
    public partial class frmSignUpPage : Form
    {
        //Public string File Name

        private static readonly string saveFolderPath = Path.Combine(
            Application.StartupPath,
            "UserData"
        );

        private readonly string usersFilePath = Path.Combine(saveFolderPath, "Users.dat");

        // Public lists to store user details
        List<User> users = new List<User>();

        public frmSignUpPage()
        {
            InitializeComponent();

            lblUserStrength.Visible = false;
            lblPassStrength.Visible = false;


            if (!Directory.Exists(saveFolderPath))
            {
                Directory.CreateDirectory(saveFolderPath);
            }

        }

        BinaryFormatter formatter = new BinaryFormatter();

        private void btnCreate_Click(object sender, EventArgs e)
        {

            // Reset warning labels 
            lblUserStrength.Visible = false;
            lblPassStrength.Visible = false;

            // Deserialize existing users from the binary file if it exists
            users.Clear();
            if (File.Exists(usersFilePath))
            {
                try
                {
                    using (FileStream readStream = new FileStream(usersFilePath, FileMode.Open, FileAccess.Read))
                    {
                        users = (List<User>)formatter.Deserialize(readStream);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading user data: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string name = txtNameSignUp.Text.Trim();
            string surname = txtSurnameSignUp.Text.Trim();
            string username = txtUsernameSignUp.Text.Trim();
            string password = txtPasswordSignUp.Text;


            // Handling User inputs that might cause errors or validation failures
            if (name == "" || surname == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool userExists = false;
            foreach (User u in users)
            {
                if (u.Username == username)
                {
                    userExists = true;
                    break;
                }
            }

            if (userExists)
            {
                lblUserStrength.Visible = true;
                return;
            }

            // Check password complexity
            if (User.CheckPass(password) == false)
            {
                lblPassStrength.Visible = true;
                return;
            }

            // Add the new user to the list
            User newUser = new User(name, surname, username, password);
            users.Add(newUser);

            // Writing the new user to the text file safely
            try
            {
                using (FileStream writeStream = new FileStream(usersFilePath, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(writeStream, users);
                }


                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLoginPage myLogin = new frmLoginPage();
                myLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user data: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNameSignUp_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
