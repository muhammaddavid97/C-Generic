using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Quiz_1
{
    public class KasirImplementation : IKasir
    {
        public double TotalBayar(Kasir[] kasirs1)
        {
            double totalBayar = 0;

            for (int i = 0; i < kasirs1.Length; i++)
            {
                totalBayar += kasirs1[i].TotalHarga;
            }

            return totalBayar;
        }

        public double BayarTunai(double nominal)
        {
            return nominal;
        }

        public double TotalKembalia(Kasir[] kasirs1, double nominal)
        {
            return this.BayarTunai(nominal) - this.TotalBayar(kasirs1);
        }

        public string printBayar(Kasir[] kasirs1, double nominal)
        {
            return $"Total harus dbayar : {this.TotalBayar(kasirs1)} \n" +
                $"Uang tunai pembeli : {this.BayarTunai(nominal)} \n" +
                $"Total kembalian : {this.TotalKembalia(kasirs1, nominal)}";
        }
    }
}
