using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta() : this(ConsoleColor.Black)
        {
            
        }

        public Tinta(ConsoleColor color) : this(color, ETipoTinta.Comun)
        {
           
        }

        public Tinta(ConsoleColor color, ETipoTinta tinta)
        {
            this._color = color;
            this._tipoTinta = tinta;
        }

        private string Mostrar()
        {
            return "Color: " + this._color.ToString() + " - Tipo: " + this._tipoTinta.ToString();
        }

        public static string Mostrar(Tinta a)
        {
            return a.Mostrar();
        }

        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool retorno = false;
            if (t1._color == t2._color && t1._tipoTinta == t2._tipoTinta)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }
    }
}
