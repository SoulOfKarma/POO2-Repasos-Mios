using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Fruta
    {
        string _Codfruta;
        TipoFruta _TipoFruta;
        string _Origen;
        string _Destino;

        public string Codfruta
        {
            get
            {
                return _Codfruta;
            }

            set
            {
                if(value.Trim().Length > 3)
                {
                    _Codfruta = value;
                }
                else
                {
                    throw new ArgumentException("Codigo muy corto");
                }
            }
        }

        public TipoFruta TipoFruta
        {
            get
            {
                return _TipoFruta;
            }

            set
            {
                if(value != TipoFruta.No_seleccionado)
                {
                    _TipoFruta = value;
                }
                else
                {
                    throw new ArgumentException("Tipo de fruta mal ingresada");
                }
            }
        }

        public string Origen
        {
            get
            {
                return _Origen;
            }

            set
            {
                if(value.Trim().Length > 3)
                {
                    _Origen = value;
                }
                else
                {
                    throw new ArgumentException("Lugar de origen muy corto");
                }
            }
        }

        public string Destino
        {
            get
            {
                return _Destino;
            }

            set
            {
                if (value.Trim().Length > 3)
                {
                    _Destino = value;
                }
                else
                {
                    throw new ArgumentException("Lugar de destino muy corto");
                }
            }
        }


        private void Init()
        {
            _Codfruta = string.Empty;
            _TipoFruta = TipoFruta.No_seleccionado;
            _Origen = string.Empty;
            _Destino = string.Empty;
        }

        public Fruta() { Init(); }

        public Fruta(string codF,TipoFruta tipF,string OriF,string DesF)
        {
            Codfruta = codF;
            TipoFruta = tipF;
            Origen = OriF;
            Destino = DesF;
        }

    }
}
