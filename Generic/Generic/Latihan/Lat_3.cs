using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Latihan
{
    public class Lat_3
    {
        public static void main()
        {
            // membuat instance dari kelas Person2
            Person2[] person2s = new Person2[]
            {
                new Dosen2("Donny cahyadi", 29, "Ilmu sosialita", 23.000),
                new Dosen2("Sifa rahmayadi", 23, "Ekonomi komputer", 11.500000),
                new Student2("Jhony cage", 54, "Teknik informatika", 3.4),
                new Student2("Ewin dudit", 43, "Pendidikan olahraga", 3.0)
            };

            // membuat instance dari kelas Dosen2
            Dosen2 dosen2 = new Dosen2("Wawan", 34, "Etika Profesi", 23.500);

            // membuat instance dari kelas generik berupa parameter tipe Person2
            BaseConstraint<Person2> baseConstraint1 = new BaseConstraint<Person2>(person2s);
            foreach(var item in baseConstraint1.sortingData())
            {
                baseConstraint1.printData(item);
            }


            // membuat instance dari kelas generik berupa parameter tipe Dosen2
            BaseConstraint<Dosen2> baseConstraint2 = new BaseConstraint<Dosen2>(dosen2);
            Console.WriteLine(baseConstraint2.Obj.ToString());

        }
    }

    class BaseConstraint<T> where T : Person2
    {
        public T[] Data { get; set; }
        public T Obj { get; set; }

        private int length;
        public BaseConstraint(T[] data)
        {
            this.Data = data;
            this.length = data.Length;
        }

        public BaseConstraint(T obj)
        {
            this.Obj = obj;
        }
        
        public void printData(T item)
        {
            Console.WriteLine(item.ToString());
        }

        // mengurutkan data berdasarkan usia
        public T[] sortingData()
        {
            for (int i = 1; i < this.length; i++)
            {
                // menunjuk ke elemen saat ini
                int prevElement = this.Data[i].Age;

                // j => indeks yang mengacu ke elemen sebelumnya
                int j = i - 1;

                // perulangan while berfungsi untuk membandingkan 
                // kemudian memindahkan elemen, jika elemen saat ini
                // lebih kecil dibandingkan elemen sebelumnya
                // ke satu posisi didepan, posisi elemen saat ini
                while (j >= 0 && this.Data[j].Age > prevElement)
                {
                    this.Data[j + 1].Age = this.Data[j].Age;

                    j--;
                }

                this.Data[j + 1].Age = prevElement;
            }

            return this.Data;
        }
     }

    class Person2
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public Person2(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        public override string? ToString()
        {
            return $"Nama lengkap : {this.FullName} \n" +
                $"Alamat : {this.Age}";
        }

    }

    class Dosen2 : Person2
    {
        public string Matkul { get; set; }
        public double Gaji { get; set; }

        public Dosen2(string fullName, int age, string matkul, double gaji) : base(fullName, age)
        {
            this.Matkul = matkul;
            this.Gaji = gaji;
        }

        public override string? ToString()
        {
            return $"Nama dosen : {this.FullName} \n" +
                $"Usia dosen : {this.Age} \n" +
                $"Mata kuliah : {this.Matkul} \n" +
                $"Gaji : {this.Gaji}";
        }
    }

    class Student2 : Person2
    {
        public string Program { get; set; }
        public double IPK { get; set; }

        public Student2(string fullName, int age, string program, double ipk) : base(fullName, age)
        {
            this.Program = program;
            this.IPK = ipk;
        }

        public override string? ToString()
        {
            return $"Nama mahasiswa : {this.FullName} \n" +
                $"Usia mahasiswa : {this.Age} \n" +
                $"Program Study : {this.Program} \n" +
                $"IPK : {this.IPK}";
        }
    } 
}
