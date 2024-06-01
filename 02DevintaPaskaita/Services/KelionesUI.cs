using DevintaPaskaita.Models;
using DevintaPaskaita.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Services
{
    public class KelionesUI
    {
        public static void Menu()
        {
            KelioniuAgentura agentura = new KelioniuAgentura();

            while (true)
            {
                Console.WriteLine("\nPasirinkite veiksma:");
                Console.WriteLine("1. Iveskite nauja kelione");
                Console.WriteLine("2. Rodyti visas keliones");
                Console.WriteLine("3. Uzdaryti programa");

                int pasirinkimas;
                if (int.TryParse(Console.ReadLine(), out pasirinkimas))
                {
                    switch (pasirinkimas)
                    {
                        case 1:
                            Console.Write("Keliones tipas (atostogos, komandiruote, ekstremali): ");
                            string tipas = Console.ReadLine();
                            Console.Write("Kryptis: ");
                            string kryptis = Console.ReadLine();
                            Console.Write("Dienu skaicius: ");
                            int dienos;
                            if (int.TryParse(Console.ReadLine(), out dienos))
                            {
                                agentura.UzsakytiKelione(tipas, kryptis, dienos);
                            }
                            else
                            {
                                Console.WriteLine("Neteisingai ivestas dienu skaicius.");
                            }
                            break;
                        case 2:
                            agentura.RodytiVisasKeliones();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Neteisinga ivestis.");
                }
            }
        }
    }
}


