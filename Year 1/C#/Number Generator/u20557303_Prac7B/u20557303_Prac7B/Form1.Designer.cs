namespace Prac7B
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
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudCols = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.chkHighlightOdd = new System.Windows.Forms.CheckBox();
            this.grpLoopSettings = new System.Windows.Forms.GroupBox();
            this.rtbTextPt = new System.Windows.Forms.RichTextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.lblMultiplySign = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).BeginInit();
            this.grpLoopSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(16, 98);
            this.nudRows.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(50, 26);
            this.nudRows.TabIndex = 0;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCols
            // 
            this.nudCols.Location = new System.Drawing.Point(105, 98);
            this.nudCols.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCols.Name = "nudCols";
            this.nudCols.Size = new System.Drawing.Size(49, 26);
            this.nudCols.TabIndex = 1;
            this.nudCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(21, 190);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 45);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.White;
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(181, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(691, 426);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // chkHighlightOdd
            // 
            this.chkHighlightOdd.AutoSize = true;
            this.chkHighlightOdd.Location = new System.Drawing.Point(16, 154);
            this.chkHighlightOdd.Name = "chkHighlightOdd";
            this.chkHighlightOdd.Size = new System.Drawing.Size(124, 24);
            this.chkHighlightOdd.TabIndex = 4;
            this.chkHighlightOdd.Text = "Highlight Odd";
            this.chkHighlightOdd.UseVisualStyleBackColor = true;
            // 
            // grpLoopSettings
            // 
            this.grpLoopSettings.Controls.Add(this.rtbTextPt);
            this.grpLoopSettings.Controls.Add(this.lblCols);
            this.grpLoopSettings.Controls.Add(this.lblMultiplySign);
            this.grpLoopSettings.Controls.Add(this.lblRows);
            this.grpLoopSettings.Controls.Add(this.nudRows);
            this.grpLoopSettings.Controls.Add(this.chkHighlightOdd);
            this.grpLoopSettings.Controls.Add(this.nudCols);
            this.grpLoopSettings.Controls.Add(this.btnGenerate);
            this.grpLoopSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpLoopSettings.Location = new System.Drawing.Point(12, 12);
            this.grpLoopSettings.Name = "grpLoopSettings";
            this.grpLoopSettings.Size = new System.Drawing.Size(163, 426);
            this.grpLoopSettings.TabIndex = 5;
            this.grpLoopSettings.TabStop = false;
            this.grpLoopSettings.Text = "Loop Settings";
            // 
            // rtbTextPt
            // 
            this.rtbTextPt.Enabled = false;
            this.rtbTextPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rtbTextPt.Location = new System.Drawing.Point(6, 385);
            this.rtbTextPt.Name = "rtbTextPt";
            this.rtbTextPt.Size = new System.Drawing.Size(41, 35);
            this.rtbTextPt.TabIndex = 6;
            this.rtbTextPt.Text = "";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(101, 69);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(40, 20);
            this.lblCols.TabIndex = 9;
            this.lblCols.Text = "Cols";
            // 
            // lblMultiplySign
            // 
            this.lblMultiplySign.AutoSize = true;
            this.lblMultiplySign.Location = new System.Drawing.Point(77, 104);
            this.lblMultiplySign.Name = "lblMultiplySign";
            this.lblMultiplySign.Size = new System.Drawing.Size(20, 20);
            this.lblMultiplySign.TabIndex = 8;
            this.lblMultiplySign.Text = "X";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(12, 69);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(49, 20);
            this.lblRows.TabIndex = 5;
            this.lblRows.Text = "Rows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.grpLoopSettings);
            this.Controls.Add(this.rtbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).EndInit();
            this.grpLoopSettings.ResumeLayout(false);
            this.grpLoopSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudCols;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.CheckBox chkHighlightOdd;
        private System.Windows.Forms.GroupBox grpLoopSettings;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblMultiplySign;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.RichTextBox rtbTextPt;
    }
}

