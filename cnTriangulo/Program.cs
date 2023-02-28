using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTriangulo
{/// <summary>
/// Nombre: Laura Serena Rivera Mejía
/// Fecha: 24-02-2023
/// Descripcin: Este programa evalúa los lados de un triangúlo, determina que lado es mayor
/// y si es equilatero o no.
/// </summary>
    internal class ClsTriangulo
    {   
        //Declaración de variables
        int Lado1, Lado2, Lado3;

        static void Main(string[] args)
        {
            //Se crea un objeto de la Clase Triangulo
            ClsTriangulo oTriangulo = new ClsTriangulo();
            //Se llaman los métodos a partir del objeto triangulo
            oTriangulo.SolicitarDatos();
            oTriangulo.LadoMayor();
            oTriangulo.Equilatero();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();
        }

        //Método 1
        public void SolicitarDatos()
        {
            Console.WriteLine("Ingrese el lado 1");
            Lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2");
            Lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3");
            Lado3 = int.Parse(Console.ReadLine());
        }

        //Método 2
        public void LadoMayor()
        {
            //Ciclo lógico 1
            if (Lado1 > Lado2 & Lado1 > Lado3)
            {
                Console.WriteLine("El lado mayor es " + Lado1);
            }
            else if (Lado2 > Lado1 & Lado2 > Lado3)
            {
                Console.WriteLine("El lado mayor es " + Lado2);
            }
            else if (Lado3 > Lado1 & Lado3 > Lado2)
            {
                Console.WriteLine("El lado mayor es " + Lado3);
            }
            else
            {
                Console.WriteLine("No hay lados mayores y/o uno es igual a otro.");
            }


        }

        //Método 3
        public void Equilatero()
        {
            //Ciclo lógico 2
            if (Lado1 != Lado2 & Lado2 != Lado3)
            {
                Console.WriteLine("El triangulo no es equilatero");
            }
            else if (Lado1 ==Lado2 & Lado2 ==Lado3 )
            {
                Console.WriteLine("El triangulo es equilatero");
            }
           

        }


    }   
    


}
