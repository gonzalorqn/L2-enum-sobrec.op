using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._marca = "Sin Marca";
            this._cantidad = 0;
            this._marca = null;
        }

        public Pluma(string marca) :this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cant) :this(marca)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, int cant, Tinta tinta):this(marca,cant)
        {
            this._tinta = tinta;
        }

        private string Mostrar()
        {
            return "Marca: " + this._marca + " - Cantidad: " + this._cantidad.ToString() + " - " + Tinta.Mostrar(this._tinta);
        }

        public static bool operator ==(Pluma p1,Tinta t1)
        {
            return p1._tinta == t1;
        }

        public static bool operator !=(Pluma p1, Tinta t1)
        {
            return !(p1 == t1);
        }

        public static implicit operator string(Pluma p1)
        {
            return p1.Mostrar();
        }

        public static Pluma operator +(Pluma p1,Tinta t1)
        {
            if(p1 == t1 && p1._cantidad < 100)
            {
                p1._cantidad += 10;
                if (p1._cantidad > 100)
                    p1._cantidad = 100;
            }
            return p1;
        }
    }
}
