using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Quiz_1
{
    public interface IKasir
    {
        double TotalBayar(Kasir[] kasirs1);
        double BayarTunai(double nominal);

    }
}
