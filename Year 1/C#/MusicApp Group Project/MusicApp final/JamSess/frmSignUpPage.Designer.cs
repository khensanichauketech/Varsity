namespace JamSess
{
    partial class frmSignUpPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.txtSurnameSignUp = new System.Windows.Forms.TextBox();
            this.txtNameSignUp = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblUserStrength = new System.Windows.Forms.Label();
            this.lblPassStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Olive;
            this.btnCreate.Location = new System.Drawing.Point(462, 497);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(228, 68);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(446, 406);
            this.txtPasswordSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(265, 26);
            this.txtPasswordSignUp.TabIndex = 9;
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.Location = new System.Drawing.Point(446, 332);
            this.txtUsernameSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(265, 26);
            this.txtUsernameSignUp.TabIndex = 8;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(533, 108);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(91, 28);
            this.lblCreateAccount.TabIndex = 7;
            this.lblCreateAccount.Text = "Sign Up";
            // 
            // txtSurnameSignUp
            // 
            this.txtSurnameSignUp.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtSurnameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameSignUp.Location = new System.Drawing.Point(446, 258);
            this.txtSurnameSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurnameSignUp.Name = "txtSurnameSignUp";
            this.txtSurnameSignUp.Size = new System.Drawing.Size(265, 26);
            this.txtSurnameSignUp.TabIndex = 12;
            // 
            // txtNameSignUp
            // 
            this.txtNameSignUp.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtNameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSignUp.Location = new System.Drawing.Point(446, 184);
            this.txtNameSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameSignUp.Name = "txtNameSignUp";
            this.txtNameSignUp.Size = new System.Drawing.Size(265, 26);
            this.txtNameSignUp.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblName.Location = new System.Drawing.Point(552, 164);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblSurname.Location = new System.Drawing.Point(542, 238);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 16);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUserName.Location = new System.Drawing.Point(536, 312);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(85, 16);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "UserName:";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPassWord.Location = new System.Drawing.Point(539, 386);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(79, 16);
            this.lblPassWord.TabIndex = 16;
            this.lblPassWord.Text = "Password:";
            // 
            // lblUserStrength
            // 
            this.lblUserStrength.AutoSize = true;
            this.lblUserStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStrength.ForeColor = System.Drawing.Color.White;
            this.lblUserStrength.Location = new System.Drawing.Point(489, 455);
            this.lblUserStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserStrength.Name = "lblUserStrength";
            this.lblUserStrength.Size = new System.Drawing.Size(179, 16);
            this.lblUserStrength.TabIndex = 17;
            this.lblUserStrength.Text = "Username already exists";
            // 
            // lblPassStrength
            // 
            this.lblPassStrength.AutoSize = true;
            this.lblPassStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassStrength.ForeColor = System.Drawing.Color.White;
            this.lblPassStrength.Location = new System.Drawing.Point(519, 455);
            this.lblPassStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassStrength.Name = "lblPassStrength";
            this.lblPassStrength.Size = new System.Drawing.Size(119, 16);
            this.lblPassStrength.TabIndex = 18;
            this.lblPassStrength.Text = "Weak Password";
            // 
            // frmSignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1174, 654);
            this.Controls.Add(this.lblPassStrength);
            this.Controls.Add(this.lblUserStrength);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSurnameSignUp);
            this.Controls.Add(this.txtNameSignUp);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.txtUsernameSignUp);
            this.Controls.Add(this.lblCreateAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUpPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.TextBox txtSurnameSignUp;
        private System.Windows.Forms.TextBox txtNameSignUp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblUserStrength;
        private System.Windows.Forms.Label lblPassStrength;
    }
}