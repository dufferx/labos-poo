using System;

namespace ejercicio_labo
{
    public class empleado
    {
       //Atributos
       private string nombre;
       private double salario;
       private string modalidad;
       private double iss;
       private double afp;
       private double renta;
       private bool genero;
       private int anioNac;
       // genero si es true, es masculino, si es femenino, false.
       //  Constructores
       public empleado(string pNombre, double pSalario, string pModalidad, bool pGenero, int pAnioNac)
       {
           iss = 0.03;
           afp = 0.07;
           renta = 0.10;
           nombre = pNombre;
           salario = pSalario;
           modalidad = pModalidad;
           genero = pGenero;
           anioNac = pAnioNac;


       }
       
       // Métodos
       public void Empleados()
       {
           Console.WriteLine("\n \nNombre:" + nombre);
           Console.WriteLine("Modalidad:" + modalidad);
           Console.WriteLine("Salario:" + salario);
           Console.WriteLine("Año de nacimiento:" + anioNac);
           
           
       }

       public double calacularDeducciones()
       {
           double descuentoRenta = salario * renta;
           double descuentoAFP = salario * afp;
           double descuentoISS = salario * iss;
           double suma = descuentoRenta + descuentoISS + descuentoAFP;
           double salarioFinal;
           if (modalidad == "Servicio profesional")
           {
               Console.WriteLine("Las deducciones son:" + descuentoRenta);
               salarioFinal = salario - descuentoRenta;
           }
           else
           {

               Console.WriteLine("Las deducciones son:" + suma);
               salarioFinal = salario - suma;
           }
           return salarioFinal;

       }

       public bool calcularRetiro()
       {
           bool apto;
           if (genero == true && anioNac == 1962 || genero == false && anioNac == 1967)
               apto = true;
           else
               apto = false;

                   
           return apto;
       }
       
    }
}