using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos y llamamos ala clase y metodo
            CapturarValor V = new CapturarValor();
            V.CapturarValores();
            Console.ReadKey();

        }
    }
}
