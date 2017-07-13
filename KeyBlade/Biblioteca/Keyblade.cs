using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Keyblade
    {
        string name;
        int large;
        int pointDamage;
        int pointMagic;
        int pointDef;
        string description;

       

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Large
        {
            get
            {
                return large;
            }

            set
            {
                large = value;
            }
        }

        public int PointDamage
        {
            get
            {
                return pointDamage;
            }

            set
            {
                pointDamage = value;
            }
        }

        public int PointMagic
        {
            get
            {
                return pointMagic;
            }

            set
            {
                pointMagic = value;
            }
        }

        public int PointDef
        {
            get
            {
                return pointDef;
            }

            set
            {
                pointDef = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        private void Init()
        {
            name = string.Empty;
            large = 0;
            pointDamage = 0;
            pointMagic = 0;
            pointDef = 0;
            description = string.Empty;

        }
        
        public Keyblade() { Init();  }

        public Keyblade(string name, int large, int pointDamage, int pointMagic, int pointDef, string description)
        {
            Name = name;
            Large = large;
            PointDamage = pointDamage;
            PointMagic = pointMagic;
            PointDef = pointDef;
            Description = description;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre :{0}" ,Name));
            sb.AppendLine(string.Format("Largo :{0} cm", Large));
            sb.AppendLine(string.Format("Puntos de Daño Fisico :{0}", PointDamage));
            sb.AppendLine(string.Format("Puntos de Daño Magico :{0}", PointMagic));
            sb.AppendLine(string.Format("Puntos De defensa :{0}", PointDef));
            sb.AppendLine(string.Format("Descripcion Habilidad :{0}", Description));
            return sb.ToString();

        }

        public override string ToString()
        {
            return ObtenerInformacion();
        }
    }
}
