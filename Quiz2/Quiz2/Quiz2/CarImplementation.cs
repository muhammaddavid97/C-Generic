using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public class CarImplementation : CarInterface
    {
        public Car[] initListCar(Car cars)
        {
            Car[] newData = { cars };

            return newData;
        }

        public void printListCar(Car[] listOfCar)
        {
           for (int i = 0; i < listOfCar.Length; i++)
            {
                Console.WriteLine("\n");
                Console.Write(listOfCar[i].ToString());
            }
        }

        public double totalPendapatan(Car[] cars, string typeCar)
        {
            double pendapatanTotal = 0.0;

            for(int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Type == typeCar)
                {
                    pendapatanTotal += cars[i].totalPendapatan();
                }
                else if(cars[i].Type == null)
                {
                    pendapatanTotal += cars[i].totalPendapatan();
                }
            }

            return pendapatanTotal;
        }
    }
}
