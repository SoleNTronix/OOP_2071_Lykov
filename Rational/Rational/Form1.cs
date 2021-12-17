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
        MyRational first;
        MyRational second;
        private void Sum_Click(object sender, EventArgs e)
        {
            first = new MyRational();
            second = new MyRational();
            Check();
            MyRational result = new MyRational();
            result.Sum(first, second);
            Result(result);
            operation.Text = "+";
        }

        private void Dif_Click(object sender, EventArgs e)
        {
            first = new MyRational();
            second = new MyRational();
            Check();
            MyRational result = new MyRational();
            result.Dif(first, second);
            Result(result);
            operation.Text = "-";
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            first = new MyRational();
            second = new MyRational();
            Check();
            MyRational result = new MyRational();
            result.Mult(first, second);
            Result(result);
            operation.Text = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            first = new MyRational();
            second = new MyRational();
            Check();
            MyRational result = new MyRational();
            result.Div(first, second);
            Result(result);
            operation.Text = "/";
        }

        private void Check()
        {
            bool check_num1 = int.TryParse(num1.Text, out first.numerator);
            bool check_denum1 = int.TryParse(denum1.Text, out first.denumerator);
            bool check_num2 = int.TryParse(num2.Text, out second.numerator);
            bool check_denum2 = int.TryParse(denum2.Text, out second.denumerator);

            if (!check_num1 || !check_num2 || !check_denum1 || !check_denum2)
                return;
        }
        private void Result(MyRational result)
        {
            resultNum.Text = Convert.ToString(result.numerator);
            resultDenum.Text = Convert.ToString(result.denumerator);
        }
    }
    
}
