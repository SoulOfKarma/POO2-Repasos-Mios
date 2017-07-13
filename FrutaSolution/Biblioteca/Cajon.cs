using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cajon
    {
        string _codCaja;
        Fruta[] _fru;
        Material _mat;
        Tamano _tam;
        int _capMax;
        string _empresa;

        public string CodCaja
        {
            get
            {
                return _codCaja;
            }

            set
            {
                if (value.Trim().Length < 4)
                {
                    _codCaja = value;
                }
                else
                {
                    throw new ArgumentException("Codigo Mal ingresado,Debe ser menor a 4");
                }

            }
        }

        public Fruta[] Fru
        {
            get
            {
                return _fru;
            }

            set
            {
                _fru = value;
            }
        }

        public Material Mat
        {
            get
            {
                return _mat;
            }

            set
            {
                if (value != Material.No_Seleccionado)
                {
                    _mat = value;
                }
                else
                {
                    throw new ArgumentException("Tipo de material mal ingresado");
                }
            }
        }

        public Tamano Tam
        {
            get
            {
                return _tam;
            }

            set
            {
                if (value != Tamano.No_Seleccionado)
                {
                    _tam = value;
                }
                else
                {
                    throw new ArgumentException("Tamaño mal ingresado");
                }
            }
        }

        public int CapMax
        {
            get
            {
                return _capMax;
            }

            set
            {
                if (value > 1)
                {
                    _capMax = value;
                }
                else
                {
                    throw new ArgumentException("Capacidad no puede ser menor a 1");
                }

            }
        }

        public string Empresa
        {
            get
            {
                return _empresa;
            }

            set
            {
                if (value.Trim().Length > 3)
                {
                    _empresa = value;
                }
                else
                {
                    throw new ArgumentException("Nombre de empresa mal ingresada");
                }
            }
        }

        private void Init()
        {
            _codCaja = string.Empty;
            _fru = new Fruta[0];
            _mat = Material.No_Seleccionado;
            _tam = Tamano.No_Seleccionado;
            _capMax = 0;
            _empresa = string.Empty;

        }

        public Cajon() { Init(); }

        public Cajon(string codCa, Fruta[] frut, Material mate, Tamano tama, int capM, string empre)
        {
            CodCaja = codCa;
            Fru = frut;
            Mat = mate;
            Tam = tama;
            CapMax = capM;
            Empresa = empre;


        }

        public int AgregarFruta(Fruta frutita)
        {
            Array.Resize(ref _fru, _fru.Length + 1);
            _fru[_fru.Length - 1] = frutita;
            return 1;
        }
    }
}
