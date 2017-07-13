using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Armas
    {
        string nombreArma;
        int cantidadArma;
        DateTime fechaCreacion;
        int precio;

       

        public string NombreArma
        {
            get
            {
                return nombreArma;
            }

            set
            {
                nombreArma = value;
            }
        }

        public int CantidadArma
        {
            get
            {
                return cantidadArma;
            }

            set
            {
                cantidadArma = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        private void Init()
        {
            nombreArma = string.Empty;
            cantidadArma = 0;
            fechaCreacion = DateTime.Now;
            precio = 0;

        }

        public Armas() { Init(); }

        public Armas(string nombreArma, int cantidadArma, DateTime fechaCreacion, int precio)
        {
            NombreArma = nombreArma;
            CantidadArma = cantidadArma;
            FechaCreacion = fechaCreacion;
            Precio = precio;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre Arma :{0}",NombreArma));
            sb.AppendLine(string.Format("Cantidad Armas :{0}",CantidadArma));
            sb.AppendLine(string.Format("Fecha de Creacion de la Arma :{0}",FechaCreacion));
            sb.AppendLine(string.Format("Precio Arma :{0}", Precio));
            return sb.ToString();
        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }
    }
}
