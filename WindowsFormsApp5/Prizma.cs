using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Prizma:Dortgen
    {
        public int Yukseklik { get; set; }

        public Prizma(int en, int boy, int yuk) : base(en, boy)
        {
            Yukseklik = yuk;
        }
        public Prizma():this(0,0,0)
        {

        }

        public override string bilgiver()
        {
            return base.bilgiver() + " yükseklik" + Yukseklik.ToString();
        }
    }
}
