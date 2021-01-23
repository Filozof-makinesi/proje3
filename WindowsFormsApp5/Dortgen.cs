using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Dortgen
    {
        public int En { get; set; }
        public int  Boy { get; set; }
        public Dortgen(int en , int boy )
        {
            En = en;
            Boy = boy;

        }
        public Dortgen():this(0,0)
        {

        }

        public virtual string bilgiver()
        {

            return string.Format("en={0} boy={1}", En, Boy);
        }
    }
}

