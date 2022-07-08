using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MethodGenerik
    {
        /*
         * Method generik => method yang didefinisikan dengan tipe generik dapat digunakan untuk 
         * berbagai macam tipe parameter hanya dengan satu deklarasi method saja
         */

        public static void main()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            string[] names = new string[] { "rudi", "eka", "opick", "cecep" };

            Person[] people = new Person[] {
                new Person("muhammad david", 23),
                new Person("hoirul abdillah", 32),
                new Person("eka wijaya", 15)
            };


            Console.WriteLine("Menampilkan array int : ");
            MethodGenerik.printData(nums);

            Console.WriteLine("\n");

            Console.WriteLine("Menampilkan array string");
            MethodGenerik.printData(names);

            Console.WriteLine("Menampilkan array objek Person");
            MethodGenerik.printData(people);
        }
        public static void printData<T>(T[] data)
        {
            foreach(var item in data){
                Console.WriteLine(item);
            }
        }   
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string? ToString()
        {
            return $"Nama lengkap : {this.Name} \n" +
                $"Usia : {this.Age}";
        }
    }
}
