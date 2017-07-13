using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CollecionArmas : List<Armas>
    {
      public string Imprimir()
        {
            string aux = " ";

            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Swords)))
                {
                    aux = aux + ((Swords)item).ObtenerInformacion(); 
                }
                else if (item.GetType().Equals(typeof(Axes)))
                {
                    aux = aux + ((Axes)item).ObtenerInformacion();
                }
            }
            return aux;

        }
        
            public List<Swords> ListaEsp()
            {
            List<Swords> esp = new List<Swords>();

               foreach (var item in this)
               {
                if (item.GetType().Equals(typeof(Swords)))
                {
                    esp.Add((Swords)item);
                }

               }
            return esp;
            }
        
        public List<Axes> ListaAxe()
        {
            List<Axes> axe = new List<Axes>();
            foreach (var item in this)
            {
                if (item.GetType().Equals(typeof(Axes)))
                {
                    axe.Add((Axes)item);
                }
            }
            return axe;
        }   
    
    }
}
