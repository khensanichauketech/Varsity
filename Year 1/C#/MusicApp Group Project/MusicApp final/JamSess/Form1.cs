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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Serialization.Formatters.Binary;

namespace JamSess
{
    public partial class frmLoginPage : Form
    {

        private static readonly string saveFolderPath = Path.Combine(
           Application.StartupPath,
           "UserData"
       );

        private readonly string usersFilePath = Path.Combine(saveFolderPath, "Users.dat");

        List<User> users = new List<User>();

        BinaryFormatter formatter = new BinaryFormatter();

        public frmLoginPage()
        {
            InitializeComponent();
            lblStrength.Visible = false;
            lblTryAgain.Visible = false;

            txtPasswordLogin.UseSystemPasswordChar = true;

            if (!Directory.Exists(saveFolderPath))
            {
                Directory.CreateDirectory(saveFolderPath);
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsernameLogin.Text == "" || txtPasswordLogin.Text == "")
            {
                MessageBox.Show("Enter your username and password.");
                return;
            }



            if (!File.Exists(usersFilePath))
            {
                MessageBox.Show("No users found.");
                lblStrength.Visible = true;
                return;
            }

            users.Clear();

            try
            {
                using (FileStream readStream = new FileStream(usersFilePath, FileMode.Open, FileAccess.Read))
                {
                    users = (List<User>)formatter.Deserialize(readStream);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No account found");
                lblStrength.Text = "Try Again?";
                lblStrength.Visible = true;
                return;
            }

            bool found = false;
            string currentUser = "";
            string name = "";

            for (int i = 0; i < users.Count; i++)
            {
                if (txtUsernameLogin.Text == users[i].Username &&
                    txtPasswordLogin.Text == users[i].Password)
                {

                    found = true;
                    currentUser = users[i].Username;
                    name = users[i].Name;
                    break;
                }

            }

            if (found)
            {
                MessageBox.Show("Login Successful");

                frmHomePage home = new frmHomePage(name, currentUser);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No account found");
                lblTryAgain.Visible = true;
                return;
            }

        }
        private void lblCreate_Click(object sender, EventArgs e)
        {
            frmSignUpPage mySignUp = new frmSignUpPage();
            mySignUp.ShowDialog();
        }

        private void txtUsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
