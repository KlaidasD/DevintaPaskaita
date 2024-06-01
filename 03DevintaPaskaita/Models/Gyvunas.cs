using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03DevintaPaskaita.Contracts;

namespace _03DevintaPaskaita.Models
{
    /*Sukurkite tėvinę klasę Gyvunas, kuri turi šiuos laukus ir metodus:
Laukai: public string Vardas, public int Amzius.
Metodai: public void Informacija(): metodas, kuris išveda informaciją apie gyvūną.
*/
    public abstract class Gyvunas
    {
        public string Vardas;
        public int Amzius;
        public abstract void Maitinti();
        public abstract void Gydyti();
        public abstract void Valyti();
        public abstract void Pasivaikscioti();


        public Gyvunas(string aVardas, int aAmzius)
        {
            Vardas = aVardas;
            Amzius = aAmzius;
        }

        public void Informacija()
        {
            Console.WriteLine($"Vardas: {Vardas}, Amzius: {Amzius}.");
        }

    }
}
