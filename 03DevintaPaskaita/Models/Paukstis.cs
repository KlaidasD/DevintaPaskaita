using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03DevintaPaskaita.Contracts;

namespace _03DevintaPaskaita.Models
{
    /*Klasėje Paukstis įgyvendinkite šiuos metodus:
void Maitinti(): išveda pranešimą, kaip paukštis yra maitinamas.
void Gydyti(): išveda pranešimą, kaip paukštis yra gydomas.
void Valyti(): išveda pranešimą, kaip paukštis yra valomas.
void Pasivaikscioti(): išveda pranešimą, kaip paukštis yra vedamas pasivaikščioti.
void Informacija(): išveda informaciją apie paukštį.
   */

    public class Paukstis : Gyvunas, IGyvunoVeikla, IGyvunoPrieziura
    {
        public Paukstis(string vardas, int amzius) : base(vardas, amzius)
        {
            Vardas = vardas;
            Amzius = amzius;
        }

        public override void Maitinti()
        {
            Console.WriteLine("Paukstis maitinamas.");
        }

        public override void Gydyti()
        {
            Console.WriteLine("Paukstis gydomas.");
        }

        public override void Valyti()
        {
            Console.WriteLine("Paukstis valomas.");
        }

        public override void Pasivaikscioti()
        {
            Console.WriteLine("Paukstis vedamas paskraidyti.");
        }

        public void Informacija()
        {
            Console.WriteLine($"Paukstis: {Vardas}, amzius: {Amzius}.");
        }
       
    }
}

