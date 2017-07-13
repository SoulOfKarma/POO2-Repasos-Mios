using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
         try
         {
                Cajon caj = new Cajon();
                caj.CodCaja = "P3S";
                caj.CapMax = 3;
                caj.Empresa = "Duron";
                caj.Mat = Material.Carton;
                caj.Tam = Tamano.Normal;

                for (int i =0;i < caj.CapMax; i++)
              {
                Fruta fruts = new Fruta();
                fruts.TipoFruta = TipoFruta.Coco;
                fruts.Origen = "Rancagua";
                fruts.Destino = "San Felipe";
                fruts.Codfruta = (i + 1) + "-" + fruts.TipoFruta + "-" + caj.Empresa;
                int res = caj.AgregarFruta(fruts);
                if(res == 1)
                {
                    Console.WriteLine("Se agrego " + fruts.Codfruta);
                }
                else
                {
                    Console.WriteLine("No se agrego "+fruts.Codfruta);
                }
               }
          }
          catch (IndexOutOfRangeException ex)
          {
                Console.WriteLine("Error " + ex.Message);
            }
          catch(ArgumentException ex)
          {
                Console.WriteLine("Error " + ex.Message);
            }
          catch (Exception ex)
          {
                Console.WriteLine("Error " + ex);
            }
            Console.ReadKey();
        }
    }
}
