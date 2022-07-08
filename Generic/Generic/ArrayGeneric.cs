using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class ArrayGeneric
    {
        public static void main()
        {
            // mendefinisikan objek array bertipe int
            int[] nums = { 11, 3, 4, 2, 9, 1, 8 };

            // membuat instance dari kelas MyArray 
            MyArray<int> numbers = new MyArray<int>(nums);

            // panjang dari array 
            Console.WriteLine("Panjang Array : " + numbers.Length);

            // menampilkan elemen array 
            numbers.printArray();

            // mencari indeks dari elemen array 
            Console.WriteLine($"Indeks dari 4 : {numbers.getIndex(10)}");

            // menampilkan elemen array berdasarkan indeks 
            Console.WriteLine($"Elemen indeks ke 4 : {numbers.valueOf(4)}");

            // mendefinisikan objek array bertipe string 
            string[] lists = { "david", "eka", "riva", "dian", "chrisant" };

            //membuat instance dari kelas MyArray bertipe string
            MyArray<string> names = new MyArray<string>(lists);

            // panjang dari array 
            Console.WriteLine("Panjang Array : " + names.Length);

            // menampilkan elemen array 
            names.printArray();

            // mencari indeks dari elemen array 
            Console.WriteLine($"Indeks dari riva : {names.getIndex("riva")}");

            // menampilkan elemen array berdasarkan indeks 
            Console.WriteLine($"Elemen indeks ke 4 : {names.valueOf(4)}");
        }
    }

    public class MyArray<T>
    {
        private T[] data;
        private int length;
        public T[] Data { get => data; set => data = value; }

        public MyArray(T[] data)
        {
            this.data = data;
            this.length = data.Length;
        }

        // property ini bersifat read-only
        public int Length { get { return length; } }

        // method untuk mencari indeks array 
        public int getIndex(T val)
        {
            int index = -1;
            for (int i = 0; i < this.length; i++)
            {
                // jika elemen dan val nilainya sama maka kembalikan indeks nya
                if (this.data[i].Equals(val))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        // method untuk mencari elemen array berdasarkan indeks 
        public T valueOf(int index)
        {
            return this.data[index];
        }

        // method untuk menampilkan elemen array
        public void printArray()
        {
            for (int i = 0; i < this.length; i++)
            {
                Console.WriteLine(this.data[i]);
            }
        }
    }
}
