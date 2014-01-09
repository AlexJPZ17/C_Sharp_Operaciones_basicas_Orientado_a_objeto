using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_basicas_P.O.O
{
    class Operaciones
    {
        //Métodos con las siguientes operaciones suma, resta multiplicación, división
        public double Suma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        public double Resta(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public double Multiplicacion(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        public double Division(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
    }
    class Program
    {
        public static void Opciones()
        {
            //Declaramos las variables
            double numero1, numero2;
            int operacion;
            string repetir = "";
            //Instrucción  do while
            do
            {
                //Mensjes con las siguientes opciones
                    Console.WriteLine("Que tipo de operación desea realizar");
                    Console.WriteLine("1 - Suma");
                    Console.WriteLine("2 - Resta");
                    Console.WriteLine("3 - Multiplicación");
                    Console.WriteLine("4 - División");
                   //capturamos el valor de la opción
                operacion = Convert.ToInt32(Console.ReadLine());
                //Mostramos los menajes y capturamos los números
                Console.WriteLine("Ingrese el primer número");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                numero2 = Convert.ToDouble(Console.ReadLine());
                //instanciamos la clase Operaciones
                Operaciones op = new Operaciones();
                //switch que evalúa la variable operación
                switch(operacion)
                {
                    case 1:
                        //Mostramos el mensaje con la operación seleccionada
                        Console.WriteLine("La suma de los números es: " + op.Suma(numero1, numero2));
                        break;
                   case 2:
                        //Mostramos el mensaje con la operación seleccionada
                        Console.WriteLine("La resta de los números es: " + op.Resta(numero1, numero2));
                        break;
                   case 3:
                        //Mostramos el mensaje con la operación seleccionada
                        Console.WriteLine("La multiplicación de los números es: " + op.Multiplicacion(numero1, numero2));
                        break;
                    case 4:
                        //Mostramos el mensaje con la operación seleccionada
                        Console.WriteLine("La división de los números es: " + op.Division(numero1, numero2));
                        break;
                    default:
                        Console.WriteLine("La operación no existe");
                        break;

                }
                //Mensaje que pregunta si desea repetir 
                Console.WriteLine("Desea repetir la operación coloque la tetra S");
                    repetir = Console.ReadLine();

            }while(repetir == "s");
        }
        static void Main(string[] args)
        {
            Opciones();
        }
    }
}
