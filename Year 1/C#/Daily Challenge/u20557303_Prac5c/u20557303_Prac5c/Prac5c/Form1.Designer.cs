namespace Prac5c
{
    partial class u20557303
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(u20557303));
            this.label1 = new System.Windows.Forms.Label();
            this.grpActivity = new System.Windows.Forms.GroupBox();
            this.cbxTodaysActivity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnRevealChallenge = new System.Windows.Forms.Button();
            this.grpActivity.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(228, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily challenge!";
            // 
            // grpActivity
            // 
            this.grpActivity.BackColor = System.Drawing.Color.Transparent;
            this.grpActivity.Controls.Add(this.cbxTodaysActivity);
            this.grpActivity.Controls.Add(this.label2);
            this.grpActivity.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActivity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpActivity.Location = new System.Drawing.Point(54, 86);
            this.grpActivity.Name = "grpActivity";
            this.grpActivity.Size = new System.Drawing.Size(630, 109);
            this.grpActivity.TabIndex = 1;
            this.grpActivity.TabStop = false;
            this.grpActivity.Text = "Today\'s Activity";
            // 
            // cbxTodaysActivity
            // 
            this.cbxTodaysActivity.BackColor = System.Drawing.Color.Bisque;
            this.cbxTodaysActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTodaysActivity.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTodaysActivity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxTodaysActivity.FormattingEnabled = true;
            this.cbxTodaysActivity.Items.AddRange(new object[] {
            "Go to the gym",
            "Play chess",
            "Go for a run"});
            this.cbxTodaysActivity.Location = new System.Drawing.Point(315, 37);
            this.cbxTodaysActivity.Name = "cbxTodaysActivity";
            this.cbxTodaysActivity.Size = new System.Drawing.Size(263, 33);
            this.cbxTodaysActivity.TabIndex = 2;
            this.cbxTodaysActivity.SelectedIndexChanged += new System.EventHandler(this.cbxTodaysActivity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose today\'s activity!";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rtbOutput);
            this.groupBox2.Controls.Add(this.btnRevealChallenge);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(54, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Today\'s challenge";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.SeaShell;
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbOutput.Location = new System.Drawing.Point(315, 34);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(263, 83);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnRevealChallenge
            // 
            this.btnRevealChallenge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRevealChallenge.Enabled = false;
            this.btnRevealChallenge.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevealChallenge.Location = new System.Drawing.Point(71, 56);
            this.btnRevealChallenge.Name = "btnRevealChallenge";
            this.btnRevealChallenge.Size = new System.Drawing.Size(173, 38);
            this.btnRevealChallenge.TabIndex = 0;
            this.btnRevealChallenge.Text = "See challenge";
            this.btnRevealChallenge.UseVisualStyleBackColor = false;
            this.btnRevealChallenge.Click += new System.EventHandler(this.btnRevealChallenge_Click);
            // 
            // u20557303
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpActivity);
            this.Controls.Add(this.label1);
            this.Name = "u20557303";
            this.Text = "u20557303";
            this.grpActivity.ResumeLayout(false);
            this.grpActivity.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRevealChallenge;
        private System.Windows.Forms.ComboBox cbxTodaysActivity;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

