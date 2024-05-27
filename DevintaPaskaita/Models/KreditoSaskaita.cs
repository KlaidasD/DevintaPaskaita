using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Models
{
    /*Užduoties aprašymas:
         * 
Sukurkite interface'ą pavadinimu IMokejimoMetodas, kuriame būtų aprašyti du metodai:

void Apmoketi(double suma): metodas, kuris priima mokėjimo sumą ir vykdo mokėjimą.
bool PatikrintiLikutį(double suma): metodas, kuris tikrina, ar yra pakankamas likutis nurodytai sumai apmokėti.

Sukurkite tėvinę klasę Saskaita, kuri turi šiuos laukus ir metodus:
Laukai: public string SavininkoVardas, protected double Balansas.
Metodai: public double GautiBalansa(): grąžina sąskaitos balansą.

Paveldėkite klasę Saskaita ir sukurkite dvi klases: KreditoSaskaita ir DebetoSaskaita. Abi šios klasės turi implementuoti IMokejimoMetodas interface'ą.
Klasėje KreditoSaskaita įgyvendinkite šiuos metodus:
Apmoketi(double suma): patikrina, ar pakankamas likutis mokėjimui. Jei taip, atima sumą iš balanso. Jei ne, išveda pranešimą, kad nepakanka lėšų.
PatikrintiLikutį(double suma): grąžina true, jei balansas didesnis arba lygus sumai, kitaip false.
Klasėje DebetoSaskaita įgyvendinkite šiuos metodus:
Apmoketi(double suma): patikrina, ar pakankamas likutis mokėjimui. Jei taip, atima sumą iš balanso. Jei ne, išveda pranešimą, kad nepakanka lėšų.
PatikrintiLikutį(double suma): grąžina true, jei balansas didesnis arba lygus sumai, kitaip false.
Sukurkite sąrašą, kuriame būtų laikomos įvairios sąskaitos (tiek KreditoSaskaita, tiek DebetoSaskaita).
Naudodami ciklą iteruokite per šį sąrašą ir išbandykite įvairius mokėjimus, naudojant skirtingas sumas. Jei mokėjimas sėkmingas, išveskite pranešimą apie sėkmingą mokėjimą ir naują balansą. Jei mokėjimas nesėkmingas, išveskite pranešimą apie nesėkmingą mokėjimą.
Papildomi reikalavimai:
Kiekviena sąskaita turi turėti pradinį balansą.
        */
    public class KreditoSaskaita : Saskaita, IMokejimoMetodas
    {
        public KreditoSaskaita(string aVardas, double aBalansas)
        {
            SavininkoVardas = aVardas;
            Balansas = aBalansas;
        }

        public void Apmoketi(double suma)
        {
            if (PatikrintiLikuti(suma))
            {
                Balansas -= suma;
                Console.WriteLine($"Mokejimas sekmingas. Naujas balansas: {Balansas}");
            }
            else
            {
                Console.WriteLine("Nepakanka lesu.");
            }
        }

        public bool PatikrintiLikuti(double suma)
        {
            return Balansas >= suma;
        }
    }
}
