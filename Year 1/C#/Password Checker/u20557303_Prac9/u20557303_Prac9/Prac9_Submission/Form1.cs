using System.Media;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prac9_Submission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;

            /*
            Create a private boolean method called CheckPass that takes string pass as a parameter and
            checks whether the password is secure.

            It must return true if secure and false if not.
            */            

            if (CheckPass(pass))
            {
                MessageBox.Show("Me when I create a secure password ===>");

                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                SoundPlayer player = new SoundPlayer("sound.wav");
                player.Play();
                MessageBox.Show("Goofy ahh password bruh");
            }
        }

        // Create private method here
        private bool CheckPass(string pass)
        {
            
            if (pass.Length < 8)
            {
                return false;
            }

            
            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            
            foreach (char c in pass)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (!char.IsLetterOrDigit(c)) hasSpecial = true;

                
                if (hasUpper && hasDigit && hasSpecial)
                {
                    return true;
                }
            }

            // Returns true only if BOTH conditions were satisfied
            return hasUpper && hasDigit;
        }

        
    }
}
