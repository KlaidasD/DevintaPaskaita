using DevintaPaskaita.Contracts;
using DevintaPaskaita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Sukurkite klasę KelioniuAgentura, kuri turi šiuos laukus ir metodus:
Laukai: private List<Kelione> keliones: sąrašas su visomis kelionėmis.
Metodai:
public void PridetiKelione(Kelione kelione): prideda kelionę į sąrašą.
public void UzsakytiKelione(string kelionėsTipas, string kryptis, int dienuSk): sukuria ir užsako kelionę pagal tipą, kryptį ir dienų skaičių.
public void RodytiVisasKeliones(): išveda visas užsakytas keliones su jų kainomis.*/
namespace DevintaPaskaita.Services
{
    public class KelioniuAgentura
    {
        private List<Kelione> keliones = new List<Kelione>();

        public void PridetiKelione(Kelione kelione)
        {
            keliones.Add(kelione);
        }

        public void UzsakytiKelione(string kelionesTipas, string kryptis, int dienuSk)
        {
            Kelione naujaKelione = null;
            if (kelionesTipas == "atostogos")
                naujaKelione = new Atostogos(kryptis, dienuSk, 100); // Assuming 100 as base price
            else if (kelionesTipas == "komandiruote")
                naujaKelione = new Komandiruote(kryptis, dienuSk, 100);
            else if (kelionesTipas == "ekstremali")
                naujaKelione = new EkstremaliKelione(kryptis, dienuSk, 100);

            if (naujaKelione != null)
            {
                keliones.Add(naujaKelione);
                Console.WriteLine($"Kelione '{kryptis}' sekmingai uzsakyta. Kaina: {naujaKelione.GautiKelionesKaina()} EUR");
            }
            else
                Console.WriteLine("Netinkamas keliones tipas.");
        }

        public void RodytiVisasKeliones()
        {
            if (keliones.Count == 0)
            {
                Console.WriteLine("Nera uzsakytu kelioniu.");
                return;
            }

            Console.WriteLine("Visos uzsakytos keliones:");
            foreach (Kelione kelione in keliones)
            {
                Console.WriteLine(kelione);
            }
        }
    }
}