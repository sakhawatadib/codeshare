using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction_work
{
    internal class fraction
    {
        private int lob;
        private int hor;

        //get and set

        public int Lob
        {
            get
            {
                return lob;
            }
            set
            {
                lob = value;
            }
        }

        public int Hor
        {
            get
            {
                return hor;
            }
            set
            {
                if(value != 0)
                {
                    hor = value;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }

        public string getfrac()
        {
            if(hor!=0)
            {
                return Convert.ToString(lob) + "/" + Convert.ToString(hor);
            }
            else
            {
                return ("ERROR");
            }
        }

        // constructor

        public fraction(int _lob, int _hor)
        {
            lob = _lob;
            if(_hor != 0)
            {
                hor = _hor;
            }
        }
        public fraction()
        { }

        // Operator Overloading

        public static string operator + (fraction a, fraction b)
        {
            fraction q = new fraction();
            q.Hor = a.Hor * b.Hor;
            q.Lob = (a.Lob * b.Hor) + (b.Lob * a.Hor);
            string s = q.getfrac();
            return s;
        }

        public static string operator - (fraction a, fraction b)
        {
            fraction q = new fraction();
            q.Hor = a.Hor * b.Hor;
            q.Lob = (a.Lob * b.Hor) - (b.Lob * a.Hor);
            string s = q.getfrac();
            return s;
        }

        public static string operator * (fraction a, fraction b)
        {
            fraction q = new fraction();
            q.Hor = a.Hor * b.Hor;
            q.Lob = a.Lob * b.Lob;
            string s = q.getfrac();
            return s;
        }

        public static string operator / (fraction a, fraction b)
        {
            fraction q = new fraction();
            q.Hor = a.Hor * b.Lob;
            q.Lob = a.Lob * b.Hor;
            if(q.Hor != 0)
            {
                string s = q.getfrac();
                return s;
            }
            else
            {
                return "ERROR";
            }
        }

    }
}
