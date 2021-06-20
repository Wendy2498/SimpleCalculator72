namespace SimpleCalculator
{
    partial class SimpleCalculatorForm
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
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOperand1.Location = new System.Drawing.Point(29, 25);
            this.lblOperand1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(65, 15);
            this.lblOperand1.TabIndex = 0;
            this.lblOperand1.Text = "Operand 1:";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(118, 23);
            this.txtOperand1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(106, 23);
            this.txtOperand1.TabIndex = 0;
            this.txtOperand1.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOperator.Location = new System.Drawing.Point(29, 54);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(57, 15);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "Operator:";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(118, 52);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(31, 23);
            this.txtOperator.TabIndex = 1;
            this.txtOperator.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOperand2.Location = new System.Drawing.Point(29, 83);
            this.lblOperand2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(65, 15);
            this.lblOperand2.TabIndex = 4;
            this.lblOperand2.Text = "Operand 2:";
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(118, 81);
            this.txtOperand2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(106, 23);
            this.txtOperand2.TabIndex = 2;
            this.txtOperand2.TextChanged += new System.EventHandler(this.ClearResult);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResult.Location = new System.Drawing.Point(29, 112);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(118, 110);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(106, 23);
            this.txtResult.TabIndex = 7;
            this.txtResult.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 147);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 20);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(144, 147);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SimpleCalculatorForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(281, 190);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOperand1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SimpleCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

