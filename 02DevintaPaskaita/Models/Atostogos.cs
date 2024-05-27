using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Models
{
    /*Klasėje Atostogos įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk) : nustato kelionės kryptį ir dienų skaičių.Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už atostogas (pvz., 50 €).
GautiKelionesKaina() : grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.*/
    public class Atostogos : Kelione, IKelionesUzsakymas
    {

        public Atostogos(string aKryptis, int aDienuSkaicius, double aBazinesKainos)
        {
            Kryptis = aKryptis;
            DienuSkaicius = aDienuSkaicius;
            BazinesKainos = aBazinesKainos;
        }

        public double GautiKelionesKaina()
        {
            throw new NotImplementedException();
        }

        public void UzsakytiKelione(string kryptis, int dienuSk)
        {
            throw new NotImplementedException();
        }
    }
}
