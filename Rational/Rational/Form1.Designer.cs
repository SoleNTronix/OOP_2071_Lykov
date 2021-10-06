
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
            this.top1 = new System.Windows.Forms.TextBox();
            this.bottom1 = new System.Windows.Forms.TextBox();
            this.top2 = new System.Windows.Forms.TextBox();
            this.bottom2 = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.resultTop = new System.Windows.Forms.TextBox();
            this.resultBottom = new System.Windows.Forms.TextBox();
            this.Dif = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // top1
            // 
            this.top1.BackColor = System.Drawing.SystemColors.Info;
            this.top1.Location = new System.Drawing.Point(69, 138);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(97, 27);
            this.top1.TabIndex = 0;
            // 
            // bottom1
            // 
            this.bottom1.BackColor = System.Drawing.SystemColors.Info;
            this.bottom1.Location = new System.Drawing.Point(69, 220);
            this.bottom1.Name = "bottom1";
            this.bottom1.Size = new System.Drawing.Size(97, 27);
            this.bottom1.TabIndex = 1;
            // 
            // top2
            // 
            this.top2.BackColor = System.Drawing.SystemColors.Info;
            this.top2.Location = new System.Drawing.Point(363, 138);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(98, 27);
            this.top2.TabIndex = 2;
            // 
            // bottom2
            // 
            this.bottom2.BackColor = System.Drawing.SystemColors.Info;
            this.bottom2.Location = new System.Drawing.Point(363, 220);
            this.bottom2.Name = "bottom2";
            this.bottom2.Size = new System.Drawing.Size(98, 27);
            this.bottom2.TabIndex = 3;
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
            // resultTop
            // 
            this.resultTop.BackColor = System.Drawing.Color.Cyan;
            this.resultTop.ForeColor = System.Drawing.Color.Crimson;
            this.resultTop.Location = new System.Drawing.Point(675, 138);
            this.resultTop.Name = "resultTop";
            this.resultTop.Size = new System.Drawing.Size(92, 27);
            this.resultTop.TabIndex = 5;
            // 
            // resultBottom
            // 
            this.resultBottom.BackColor = System.Drawing.Color.Cyan;
            this.resultBottom.ForeColor = System.Drawing.Color.Crimson;
            this.resultBottom.Location = new System.Drawing.Point(675, 220);
            this.resultBottom.Name = "resultBottom";
            this.resultBottom.Size = new System.Drawing.Size(92, 27);
            this.resultBottom.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(427, 41);
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
            this.Controls.Add(this.resultBottom);
            this.Controls.Add(this.resultTop);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.bottom2);
            this.Controls.Add(this.top2);
            this.Controls.Add(this.bottom1);
            this.Controls.Add(this.top1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bottom1;
        private System.Windows.Forms.TextBox top2;
        private System.Windows.Forms.TextBox bottom2;
        private System.Windows.Forms.TextBox top1;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.TextBox resultTop;
        private System.Windows.Forms.TextBox resultBottom;
        private System.Windows.Forms.Button Dif;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Label label1;
    }
}

