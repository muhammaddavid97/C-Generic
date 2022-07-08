using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Quiz_1
{
    public class Minuman : Kasir
    {
        public string Minum { get; set; }
        public Minuman(int pilihan, int banyak) : base(pilihan, banyak)
        {

        }

        public Minuman()
        {

        }

        public Minuman(int pilihan, string minum, double harga) : base(pilihan, harga)
        {
            this.Minum = minum;
        }

        public override string? ToString()
        {
            bool condition = true;

            while (condition)
            {
                if (this.Pilihan == 1 || this.Pilihan == 2 ||this.Pilihan == 3)
                {
                    switch (this.Pilihan)
                    {
                        case 1:
                            this.Minum = "Es Teh";
                            this.Harga = 2000;
                            break;
                        case 2:
                            this.Minum = "Es Jeruk";
                            this.Harga = 3500;
                            break;
                        case 3:
                            this.Minum = "Es Kopi";
                            this.Harga = 4000;
                            break;
                        default:
                            break;
                    }

                    TotalHarga = this.Banyak * this.Harga;
                    condition = false;
                }
                else
                {
                    Console.WriteLine("Minuman yang anda pilih tidak ditemukan");
                    Console.Write("Silakan pilih minuman yang ada : ");
                    string input = Console.ReadLine();
                    this.Pilihan = Convert.ToInt32(input);
                }

            }

            return $"{this.Banyak} {this.Minum} = Rp.{this.TotalHarga}";
        }
    }
}
