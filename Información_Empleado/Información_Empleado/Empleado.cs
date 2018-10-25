using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Información_Empleado
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fecha_de_nacimiento;
        private string ciudad;
        private char genero;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime Fecha_de_Nacimiento
        {
            get { return fecha_de_nacimiento; }
            set { fecha_de_nacimiento = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        internal static void Capturar()
        {
            Console.WriteLine("Agregar datos del empleado");

            Console.WriteLine("Defina el numero de empleados");
            int employeeNumber = Convert.ToInt32(Console.ReadLine());

            Empleado[] employeeArray = new Empleado[employeeNumber];
            Console.Clear();
            CapturarDatos(employeeArray);
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("[1] Mostrar lista de emplados");
                Console.WriteLine("[2] Mostrar lista de empladas y la cantidad");
                Console.WriteLine("[3] Mostrar lista de emplados y la cantidad");
                Console.WriteLine("[4] Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MostrarInf(employeeArray);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                
                case 2:
                    MostarM(employeeArray);
                    Console.Write("Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                
                case 3:
                    MostarH(employeeArray);
                    Console.Write("Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                }
            } while (opcion != 4);
        
        }

       

        private static void CapturarDatos(Empleado[] employeeArray)
        {
            for (int i = 0; i < employeeArray.Length; i++)

            {
                Empleado employee = new Empleado();
                Console.WriteLine("Escriba el nombre del empleado");
                employee.Nombre = Console.ReadLine();
                Console.WriteLine("Escriba el apellido del empleado");
                employee.Apellido = Console.ReadLine();
                Console.WriteLine("Escriba la fecha de nacimiento del empleado");
                employee.Fecha_de_Nacimiento = Convert.ToDateTime(Console.ReadLine());
                employee.Edad = CalcularEdad(employee.Fecha_de_Nacimiento); 
                Console.WriteLine("Escriba la ciudad del empleado");
                employee.Ciudad = Console.ReadLine();
                Console.WriteLine("Escriba  el genero del empleado: Hombre(H)/Mujer(M)");
                employee.Genero = Convert.ToChar(Console.ReadLine());
                employeeArray[i] = employee;
                Console.Clear();
            }
        }

        private static void MostrarInf(Empleado[] employeeArray)
        {
            Console.WriteLine(" \n" + "Los Empleados Ingresados son: \n");
            Console.WriteLine("Nombre \t Apellido \t Edad \t Ciudad");
            for (int i = 0; i < employeeArray.Length; i++)
            {
                Console.WriteLine(employeeArray[i].Nombre + " \t" + employeeArray[i].Apellido + " \t" + employeeArray[i].Edad + " \t" + employeeArray[i].Ciudad);

            }
        }

        private static void MostarM(Empleado[] employeeArray)
        {
            int CantidadM = 0;
            Console.WriteLine(" \n" + "Lista de Mujeres");
            for (int i = 0; i < employeeArray.Length; i++)
            {
                if (employeeArray[i].Genero == 'M')
                {
                    CantidadM = CantidadM + 1;
                    Console.WriteLine(employeeArray[i].Nombre + " \t" + employeeArray[i].Apellido);
                }
            }
            Console.WriteLine(" \n" + "La cantidad de mujeres:" + CantidadM + " \n");
        }

        private static void MostarH(Empleado[] employeeArray)
        {
            int CantidadH = 0;
            Console.WriteLine("Lista de Hombres");
            for (int i = 0; i < employeeArray.Length; i++)
            {
                if (employeeArray[i].Genero == 'H')
                {
                    CantidadH = CantidadH + 1;
                    Console.WriteLine(employeeArray[i].Nombre + " \t" + employeeArray[i].Apellido);
                }
            }
            Console.WriteLine(" \n" + "La cantidad de hombres:" + CantidadH);
        }

        private static int CalcularEdad(DateTime fecha_de_Nacimiento)
        {
            int edad = DateTime.Now.Year - fecha_de_Nacimiento.Year;
            DateTime nacimientoAhora = fecha_de_Nacimiento.AddYears(edad);

            if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
            {
                --edad;
            }
            return edad;
        }
    }
}
