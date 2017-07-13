using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Swords : Armas, IArmas
    {

        Espadas tipoEspada;
        DateTime fechaCheckeoArmas;
        int cantidadReparaciones;
        int porcentajeReparacion;

       

        public DateTime FechaCheckeoArmas
        {
            get
            {
                return fechaCheckeoArmas;
            }

            set
            {
                fechaCheckeoArmas = value;
            }
        }

        public int CantidadReparaciones
        {
            get
            {
                return cantidadReparaciones;
            }

            set
            {
                cantidadReparaciones = value;
            }
        }

        public int PorcentajeReparacion
        {
            get
            {
                return porcentajeReparacion;
            }

            set
            {
                porcentajeReparacion = value;
            }
        }

        public Espadas TipoEspada
        {
            get
            {
                return tipoEspada;
            }

            set
            {
                tipoEspada = value;
            }
        }

        private void Init()
        {
            TipoEspada = Espadas.NoDescrito;
            fechaCheckeoArmas = DateTime.Now;
            cantidadReparaciones = 0;
            porcentajeReparacion = 0;
        }

       public Swords() { Init(); }
        public Swords(string nom, int canEsp, DateTime fecCre, int Pre, Espadas tipoEspada, DateTime fechaCheckeoArmas, int cantidadReparaciones, int porcentajeReparacion):base
            (nom, canEsp, fecCre, Pre)
        {
            TipoEspada = tipoEspada;
            FechaCheckeoArmas = fechaCheckeoArmas;
            CantidadReparaciones = cantidadReparaciones;
            PorcentajeReparacion = porcentajeReparacion;
        }

        public int CalcularEfectividadReparacion()
        {
            if (CantidadReparaciones <= 1)
            {
                CantidadReparaciones = CantidadReparaciones + 1;
                PorcentajeReparacion = 90;
            }
            else if (CantidadReparaciones >= 1 && CantidadReparaciones <= 3)
            {
                CantidadReparaciones = CantidadReparaciones + 1;
                PorcentajeReparacion = 60;
            }
            else if (CantidadReparaciones >= 4 && CantidadReparaciones <= 6)
            {
                CantidadReparaciones = CantidadReparaciones + 1;
                PorcentajeReparacion = 30;
            }
            else if (CantidadReparaciones >= 7)
            {
                CantidadReparaciones = CantidadReparaciones + 1;
                PorcentajeReparacion = 15;
            }
            return PorcentajeReparacion;

        }

        public new string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("Tipo Espada :{0}", TipoEspada));
            sb.AppendLine(string.Format("Fecha Checkeo Espada :{0}", FechaCheckeoArmas));
            sb.AppendLine(string.Format("Cantidad De Reparaciones :{0}", CantidadReparaciones));
            sb.AppendLine(string.Format("Porcenje Efectividad Reparacion :{0}%", PorcentajeReparacion));
            return sb.ToString();
        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }

    }
}
