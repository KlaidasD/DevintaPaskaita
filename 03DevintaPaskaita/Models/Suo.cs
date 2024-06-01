using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03DevintaPaskaita.Contracts;

namespace _03DevintaPaskaita.Models
{
    /*Paveldėkite klasę Gyvunas ir sukurkite kelias klases: Suo, Kate, ir Paukstis. Šios klasės turi implementuoti IGyvunoVeikla ir IGyvunoPrieziura interface'us.
Klasėje Suo įgyvendinkite šiuos metodus:
void Maitinti(): išveda pranešimą, kaip šuo yra maitinamas.
void Gydyti(): išveda pranešimą, kaip šuo yra gydomas.
void Valyti(): išveda pranešimą, kaip šuo yra valomas.
void Pasivaikscioti(): išveda pranešimą, kaip šuo yra vedamas pasivaikščioti.
void Informacija(): išveda informaciją apie šunį.
    */

    public class Suo : Gyvunas, IGyvunoVeikla, IGyvunoPrieziura
    {

        public Suo(string vardas, int amzius) : base(vardas, amzius)
        {
           
        }

        public override void Maitinti()
        {
            Console.WriteLine("Suo maitinamas.");
        }

        public override void Gydyti()
        {
            Console.WriteLine("Suo gydomas.");
        }

        public override void Valyti()
        {
            Console.WriteLine("Suo valomas.");
        }

        public override void Pasivaikscioti()
        {
            Console.WriteLine("Suo vedamas pasivaikscioti.");
        }

        public void Informacija()
        {
            Console.WriteLine($"Suo: {Vardas}, amžius: {Amzius}.");
        }

        
    }
}
