using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DevintaPaskaita.Contracts
{
    /*Užduoties aprašymas:
Sukurkite interface'ą pavadinimu IGyvunoVeikla, kuriame būtų aprašyti du metodai:
void Maitinti(): metodas, kuris aprašo, kaip gyvūnas yra maitinamas.
void Gydyti(): metodas, kuris aprašo, kaip gyvūnas yra gydomas.*/
    public interface IGyvunoVeikla
    {
        void Maitinti();
        void Gydyti();
    }
}
