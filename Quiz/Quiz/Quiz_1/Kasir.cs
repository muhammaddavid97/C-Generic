using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Quiz_1
{
    public class Kasir
    {
        public int Pilihan { get; set; }
        public int Banyak { get; set; }
        public double Harga { get; set; }
        public double TotalHarga { get; set; }

        public Kasir(int pilihan, int banyak)
        {
            this.Pilihan = pilihan;
            this.Banyak = banyak;
        }

        public Kasir(int pilihan, double harga)
        {
            this.Pilihan = pilihan;
            this.Harga = harga;
        }

        public Kasir() { }
    }

}
