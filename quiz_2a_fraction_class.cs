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

        public fraction(int _lob, int _hor)
        {
            lob = _lob;
            if(_hor != 0)
            {
                hor = _hor;
            }
        }
    }
}
