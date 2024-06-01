using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03DevintaPaskaita.Contracts;

namespace _03DevintaPaskaita.Models
{
    /*Klasėje Kate įgyvendinkite šiuos metodus:
void Maitinti(): išveda pranešimą, kaip katė yra maitinama.
void Gydyti(): išveda pranešimą, kaip katė yra gydoma.
void Valyti(): išveda pranešimą, kaip katė yra valoma.
void Pasivaikscioti(): išveda pranešimą, kaip katė yra vedama pasivaikščioti.
void Informacija(): išveda informaciją apie katę.
   */

    public class Kate : Gyvunas, IGyvunoPrieziura, IGyvunoVeikla
    {

        public Kate(string vardas, int amzius) : base(vardas, amzius)
        {
            Vardas = vardas;
            Amzius = amzius;
        }

        public override void Maitinti()
        {
            Console.WriteLine("Kate maitinama.");
        }

        public override void Gydyti()
        {
            Console.WriteLine("Kate gydoma.");
        }

        public override void Valyti()
        {
            Console.WriteLine("Kate valoma.");
        }

        public override void Pasivaikscioti()
        {
            Console.WriteLine("Kate vedama pasivaikscioti.");
        }

        public void Informacija()
        {
            Console.WriteLine($"Kate: {Vardas}, amzius: {Amzius}.");
        }
       
    }
}
