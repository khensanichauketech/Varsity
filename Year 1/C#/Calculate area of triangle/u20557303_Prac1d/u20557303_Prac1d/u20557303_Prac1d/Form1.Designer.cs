namespace u20557303_Prac1d
{
    partial class Form1
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
            this.nudBase = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalculateTheAreaOfaTriangle = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBase
            // 
            this.nudBase.Location = new System.Drawing.Point(45, 129);
            this.nudBase.Name = "nudBase";
            this.nudBase.Size = new System.Drawing.Size(100, 20);
            this.nudBase.TabIndex = 0;
            this.nudBase.ValueChanged += new System.EventHandler(this.nudBase_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(267, 129);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(100, 20);
            this.nudHeight.TabIndex = 1;
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // nudArea
            // 
            this.nudArea.Location = new System.Drawing.Point(161, 344);
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(100, 20);
            this.nudArea.TabIndex = 2;
            this.nudArea.ValueChanged += new System.EventHandler(this.nudArea_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(161, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 43);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalculateTheAreaOfaTriangle
            // 
            this.lblCalculateTheAreaOfaTriangle.AutoSize = true;
            this.lblCalculateTheAreaOfaTriangle.Font = new System.Drawing.Font("Symbola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculateTheAreaOfaTriangle.Location = new System.Drawing.Point(41, 57);
            this.lblCalculateTheAreaOfaTriangle.Name = "lblCalculateTheAreaOfaTriangle";
            this.lblCalculateTheAreaOfaTriangle.Size = new System.Drawing.Size(326, 21);
            this.lblCalculateTheAreaOfaTriangle.TabIndex = 4;
            this.lblCalculateTheAreaOfaTriangle.Text = "Calculate the area of a triangle";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(76, 113);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "Base";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(300, 113);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(195, 328);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblCalculateTheAreaOfaTriangle);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudArea);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBase;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalculateTheAreaOfaTriangle;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblArea;
    }
}

