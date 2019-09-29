using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Area
{
    class CapturarValor
    {

        public void CapturarValores()
        {
        //instanciamos operaciones
        Operaciones x = new Operaciones();
            //pedimos los valores del Lado A y B
            Console.WriteLine("ingrese Lado A");
            double V1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ingrese Lado B");
            double V2 = Convert.ToDouble(Console.ReadLine());
            //asignamos una nueva variable que capture el 2
            int Val = 2;
            //asignamos los valores capturados
            double ResA = x.CalcularArea(V1), ResA2 = x.CalcularArea(V1, V2), ResA3 = x.CalcularArea(V1, V2, Val);
            //Imprimimos los resultados
            Console.WriteLine("El area de un cuadrado es:"+ResA);
            Console.WriteLine("El area de un rectangulo es:" + ResA2);
            Console.WriteLine("El area de un triangulo es:" + ResA3);


        }
    }
}
