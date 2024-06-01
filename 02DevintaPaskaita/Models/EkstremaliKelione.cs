using DevintaPaskaita.Services;
using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Klasėje EkstremaliKelione įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už ekstremalias veiklas (pvz., 100 €).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.*/

namespace DevintaPaskaita.Models
{
    public class EkstremaliKelione : Kelione, IKelionesUzsakymas

    {
        public EkstremaliKelione(string kryptis, int dienuSkaicius, double bazineKaina) : base(kryptis, dienuSkaicius, bazineKaina) { }

        public override double GautiKelionesKaina()
        {
            return base.GautiKelionesKaina() + 100;
        }

        public void UzsakytiKelione(string kryptis, int dienuSkaicius)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSkaicius;
        }
    }
}
