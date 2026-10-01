namespace Prac9_Submission
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            btnCheck = new Button();
            lblHeadng = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(12, 141);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 35);
            txtPassword.TabIndex = 0;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(12, 182);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(259, 47);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check My Password";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblHeadng
            // 
            lblHeadng.AutoSize = true;
            lblHeadng.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeadng.Location = new Point(12, 9);
            lblHeadng.Name = "lblHeadng";
            lblHeadng.Size = new Size(259, 30);
            lblHeadng.TabIndex = 2;
            lblHeadng.Text = "Password strength checker";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(176, 68);
            label1.TabIndex = 3;
            label1.Text = "Your password must contain:\r\nA capital word, \r\nA number,\r\nAnd a special character.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 251);
            Controls.Add(label1);
            Controls.Add(lblHeadng);
            Controls.Add(btnCheck);
            Controls.Add(txtPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnCheck;
        private Label lblHeadng;
        private Label label1;
    }
}
