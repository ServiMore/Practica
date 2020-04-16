using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico
{
    class Program
    {
        static void Main(string[] args)
        {
            //calcualr el precio usuario tiene que indicar el ancho y el largo en cm, calcular cual es el precio final asumiendo que el precio es de 8 cordobas por cm2.
            Console.WriteLine("Ingrese el largo que desea tener la pintura en centimetros");
            double largo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho que desea tener la pintura  en centimetros");
            double ancho = Convert.ToDouble(Console.ReadLine());


            double precioFinal = largo * ancho * 8 ;

            Console.WriteLine("El precio de la pintura es: {0}", precioFinal);
            Console.ReadKey();


        }
       
        private static void PrecioPintura() 
        {
            //el usuario va a poner la medida xs(muy pequeno) s(pequeno) m(medio) l(largo) xl(muy largo), 10xs, 20s, 30m, 40l, 50xl. va a poner cuantas pinturas quiere, mostrar el precio final, luego preguntar si dare descuento. tiene que ingresar el descuento y volver a calcular el resultado.

            int xs = 10;
            int s = 20;
            int m = 30;
            int l = 40;
            int xl = 50;

            Console.WriteLine("Que medida de pintura quiere?: 1-XS 2-S 3-M 4-L 5-XL");
            int tipo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantas pinturas de ese tipo desea?");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double precioFinal= 0;

            if (tipo == 1)
            {
                precioFinal = xs * cantidad;
            
            }

            else if (tipo == 2)
            {
                precioFinal = s * cantidad;
            }

            else if (tipo == 3)
            {
                precioFinal = m * cantidad;
            }

            else if (tipo == 4)
            {
                precioFinal = l * cantidad;
            }

            else if (tipo == 5)
            {
                precioFinal = xl * cantidad;
            }

            else
            {
                Console.WriteLine("ingrese un numero por favor");
            }

            Console.WriteLine("El precio de la pintura es: {0}, desea agregar descuento? 1-si, 2-no", precioFinal);
            int respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine("De cuanto es el descuento que desea? 1-25%  2-50%  3-75% ");
                double descuento = Convert.ToDouble(Console.ReadLine());

                if (descuento == 1)
                {
                    descuento = 0.25;
                }

                else if(descuento == 2)
                {
                    descuento = 0.50;
                }

                else if (descuento == 3)
                {
                    descuento = 0.75;
                }

                else
                {
                    Console.WriteLine("seleccione un descuento");
                }

                descuento = Convert.ToDouble(descuento * precioFinal);
                precioFinal = precioFinal - descuento;

                Console.WriteLine("El precio de la pintura con descuento aplicado es de: {0}", precioFinal);

            }
            else
            {
                Console.WriteLine("El precio de la pintura es: {0}", precioFinal);
            }
           


        }

    }
}
