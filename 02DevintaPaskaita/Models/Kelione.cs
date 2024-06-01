using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Užduoties aprašymas:
Sukurkite tėvinę klasę Kelione, kuri turi šiuos laukus ir metodus:
Laukai: public string Kryptis, protected int DienuSkaicius, protected double BazinesKainos.
Metodai: public double GautiBazinesKainos(): grąžina bazinę kelionės kainą.

Paveldėkite klasę Kelione ir sukurkite kelias klases: Atostogos, Komandiruote, ir EkstremaliKelione. Visos šios klasės turi implementuoti IKelionesUzsakymas interface'ą.

Sukurkite sąrašą, kuriame būtų laikomos įvairios kelionės (tiek Atostogos, tiek Komandiruote, tiek EkstremaliKelione).
Naudodami ciklą iteruokite per šį sąrašą ir užsakykite įvairias keliones, naudodami skirtingas kryptis ir dienų skaičių.
Jei kelionės užsakymas sėkmingas, išveskite pranešimą apie sėkmingą užsakymą ir galutinę kelionės kainą.

Papildomi reikalavimai:
Kiekviena kelionė turi turėti pradinę bazinę kainą (pvz., 100 € už dieną).
Pridėkite galimybę rodyti visas užsakytas keliones ir jų detales.*/

namespace DevintaPaskaita.Models
{
    public class Kelione
    {
        public string Kryptis { get; set; }
        public int DienuSkaicius { get; set; }
        public double BazineKaina { get; set; } = 100; // Default base price

        public Kelione(string kryptis, int dienuSkaicius, double bazineKaina = 100)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSkaicius;
            BazineKaina = bazineKaina;
        }

        public virtual double GautiKelionesKaina()
        {
            return BazineKaina * DienuSkaicius;
        }

        public override string ToString()
        {
            return $"Kryptis: {Kryptis}, Dienu skaicius: {DienuSkaicius}, Bazine kaina: {BazineKaina}";
        }
    }
}