using System;

namespace ejercicio_labo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            empleado empleado01 = new empleado("Fernando Pineda", 500, "Servicio profesional", true, 1962);
            
            empleado01.Empleados();
            Console.Write(empleado01.calacularDeducciones());
            Console. WriteLine(": salario final.");
            if (empleado01.calcularRetiro())
            {
                Console.WriteLine("El empleado es apto para retirar");
            }
            else
            {
                Console.WriteLine("El empleado no es apto para retirar");
            }
            
            empleado empleado02 = new empleado("Sofia Paredes", 700, "Planilla", false, 1968);
            
            empleado02.Empleados();
            Console.Write(empleado02.calacularDeducciones());
            Console. WriteLine(": salario final.");
            if (empleado02.calcularRetiro())
            {
                Console.WriteLine("El empleado es apto para retirar");
            }
            else
            {
                Console.WriteLine("El empleado no es apto para retirar");
            }
            
            
        }
    }
}