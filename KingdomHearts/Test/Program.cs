using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                CollecionArmas col = new CollecionArmas();
                Axes axe = new Axes();
                axe.NombreArma = "Deicide";
                axe.CantidadArma = 2;
                axe.FechaCreacion = new DateTime(2016,8,21);
                axe.Precio = 8000;
                axe.TipoHacha = Hachas.GreatHammer;
                axe.FechaCheckeoArmas = new DateTime(2018,9,6);
                axe.CantidadReparaciones = 2;
                axe.CalcularEfectividadReparacion();
                
                Swords swordie = new Swords();
                swordie.NombreArma = "Fenrir";
                swordie.CantidadArma = 1;
                swordie.FechaCreacion = new DateTime(2015,12,5);
                swordie.Precio = 5000;
                swordie.TipoEspada = Espadas.KeyBlade;
                swordie.FechaCheckeoArmas = new DateTime(2017, 6, 25);
                swordie.CantidadReparaciones = 5;
                swordie.CalcularEfectividadReparacion();

                col.Add(swordie);
                col.Add(axe);
                Console.WriteLine(col.Imprimir());
                

                Console.ReadKey();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error :",ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error",ex);
            }
        }
    }
}
