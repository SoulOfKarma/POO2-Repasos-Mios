using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Arma : Keyblade,IKeyBlade
    {
        TypeKeyBlade type;
        Element elem;
        int maxDmg;

        public TypeKeyBlade Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Element Elem
        {
            get
            {
                return elem;
            }

            set
            {
                elem = value;
            }
        }

        public int MaxDmg
        {
            get
            {
                return maxDmg;
            }

            set
            {
                maxDmg = value;
            }
        }

        private void Init()
        {
            type = TypeKeyBlade.NotInformed;
            elem = Element.NotInformed;
            maxDmg = 0;
        }

        public Arma() { Init(); }
        public Arma(string nam, int lar, int poidmg, int poidmgmac, int poidef, string desc, TypeKeyBlade type, Element elem, int maxDmg) : base
            (nam, lar, poidmg, poidmgmac, poidef, desc)
        {
            Type = type;
            Elem = elem;
            MaxDmg = maxDmg;
        }

        public int calcularDano()
        {
            MaxDmg = (((PointDamage - PointDef) * PointMagic) * 50);
            return MaxDmg;
        }

        public new string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("Tipo Arma :{0}", Type));
            sb.AppendLine(string.Format("Tipo Elemento : {0}", Elem));
            sb.AppendLine(string.Format("Max Daño a Provocar :{0}", MaxDmg));
            return sb.ToString();
        }
    }
}
