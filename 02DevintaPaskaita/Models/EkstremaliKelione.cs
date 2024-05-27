using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Models
{
    /*Klasėje EkstremaliKelione įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už ekstremalias veiklas (pvz., 100 €).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.*/

    public class EkstremaliKelione : Kelione, IKelionesUzsakymas
    {
        public EkstremaliKelione(string aKryptis, int aDienuSkaicius, double aBazinesKainos)
        {
            Kryptis = aKryptis;
            DienuSkaicius = aDienuSkaicius;
            BazinesKainos = aBazinesKainos;
        }



        public double GautiKelionesKaina()
        {
            double suma = BazinesKainos * DienuSkaicius;
            Console.WriteLine("Keliones suma:");
            return suma;
        }

        public void UzsakytiKelione(string kryptis, int dienuSk)
        {
            KelioniuAgentura.UzsakytiKelione();
        }
    }
}
