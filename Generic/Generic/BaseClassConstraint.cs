using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class BaseClassConstraint
    {
        /*
         * BaseClassConstraint => Digunakan untuk membatasi parameter tipe agar hanya dapat di isi dengan 
         * objek - objek dari kelas yang merupakan turunan dari kelas dasar tertentu.
         * 
         * Bentuk umum : 
         * 
         * class NamaClass<T> where T : NamaKelasDasar{}
         */

        public static void main()
        {
            // membuat instance dari kelas A
            A a = new A();

            // membuat instance dari kelas B
            B b = new B();

            // membuat instance dari kelas C
            C c = new C();

            // membuat instance kelas generik 
            BaseConstraint<A> obj1 = new BaseConstraint<A>(a);
            BaseConstraint<B> obj2 = new BaseConstraint<B>(b);

            // salah karena objek C tidak memiliki hierarki kelas manapun
            //BaseConstraint<C> obj3 = new BaseConstraint<C>(c);

            obj1.Text = "Halo Sayang !!";
            obj1.printData();

            obj2.Text = "Hello Baby !!";
            obj2.printData();
        }
    }

    // mendefinisikan kelas dengan tipe parameter generik
    class BaseConstraint<T> where T : A
    {
        public T Obj { get; set; }
        public string Text { get; set; }

        public BaseConstraint(T obj)
        {
            this.Obj = obj;
            this.Text = null;
        }

        public void printData()
        {
            // data Obj dapat memanggil method yang ada pada kelas A
            this.Obj.Tulis(this.Text);
        }
    }

    class A
    {
        public void Tulis(string s)
        {
            Console.WriteLine(s);
        }
    }

    class B : A
    {

    }

    class C
    {

    }
}
