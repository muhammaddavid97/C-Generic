using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public class Suv : Car
    {
        public double Sewa { get; set; }
        public double BiayaSupir { get; set; }

        public Suv(string nopol, int tahun, string type, double sewa, double supir) : base(nopol, tahun, type)
        {
            this.Sewa = sewa;
            this.BiayaSupir = supir;
            TotalPendapatan = this.BiayaSupir + this.Sewa;
        }

        public override double totalPendapatan()
        {
            return this.TotalPendapatan;
        }

        public override string? ToString()
        {
            return $"NoPolisi : {this.Nopol} \n" +
                $"Tahun : {this.Tahun} \n" +
                $"Type : {this.Type} \n" +
                $"Sewa : {this.Sewa} \n" +
                $"Supir : {this.BiayaSupir} \n" +
                $"Total Pendapatan : {this.totalPendapatan()}";
        }
    }
}
