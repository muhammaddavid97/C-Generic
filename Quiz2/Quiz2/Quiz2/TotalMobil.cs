using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public class TotalMobil<T> where T: CarInterface
    {
        public double Sum { get; set; }
        public double TotalPendapatan { get; set; }
        public string TypeCar { get;  set;}
        public TotalMobil(double sum)
        {
            this.Sum = sum;
            this.TotalPendapatan += this.Sum;
        }
    }
}
