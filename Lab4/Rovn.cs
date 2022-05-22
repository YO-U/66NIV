using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Rovn : Triangle
    {
        public double Per { get; set; }       
        public double Ugl { get; set; }
        public Rovn(double per, double ugl)
        {
           Per = per;        
            Ugl = ugl;
        }
        public override double Area()
        {

            return ((Per + Per + Math.Sqrt((Per * Per) + (Per * Per) - 2 * Per * Per * Math.Cos(Ugl)) - Per + Per) / 2)* Per;
        }
        public override double Perimetr()
        {
            return (Per + Per + Math.Sqrt((Per * Per) + (Per * Per) - 2 * Per * Per * Math.Cos(Ugl)));
        }
        public override string Print()
        {
            return $"Площадь {Area()},\n" +
                $" периметр {Perimetr()}";
        }
    }
}
