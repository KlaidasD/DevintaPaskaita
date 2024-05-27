using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Models
{
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
    public class Kelione
    {
        public string Kryptis;
        protected int DienuSkaicius;
        protected double BazinesKainos;
        public bool ArUzsakyta;
        public double Suma;

        public Kelione(string aKryptis, int aDienuSkaicius, double aBazinesKainos)
        {
            Kryptis = aKryptis;
            DienuSkaicius = aDienuSkaicius;
            BazinesKainos = aBazinesKainos;
            ArUzsakyta = false;
            Suma = BazinesKainos * DienuSkaicius;
        }

        public Kelione()
        {

        }

        public double GautiBazinesKainos()
        {
            return BazinesKainos;
        }

        public override string ToString()
        {
            return $"Kryptis: {Kryptis}, Dienu skaicius: {DienuSkaicius}, Bazine kaina: {BazinesKainos}, Viso suma: {Suma}";
        }
    }
}
