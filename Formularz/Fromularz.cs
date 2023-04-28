using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class Fromularz
    {
        public string kierunek = "";
        public string studia_w_zakresie = "";
        public string tytuł_pracy = "";
    }

    public class Formularz_protokołu : Fromularz
    {
        public string imie_nazwisko = "";
        public string data_narodzin = "";
        public string miejsce_narodzin = "";
        public string data_egz = "";
        public string nr_albumu = "";
        public string profil = "";
        public string forma = "";
        public string poziom = "";
        public string data_rozp = "";
        public string ocena_pracy = "";
        public string ocena_mowy = "";
        public string ocena_pytań = "";
    }

    public class Karta_tematu : Fromularz
    {
        public string profil_studiów = "";
        public string forma_studiów = "";
        public string poziom_studiów = "";
        public string student1_imie_album_data = "";
        public string student2_imie_album_data = "";
        public string student3_imie_album_data = "";
        public string student4_imie_album_data = "";
        public string tytuł_po_ang = "";
        public string dane_wejściowe = "";
        public string zakres_pracy = "";
        public string termin_oddania = "";
        public string promotor = "";
        public string jedn_org_promotora = "";
    }

    public class Opinia : Fromularz
    {
        public string imie_nazwisko = "";
        public string r_lub_p = "";
        public string jednostka = "";
        public string ocena_słowo = "";
        public string ocena_liczba = "";
        public string nr_albumu = "";
    }
}


