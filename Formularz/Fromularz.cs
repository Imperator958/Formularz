using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    internal class Fromularz
    {
        string Imie_i_nazwisko = "";
        string kierunek = "";
        string nr_albumu = "";
        string zakres = "";
        string tytuł_pracy = "";
    }

    class Formularz_protokołu : Fromularz
    {

    }

    class Karta_tematu : Fromularz
    {

    }

    class Opinia : Fromularz
    {

    }

    class Opinia_Recenzenta : Opinia
    {

    }

    class Opinia_Promotora : Opinia
    {

    }
}


