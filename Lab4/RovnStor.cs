using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class RovnStor:Triangle
    {
        public double Per { get; set; }
        public RovnStor(double per)
        {
           Per = per;
         
        }
        public override double Area()
        {
            return (Per * Per * Math.Sqrt(3)) / 4;
        }
        public override double Perimetr()
        {
            return Per * 3;
        }
        public override string Print()
        {
            return $"Площадь {Area():F2}," +
                $" периметр {Perimetr():F2}";
        }
    }
}
