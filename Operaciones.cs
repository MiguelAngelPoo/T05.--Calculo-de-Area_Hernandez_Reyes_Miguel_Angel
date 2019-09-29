using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Area
{
    class Operaciones
    {
        //realizamos las operaciones con sobre carga colocando el mismo nombre a todos los metodos
        public double CalcularArea(double LadoA)
        {
            //realizamos las operaciones y se lo asignamos a un valor 
            var ResA = LadoA * LadoA;
            return ResA;
            //retornamos el valor ResA
        }

        public double CalcularArea(double LadoA,double LadoB)
        {
            var ResA2 = LadoA * LadoB;
            return ResA2;
        }

        public double CalcularArea(double LadoA, double LadoB, int Num)
        {
            var ResA3 = LadoA * LadoB / Num;
            return ResA3;
        }



    }
}
