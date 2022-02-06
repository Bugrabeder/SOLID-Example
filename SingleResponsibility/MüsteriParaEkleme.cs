using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class MüsteriParaEkleme
    {

        public int paraEkleme(string isim, int para)
        {
            return para;
        }

        public Cevirici ceviricii { get; set; }

        public double cevirici(int para)
        {
            return ceviricii.doviz.cevirici(para);
        }


    }
    public class Cevirici
    {
        public Doviz doviz  { get; set; }
    }

    public abstract class Doviz
    {
        public abstract double cevirici(int para);
    }

    public class Euro : Doviz
    {
        public override double cevirici(int para)
        {
            return para / 15.27;
        }
    }

    public class Dolar : Doviz
    {
        public override double cevirici(int para)
        {
            return para / 13.57;
        }
    }
}
