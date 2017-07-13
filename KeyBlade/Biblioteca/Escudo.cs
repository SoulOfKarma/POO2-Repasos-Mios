using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Escudo : Keyblade, IKeyBlade
    {

        TypeKeyBlade type;
        Element eleme;
        int maxDMG;

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

        public Element Eleme
        {
            get
            {
                return eleme;
            }

            set
            {
                eleme = value;
            }
        }

        public int MaxDMG
        {
            get
            {
                return maxDMG;
            }

            set
            {
                maxDMG = value;
            }
        }

        private void Init()
        {
            type = TypeKeyBlade.NotInformed;
            eleme = Element.NotInformed;
            maxDMG = 0;
        }

        public Escudo() { Init(); }
        public Escudo(string nam,int lar,int poidmg,int poidmgmac,int poidef,string desc,TypeKeyBlade type, Element eleme,int maxd):base
            (nam,lar,poidmg,poidmgmac,poidef,desc)
        {
            Type = type;
            Eleme = eleme;
            MaxDMG = maxd;
        }

        public int calcularDano()
        {
            
            MaxDMG = (((PointDef - PointDamage)*PointMagic)*50);
            return MaxDMG;
        }


        public new string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("Tipo Arma :{0}", Type));
            sb.AppendLine(string.Format("Tipo Elemento : {0}", Eleme));
            sb.AppendLine(string.Format("Max Daño a Provocar :{0}", MaxDMG));
            return sb.ToString();
        }
    }
}
