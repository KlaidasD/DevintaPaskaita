/*Užduoties aprašymas:
Sukurkite interface'ą pavadinimu IKelionesUzsakymas, kuriame būtų aprašyti du metodai:
void UzsakytiKelione(string kryptis, int dienuSk): metodas, kuris priima kelionės kryptį ir dienų skaičių, bei vykdo kelionės užsakymą.
double GautiKelionesKaina(): metodas, kuris grąžina kelionės kainą.

Sukurkite tėvinę klasę Kelione, kuri turi šiuos laukus ir metodus:
Laukai: public string Kryptis, protected int DienuSkaicius, protected double BazinesKainos.
Metodai: public double GautiBazinesKainos(): grąžina bazinę kelionės kainą.

Paveldėkite klasę Kelione ir sukurkite kelias klases: Atostogos, Komandiruote, ir EkstremaliKelione. Visos šios klasės turi implementuoti IKelionesUzsakymas interface'ą.

Klasėje Atostogos įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už atostogas (pvz., 50 €).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.

Klasėje Komandiruote įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus, tačiau komandiruotės atveju gali būti taikoma nuolaida (pvz., 20%).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant nuolaidą.

Klasėje EkstremaliKelione įgyvendinkite šiuos metodus:
UzsakytiKelione(string kryptis, int dienuSk): nustato kelionės kryptį ir dienų skaičių. Bazinė kaina turi būti padauginta iš dienų skaičiaus ir pridedamas papildomas mokestis už ekstremalias veiklas (pvz., 100 €).
GautiKelionesKaina(): grąžina galutinę kelionės kainą, įskaitant papildomą mokestį.

Sukurkite klasę KelioniuAgentura, kuri turi šiuos laukus ir metodus:
Laukai: private List<Kelione> keliones: sąrašas su visomis kelionėmis.
Metodai:
public void PridetiKelione(Kelione kelione): prideda kelionę į sąrašą.
public void UzsakytiKelione(string kelionėsTipas, string kryptis, int dienuSk): sukuria ir užsako kelionę pagal tipą, kryptį ir dienų skaičių.
public void RodytiVisasKeliones(): išveda visas užsakytas keliones su jų kainomis.

Sukurkite sąrašą, kuriame būtų laikomos įvairios kelionės (tiek Atostogos, tiek Komandiruote, tiek EkstremaliKelione).
Naudodami ciklą iteruokite per šį sąrašą ir užsakykite įvairias keliones, naudodami skirtingas kryptis ir dienų skaičių.
Jei kelionės užsakymas sėkmingas, išveskite pranešimą apie sėkmingą užsakymą ir galutinę kelionės kainą.

Papildomi reikalavimai:
Kiekviena kelionė turi turėti pradinę bazinę kainą (pvz., 100 € už dieną).
Pridėkite galimybę rodyti visas užsakytas keliones ir jų detales.*/

using DevintaPaskaita.Models;
using DevintaPaskaita.Contracts;
using DevintaPaskaita.Models;
using System;
using System.ComponentModel;

namespace DevintaPaskaita
{
    public class Program : Kelione
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Programos funkcionalumas: " +
                    "\n1.Prideti kelione." +
                    "\n2.Rodyti visas keliones." +
                    "\n3.Uzsakyti kelione." +
                    "\n4.Rodyti visas uzsakytas keliones." +
                    "\n5.Uzdaryti programa.");

                int ivestis;
                if(!int.TryParse(Console.ReadLine(), out ivestis) )
                {
                    Console.WriteLine("Netinkama ivestis.");
                }
                switch(ivestis)
                {
                    case 1:
                        Kelione kelione = SukurtiKelione();
                        if (kelione != null)
                        {
                            KelioniuAgentura.PridetiKelione(kelione);
                            Console.WriteLine("Kelione sekmingai prideta.");
                        }
                        break;
                    case 2:
                        KelioniuAgentura.RodytiVisasKeliones();
                        break;
                    case 3:
                        KelioniuAgentura.UzsakytiKelione();
                        break;
                    case 4:
                        KelioniuAgentura.RodytiVisasUzsakytasKeliones();
                        break;
                    case 5:
                        Console.WriteLine("Isjungiama programa.");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static Kelione SukurtiKelione()
        {
            Console.WriteLine("Iveskite keliones krypti: ");
            string kryptis = Console.ReadLine();
            Console.WriteLine("Iveskit keliones trukme dienomis: ");
            int dSkaicius;
            if(!int.TryParse(Console.ReadLine(), out dSkaicius))
            {
                Console.WriteLine("Netinkamai ivestas dienu skaicius.");
            }
            Console.WriteLine("Iveskite keliones dienos kaina: ");
            double kaina;

            if(!double.TryParse(Console.ReadLine(), out kaina))
            {
                Console.WriteLine("Netinkamai ivesta kaina.");
            }

            return new Kelione(kryptis, dSkaicius, kaina);
        }
    }
}