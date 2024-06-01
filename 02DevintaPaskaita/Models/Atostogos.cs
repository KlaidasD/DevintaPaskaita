using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Klasėje Atostogos įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk) : nustato kelionės kryptį ir dienų skaičių.Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už atostogas (pvz., 50 €).
GautiKelionesKaina() : grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.*/
namespace DevintaPaskaita.Models
{
    public class Atostogos : Kelione, IKelionesUzsakymas
    {
        public Atostogos(string kryptis, int dienuSkaicius, double bazineKaina) : base(kryptis, dienuSkaicius, bazineKaina) { }

        public override double GautiKelionesKaina()
        {
            return base.GautiKelionesKaina() + 50;
        }

        public void UzsakytiKelione(string kryptis, int dienuSkaicius)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSkaicius;
        }
    }
}
