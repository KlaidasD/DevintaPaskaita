using _03DevintaPaskaita.Contracts;
using _03DevintaPaskaita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DevintaPaskaita.Services
{
    /*Sukurkite klasę GyvunuPrieglauda, kuri turi šiuos laukus ir metodus:
Laukai: private List<Gyvunas> gyvunai: sąrašas su visais gyvūnais.
Metodai:
public void PridetiGyvuna(Gyvunas gyvunas): prideda gyvūną į sąrašą.
public void VykdytiVeiklasSuGyvunais(): vykdo maitinimo, gydymo, valymo ir pasivaikščiojimo veiklas visiems gyvūnams.
public void RodytiVisusGyvunus(): išveda informaciją apie visus prieglaudoje esančius gyvūnus.*/

    public class GyvunuPrieglauda
    {
        private List<Gyvunas> gyvunai = new List<Gyvunas>();

        public void PridetiGyvuna(Gyvunas gyvunas)
        {
            gyvunai.Add(gyvunas);
        }

        public List<Gyvunas> GetGyvunai()
        {
            return gyvunai;
        }

        public void VykdytiVeiklasSuGyvunais()
        {
            foreach (Gyvunas gyvunas in gyvunai)
            {
                gyvunas.Maitinti();
                gyvunas.Gydyti();
                gyvunas.Valyti();
                gyvunas.Pasivaikscioti();
            }
            
        }

        public void RodytiVisusGyvunus()
        {
            foreach (Gyvunas gyvunas in gyvunai)
            {
                gyvunas.Informacija();
            }
        }

       
    }
}
