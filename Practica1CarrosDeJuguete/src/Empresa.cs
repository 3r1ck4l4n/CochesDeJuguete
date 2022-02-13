using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1CarrosDeJuguete.src
{
    class Empresa
    {
    
        public List<Componente> TomarPedido(Componente[] componentes)
        {
            int ctrl;
            List<Componente> pedido = new List<Componente>();

            do
            {
                Console.WriteLine("Ingrese la clave que corresponda al componente que desea comprar:\n");
                int opt = int.Parse(Console.ReadLine());
                
                if (opt < 4 && opt >= 0)
                {
                    Console.WriteLine("Ingrese la cantidad que desea comprar:\n");
                    double cant = double.Parse(Console.ReadLine());
                    Componente c = new Componente(componentes[opt],cant);
                    pedido.Add(c);
                    foreach (Componente comp in pedido)
                    {
                        Console.WriteLine(comp.DblCantidad);
                    }

                    Console.WriteLine("\n\n\t Desea ingresar otro producto? \n \t\t Escribe 1 \n\t de lo conjtrario ingresa cualquier otro valor.");
                    ctrl = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese un valor valido");
                    ctrl = 1;
                }

            } while (ctrl == 1);

            return pedido;
        }

        public int Manufactura(List<Componente> inventario) {
            int cantidad;
            int clave;
            int numMotor = 0;
            int numCarroceria = 0;
            int numLlantas = 0;
            int numAdorno = 0;
            foreach (Componente c in inventario)
            {
                clave = c.Clave;
                switch (clave)
                {
                    case 0: numMotor += (int)c.DblCantidad;
                        break;
                    case 1: numCarroceria += (int)c.DblCantidad;
                        break;
                    case 2: numLlantas += (int)c.DblCantidad;
                        break;
                    case 3: numAdorno += (int)c.DblCantidad;
                        break;
                    default:break;

                }
            }

            numLlantas = numLlantas / 4;
            numAdorno = numAdorno / 2;

            if (numAdorno <= numLlantas && numMotor <= numCarroceria)
            {
                if (numAdorno <= numMotor)
                {
                    cantidad = numAdorno;
                }
                else cantidad = numMotor;
            }
            else if (numLlantas <= numCarroceria)
            {
                cantidad = numLlantas;
            }
            else cantidad = numCarroceria;

            return cantidad;
        }

    }
}
