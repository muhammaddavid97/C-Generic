using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Latihan
{
    public class Lat_6
    {
        public static void main()
        {
            Console.Write("Total luas bangun datar = " );
            //Lat_6.sumLuas();
        }

        // mendefinisikan method generik
        public static double sumLuas<T>()
        {
           BangunDatar2D[] datar2Ds = new BangunDatar2D[]
           {
                new Circle2(2.5),
                new Circle2(5.5),
                new Rectangle2(10.5, 2.5),
                new Rectangle2(11.5, 3.5)
           };

            int len = datar2Ds.Length;
            double sum = 0;

            for (int i = 0; i < len; i++)
            {
                sum += datar2Ds[i].getLuas();
            }

            return sum;
        }
    }

    abstract class BangunDatar2D
    {
        protected double panjang;
        protected double lebar;
        protected double radius;
        public abstract double getLuas();
        public abstract double getKeliling();
    }

    class Circle2 : BangunDatar2D
    {
        public double Radius{ get => panjang; set => panjang = value;}

        public Circle2(double radius)
        {
            this.radius = radius;
        }

        public override double getLuas()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }

        public override double getKeliling()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string? ToString()
        {
            return $"Radius : {this.Radius} \n" +
                $"Luas lingkaran : {this.getLuas()} \n" +
                $"Keliling lingkaran : {this.getKeliling()}";
        }
    }

    class Rectangle2 : BangunDatar2D
    {
        public double Panjang { get => panjang; set => panjang = value; }
        public double Lebar { get => lebar; set => lebar = value; }

        public Rectangle2(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }

        public override double getLuas()
        {
            return this.panjang * this.lebar;
        }

        public override double getKeliling()
        {
            return 2 * (this.panjang + this.lebar);
        }

        public override string? ToString()
        {
            return $"Panjang : {this.panjang} \n" +
                $"Lebar : {this.lebar} \n" +
                $"Luas persegi panjang : {this.getLuas()} \n" +
                $"Keliling persegi panjang : {this.getKeliling()}";
        }
    }
}
