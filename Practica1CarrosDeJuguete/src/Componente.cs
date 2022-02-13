using System;


namespace Practica1CarrosDeJuguete.src
{
    class Componente
    {
        private int intClave;
        private string strNombre;
        private double dblPrecio;
        private double dblCantidad;

        public int Clave { set => intClave = value; get => intClave; }
        public string Nombre { get => strNombre; set => strNombre = value; }
        public double Precio { get => dblPrecio; set => dblPrecio = value; }
        public double DblCantidad { get => dblCantidad; set => dblCantidad = value; }

        public Componente( int intClave, string strNombre, double dblPrecio)
        {
            this.intClave = intClave;
            this.strNombre = strNombre;
            this.dblPrecio = dblPrecio;

        }
        public Componente(Componente componente, double cantidad)
        {
            this.intClave = componente.Clave;
            this.strNombre = componente.Nombre;
            this.dblPrecio = componente.Precio;
            this.dblCantidad = cantidad;

        }
        public override string ToString()
        {
            return string.Format("El componente es: {0}, con clave: {1}, con un precio de ${2}\n",strNombre, intClave, dblPrecio);
        }
    }
}
