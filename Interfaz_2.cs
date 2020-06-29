using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementando_el_uso_de_interfaz
{
    interface Interfaz_2 : Interfaz_Operaciones_Basicas
    {
        int multiplicacion(int i, int j);
        int Division(int i, int j);
    }
}
