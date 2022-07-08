using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            // membuat objek dari kelas generic dengan tipe parameter string 
            Generic<string> name = new Generic<string>("yusuf");
            Console.WriteLine(name.ToString());

            // membuat objek dari kelas generic dengan tipe parameter int
            Generic<int> age = new Generic<int>(21);
            Console.WriteLine(age.ToString());

            // membuat instance dari kelas Dosen
            Dosen d = new Dosen("Stikom Cirebon", "Jaringan Komputer", "Muhammad david", 23);

            // membuat objek dari kelas generic dengan tipe parameter objek
            Generic<Dosen> dosen = new Generic<Dosen>(d);
            Console.WriteLine(dosen.ToString());
        }
    }

    class Generic<T>
    {
        private T data;

        public Generic(T data)
        {
            this.data = data;
        }

        // property ini bersifat read-only
        public T Data { get { return data; } }

        public override string? ToString()
        {
            return $"Nilai : \n{this.data} \n" +
                $"Tipe data : {data.GetType()}";
        }
    }

    class Person
    {
        protected string fullName;
        protected int age;

        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
    }

    class Dosen : Person
    {
        private string universitas;
        private string matkul;

        public Dosen(string universitas, string matkul, string fullName, int age) : base(fullName, age)
        {
            this.universitas = universitas;
            this.matkul = matkul;
        }

        public string Universitas { get => universitas; set => universitas = value; }
        public string Matkul { get => matkul; set => matkul = value; }

        public override string? ToString()
        {
            return $"Nama dosen : {this.fullName} \n" +
                $"Usia : {this.age} \n" +
                $"Universitas : {this.universitas} \n" +
                $"Mata kuliah : {this.matkul}";
        }
    }
}
