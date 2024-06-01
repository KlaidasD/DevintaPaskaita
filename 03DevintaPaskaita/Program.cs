/*GYVUNAI



Naudodami ciklą iteruokite per sąrašą ir vykdykite įvairias veiklas su gyvūnais, išveskite pranešimus apie atliktas veiklas.
Papildomi reikalavimai:
Kiekvienas gyvūnas turi turėti savo vardą ir amžių.
Pridėkite galimybę rodyti visus prieglaudoje esančius gyvūnus ir jų detales.*/

using _03DevintaPaskaita.Models;
using System;
using _03DevintaPaskaita.Services;

namespace _03DevintaPaskaita
{
    class Program
    {
        static void Main(string[] args)
        {

            GyvunuPrieglauda prieglauda = new GyvunuPrieglauda();

            List<Gyvunas> gyvunai = prieglauda.GetGyvunai();

            prieglauda.PridetiGyvuna(new Suo("Rokis", 3));
            prieglauda.PridetiGyvuna(new Kate("Juoduolis", 5));
            prieglauda.PridetiGyvuna(new Paukstis("Flappy", 4));

            
            prieglauda.VykdytiVeiklasSuGyvunais();
            

            prieglauda.RodytiVisusGyvunus();
            

        }   
    }
}