using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public class Taxi : Car
    {
        public int Order { get; set; }
        public double OrderKm { get; set; }
        public int TotalKm { get; set; }
        public double Bonus { get; set; }

        public Taxi(string nopol, int tahun, string type, int order, double orderPerKm, int totalKm, double bonus) : base(nopol, tahun, type)
        {
            this.Order = order;
            this.OrderKm = orderPerKm;
            this.TotalKm = totalKm;
            this.Bonus = bonus;
            TotalPendapatan = (this.Order * this.Bonus) + (this.OrderKm * this.TotalKm);
        }

        public override double totalPendapatan()
        {
            return this.TotalPendapatan;
        }

        public override string? ToString()
        {
            return $"Nopolisi : {this.Nopol} \n" +
                $"Tahun : {this.Tahun} \n" +
                $"Type : {this.Type} \n" +
                $"Order : {this.Order} \n" +
                $"OrderPerKm : {this.OrderKm} \n" +
                $"TotalKm : {this.TotalKm} \n" +
                $"Bonus : {this.Bonus} \n" +
                $"Total Pendapatan : {this.TotalPendapatan}";
        }
    }
}
