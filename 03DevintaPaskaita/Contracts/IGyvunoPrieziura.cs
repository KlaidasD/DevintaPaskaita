using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sukurkite kitą interface'ą pavadinimu IGyvunoPrieziura, kuriame būtų aprašyti du metodai:
void Valyti(): metodas, kuris aprašo, kaip gyvūnas yra valomas.
void Pasivaikscioti(): metodas, kuris aprašo, kaip gyvūnas yra vedamas pasivaikščioti.*/

namespace _03DevintaPaskaita.Contracts
{
    public interface IGyvunoPrieziura
    {
        void Valyti();
        void Pasivaikscioti();
    }
}
