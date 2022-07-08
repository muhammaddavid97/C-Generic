using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Quiz_1
{
    public class Makanan : Kasir
    {
        public string Menu { get; set; }

        public Makanan() { }

        public Makanan(int pilihan, int banyak) : base(pilihan, banyak)
        {
        }

        public Makanan(int pilihan, string menu, double harga) : base(pilihan, harga)
        {
            this.Menu = menu;
        }

        public override string? ToString()
        {
            bool condition = true;

            while (condition)
            {
                if (this.Pilihan == 1 || this.Pilihan == 2 || this.Pilihan == 3)
                {
                    switch (this.Pilihan)
                    {
                        case 1:
                            this.Menu = "Nasi Goreing";
                            this.Harga = 15000;
                            break;
                        case 2:
                            this.Menu = "Soto";
                            this.Harga = 9000;
                            break;
                        case 3:
                            this.Menu = "Mie Ayam";
                            this.Harga = 11000;
                            break;
                        default:
                            break;
                    }

                    TotalHarga = this.Banyak * this.Harga;
                    condition = false;
                }
                else
                {
                    Console.WriteLine("Menu yang anda pilih tidak ada");
                    Console.Write("Silakan pilih menu yang ada : ");
                    string input = Console.ReadLine();
                    this.Pilihan = Convert.ToInt32(input);
                }

            }

            return $"{this.Banyak} Porsi {this.Menu} = Rp.{this.TotalHarga}";
        }
    }
}
