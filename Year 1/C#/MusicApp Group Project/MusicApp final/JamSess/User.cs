using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamSess
{
    [Serializable]
    public class User
    {
        // Private fields to store the data
        private string mName;
        private string mSurname;
        private string mUsername;
        private string mPassword;

        // Parameter constructor
        public User(string name, string surname, string username, string password)
        {
            mName = name;
            mSurname = surname;
            mUsername = username;
            mPassword = password;
        }

        // properties
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Surname
        {
            get { return mSurname; }
            set { mSurname = value; }
        }

        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public static bool CheckPass(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasLower = false;
            bool hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (char.IsLower(c)) hasLower = true;
                if (!char.IsLetterOrDigit(c)) hasSpecial = true;
            }

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }
    }
}

