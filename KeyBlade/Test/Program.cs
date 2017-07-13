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
                ColleccionKeyBlade col = new ColleccionKeyBlade();
                Arma arms = new Arma();

                arms.Name = "Fenrir";
                arms.Large = 90;
                arms.PointDamage = 25;
                arms.PointMagic = 1;
                arms.PointDef = 14;
                arms.Description = "This Arm Nullified Magic but Have much Damage Base";
                arms.Type = TypeKeyBlade.Sword;
                arms.Elem = Element.Light;
                arms.calcularDano();

                Escudo esc = new Escudo();

                esc.Name = "Lotus Shield";
                esc.Large = 60;
                esc.PointDamage = 10;
                esc.PointMagic = 6;
                esc.PointDef = 20;
                esc.Description = "This Shield Have a lot defense and estable attack";
                esc.Type = TypeKeyBlade.Shield;
                esc.Eleme = Element.Fire;
                esc.calcularDano();

                col.Add(arms);
                col.Add(esc);

                Console.WriteLine(col.Imprimir());

                Console.ReadKey();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }

        }
    }
}
