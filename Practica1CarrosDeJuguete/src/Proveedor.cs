using System;
using System.Collections.Generic;

namespace Practica1CarrosDeJuguete.src
{
    class Proveedor
    {
        public double CalcularSubtotal(List<Componente> pedido) {
            double subTotal = 0;
            
            foreach (Componente c in pedido)
            {
                subTotal += c.DblCantidad * c.Precio;
            }
            return subTotal;
        }

        public double CalcularPromociones(List<Componente> pedido, double subTotal)
        {
            double promociones = 0;
            if (subTotal > 20000) {
                foreach (Componente c in pedido) {
                    if (c.Clave == 2 || c.Clave == 3)
                    {
                        int p = (int)(c.DblCantidad * 0.666666666);
                        int pDescuento = (int)(c.DblCantidad - p -1);
                        Console.WriteLine("\n\t***********Se han descontado: " + pDescuento + " piezas del producto: "+ c.Nombre+"; promoción de 3x2***********");
                   
                            
                        promociones = (p * c.Precio);
                    }
                }
            }
            return promociones;
        }

        public double CalcularDescuentos(List<Componente> pedido) {
            double descuento = 0;
            double porcentaje;
            foreach (Componente c in pedido) {
                
                if (c.DblCantidad >= 500 && c.Clave == 1 || c.DblCantidad >= 500 && c.Clave == 0)
                {
                    porcentaje = 0.1;
                    double descuentoParcial = porcentaje * c.DblCantidad * c.Precio;
                    descuento += descuentoParcial;
                    Console.WriteLine("\nSe ha aplicado un descuento del 10%, que equivale a : $"+descuentoParcial);
                }
                else if (c.DblCantidad >= 100 && c.Clave == 1 || c.DblCantidad >= 100 && c.Clave == 0) {
                    porcentaje = 0.05;
                    double descuentoParcial = porcentaje * c.DblCantidad * c.Precio;
                    descuento += descuentoParcial;
                    Console.WriteLine("\nSe ha aplicado un descuento del 5%, que equivale a : $" + descuentoParcial);
                }
            }
                return descuento;
        }

    }
}
