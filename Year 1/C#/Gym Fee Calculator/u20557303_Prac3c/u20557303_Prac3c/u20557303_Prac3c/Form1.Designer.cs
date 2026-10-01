namespace u20557303_Prac3c
{
    partial class frmGymFeeCalculator
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
            this.lblGymFeeCalculator = new System.Windows.Forms.Label();
            this.lblMonthlyBaseFee = new System.Windows.Forms.Label();
            this.lblTrainingSessionRate = new System.Windows.Forms.Label();
            this.lblNumberOfSessions = new System.Windows.Forms.Label();
            this.nudMonthlyBaseFee = new System.Windows.Forms.NumericUpDown();
            this.nudTrainingSessionRate = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfSessions = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.gbxCalculatorInputs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyBaseFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrainingSessionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSessions)).BeginInit();
            this.gbxCalculatorInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGymFeeCalculator
            // 
            this.lblGymFeeCalculator.AutoSize = true;
            this.lblGymFeeCalculator.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGymFeeCalculator.Location = new System.Drawing.Point(131, 67);
            this.lblGymFeeCalculator.Name = "lblGymFeeCalculator";
            this.lblGymFeeCalculator.Size = new System.Drawing.Size(203, 23);
            this.lblGymFeeCalculator.TabIndex = 0;
            this.lblGymFeeCalculator.Text = "Gym Fee Calculator";
            // 
            // lblMonthlyBaseFee
            // 
            this.lblMonthlyBaseFee.AutoSize = true;
            this.lblMonthlyBaseFee.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyBaseFee.Location = new System.Drawing.Point(43, 63);
            this.lblMonthlyBaseFee.Name = "lblMonthlyBaseFee";
            this.lblMonthlyBaseFee.Size = new System.Drawing.Size(129, 16);
            this.lblMonthlyBaseFee.TabIndex = 2;
            this.lblMonthlyBaseFee.Text = "Monthly Base Fee (R)";
            // 
            // lblTrainingSessionRate
            // 
            this.lblTrainingSessionRate.AutoSize = true;
            this.lblTrainingSessionRate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingSessionRate.Location = new System.Drawing.Point(44, 101);
            this.lblTrainingSessionRate.Name = "lblTrainingSessionRate";
            this.lblTrainingSessionRate.Size = new System.Drawing.Size(150, 16);
            this.lblTrainingSessionRate.TabIndex = 3;
            this.lblTrainingSessionRate.Text = "Training Session Rate (R)";
            // 
            // lblNumberOfSessions
            // 
            this.lblNumberOfSessions.AutoSize = true;
            this.lblNumberOfSessions.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSessions.Location = new System.Drawing.Point(44, 139);
            this.lblNumberOfSessions.Name = "lblNumberOfSessions";
            this.lblNumberOfSessions.Size = new System.Drawing.Size(120, 16);
            this.lblNumberOfSessions.TabIndex = 4;
            this.lblNumberOfSessions.Text = "Number of Sessions";
            // 
            // nudMonthlyBaseFee
            // 
            this.nudMonthlyBaseFee.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonthlyBaseFee.Location = new System.Drawing.Point(204, 56);
            this.nudMonthlyBaseFee.Name = "nudMonthlyBaseFee";
            this.nudMonthlyBaseFee.Size = new System.Drawing.Size(79, 23);
            this.nudMonthlyBaseFee.TabIndex = 5;
            // 
            // nudTrainingSessionRate
            // 
            this.nudTrainingSessionRate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTrainingSessionRate.Location = new System.Drawing.Point(204, 94);
            this.nudTrainingSessionRate.Name = "nudTrainingSessionRate";
            this.nudTrainingSessionRate.Size = new System.Drawing.Size(79, 23);
            this.nudTrainingSessionRate.TabIndex = 6;
            // 
            // nudNumberOfSessions
            // 
            this.nudNumberOfSessions.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfSessions.Location = new System.Drawing.Point(204, 132);
            this.nudNumberOfSessions.Name = "nudNumberOfSessions";
            this.nudNumberOfSessions.Size = new System.Drawing.Size(79, 23);
            this.nudNumberOfSessions.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(97, 187);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 38);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbOutput.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(38, 377);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(393, 73);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // gbxCalculatorInputs
            // 
            this.gbxCalculatorInputs.Controls.Add(this.lblMonthlyBaseFee);
            this.gbxCalculatorInputs.Controls.Add(this.lblTrainingSessionRate);
            this.gbxCalculatorInputs.Controls.Add(this.btnCalculate);
            this.gbxCalculatorInputs.Controls.Add(this.lblNumberOfSessions);
            this.gbxCalculatorInputs.Controls.Add(this.nudNumberOfSessions);
            this.gbxCalculatorInputs.Controls.Add(this.nudMonthlyBaseFee);
            this.gbxCalculatorInputs.Controls.Add(this.nudTrainingSessionRate);
            this.gbxCalculatorInputs.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCalculatorInputs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxCalculatorInputs.Location = new System.Drawing.Point(62, 118);
            this.gbxCalculatorInputs.Name = "gbxCalculatorInputs";
            this.gbxCalculatorInputs.Size = new System.Drawing.Size(348, 253);
            this.gbxCalculatorInputs.TabIndex = 10;
            this.gbxCalculatorInputs.TabStop = false;
            this.gbxCalculatorInputs.Text = "Calculator Inputs";
            // 
            // frmGymFeeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(469, 464);
            this.Controls.Add(this.gbxCalculatorInputs);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lblGymFeeCalculator);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmGymFeeCalculator";
            this.Text = "Gym Fee Calculator";
            this.Load += new System.EventHandler(this.frmGymFeeCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyBaseFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrainingSessionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSessions)).EndInit();
            this.gbxCalculatorInputs.ResumeLayout(false);
            this.gbxCalculatorInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGymFeeCalculator;
        private System.Windows.Forms.Label lblMonthlyBaseFee;
        private System.Windows.Forms.Label lblTrainingSessionRate;
        private System.Windows.Forms.Label lblNumberOfSessions;
        private System.Windows.Forms.NumericUpDown nudMonthlyBaseFee;
        private System.Windows.Forms.NumericUpDown nudTrainingSessionRate;
        private System.Windows.Forms.NumericUpDown nudNumberOfSessions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.GroupBox gbxCalculatorInputs;
    }
}

