using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class TwoParameter
    {
        // selain mendefinisikan satu parameter tipe pada kelas generic, kita juga bisa mendefinisikan 
        // lebih dari satu parameter tipe generik dengan memisahkannya menggunakan koma.

        public static void main()
        {
            Generic2<int, double> obj1 = new Generic2<int, double>(2, 1.5);
            Generic2<string, int> obj2 = new Generic2<string, int>("apuy", 23);

            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.ToString());
        }
    }

    class Generic2<T, V>
    {
        public T Data1 { get; set; }
        public V Data2 { get; set; }

        public Generic2(T data1, V data2)
        {
            this.Data1 = data1;
            this.Data2 = data2;
        }

        public override string? ToString()
        {
            return $"Data1  : {this.Data1} \n" +
                $"Data2 : {this.Data2}";
        }
    }
}
