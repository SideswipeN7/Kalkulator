using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT_V._1._2
{
   public  class Dane
    {
        string nazwa;
        double miejsce;
        public Dane(string n, double m)
        {
            this.nazwa = n;
            this.miejsce = m;
        }
        public override string ToString()
        {
            return this.nazwa;
        }
        public double Moc()
        {
            return this.miejsce;
        }

    }
}
