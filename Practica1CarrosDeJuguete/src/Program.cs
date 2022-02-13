using Practica1CarrosDeJuguete.src;
using System;
using System.Collections.Generic;

namespace Practica1CarrosDeJuguete
{
    class Program
    {
        static void Main(string[] args)
        {
            int controller = 0;
            do
            {
                System.Console.Clear();
                Componente[] componentes = new Componente[] {
                    new Componente(0,"Motor",400),
                    new Componente(1,"Carrocería", 300),
                    new Componente(2,"llantas", 20),
                    new Componente(3,"Adorno", 30)
                };
                foreach (Componente componente in componentes)
                {
                    Console.WriteLine(componente);
                }
                Empresa p1 = new Empresa();
                List<Componente> pedido = p1.TomarPedido(componentes);

                Proveedor prov = new Proveedor();
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("\n\t Detalle del pedido");
                foreach (Componente componente in pedido)
                {
                    Console.WriteLine("\n" + componente + "CANTIDAD: " + componente.DblCantidad);
                }

                double subTotal = prov.CalcularSubtotal(pedido);
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("El precio parcial antes de promociones es: $" + subTotal);
                double promocion = prov.CalcularPromociones(pedido, subTotal);
                double descuento = prov.CalcularDescuentos(pedido);
                double total = subTotal - promocion - descuento;
                Console.WriteLine("\n\tEl descuento por compra mayor a $20,000.00 es : $" + promocion);
                Console.WriteLine("\n\tEl descuento por compra de piezas mayor a 100 o 500 : $" + descuento);
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("\n\t Costo Total");
                Console.WriteLine("\n\t $" + total);
                int cantidad = p1.Manufactura(pedido);
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("La cantidad posible de cochecitos a ensamblar es: " + cantidad);
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("\n*******************************************************************");
                Console.WriteLine("\n\t Desea realizar otro presupuesto? Ingrese 1");
                controller= int.Parse(Console.ReadLine());
            } while (controller == 1);
        }

       


    }
}
