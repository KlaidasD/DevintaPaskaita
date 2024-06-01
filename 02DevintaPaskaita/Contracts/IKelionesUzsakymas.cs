using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Užduoties aprašymas:
Sukurkite interface'ą pavadinimu IKelionesUzsakymas, kuriame būtų aprašyti du metodai:
void UzsakytiKelione(string kryptis, int dienuSk): metodas, kuris priima kelionės kryptį ir dienų skaičių, bei vykdo kelionės užsakymą.
double GautiKelionesKaina(): metodas, kuris grąžina kelionės kainą.

*/

namespace DevintaPaskaita.Contracts
{
    public interface IKelionesUzsakymas
    {
        void UzsakytiKelione(string kryptis, int dienuSkaicius);
        double GautiKelionesKaina();
    }
}
