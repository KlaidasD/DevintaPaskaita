using DevintaPaskaita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Models
{
    /*Sukurkite klasę KelioniuAgentura, kuri turi šiuos laukus ir metodus:
Laukai: private List<Kelione> keliones: sąrašas su visomis kelionėmis.
Metodai:
public void PridetiKelione(Kelione kelione): prideda kelionę į sąrašą.
public void UzsakytiKelione(string kelionėsTipas, string kryptis, int dienuSk): sukuria ir užsako kelionę pagal tipą, kryptį ir dienų skaičių.
public void RodytiVisasKeliones(): išveda visas užsakytas keliones su jų kainomis.*/

    public class KelioniuAgentura : Kelione
    {
        private static List<Kelione> keliones = new List<Kelione>();

        public static void PridetiKelione(Kelione kelione)
        {
            keliones.Add(kelione);
        }

        public static void UzsakytiKelione()
        {
            RodytiVisasKeliones();
            Console.WriteLine("Iveskite krypti keliones, kurian norite uzsakyti.");
            string ivestis = Console.ReadLine();
            foreach(Kelione kelione in keliones)
            {
                if(kelione.Kryptis.Contains(ivestis))
                {
                    kelione.ArUzsakyta = true;
                    Console.WriteLine($"Sekmingai uzsakyta kelione..{kelione}");
                }
            }
        }

        public static void RodytiVisasKeliones()
        {
            Console.WriteLine($"Atspausdinamos visos keliones..");
            foreach(Kelione kelione in keliones)
            {
                Console.WriteLine(kelione);
            }
        }

        public static void RodytiVisasUzsakytasKeliones()
        {
            Console.WriteLine($"Atspausdinamos visos uzsakytos keliones.");
            foreach(Kelione kelione in keliones)
            {
                if (kelione.ArUzsakyta == true)
                {
                    Console.WriteLine($"{kelione} " + $"Ar uzsakyta: {kelione.ArUzsakyta}");
                }
            }
        }

    }
}
