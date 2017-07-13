using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Axes : Armas, IArmas
    {

        Hachas tipoHacha;
        DateTime fechaCheckeoArmas;
        int cantidadReparaciones;
        int porcentajeReparacion;


        public Hachas TipoHacha
        {
            get
            {
                return tipoHacha;
            }

            set
            {
                tipoHacha = value;
            }
        }

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

        private void Init()
        {
            tipoHacha = Hachas.NoDescrito;
            fechaCheckeoArmas = DateTime.Now;
            cantidadReparaciones = 0;
            porcentajeReparacion = 0;
        }

        public Axes() { Init(); }
        public Axes(string nom, int canEsp, DateTime fecCre, int Pre, Hachas tipoHacha, DateTime fechaCheckeoArmas, int cantidadReparaciones, int por) : base
            (nom, canEsp, fecCre, Pre)
        {
            TipoHacha = tipoHacha;
            FechaCheckeoArmas = fechaCheckeoArmas;
            CantidadReparaciones = cantidadReparaciones;
            PorcentajeReparacion = por;
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
            sb.AppendLine(string.Format("Tipo Hacha :{0}", TipoHacha));
            sb.AppendLine(string.Format("Fecha Checkeo Hacha :{0}", FechaCheckeoArmas));
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
