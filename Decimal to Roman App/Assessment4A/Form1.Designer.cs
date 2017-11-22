namespace Assessment4A
{
    partial class decimalToRomanConverterForm
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
            this.txtBoxDecimalNumberInput = new System.Windows.Forms.TextBox();
            this.lblDecimalNumberPrompt = new System.Windows.Forms.Label();
            this.lblAnswerPrompt = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxDecimalNumberInput
            // 
            this.txtBoxDecimalNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDecimalNumberInput.Location = new System.Drawing.Point(370, 104);
            this.txtBoxDecimalNumberInput.Name = "txtBoxDecimalNumberInput";
            this.txtBoxDecimalNumberInput.Size = new System.Drawing.Size(228, 26);
            this.txtBoxDecimalNumberInput.TabIndex = 0;
            // 
            // lblDecimalNumberPrompt
            // 
            this.lblDecimalNumberPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalNumberPrompt.Location = new System.Drawing.Point(31, 106);
            this.lblDecimalNumberPrompt.Name = "lblDecimalNumberPrompt";
            this.lblDecimalNumberPrompt.Size = new System.Drawing.Size(228, 23);
            this.lblDecimalNumberPrompt.TabIndex = 1;
            this.lblDecimalNumberPrompt.Text = "Enter a decimal number";
            this.lblDecimalNumberPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerPrompt
            // 
            this.lblAnswerPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPrompt.Location = new System.Drawing.Point(94, 169);
            this.lblAnswerPrompt.Name = "lblAnswerPrompt";
            this.lblAnswerPrompt.Size = new System.Drawing.Size(100, 23);
            this.lblAnswerPrompt.TabIndex = 2;
            this.lblAnswerPrompt.Text = "Answer";
            this.lblAnswerPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswerPrompt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(370, 159);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(228, 43);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Firebrick;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(305, 258);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(137, 39);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Firebrick;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(201, 337);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 39);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(419, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(140, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(431, 24);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome to our Decimal-Roman Calculator ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(644, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // decimalToRomanConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(775, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerPrompt);
            this.Controls.Add(this.lblDecimalNumberPrompt);
            this.Controls.Add(this.txtBoxDecimalNumberInput);
            this.Name = "decimalToRomanConverterForm";
            this.Text = "Decimal to Roman Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDecimalNumberInput;
        private System.Windows.Forms.Label lblDecimalNumberPrompt;
        private System.Windows.Forms.Label lblAnswerPrompt;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
    }
}

