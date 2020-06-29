using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementando_el_uso_de_interfaz
{
    class Class_Operaciones1 : Interfaz_Operaciones_Basicas
    {
        public Class_Operaciones1() { }
        public int suma(int i, int j)
        {
            int r;
            r = i + j;
            return r;
        }
        public int resta(int i, int j)
        {
            int x = 0;
            if (i > j)
            {
                x = i - j;
            }
            if (j > i)
            {
                x = j - i;
            }
            return x;
        }
        public static void foo(Interfaz_Operaciones_Basicas c)
        {
            int i, j, r;
            Console.Write("Ingrese i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese j: ");
            j = int.Parse(Console.ReadLine());
            r = c.suma(i, j);
            Console.WriteLine("La suma de los numeros {0} + {1} = {2}", i, j, r);
            r = c.resta(i, j);
            Console.WriteLine("La resta de los numeros {0} + {1} = {2}", i, j, r);
        }
    }
}
