using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class InterfaceConstraint
    {
        /*
         * Interface Constraint digunakan untuk membatasai parameter tipe generik agar nilainya hanya dapat diisi
         * oleh objek - objek yang merupakan kelas implementasi dari interface tertentu.
         * 
         * Bentuk umum :
         * 
         * class NameClass<T> where T : NamaInterface
         */

        public static void main()
        {
            // membuat referensi dari interface IPerson
            IPerson[] person = new IPerson[]
            {
                new Students("Muhammad david", 23, "Cirebon", "Teknik Informatika", 3.4),
                new Students("Evan dimas", 19, "Surabaya", "Pendidikan Filasafat", 2.5),
                new Dosen("Yusuf irawan", 55, "Majalengka", "Ilmu Hukum", 34.50000),
                new Dosen("Gunawan", 34, "Karawang", "Etika kerja", 4.50000000)
            };

            // membuat instance dari kelas Students 
            Students students = new Students("Yayat ruhiyan", 15, "Kuningan", "Sistem Informasi", 3.2);

            // membuat instance dari kelas Animal
            Animal animal = new Animal("Karnivora", "Daging");

            // membuat instance dari kelas generik
            InterfaceConstraintBasic<IPerson> obj1 = new InterfaceConstraintBasic<IPerson>(person);
            InterfaceConstraintBasic<Students> obj2 = new InterfaceConstraintBasic<Students>(students);

            // error, karena parameter tipe bukan berisi objek dari kelas yang bukan implementasi dari interface
           // InterfaceConstraintBasic<Animal> obj3 = new InterfaceConstraintBasic<Animal>(animal);

            foreach(var item in obj1.sortingData())
            {
                obj1.printData(item);
            }

            Console.WriteLine("\n");
            obj2.printData(obj2.Data2);
        }
    }

    // mendefinisikan class generik dengan tipe Interface Constraint

    class InterfaceConstraintBasic<T> where T : IPerson
    {
        public T[] Data { get; set; }
        public T Data2 { get; set; }

        public InterfaceConstraintBasic(T[] data)
        {
            this.Data = data;
        }

        public InterfaceConstraintBasic(T data2)
        {
            this.Data2 = data2;
        }

        public T[] sortingData()
        {
            for (int i = 0; i < this.Data.Length - 1; i++)
            {
                int temp = i;

                for (int j = i + 1; j < this.Data.Length; j++)
                {
                    if (this.Data[temp].Age > this.Data[j].Age)
                    {
                        temp = j;
                    }
                }

                T swapp = this.Data[i];
                this.Data[i] = this.Data[temp];
                this.Data[temp] = swapp;
            }

            return this.Data;
        }

        public void printData(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
    interface IPerson
    {
         string FullName { get; set; }
         int Age { get; set; }
         string Address { get; set; }
    }

    class Students : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Program { get; set; }
        public double Ipk { get; set; }

        public Students(string fullName, int age, string address, string program, double ipk)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Address = address;
            this.Program = program;
            this.Ipk = ipk;
        }

        public override string? ToString()
        {
            return $"Nama mahasiswa : {this.FullName} \n" +
                $"Usia : {this.Age} \n" +
                $"Alamat : {this.Address} \n" +
                $"Program studi : {this.Program} \n" +
                $"IPK : {this.Ipk}";
        }
    }

    class Dosen : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Matkul { get; set; }
        public double Gaji { get; set; }

        public Dosen(string fullName, int age, string address, string matkul, double gaji)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Address = address;
            this.Matkul = matkul;
            this.Gaji = gaji;
        }

        public override string? ToString()
        {
            return $"Nama dosen : {this.FullName} \n" +
                $"Usia : {this.Age} \n" +
                $"Alamat : {this.Address} \n" +
                $"Mata kuliah : {this.Matkul} \n" +
                $"Gaji : {this.Gaji}";
        }
    }

    class Animal
    {
        public string Jenis { get; set; }
        public string Makanan { get; set; }

        public Animal(string jenis, string makanan) {
            this.Jenis = jenis;
            this.Makanan = makanan;
        }
    }
}
