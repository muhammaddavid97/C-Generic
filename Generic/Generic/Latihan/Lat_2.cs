using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Latihan
{
    public class Lat_2
    {

        public static void main()
        {
            // membuat referensi dari interface BangunDatar
            BangunDatar[] bangunDatars = new BangunDatar[]
            {
            new Lingkaran(22.5),
            new Lingkaran(10.0),
            new PersegiPanjang(11.5, 2.5),
            new PersegiPanjang(2.4, 4.5)
            };

            // membuat instance dari kelas Lingkaran
            Lingkaran[] lingkaran =
            {
                new Lingkaran(5.5),
                new Lingkaran(2.2)
            };

            // membuat instance dari kelas PersegiPanjang 
            PersegiPanjang[] persegiPanjangs =
            {
                new PersegiPanjang(4.5, 2.0),
                new PersegiPanjang(1.5, 0)
            };

            // membuat instance dari kelas generic2 dengan parameter tipe berupa interface BangunDatar 
            Generic2<BangunDatar> obj1 = new Generic2<BangunDatar>(bangunDatars);
            obj1.printArray();

            Console.WriteLine("\n");

            // membuat instance dari kelas generic2 dengan parameter tipe berupa objek Lingkaran
            Generic2<Lingkaran> obj2 = new Generic2<Lingkaran>(lingkaran);
            obj2.printArray();

            Console.WriteLine("\n");

            // membuat instance dari kelas generic2 dengan parameter tipe berupa objek PersegiPanjang
            Generic2<PersegiPanjang> obj3 = new Generic2<PersegiPanjang>(persegiPanjangs);
            obj3.printArray();
        }

    }

    class Generic2<T>
    {
        public T[] Data { get; set; }

       public Generic2(T[] data)
       {
            this.Data = data;
       }

       public System.Type checkDataType()
        {
            return this.Data.GetType();
        }
       
      public void printArray()
        {
            for (int i = 0; i < this.Data.Length; i++)
            {
                Console.WriteLine(this.Data[i].ToString());
            }
        }
    }

    interface BangunDatar
    {
        double hitungLuas();
        double hitungKeliling();

    }

    class Lingkaran : BangunDatar
    {
        public double Radius { get; set; }

        public Lingkaran(double radius)
        {
            this.Radius = radius;
        }

        public double hitungLuas()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }

        public double hitungKeliling()
        {
            return 2 * (Math.PI) * this.Radius;
        }

        public override string? ToString()
        {
            return $"Radius : {this.Radius} \n" +
                $"Luas lingkaran : {this.hitungLuas()} \n" +
                $"Kelilng lingkaran : {this.hitungKeliling()}";
        }
    }

    class PersegiPanjang : BangunDatar
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }

        public PersegiPanjang(double panjang, double lebar)
        {
            this.Panjang = panjang;
            this.Lebar = lebar;
        }

        public double hitungLuas()
        {
            return this.Panjang * this.Lebar;
        }

        public double hitungKeliling()
        {
            return 2 * (this.Panjang + this.Lebar);
        }

        public override string? ToString()
        {
            return $"Panjang : {this.Panjang} \n" +
                $"Lebar : {this.Lebar} \n" +
                $"Luas persegi panjang : {this.hitungLuas()} \n" +
                $"Keliling persegi panjang : {this.hitungKeliling()}";
        }
    }
}
