using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ColleccionKeyBlade : List<Keyblade>
    {
        public string Imprimir()
        {
            string aux = " ";

            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Arma)))
                {
                    aux = aux + ((Arma)item).ObtenerInformacion();
                }
                else if (item.GetType().Equals(typeof(Escudo)))
                {
                    aux = aux + ((Escudo)item).ObtenerInformacion();
                }
            }

            return aux;

        }
        
        public List<Arma> ListaArma()
        {
            List<Arma> arm = new List<Arma>();

            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Arma)))
                {
                    arm.Add((Arma)item);
                }
            }

            return arm;

        }

        public List<Escudo> ListaEscudo()
        {
            List<Escudo> arm = new List<Escudo>();

            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Escudo)))
                {
                    arm.Add((Escudo)item);
                }
            }

            return arm;

        }



    }
}
