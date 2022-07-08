using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Quiz_1
{
    public class Struk<T> where T:IKasir
    {
        public string Name { get; set; }
        public string Orders { get; }
        public double Tagihan { get; }
        public double Bayar { get; }
        public double Kembalian { get; }

        public Struk(string name, string orders, double tagihan, double bayar, double kembalian)
        {
            this.Name = name;
            this.Orders = orders;
            this.Tagihan = tagihan;
            this.Bayar = bayar;
            this.Kembalian = kembalian;
        }

        public string printOrders()
        {
            return this.Orders;
        }

        public void printStruk()
        {
            Console.WriteLine("Nama pembeli : " + this.Name);
            Console.WriteLine("Tagihan : Rp." + this.Tagihan);
            Console.WriteLine("Dibayar : Rp." + this.Bayar);
            Console.WriteLine("Kembalian : Rp." + this.Kembalian);
        }
    }
}
