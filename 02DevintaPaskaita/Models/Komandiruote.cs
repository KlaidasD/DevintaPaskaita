using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Models
{
    /*Klasėje Komandiruote įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus, tačiau komandiruotės atveju gali būti taikoma nuolaida (pvz., 20%).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant nuolaidą.*/

    public class Komandiruote : Kelione, IKelionesUzsakymas
    {
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
