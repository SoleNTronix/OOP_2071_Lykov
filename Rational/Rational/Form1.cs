using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rational
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(top1.Text);
            int text2 = Convert.ToInt32(bottom1.Text);
            int text3 = Convert.ToInt32(top2.Text);
            int text4 = Convert.ToInt32(bottom2.Text);

            Rat result = new Rat();
            result.Sum(text1, text3, text2, text4);
            resultTop.Text = Convert.ToString(result.top);
            resultBottom.Text = Convert.ToString(result.bottom);
            operation.Text = "+";
        }

        private void Dif_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(top1.Text);
            int text2 = Convert.ToInt32(bottom1.Text);
            int text3 = Convert.ToInt32(top2.Text);
            int text4 = Convert.ToInt32(bottom2.Text);

            Rat result = new Rat();
            result.Dif(text1, text3, text2, text4);
            resultTop.Text = Convert.ToString(result.top);
            resultBottom.Text = Convert.ToString(result.bottom);
            operation.Text = "-";
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(top1.Text);
            int text2 = Convert.ToInt32(bottom1.Text);
            int text3 = Convert.ToInt32(top2.Text);
            int text4 = Convert.ToInt32(bottom2.Text);

            Rat result = new Rat();
            result.Mult(text1, text3, text2, text4);
            resultTop.Text = Convert.ToString(result.top);
            resultBottom.Text = Convert.ToString(result.bottom);
            operation.Text = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(top1.Text);
            int text2 = Convert.ToInt32(bottom1.Text);
            int text3 = Convert.ToInt32(top2.Text);
            int text4 = Convert.ToInt32(bottom2.Text);

            Rat result = new Rat();
            result.Div(text1, text3, text2, text4);
            resultTop.Text = Convert.ToString(result.top);
            resultBottom.Text = Convert.ToString(result.bottom);
            operation.Text = "/";
        }
    }
    
}
