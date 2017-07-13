using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IArmas
    {
        DateTime FechaCheckeoArmas { get; set; }
        int CalcularEfectividadReparacion();

    }
}
