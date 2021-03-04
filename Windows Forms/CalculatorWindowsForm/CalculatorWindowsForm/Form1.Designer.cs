
namespace CalculatorWindowsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.subtract = new System.Windows.Forms.RadioButton();
            this.multiply = new System.Windows.Forms.RadioButton();
            this.divide = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand2";
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(277, 64);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(100, 20);
            this.Operand1.TabIndex = 2;
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(277, 115);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(100, 20);
            this.Operand2.TabIndex = 3;
            // 
            // subtract
            // 
            this.subtract.AutoSize = true;
            this.subtract.Location = new System.Drawing.Point(202, 236);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(65, 17);
            this.subtract.TabIndex = 5;
            this.subtract.TabStop = true;
            this.subtract.Text = "Subtract";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.CheckedChanged += new System.EventHandler(this.subtract_CheckedChanged);
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(348, 236);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 17);
            this.multiply.TabIndex = 6;
            this.multiply.TabStop = true;
            this.multiply.Text = "Multiply";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.CheckedChanged += new System.EventHandler(this.multiply_CheckedChanged);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Location = new System.Drawing.Point(496, 236);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(55, 17);
            this.divide.TabIndex = 7;
            this.divide.TabStop = true;
            this.divide.Text = "Divide";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.CheckedChanged += new System.EventHandler(this.divide_CheckedChanged);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(89, 236);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(44, 17);
            this.add.TabIndex = 8;
            this.add.TabStop = true;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.RadioButton subtract;
        private System.Windows.Forms.RadioButton multiply;
        private System.Windows.Forms.RadioButton divide;
        private System.Windows.Forms.RadioButton add;
    }
}

