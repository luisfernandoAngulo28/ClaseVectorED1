using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClsVector V = new ClsVector();
            ///Llamada para un procedimiento
            V.CargarElemC(5);
            
            Console.WriteLine("------------Vector-----------------");
            //Llamada de una Funcion
            Console.WriteLine(V.Descargar());
            Console.WriteLine("el mayor es "+V.Mayor());
            Console.ReadKey();
        }
    }
}
