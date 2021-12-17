
namespace Rational
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.denum1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.denum2 = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.resultNum = new System.Windows.Forms.TextBox();
            this.resultDenum = new System.Windows.Forms.TextBox();
            this.Dif = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Info;
            this.num1.Location = new System.Drawing.Point(69, 138);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(97, 27);
            this.num1.TabIndex = 0;
            // 
            // denum1
            // 
            this.denum1.BackColor = System.Drawing.SystemColors.Info;
            this.denum1.Location = new System.Drawing.Point(69, 220);
            this.denum1.Name = "denum1";
            this.denum1.Size = new System.Drawing.Size(97, 27);
            this.denum1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Info;
            this.num2.Location = new System.Drawing.Point(363, 138);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(98, 27);
            this.num2.TabIndex = 2;
            // 
            // denum2
            // 
            this.denum2.BackColor = System.Drawing.SystemColors.Info;
            this.denum2.Location = new System.Drawing.Point(363, 220);
            this.denum2.Name = "denum2";
            this.denum2.Size = new System.Drawing.Size(98, 27);
            this.denum2.TabIndex = 3;
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Sum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Sum.Location = new System.Drawing.Point(69, 349);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(94, 29);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // resultNum
            // 
            this.resultNum.BackColor = System.Drawing.Color.Cyan;
            this.resultNum.ForeColor = System.Drawing.Color.Crimson;
            this.resultNum.Location = new System.Drawing.Point(675, 138);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(92, 27);
            this.resultNum.TabIndex = 5;
            // 
            // resultDenum
            // 
            this.resultDenum.BackColor = System.Drawing.Color.Cyan;
            this.resultDenum.ForeColor = System.Drawing.Color.Crimson;
            this.resultDenum.Location = new System.Drawing.Point(675, 220);
            this.resultDenum.Name = "resultDenum";
            this.resultDenum.Size = new System.Drawing.Size(92, 27);
            this.resultDenum.TabIndex = 6;
            // 
            // Dif
            // 
            this.Dif.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Dif.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Dif.Location = new System.Drawing.Point(267, 349);
            this.Dif.Name = "Dif";
            this.Dif.Size = new System.Drawing.Size(94, 29);
            this.Dif.TabIndex = 7;
            this.Dif.Text = "Def";
            this.Dif.UseVisualStyleBackColor = false;
            this.Dif.Click += new System.EventHandler(this.Dif_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Mult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Mult.Location = new System.Drawing.Point(469, 349);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(94, 29);
            this.Mult.TabIndex = 8;
            this.Mult.Text = "Mult";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Div.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Div.Location = new System.Drawing.Point(676, 349);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(94, 29);
            this.Div.TabIndex = 9;
            this.Div.Text = "Div";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operation.Location = new System.Drawing.Point(249, 167);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(29, 46);
            this.operation.TabIndex = 10;
            this.operation.Text = " ";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.res.Location = new System.Drawing.Point(563, 167);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(43, 46);
            this.res.TabIndex = 11;
            this.res.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(203, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calculator of rational nums";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Dif);
            this.Controls.Add(this.resultDenum);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.denum2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.denum1);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox denum1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox denum2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.TextBox resultNum;
        private System.Windows.Forms.TextBox resultDenum;
        private System.Windows.Forms.Button Dif;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label label1;
    }
}

