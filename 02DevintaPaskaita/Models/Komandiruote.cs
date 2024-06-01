using DevintaPaskaita.Services;
using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Klasėje Komandiruote įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus, tačiau komandiruotės atveju gali būti taikoma nuolaida (pvz., 20%).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant nuolaidą.*/

namespace DevintaPaskaita.Models
{
    public class Komandiruote : Kelione, IKelionesUzsakymas
    {
        public Komandiruote(string kryptis, int dienuSkaicius, double bazineKaina) : base(kryptis, dienuSkaicius, bazineKaina) { }

        public override double GautiKelionesKaina()
        {
            return base.GautiKelionesKaina() * 0.8;
        }

        public void UzsakytiKelione(string kryptis, int dienuSkaicius)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSkaicius;
        }
    }
}