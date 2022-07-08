using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public class Angkot : Car
    {
        public double HargaTiket { get; set; }
        public int TotalPenumpang { get; set; }
        
        public Angkot(string nopol, int tahun, string type, double hargaTiket, int totalPenumpang) : base(nopol, tahun, type)
        {
            this.HargaTiket = hargaTiket;
            this.TotalPenumpang = totalPenumpang;
            TotalPendapatan = this.HargaTiket * this.TotalPenumpang;
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
                $"Harga Tiket : {this.HargaTiket} \n" +
                $"Total Penumpang : {this.TotalPenumpang} \n" +
                $"Total Pendapatan : {this.totalPendapatan()}";
        }
    }
}
