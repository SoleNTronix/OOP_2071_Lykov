using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    public class Rat
    {
        public int top;
        public int bottom;
        int[] getter = new int[2];
        public void Sum(int t1, int t2, int b1, int b2)
        {
            int sum_bottom = b1 * b2;
            int sum_top = t1 * b2 + t2 * b1;
            getter = Red(sum_top, sum_bottom);
            top = getter[0];
            bottom = getter[1];
        }
        public void Dif(int t1, int t2, int b1, int b2)
        {
            int dif_bottom = b2 * b1;
            int dif_top = t1 * b2 - t2 * b1;
            getter = Red(dif_top, dif_bottom);
            top = getter[0];
            bottom = getter[1];
        }
        public void Mult(int t1, int t2, int b1, int b2)
        {
            int mult_top = t1 * t2;
            int mult_bottom = b1 * b2;
            getter = Red(mult_top, mult_bottom);
            top = getter[0];
            bottom = getter[1];
        }
        public void Div(int t1, int t2, int b1, int b2)
        {
            int div_top = t1 * b2;
            int div_bottom = b1 * t2;
            getter = Red(div_top, div_bottom);
            top = getter[0];
            bottom = getter[1];
        }

        int[] Red(int t, int b)
        {
            int t_nod = t;
            int b_nod = b;
            while (t_nod != 0)
            {
                int temp = t_nod;
                t_nod = b_nod % t_nod;
                b_nod = temp;
                
            }
            t = t / b_nod;
            b = b / b_nod;
            int[] rat = new int[2];
            rat[0] = t;
            rat[1] = b;
            return rat;
        }


}   }
