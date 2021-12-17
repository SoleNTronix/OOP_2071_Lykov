using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    public class MyRational
    {
        public int numerator;
        public int denumerator;
        public void Sum(MyRational one, MyRational two)
        {
            int sum_denum = one.denumerator * two.denumerator;
            int sum_num = one.numerator * two.denumerator + two.numerator * one.denumerator;
            MyRational res = new MyRational();
            res = Red(sum_num, sum_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }
        public void Dif(MyRational one, MyRational two)
        {
            int dif_denum = one.denumerator * two.denumerator;
            int dif_num = one.numerator * two.denumerator - two.numerator * one.denumerator;
            MyRational res = new MyRational();
            res = Red(dif_num, dif_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }
        public void Mult(MyRational one, MyRational two)
        {
            int mult_num = one.numerator * two.numerator;
            int mult_denum = one.denumerator * two.denumerator;
            MyRational res = new MyRational();
            res = Red(mult_num, mult_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }
        public void Div(MyRational one, MyRational two)
        {
            int div_num = one.numerator * two.denumerator;
            int div_denum = one.denumerator * two.numerator;
            MyRational res = new MyRational();
            res = Red(div_num, div_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }

        MyRational Red(int n, int d)
        {
            int n_nod = n;
            int d_nod = d;
            while (n_nod != 0)
            {
                int temp = n_nod;
                n_nod = d_nod % n_nod;
                d_nod = temp;
                
            }
            n = n / d_nod;
            d = d / d_nod;
            MyRational res = new MyRational();
            res.numerator = n;
            res.denumerator = d;
            return res;
        }


}   }
