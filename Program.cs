using CalculoAreas.Models;
using System;
using System.Reflection.Metadata;

namespace CalculoAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool consultaArea = true;
            while(consultaArea)
            {
                Console.WriteLine("Benvenido. Esta aplicación le permite calcular el área de las figuaras geométricas");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("Escoja una opción:");
                string option = Console.ReadLine();
                double area;
                if(option == "1")
                {
                    Console.WriteLine("Ha elegido el cálculo del área de un Círculo");
                    Console.WriteLine("Por favor ingrese el radio:");
                    try
                    {
                        Circulo circulo = new Circulo();
                        circulo.radio = Convert.ToDouble(Console.ReadLine());                        
                        Console.WriteLine("El area es: ");
                        Console.WriteLine(circulo.calcularArea());
                    }
                    catch
                    {
                        Console.WriteLine("Debe digitar un numero para el radio del Círculo");
                    }
                    
                }
                else
                if (option == "2")
                {
                   
                        Console.WriteLine("Ha elegido el cálculo del área de un Rectangulo");
                        Console.WriteLine("Por favor ingrese la base:");
                    try
                    {
                        Rectangulo rectangulo = new Rectangulo();
                        rectangulo.baseR = Convert.ToInt32(Console.ReadLine());                        
                        Console.WriteLine("Por favor ingrese la altura:");
                        rectangulo.altura = Convert.ToInt32(Console.ReadLine());                        
                        Console.WriteLine("El area es: ");
                        Console.WriteLine(rectangulo.calcularArea());
                    }
                    catch
                    {
                        Console.WriteLine("Debe digitar valores numericos para la base y la altura del Rectángulo");

                    }
                }
                else
                {
                    Console.WriteLine("Digite una opción válida");
                }                
                Console.WriteLine("Digite S o SI para un nuevo calculo:");
                string consulta = Console.ReadLine();
                if (consulta.ToUpper() == "S" || consulta.ToUpper() == "SI")
                    consultaArea = true;
                else
                    consultaArea = false;
                     
            }
        }
    }
}
