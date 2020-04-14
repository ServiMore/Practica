using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione el ejercicio que desea ejecutar.");
                Console.WriteLine("1. Leer un número entero y determinar si tiene 3 dígitos.");
                Console.WriteLine("2. Leer un número entero y determinar si es negativo.");
                Console.WriteLine("3. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.");
                Console.WriteLine("4. Resolver la ecuación a*x + b = 0.");
                Console.WriteLine("5. programa que calcule el desglose de una cantidad en billetes y monedas en cordobas tal que se minimice la cantidad de monedas y billetes.");
                Console.WriteLine("0. salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;

                    case 2:
                        Ejercicio2();
                        break;

                    case 3:
                        Ejercicio3();
                        break;

                    case 4:
                        Ejercicio4();
                        break;

                    case 5:
                        Ejercicio5();
                        break;

                }

            } while (opcion != 0);
        }

        private static void Ejercicio1()
        {
            Console.WriteLine("Ingrese el numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 999 && numero >= 100)
            {
                Console.WriteLine("Este numero tiene 3 digitos");
            }
            else
            {
                Console.WriteLine("Este numero no contiene 3 digitos");
            }

            Console.ReadKey();

        }

        private static void Ejercicio2()
        {
            Console.WriteLine("Ingrese el numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Este numero es negativo " + numero);
            }
            else
            {
                Console.WriteLine("Este numero no es negativo");
            }

            Console.ReadKey();
        }

        private static void Ejercicio3()
        {
            int total;
            Console.WriteLine("Ingrese el primer numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            total = numero1 + numero2;
            if (numero1 <= 99 && numero1 >= 10)
            {
                if (numero2 <= 99 && numero2 >= 10)
                {
                    if (total % 2 == 0)
                    {
                        Console.WriteLine("El numero es par");
                    }
                    else
                    {
                        Console.WriteLine("El numero no es par");
                    }
                }
            }
            else
            {
                Console.WriteLine("Necesita ingresar un numero de dos digitos");
            }
            Console.ReadKey();
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("Ingrese A");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese B");
            int b = Convert.ToInt32(Console.ReadLine());

            double respuesta = (b * -1) / a;
            Console.WriteLine("El resultado de AX+B=0 es: " + respuesta);
        }

        private static void Ejercicio5()
        {

        }
    }
}


           
