using System;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Ejercicios
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
                Console.WriteLine("1. Operaciones matematicas.");
                Console.WriteLine("2. Comparacion de numeros");
                Console.WriteLine("3. Comparacion de numeros avanzado");
                Console.WriteLine("4. porcentajes");
                Console.WriteLine("5. descuento e importe");
                Console.WriteLine("6. cuadrado de los numeros naturales");
                Console.WriteLine("7. area de una circunferencia");
                Console.WriteLine("8. promedio de notas");
                Console.WriteLine("9. asignaturas aprobadas y reprobadas");
                Console.WriteLine("10. descuento a otorgar");
                Console.WriteLine("11. encontrar el varlo de la hipotenusa");
                Console.WriteLine("12.  ");
                Console.WriteLine("13.  ");
                Console.WriteLine("14.  ");
                Console.WriteLine("15.  ");
                Console.WriteLine("16. Leer número entero y determinar si tiene 3 dígitos.");
                Console.WriteLine("17. Leer un número entero y determinar si es negativo.");
                Console.WriteLine("18. Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.");
                Console.WriteLine("19. Resolver la ecuación a*x + b = 0.");
                Console.WriteLine("20. pregunte al usuario su edad y muestre por pantalla si es mayor de edad o no.");
                Console.WriteLine("21. que pregunte al usuario su edad y sus ingresos mensuales y muestre por pantalla si el usuario tiene que tributar o no.");
                Console.WriteLine("22. pregunte al usuario su renta anual y muestre por pantalla el tipo impositivo que le corresponde.");
                Console.WriteLine("23. pida al usuario una palabra y la muestre por pantalla 10 veces.");
                Console.WriteLine("24. programa que muestre por pantalla la tabla de multiplicar del 1 al 10.");
                Console.WriteLine("25. almacenar la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña hasta que introduzca la contraseña correcta.");
                Console.WriteLine("26. programa que pregunte el nombre del usuario en la consola y después de que el usuario lo introduzca muestre por pantalla la cadena ¡Hola <nombre>!");
                Console.WriteLine("27. Escribir un programa que pregunte el nombre del usuario en la consola y después de que el usuario lo introduzca muestre por pantalla <NOMBRE> tiene <n> letras");
                Console.WriteLine("28. Escribir un programa que pregunte al usuario por el número de horas trabajadas y el coste por hora. Después debe mostrar por pantalla la paga que le corresponde.");
                Console.WriteLine("29. programa que pida al usuario su peso (en kg) y estatura (en metros), calcule el índice de masa corporal y lo almacene en una variable, luego mostrarlo");
                Console.WriteLine("30. Ejercicio # 17 ");


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

                    case 6:
                        Ejercicio6();
                        break;

                    case 7:
                        Ejercicio7();
                        break;

                    case 8:
                        Ejercicio8();
                        break;

                    case 9:
                        Ejercicio9();
                        break;

                    case 10:
                        Ejercicio10();
                        break;

                    case 11:
                        Ejercicio11();
                        break;

                    case 12:
                        Ejercicio12();
                        break;

                    case 13:
                        Ejercicio13();
                        break;

                    case 14:
                        Ejercicio14();
                        break;

                    case 15:
                        Ejercicio15();
                        break;

                    case 16:
                        Ejercicio16();
                        break;

                    case 17:
                        Ejercicio17();
                        break;

                    case 18:
                        Ejercicio18();
                        break;

                    case 19:
                        Ejercicio19();
                        break;

                    case 20:
                        Ejercicio20();
                        break;

                    case 21:
                        Ejercicio21();
                        break;

                    case 22:
                        Ejercicio22();
                        break;
                    
                    case 23:
                        Ejercicio23();
                        break;

                    case 24:
                        Ejercicio24();
                        break;

                    case 25:
                        Ejercicio25();
                        break;

                    case 26:
                        Ejercicio26();
                        break;

                    case 27:
                        Ejercicio27();
                        break;

                    case 28:
                        Ejercicio28();
                        break;

                    case 29:
                        Ejercicio29();
                        break;
                   
                    case 30:
                        Ejercicio30();
                        break;
                }

            } while (opcion != 0);
        }
        private static void Ejercicio1()
        {
            Console.WriteLine("ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = numero1 + numero2;
            Console.WriteLine("La suma de los numeros es: " + suma);

            int resta = numero1 - numero2;
            Console.WriteLine("La resta de los numeros es: " + resta);

            int producto = numero1 * numero2;
            Console.WriteLine("El producto de los numeros es: " + producto);

            double division = (double)numero1 / numero2;
            Console.WriteLine("La division de los numeros es: " + division);

            Console.ReadKey();
        }

        private static void Ejercicio2()
        {
            Console.WriteLine("ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es: " + numero1);
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + numero2);
            }

            Console.ReadKey();


        }

        private static void Ejercicio3()
        {
            Console.WriteLine("ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("el mayor es: " + numero1);
            }
            else if (numero2 > numero3)
            {
                Console.WriteLine("El mayor es: " + numero2);
            }
            else
            {
                Console.WriteLine("El mayor es: " + numero3);
            }

            Console.ReadKey();
        }

        private static void Ejercicio4()
        {
            Console.WriteLine("ingrese la cantidad de ninos");
            int cantidad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de ninas");
            int cantidad2 = Convert.ToInt32(Console.ReadLine());

            var total = cantidad1 + cantidad2;
            var porcentaje1 = cantidad1 * 100 / total;
            var porcentaje2 = cantidad2 * 100 / total;

            Console.WriteLine("El porcentaje de ninos es: " + porcentaje1);
            Console.WriteLine("El porcentaje de ninas es: " + porcentaje2);

            Console.ReadKey();

        }

        private static void Ejercicio5()
        {
            double pagar;
            double descuento;

            Console.WriteLine("ingrese el importe");
            double importe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el mes");
            int mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 10)
            {
                descuento = importe * 0.15;
                pagar = importe - descuento;
            }
            else
            {
                pagar = importe;
            }

            Console.WriteLine("usted debe pagar: " + pagar);

            Console.ReadLine();
        }


        private static void Ejercicio6()
        {
            Console.WriteLine("introduzca un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("El numero es 0");
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El nummero es impar");
            }

            Console.ReadKey();
        }

        private static void Ejercicio7()
        {
            double radio;
            double area;

            Console.WriteLine("ingrese el diametro");
            double diametro = Convert.ToInt32(Console.ReadLine());

            radio = diametro / 2;
            double v = (Math.PI * Math.Pow(radio, 2));
            area = v;

            Console.WriteLine("El area de la circunferencia es: " + area);

            Console.ReadKey();

        }

        private static void Ejercicio8()
        {
            double suma = 0;
            double promedio;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("ingrese la nota #" + i);
                suma += Convert.ToInt32(Console.ReadLine());
            }

            promedio = suma / 7;
            if (promedio < 60)
            {
                Console.WriteLine("deficiente");
            }
            else if (promedio >= 60 && promedio < 90)
            {
                Console.WriteLine("normal");
            }
            else
            {
                Console.WriteLine("sobresaliente");
            }
            Console.ReadKey();
        }

        private static void Ejercicio9()
        {
            int aprobados = 0;
            int reprobados = 0;

            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine("ingrese sus notas");
                int nota = Convert.ToInt32(Console.ReadLine());
                if (nota >= 60)
                {
                    aprobados += 1;
                }
                else
                {
                    reprobados += 1;
                }
            }
            Console.WriteLine("aprobaste: " + aprobados);
            Console.WriteLine("reprobaste: " + reprobados);

            Console.ReadKey();
        }

        private static void Ejercicio10()
        {
            Console.WriteLine("ingrese el precio original");
            double precioOriginal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el precio pagado");
            double precioPagado = Convert.ToInt32(Console.ReadLine());

            double descuento = precioOriginal - precioPagado;
            double porcentaje = descuento * 100 / precioOriginal;

            Console.WriteLine("el descuento otorgado es de: " + porcentaje);

            Console.ReadKey();
        }

        private static void Ejercicio11()
        {
            double hipotenusa;

            Console.WriteLine("ingrese el primer cateto");
            double cateto1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo cateto ");
            double cateto2 = Convert.ToInt32(Console.ReadLine());

            hipotenusa = (Math.Pow(cateto1, 2)) + (cateto2 * cateto2);
            hipotenusa = Math.Sqrt(hipotenusa);

            Console.WriteLine("el valor de la hipotenusa es: " + hipotenusa);
            Console.ReadKey();
        }

        private static void Ejercicio12()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("El cuadrado de " + i + " es:" + i * i);
            }
            Console.ReadKey();
        }

        private static void Ejercicio13()
        {
            int numero;
            int conteo = 0;
            double suma = 0;
            double promedio = 0;

            do
            {
                Console.WriteLine("Ingrese el numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero != -1)
                {
                    suma += numero;
                    conteo += 1;
                }
            } while (numero != -1);

            promedio = suma / conteo;
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }

        private static void Ejercicio14()
        {
            int cantidad;
            Console.WriteLine("Ingrese el numero: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int fila = 1; fila <= cantidad; fila++)
            {
                Console.WriteLine("");

                for (int columna = 1; columna <= cantidad; columna++)
                {
                    if (fila == 1 || fila == cantidad)
                    {
                        Console.Write("*");
                    }
                    else if (columna == 1 || columna == cantidad)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }
            Console.ReadKey();
        }

        private static void Ejercicio15()
        {
            Console.WriteLine("Ingrese a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double denominador = 2 * a;
            double bCuadrado = b * b;
            double menosB = b * -1;
            double cuatroAC = 4 * a * c;
            double raiz = Math.Sqrt(bCuadrado - cuatroAC);
            double positivo = (menosB + raiz) / denominador;
            double negativo = (menosB - raiz) / denominador;

            Console.WriteLine("La raiz 1 es: " + positivo);
            Console.WriteLine("La raiz 2 es: " + negativo);

            Console.ReadKey();
        }

        private static void Ejercicio16()
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

        private static void Ejercicio17()
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

        private static void Ejercicio18()
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

        private static void Ejercicio19()
        {
            Console.WriteLine("Ingrese A");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese B");
            int b = Convert.ToInt32(Console.ReadLine());

            double respuesta = (b * -1) / a;
            Console.WriteLine("El resultado de AX+B=0 es: " + respuesta);
        }
        private static void Ejercicio20()
        {
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("usted es menor de edad");
            }
            else
            {
                Console.WriteLine("usted es mayor de edad");
            }
            Console.ReadKey();
        }

        private static void Ejercicio21()
        {
            Console.WriteLine("cual es tu edad?");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De cuanto es tu ingreso mensual?");
            int ingresos = Convert.ToInt32(Console.ReadLine());

            if (edad > 16 && ingresos >= 1000)
            {
                Console.WriteLine("tienes que pagar impuestos");
            }
            else
            {
                Console.WriteLine("no tienes que pagar impuestos");
            }
            Console.ReadKey();
        }

        private static void Ejercicio22()
        {
            int impositivo = 0;

            Console.WriteLine("cual es tu renta anual?");
            int renta = Convert.ToInt32(Console.ReadLine());

            if (renta < 10000)
            {
                impositivo = 5;
            }
            else if (renta > 10000 && renta < 20000)
            {
               impositivo = 15;
            }

            else if (renta > 20000 && renta < 35000)
            {
                impositivo = 20;
            }

            else if (renta > 35000 && renta < 60000)
            {
                impositivo = 30;
            }

            else
            {
                impositivo = 40;
            }

            Console.WriteLine("tu impositivo es: " + impositivo + "%");
            Console.ReadKey();
        }

        private static void Ejercicio23()
        {
            Console.WriteLine("ingrese la palabra");
            string palabra = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
        
        private static void Ejercicio24()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int o = 1; o < 11; o++)
                {
                    Console.WriteLine(i * o);
                }
            }
            Console.ReadKey();
        }
        
        private static void Ejercicio25()
        {
            string clave = "contraseña";
            string clave2 = "";

            while (clave2 != clave)
            {
                Console.WriteLine("ingrese la contraseña");
                clave2 = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("la contraseña es correcta");
            Console.ReadKey();
        }
        
        private static void Ejercicio26()
        {
            Console.WriteLine("ingrese su nombre");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hola {0}!", nombre);
            Console.ReadKey();
        }

        private static void Ejercicio27()
        {
            Console.WriteLine("ingrese su nombre");
            string nombre = Convert.ToString(Console.ReadLine());
            int largo = nombre.Length;
            int contar = 0;

            for (int i = 0; i < largo; i++)
            {
               contar += 1;
            }
            Console.WriteLine("{0} tiene {1} letras", nombre, contar);
            Console.ReadKey();
        }

        private static void Ejercicio28()
        {
            Console.WriteLine("ingrese sus horas de trabajo");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el coste por hora");
            int costo = Convert.ToInt32(Console.ReadLine());

            int pago = horas * costo;

            Console.WriteLine("tu paga es de: {0}$", pago);
            Console.ReadKey();
        }
    
        private static void Ejercicio29()
        {
            Console.WriteLine("ingrese su peso en kg");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese estatura en metros");
            double altura = Convert.ToDouble(Console.ReadLine());

            double masa = Math.Floor(peso) /Math.Floor(altura) * 2.2;

            Console.WriteLine("tu indice de masa corporal es {0}", masa);
            Console.ReadKey();
        }
    
        private static void Ejercicio30()
        {
            Console.WriteLine("ingrese la inversion inicial");
            double inversion = Convert.ToDouble(Console.ReadLine());

            double interes = 0.04;

            double ahorro1 = Math.Floor(inversion) * (1 + interes);
            double ahorro2 = Math.Floor(ahorro1) * (1 + interes);
            double ahorro3 = Math.Floor(ahorro2) * (1 + interes);

            Console.WriteLine("ahorro tras primer año {0}", ahorro1);
            Console.WriteLine("ahorro tras segundo año {0}", ahorro2);
            Console.WriteLine("ahorro tras tercer año {0}", ahorro3);
            Console.ReadKey();

        }
    
        private static void Ejercicio31()
        {

        }
    }
}
    

 
