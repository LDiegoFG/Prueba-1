using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Información_Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleados = new Empleado();
            Empleado.Capturar();
            Console.ReadKey();

        }
    }
}
