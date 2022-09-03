using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsVector
    {
        //Atributos
        const int Max = 50; //Cantidad Maxima de Casillas
        private int[] v;  //Vector
        private int cant; //cantidad de Elementos
        Random rd = new Random();
        //Constructor 
        public ClsVector()
        {
            v = new int[Max];
            this.cant = 0;
        }
        //Constuctor Parametrizado
        public ClsVector(int cantElem)
        {
            v = new int[cantElem];
            cant = 0;
        }

        public void CargarElem(int cant1,int a,int b)
        {
            this.cant = cant1;
            for (int i = 0; i <= cant; i++){
                v[i] = a + rd.Next(b - a);
            }
        }

        public void CargarElemC( int cant1)
        {
            this.cant = cant1;
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("ingrese un numero en la posicion " + i);
                v[i] = int.Parse(Console.ReadLine());
            }

        }

        //Descargar
        public  String Descargar()
        {
            String S = "[";
            for (int i = 0; i < cant; i++)
            {
                S = S + v[i] + "|";

            }
            S = S.Substring(0, S.Length - 1);
            return S+"]";
        }

        public int Mayor()
        {
            int may = v[0];
            for(int i = 1; i < cant; i++)
            {
                if (v[i] > may)
                {
                    may = v[i];
                }
            }
            return may;
        }







    }
}
