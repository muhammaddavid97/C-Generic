using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Latihan
{
    public class Lat_4
    {
        public static void main()
        {
            // membuat referensi dari interface IGeometricObject
            IGeometricObject[] geometricObjects = new IGeometricObject[]
            {
                new Circle(5.5),
                new Circle(2.5),
                new Rectangle(4.2, 1.5),
                new Rectangle(1.5, -2.0)
            };

            // membuat instance dari kelas generik dengan parameter tipe berupa objek dari kelas implementasi
            InterfaceConstraint<IGeometricObject> constraint = new InterfaceConstraint<IGeometricObject>(geometricObjects);

            foreach(var item in constraint.sortingData())
            {
                constraint.printData(item);
            }
        }
    }

    class InterfaceConstraint<T> where T : IGeometricObject
    {
        public T[] Data1 { get; set; }
        private int length;

        public InterfaceConstraint(T[] data1)
        {
            this.Data1 = data1;
            this.length = data1.Length;
        }

        public T[] sortingData()
        {
            for (int i = 0; i < this.length; i++)
            {
                for (int j = i + 1; j < this.length - 1; j++)
                {
                    if (this.Data1[j].getArea() < this.Data1[i].getArea() && this.Data1[j].getPerimeter() < this.Data1[i].getPerimeter())
                    {
                        T swapp = this.Data1[i];
                        this.Data1[i] = this.Data1[j];
                        this.Data1[j] = swapp;
                    }
                }
            }

            return this.Data1;
        }

        public void printData(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
    interface IGeometricObject
    {
        double getArea();
        double getPerimeter();
    }

    class Circle : IGeometricObject
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double getArea()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string? ToString()
        {
            return $"Radius : {this.Radius} \n" +
                $"Luas lingkaran : {this.getArea()} \n" +
                $"Keliling lingkaran : {this.getArea()}";
        }
    }

    class Rectangle : IGeometricObject
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public double getArea()
        {
            return this.Width * this.Length;
        }

        public double getPerimeter()
        {
            return 2 * (this.Width + this.Length);
        }

        public override string? ToString()
        {
            return $"Panjang : {this.Width} \n" +
                $"Lebar : {this.Length} \n" +
                $"Luas persegi panjang : {this.getArea()}\n" +
                $"Keliling persegi panjang : {this.getPerimeter()}";
        }
    }
}
