
namespace Drawing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRect = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rect_w = new System.Windows.Forms.TextBox();
            this.label_w = new System.Windows.Forms.Label();
            this.label_h = new System.Windows.Forms.Label();
            this.rect_h = new System.Windows.Forms.TextBox();
            this.circ_r = new System.Windows.Forms.TextBox();
            this.label_r = new System.Windows.Forms.Label();
            this.rbWagon = new System.Windows.Forms.RadioButton();
            this.label_s = new System.Windows.Forms.Label();
            this.wag_s = new System.Windows.Forms.TextBox();
            this.rbWagonE = new System.Windows.Forms.RadioButton();
            this.rbWagonC = new System.Windows.Forms.RadioButton();
            this.rbWagonS = new System.Windows.Forms.RadioButton();
            this.gbWagon = new System.Windows.Forms.GroupBox();
            this.B_clear = new System.Windows.Forms.Button();
            this.bWD = new System.Windows.Forms.Button();
            this.rbTrain = new System.Windows.Forms.RadioButton();
            this.wgCnt = new System.Windows.Forms.TextBox();
            this.labelT = new System.Windows.Forms.Label();
            this.gbWagon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 486);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // rbRect
            // 
            this.rbRect.AutoSize = true;
            this.rbRect.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbRect.Location = new System.Drawing.Point(679, 226);
            this.rbRect.Name = "rbRect";
            this.rbRect.Size = new System.Drawing.Size(96, 24);
            this.rbRect.TabIndex = 2;
            this.rbRect.TabStop = true;
            this.rbRect.Text = "Rectangle";
            this.rbRect.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbCircle.Location = new System.Drawing.Point(679, 256);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(67, 24);
            this.rbCircle.TabIndex = 3;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rect_w
            // 
            this.rect_w.Location = new System.Drawing.Point(680, 32);
            this.rect_w.Name = "rect_w";
            this.rect_w.Size = new System.Drawing.Size(182, 27);
            this.rect_w.TabIndex = 4;
            // 
            // label_w
            // 
            this.label_w.AutoSize = true;
            this.label_w.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_w.Location = new System.Drawing.Point(717, 9);
            this.label_w.Name = "label_w";
            this.label_w.Size = new System.Drawing.Size(116, 20);
            this.label_w.TabIndex = 5;
            this.label_w.Text = "Rectangle width";
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_h.Location = new System.Drawing.Point(717, 64);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(121, 20);
            this.label_h.TabIndex = 7;
            this.label_h.Text = "Rectangle height";
            // 
            // rect_h
            // 
            this.rect_h.Location = new System.Drawing.Point(679, 87);
            this.rect_h.Name = "rect_h";
            this.rect_h.Size = new System.Drawing.Size(183, 27);
            this.rect_h.TabIndex = 6;
            // 
            // circ_r
            // 
            this.circ_r.Location = new System.Drawing.Point(679, 137);
            this.circ_r.Name = "circ_r";
            this.circ_r.Size = new System.Drawing.Size(183, 27);
            this.circ_r.TabIndex = 8;
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_r.Location = new System.Drawing.Point(730, 114);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(90, 20);
            this.label_r.TabIndex = 9;
            this.label_r.Text = "Circle radius";
            // 
            // rbWagon
            // 
            this.rbWagon.AutoSize = true;
            this.rbWagon.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbWagon.Location = new System.Drawing.Point(679, 286);
            this.rbWagon.Name = "rbWagon";
            this.rbWagon.Size = new System.Drawing.Size(77, 24);
            this.rbWagon.TabIndex = 10;
            this.rbWagon.TabStop = true;
            this.rbWagon.Text = "Wagon";
            this.rbWagon.UseVisualStyleBackColor = true;
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_s.Location = new System.Drawing.Point(730, 167);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(85, 20);
            this.label_s.TabIndex = 11;
            this.label_s.Text = "Wagon size";
            // 
            // wag_s
            // 
            this.wag_s.Location = new System.Drawing.Point(680, 190);
            this.wag_s.Name = "wag_s";
            this.wag_s.Size = new System.Drawing.Size(182, 27);
            this.wag_s.TabIndex = 12;
            // 
            // rbWagonE
            // 
            this.rbWagonE.AutoSize = true;
            this.rbWagonE.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbWagonE.Location = new System.Drawing.Point(5, 26);
            this.rbWagonE.Name = "rbWagonE";
            this.rbWagonE.Size = new System.Drawing.Size(121, 24);
            this.rbWagonE.TabIndex = 13;
            this.rbWagonE.TabStop = true;
            this.rbWagonE.Text = "Empty wagon";
            this.rbWagonE.UseVisualStyleBackColor = true;
            // 
            // rbWagonC
            // 
            this.rbWagonC.AutoSize = true;
            this.rbWagonC.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbWagonC.Location = new System.Drawing.Point(5, 56);
            this.rbWagonC.Name = "rbWagonC";
            this.rbWagonC.Size = new System.Drawing.Size(141, 24);
            this.rbWagonC.TabIndex = 14;
            this.rbWagonC.TabStop = true;
            this.rbWagonC.Text = "Wagon with coal";
            this.rbWagonC.UseVisualStyleBackColor = true;
            // 
            // rbWagonS
            // 
            this.rbWagonS.AutoSize = true;
            this.rbWagonS.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbWagonS.Location = new System.Drawing.Point(5, 89);
            this.rbWagonS.Name = "rbWagonS";
            this.rbWagonS.Size = new System.Drawing.Size(144, 24);
            this.rbWagonS.TabIndex = 15;
            this.rbWagonS.TabStop = true;
            this.rbWagonS.Text = "Wagon with sand";
            this.rbWagonS.UseVisualStyleBackColor = true;
            // 
            // gbWagon
            // 
            this.gbWagon.Controls.Add(this.rbWagonS);
            this.gbWagon.Controls.Add(this.rbWagonE);
            this.gbWagon.Controls.Add(this.rbWagonC);
            this.gbWagon.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbWagon.Location = new System.Drawing.Point(694, 315);
            this.gbWagon.Name = "gbWagon";
            this.gbWagon.Size = new System.Drawing.Size(168, 124);
            this.gbWagon.TabIndex = 16;
            this.gbWagon.TabStop = false;
            this.gbWagon.Text = "Wagon type";
            // 
            // B_clear
            // 
            this.B_clear.Location = new System.Drawing.Point(680, 499);
            this.B_clear.Name = "B_clear";
            this.B_clear.Size = new System.Drawing.Size(182, 29);
            this.B_clear.TabIndex = 17;
            this.B_clear.Text = "Clear";
            this.B_clear.UseVisualStyleBackColor = true;
            this.B_clear.Click += new System.EventHandler(this.B_clear_Click);
            // 
            // bWD
            // 
            this.bWD.Location = new System.Drawing.Point(12, 504);
            this.bWD.Name = "bWD";
            this.bWD.Size = new System.Drawing.Size(94, 29);
            this.bWD.TabIndex = 18;
            this.bWD.Text = "Write Data";
            this.bWD.UseVisualStyleBackColor = true;
            this.bWD.Click += new System.EventHandler(this.bWD_Click);
            // 
            // rbTrain
            // 
            this.rbTrain.AutoSize = true;
            this.rbTrain.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rbTrain.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rbTrain.Location = new System.Drawing.Point(679, 466);
            this.rbTrain.Name = "rbTrain";
            this.rbTrain.Size = new System.Drawing.Size(62, 24);
            this.rbTrain.TabIndex = 19;
            this.rbTrain.Text = "Train";
            this.rbTrain.UseVisualStyleBackColor = false;
            // 
            // wgCnt
            // 
            this.wgCnt.Location = new System.Drawing.Point(748, 466);
            this.wgCnt.Name = "wgCnt";
            this.wgCnt.Size = new System.Drawing.Size(114, 27);
            this.wgCnt.TabIndex = 20;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelT.Location = new System.Drawing.Point(748, 443);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(114, 20);
            this.labelT.TabIndex = 21;
            this.labelT.Text = "Wagon quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(871, 541);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.wgCnt);
            this.Controls.Add(this.rbTrain);
            this.Controls.Add(this.bWD);
            this.Controls.Add(this.B_clear);
            this.Controls.Add(this.gbWagon);
            this.Controls.Add(this.wag_s);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.rbWagon);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.circ_r);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.rect_h);
            this.Controls.Add(this.label_w);
            this.Controls.Add(this.rect_w);
            this.Controls.Add(this.rbCircle);
            this.Controls.Add(this.rbRect);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.gbWagon.ResumeLayout(false);
            this.gbWagon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbRect;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.TextBox rect_w;
        private System.Windows.Forms.Label label_w;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.TextBox rect_h;
        private System.Windows.Forms.TextBox circ_r;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.RadioButton rbWagon;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.TextBox wag_s;
        private System.Windows.Forms.RadioButton rbWagonE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWagonS;
        private System.Windows.Forms.RadioButton rbWagonC;
        private System.Windows.Forms.GroupBox gbWagon;
        private System.Windows.Forms.Button B_clear;
        private System.Windows.Forms.Button bWD;
        private System.Windows.Forms.RadioButton rbTrain;
        private System.Windows.Forms.TextBox wgCnt;
        private System.Windows.Forms.Label labelT;
    }
}

