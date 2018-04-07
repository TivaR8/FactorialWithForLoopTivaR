namespace FactorialWithForLoopTivaR
{
    partial class frmFactorialWithForLoop
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.lblFinalAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(185, 84);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(122, 35);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(91, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Enter the number:";
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(228, 35);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(100, 20);
            this.txtFactorial.TabIndex = 2;
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(161, 144);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(120, 95);
            this.lstFactorialNumbers.TabIndex = 3;
            // 
            // lblFinalAnswer
            // 
            this.lblFinalAnswer.AutoSize = true;
            this.lblFinalAnswer.Location = new System.Drawing.Point(161, 264);
            this.lblFinalAnswer.Name = "lblFinalAnswer";
            this.lblFinalAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblFinalAnswer.TabIndex = 4;
            this.lblFinalAnswer.Text = "label1";
            // 
            // frmFactorialWithForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 349);
            this.Controls.Add(this.lblFinalAnswer);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnStart);
            this.Name = "frmFactorialWithForLoop";
            this.Text = "Factorial with For Loop By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.Label lblFinalAnswer;
    }
}

