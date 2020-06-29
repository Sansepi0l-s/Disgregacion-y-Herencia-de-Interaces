using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementando_el_uso_de_interfaz
{
    class Operaciones2 : Interfaz_2
    {
        public int multiplicacion(int i, int j)
        {
            int r = 0;
            r = i * j;
            return r;
        }
        public int Division(int i, int j)
        {
            int r = 0;
            if(i > j)
            {
                r =  i / j;
            }
            if (j > i)
            {
                r = j / 1;
            }
            return r;
        }
        public int suma(int i, int j) { throw new NotImplementedException();}
        public int resta(int i, int j){throw new NotImplementedException();}
        public static void foo2(Interfaz_2 c)
        {
            int i, j, r;
            Console.Write("Ingrese i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese j: ");
            j = int.Parse(Console.ReadLine());
            r = c.multiplicacion(i, j);
            Console.WriteLine("La Multiplicacion de los numeros {0} * {1} = {2}", i, j, r);
            r = c.Division(i, j);
            Console.WriteLine("La Division de los numeros {0} / {1} = {2}", i, j, r);
        }
    }
}
