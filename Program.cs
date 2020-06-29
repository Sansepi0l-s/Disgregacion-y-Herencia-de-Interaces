using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementando_el_uso_de_interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Interfaz_Operaciones_Basicas c1 = new Class_Operaciones1();
            Class_Operaciones1.foo(c1);
            Interfaz_2 c2 = new Operaciones2();
            Operaciones2.foo2(c2);
        }
    }  
}
