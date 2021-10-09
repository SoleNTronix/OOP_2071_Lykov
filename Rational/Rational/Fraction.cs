using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    public class Fraction
    {
        public int numerator;
        public int denumerator;
        public void Sum(Fraction one, Fraction two)
        {
            int sum_denum = one.denumerator * two.denumerator;
            int sum_num = one.numerator * two.denumerator + two.numerator * one.denumerator;
            Fraction res = new Fraction();
            res = Red(sum_num, sum_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }
        public void Dif(Fraction one, Fraction two)
        {
            int dif_denum = one.denumerator * two.denumerator;
            int dif_num = one.numerator * two.denumerator - two.numerator * one.denumerator;
            Fraction res = new Fraction();
            res = Red(dif_num, dif_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }
        public void Mult(Fraction one, Fraction two)
        {
            int mult_num = one.numerator * two.numerator;
            int mult_denum = one.denumerator * two.denumerator;
            Fraction res = new Fraction();
            res = Red(mult_num, mult_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }
        public void Div(Fraction one, Fraction two)
        {
            int div_num = one.numerator * two.denumerator;
            int div_denum = one.denumerator * two.numerator;
            Fraction res = new Fraction();
            res = Red(div_num, div_denum);
            numerator = res.numerator;
            denumerator = res.denumerator;
        }

        Fraction Red(int n, int d)
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
            Fraction res = new Fraction();
            res.numerator = n;
            res.denumerator = d;
            return res;
        }


}   }
