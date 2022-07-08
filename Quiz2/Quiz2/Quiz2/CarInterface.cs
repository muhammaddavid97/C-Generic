using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public interface CarInterface
    {
        Car[] initListCar(Car cars);
        void printListCar(Car[] listOfCar);
        double totalPendapatan(Car[] cars, string typeCar);
    }
}
