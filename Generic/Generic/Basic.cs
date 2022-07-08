using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Basic
    {
        /*
         * Generic adalah kelas yang datanya dapat diisi dengan tipe data apapun. Syntaxnya sebagai berikut 
         * 
         * Syntax kelas generic : 
         * c;ass NamaClass<T> {}
         * 
         * T disebut parameter tipe yang merepresentasikan parameter tipe data generic artinya pada saat pembuatan objek dari kelas yang bersangkutan
         * T harus diganti dengan tipe data aktual yang akan diisikan ke dalam kelas.
         * 
         * Pembuatan instance kelas generic : 
         * NamaClass<T> reference = new NamaClass<T>(daftar-parameter);
         * 
         * 
         */

        public static void main()
        {
            // membuat instance kelas Generic dengan parameter bertipe int
            Generic<int> number = new Generic<int>(21);

            // membuat instance kelas generic dengan parameter bertipe string
            Generic<string> words = new Generic<string>("david");

            // membuat instance kelas generic dengan parameter bertipe char
            Generic<char> word = new Generic<char>('A');

            Console.WriteLine("\nNilai : " + number.Data);
            number.showType();

            Console.WriteLine("\nNilai : " + words.Data);
            words.showType();

            Console.WriteLine("\nNilai : " + word.Data);
            word.showType();
        }
    }

    class Generic<T>
    {
        // mendefinisikan data dengan tipe data generic
        private T data;

        public Generic(T data)
        {
            this.data = data;
        }
        public T Data { get => data; set => data = value; }

        public void showType()
        {
            // GetType() => method yang berfungsi untuk mengembalikan informasi tentang tipe data dari suatu variable
            Console.WriteLine("Tipe T : " + data.GetType());
        }
    }
}
