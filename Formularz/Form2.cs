using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Formularz
{
    public partial class Form2 : Form
    {
        List<string> listaText = new List<string>();
        List<string> listaNazwy = new List<string>();

        Button button = new Button();
        Button button2 = new Button();

        Form1 form1;
        public Form2(Form1 form2)
        {
            InitializeComponent();
            this.form1 = form2;
            int x = 0;
            int y = 0;
            int W = 0;
            int H = 0;
            switch (form1.What_in_comboBox())
            {
                case "Karta tematu pracy dyplomowej inżynierskiej":
                    x = 30;
                    y = 10;
                    listaText.Add("Kierunek:");
                    listaText.Add("Studia w zakresie:");
                    listaText.Add("Tytuł pracy inżynierskiej:");
                    listaText.Add("Profil studiów:");
                    listaText.Add("Forma studiów:");
                    listaText.Add("Poziom studiów:");
                    listaText.Add("Student 1:");
                    listaText.Add("Student 2:");
                    listaText.Add("Student 3:");
                    listaText.Add("Student 4:");
                    listaText.Add("Tytuł pracy po angielsku:");
                    listaText.Add("Dane wejściowe:");
                    listaText.Add("Zakres pracy:");
                    listaText.Add("Termin oddania:");
                    listaText.Add("Promotor:");
                    listaText.Add("Jednostka organizacyjna promotora:");

                    listaNazwy.Add("Kierunek");
                    listaNazwy.Add("Studia_w_zakresie");
                    listaNazwy.Add("Tytuł_pracy_inżynierskiej");
                    listaNazwy.Add("Profil_studiów");
                    listaNazwy.Add("Forma_studiów");
                    listaNazwy.Add("Poziom_studiów");
                    listaNazwy.Add("Student_1");
                    listaNazwy.Add("Student_2");
                    listaNazwy.Add("Student_3");
                    listaNazwy.Add("Student_4");
                    listaNazwy.Add("Tytuł_pracy_po_angielsku");
                    listaNazwy.Add("Dane_wejściowe");
                    listaNazwy.Add("Zakres_pracy");
                    listaNazwy.Add("Termin_oddania");
                    listaNazwy.Add("Promotor");
                    listaNazwy.Add("Jednostka_organizacyjna_promotora");

                    for (int i = 0; i < 16; i++)
                    {
                        if(x == 30)
                        {
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W*2, H);
                            x = 500;
                        }
                        else
                        {
                            y = y - 20;
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);  
                            x = 30;
                            y = y + 50;
                        }
                    }
                    this.AutoSize = true;

                    break;
                case "Opinia Promotora - praca inżynierska":
                    x = 30;
                    y = 10;
                    listaText.Add("Kierunek:");
                    listaText.Add("Studia w zakresie:");
                    listaText.Add("Tytuł pracy inżynierskiej:");
                    listaText.Add("Imię i nazwisko dyplomanta:");
                    listaText.Add("Imię i nazwisko promotora:");
                    listaText.Add("Jednostka organizacyjna promotora:");
                    listaText.Add("Ocena (słownie):");
                    listaText.Add("Ocena (liczbowo):");
                    listaText.Add("Numer albumu:");

                    listaNazwy.Add("Kierunek");
                    listaNazwy.Add("Studia_w_zakresie");
                    listaNazwy.Add("Tytuł_pracy_inżynierskiej");
                    listaNazwy.Add("Imię_i_nazwisko_dyplomanta");
                    listaNazwy.Add("Imię_i_nazwisko_promotora");
                    listaNazwy.Add("Jednostka_organizacyjna_promotora");
                    listaNazwy.Add("Ocena_słowna");
                    listaNazwy.Add("Ocena_liczbowa");
                    listaNazwy.Add("Numer_albumu");

                    for (int i = 0; i < 9; i++)
                    {
                        if (x == 30)
                        {
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);
                            x = 500;
                        }
                        else
                        {
                            y = y - 20;
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);
                            x = 30;
                            y = y + 50;
                        }
                    }
                    this.AutoSize = true;
                    break;
                case "Opinia Recenzenta - praca inżynierska":
                    x = 30;
                    y = 10;
                    listaText.Add("Kierunek:");
                    listaText.Add("Studia w zakresie:");
                    listaText.Add("Tytuł pracy inżynierskiej:");
                    listaText.Add("Imię i nazwisko dyplomanta:");
                    listaText.Add("Imię i nazwisko recenzenta:");
                    listaText.Add("Jednostka organizacyjna promotora:");
                    listaText.Add("Ocena (słownie):");
                    listaText.Add("Ocena (liczbowo):");
                    listaText.Add("Numer albumu:");

                    listaNazwy.Add("Kierunek");
                    listaNazwy.Add("Studia_w_zakresie");
                    listaNazwy.Add("Tytuł_pracy_inżynierskiej");
                    listaNazwy.Add("Imię_i_nazwisko_dyplomanta");
                    listaNazwy.Add("Imię_i_nazwisko_recenzenta");
                    listaNazwy.Add("Jednostka_organizacyjna_promotora");
                    listaNazwy.Add("Ocena_słowna");
                    listaNazwy.Add("Ocena_liczbowa");
                    listaNazwy.Add("Numer_albumu");

                    for (int i = 0; i < 9; i++)
                    {
                        if (x == 30)
                        {
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);
                            x = 500;
                        }
                        else
                        {
                            y = y - 20;
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);
                            x = 30;
                            y = y + 50;
                        }
                    }
                    this.AutoSize = true;
                    break;
                case "Protokół komisji egzaminu dyplomowego inżynierskiego":
                    x = 30;
                    y = 10;
                    listaText.Add("Kierunek:");
                    listaText.Add("Studia w zakresie:");
                    listaText.Add("Tytuł pracy inżynierskiej:");
                    listaText.Add("Imię i nazwisko dyplomanta:");
                    listaText.Add("Data narodzin dyplomanta:");
                    listaText.Add("Miejsce narodzin dyplomanta:");
                    listaText.Add("Data przeprowadzenia egzaminu:");
                    listaText.Add("Numer albumu:");
                    listaText.Add("Profil studiów:");
                    listaText.Add("Forma studiów:");
                    listaText.Add("Poziom studiów:");
                    listaText.Add("Data rozpoczęcia studiów:");
                    listaText.Add("Ocena pracy:");
                    listaText.Add("Ocena odpowiedzi ustnej:");
                    listaText.Add("Ocena poprawności odpowiedzi na zadane pytania:");

                    listaNazwy.Add("Kierunek");
                    listaNazwy.Add("Studia_w_zakresie");
                    listaNazwy.Add("Tytuł_pracy_inżynierskiej");
                    listaNazwy.Add("Imię_i_nazwisko_dyplomanta");
                    listaNazwy.Add("Data_narodzin_dyplomanta");
                    listaNazwy.Add("Miejsce_narodzin_dyplomanta");
                    listaNazwy.Add("Data_przeprowadzenia_egzaminu");
                    listaNazwy.Add("Numer_albumu");
                    listaNazwy.Add("Profil_studiów");
                    listaNazwy.Add("Forma_studiów");
                    listaNazwy.Add("Poziom_studiów");
                    listaNazwy.Add("Data_rozpoczęcia_studiów");
                    listaNazwy.Add("Ocena_pracy");
                    listaNazwy.Add("Ocena_odpowiedzi_ustnej");
                    listaNazwy.Add("Ocena_poprawności_odpowiedzi_na_zadane_pytania");

                    for (int i = 0; i < 15; i++)
                    {
                        if (x == 30)
                        {
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);
                            x = 500;
                        }
                        else
                        {
                            y = y - 20;
                            Label label = new Label();
                            label.Name = listaNazwy[i].ToString() + "label";
                            label.Text = listaText[i].ToString();
                            label.Location = new Point(x, y);
                            label.Font = new Font("Arial", 10, FontStyle.Bold);
                            this.Controls.Add(label);
                            W = label.Width;
                            H = label.Height;
                            label.Size = new Size(W * 3, H);
                            y = y + 20;

                            TextBox textBox = new TextBox();
                            textBox.Name = listaNazwy[i].ToString() + "textbox";
                            textBox.Location = new Point(x, y);
                            this.Controls.Add(textBox);
                            W = textBox.Width;
                            H = textBox.Height;
                            textBox.Size = new Size(W * 2, H);
                            x = 30;
                            y = y + 50;
                        }
                    }
                    this.AutoSize = true;
                    break;
                default:
                    MessageBox.Show("Nie wybrano formularza");
                    form1.Close();
                    break;
            }

            y = y + 50;

            button.Name = "ZAPISZ";
            button.Text = "ZAPISZ";
            button.Location = new Point(30, y);
            button.Font = new Font("Arial", 20, FontStyle.Regular);
            W = button.Width;
            H = button.Height;
            button.Size = new Size(W * 3, H*3);
            button.Click += new EventHandler(button_Click);
            this.Controls.Add(button);

            button2.Name = "WCZYTAJ";
            button2.Text = "WCZYTAJ";
            button2.Location = new Point(500, y);
            button2.Font = new Font("Arial", 20, FontStyle.Regular);
            W = button2.Width;
            H = button2.Height;
            button2.Size = new Size(W * 3, H*3);
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object Sender, EventArgs e)
        {
            XmlSerializer xmlSerializer;
            switch (form1.What_in_comboBox())
            {
                case "Karta tematu pracy dyplomowej inżynierskiej":
                    Karta_tematu karta_Tematu = new Karta_tematu();
                    karta_Tematu.kierunek = ((TextBox)this.Controls["KierunektextBox"]).Text;
                    karta_Tematu.studia_w_zakresie = ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text;
                    karta_Tematu.tytuł_pracy = ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text;
                    karta_Tematu.profil_studiów = ((TextBox)this.Controls["Profil_studiówtextBox"]).Text;
                    karta_Tematu.forma_studiów = ((TextBox)this.Controls["Forma_studiówtextBox"]).Text;
                    karta_Tematu.poziom_studiów = ((TextBox)this.Controls["Poziom_studiówtextBox"]).Text;
                    karta_Tematu.student1_imie_album_data = ((TextBox)this.Controls["Student_1textBox"]).Text;
                    karta_Tematu.student2_imie_album_data = ((TextBox)this.Controls["Student_2textBox"]).Text;
                    karta_Tematu.student3_imie_album_data = ((TextBox)this.Controls["Student_3textBox"]).Text;
                    karta_Tematu.student4_imie_album_data = ((TextBox)this.Controls["Student_4textBox"]).Text;
                    karta_Tematu.tytuł_po_ang = ((TextBox)this.Controls["Tytuł_pracy_po_angielskutextBox"]).Text;
                    karta_Tematu.dane_wejściowe = ((TextBox)this.Controls["Dane_wejściowetextBox"]).Text;
                    karta_Tematu.zakres_pracy = ((TextBox)this.Controls["Zakres_pracytextBox"]).Text;
                    karta_Tematu.termin_oddania = ((TextBox)this.Controls["Termin_oddaniatextBox"]).Text;
                    karta_Tematu.promotor = ((TextBox)this.Controls["PromotortextBox"]).Text;
                    karta_Tematu.jedn_org_promotora = ((TextBox)this.Controls["Jednostka_organizacyjna_promotoratextBox"]).Text;

                    xmlSerializer = new XmlSerializer(typeof(Karta_tematu));
                    using (var writer = new StreamWriter("Karta_tematu.xml"))
                    {
                        xmlSerializer.Serialize(writer, karta_Tematu);
                        MessageBox.Show("Zapisano plik Karta_tematu.xml");

                    }

                    break;
                case "Opinia Promotora - praca inżynierska":
                    Opinia opinia_p = new Opinia();
                    opinia_p.kierunek = ((TextBox)this.Controls["KierunektextBox"]).Text;
                    opinia_p.studia_w_zakresie = ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text;
                    opinia_p.tytuł_pracy = ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text;
                    opinia_p.imie_nazwisko = ((TextBox)this.Controls["Imię_i_nazwisko_dyplomantatextBox"]).Text;
                    opinia_p.r_lub_p = ((TextBox)this.Controls["Imię_i_nazwisko_promotoratextBox"]).Text;
                    opinia_p.jednostka = ((TextBox)this.Controls["Jednostka_organizacyjna_promotoratextBox"]).Text;
                    opinia_p.ocena_słowo = ((TextBox)this.Controls["Ocena_słownatextBox"]).Text;
                    opinia_p.ocena_liczba = ((TextBox)this.Controls["Ocena_liczbowatextBox"]).Text;
                    opinia_p.nr_albumu = ((TextBox)this.Controls["Numer_albumutextBox"]).Text;
                    xmlSerializer = new XmlSerializer(typeof(Opinia));
                    using(var writer = new StreamWriter("Opinia_promotora.xml"))
                    {
                        xmlSerializer.Serialize(writer, opinia_p);
                        MessageBox.Show("Zapisano plik Opinia_promotora.xml");

                    }
                    break;
                case "Opinia Recenzenta - praca inżynierska":
                    Opinia opinia_r = new Opinia();
                    opinia_r.kierunek = ((TextBox)this.Controls["KierunektextBox"]).Text;
                    opinia_r.studia_w_zakresie = ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text;
                    opinia_r.tytuł_pracy = ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text;
                    opinia_r.imie_nazwisko = ((TextBox)this.Controls["Imię_i_nazwisko_dyplomantatextBox"]).Text;
                    opinia_r.r_lub_p = ((TextBox)this.Controls["Imię_i_nazwisko_recenzentatextBox"]).Text;
                    opinia_r.jednostka = ((TextBox)this.Controls["Jednostka_organizacyjna_promotoratextBox"]).Text;
                    opinia_r.ocena_słowo = ((TextBox)this.Controls["Ocena_słownatextBox"]).Text;
                    opinia_r.ocena_liczba = ((TextBox)this.Controls["Ocena_liczbowatextBox"]).Text;
                    opinia_r.nr_albumu = ((TextBox)this.Controls["Numer_albumutextBox"]).Text;

                    xmlSerializer = new XmlSerializer(typeof(Opinia));
                    using (var writer = new StreamWriter("Opinia_recenzenta.xml"))
                    {
                        xmlSerializer.Serialize(writer, opinia_r);
                        MessageBox.Show("Zapisano plik Opinia_recenzenta.xml");

                    }
                    break;

                case "Protokół komisji egzaminu dyplomowego inżynierskiego":
                    Formularz_protokołu formularz_Protokołu = new Formularz_protokołu();
                    formularz_Protokołu.kierunek = ((TextBox)this.Controls["KierunektextBox"]).Text;
                    formularz_Protokołu.studia_w_zakresie = ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text;
                    formularz_Protokołu.tytuł_pracy = ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text;
                    formularz_Protokołu.imie_nazwisko = ((TextBox)this.Controls["Imię_i_nazwisko_dyplomantatextBox"]).Text;
                    formularz_Protokołu.data_narodzin = ((TextBox)this.Controls["Data_narodzin_dyplomantatextBox"]).Text;
                    formularz_Protokołu.miejsce_narodzin = ((TextBox)this.Controls["Miejsce_narodzin_dyplomantatextBox"]).Text;
                    formularz_Protokołu.data_egz = ((TextBox)this.Controls["Data_przeprowadzenia_egzaminutextBox"]).Text;
                    formularz_Protokołu.nr_albumu = ((TextBox)this.Controls["Numer_albumutextBox"]).Text;
                    formularz_Protokołu.profil = ((TextBox)this.Controls["Profil_studiówtextBox"]).Text;
                    formularz_Protokołu.forma = ((TextBox)this.Controls["Forma_studiówtextBox"]).Text;
                    formularz_Protokołu.poziom = ((TextBox)this.Controls["Poziom_studiówtextBox"]).Text;
                    formularz_Protokołu.data_rozp = ((TextBox)this.Controls["Data_rozpoczęcia_studiówtextBox"]).Text;
                    formularz_Protokołu.ocena_pracy = ((TextBox)this.Controls["Ocena_pracytextBox"]).Text;
                    formularz_Protokołu.ocena_mowy = ((TextBox)this.Controls["Ocena_odpowiedzi_ustnejtextBox"]).Text;
                    formularz_Protokołu.ocena_pytań = ((TextBox)this.Controls["Ocena_poprawności_odpowiedzi_na_zadane_pytaniatextBox"]).Text;

                    xmlSerializer = new XmlSerializer(typeof(Formularz_protokołu));
                    using (var writer = new StreamWriter("Formularz_protokołu.xml"))
                    {
                        xmlSerializer.Serialize(writer, formularz_Protokołu);
                        MessageBox.Show("Zapisano plik Formularz_protokołu.xml");

                    }

                    break;
            }
        }

        protected void button2_Click(object Sender, EventArgs e)
        {
            XmlSerializer xmlSerializer;
            switch (form1.What_in_comboBox())
            {
                case "Karta tematu pracy dyplomowej inżynierskiej":
                    Karta_tematu karta_Tematu = new Karta_tematu();

                    try
                    {
                        xmlSerializer = new XmlSerializer(typeof(Karta_tematu));
                        using (var reader = new StreamReader("Karta_tematu.xml"))
                        {
                            karta_Tematu = (Formularz.Karta_tematu)xmlSerializer.Deserialize(reader);
                            MessageBox.Show("Wczytano plik Karta_tematu.xml");

                        }

                        ((TextBox)this.Controls["KierunektextBox"]).Text = karta_Tematu.kierunek;
                        ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text = karta_Tematu.studia_w_zakresie;
                        ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text = karta_Tematu.tytuł_pracy;
                        ((TextBox)this.Controls["Profil_studiówtextBox"]).Text = karta_Tematu.profil_studiów;
                        ((TextBox)this.Controls["Forma_studiówtextBox"]).Text = karta_Tematu.forma_studiów;
                        ((TextBox)this.Controls["Poziom_studiówtextBox"]).Text = karta_Tematu.poziom_studiów;
                        ((TextBox)this.Controls["Student_1textBox"]).Text = karta_Tematu.student1_imie_album_data;
                        ((TextBox)this.Controls["Student_2textBox"]).Text = karta_Tematu.student2_imie_album_data;
                        ((TextBox)this.Controls["Student_3textBox"]).Text = karta_Tematu.student3_imie_album_data;
                        ((TextBox)this.Controls["Student_4textBox"]).Text = karta_Tematu.student4_imie_album_data;
                        ((TextBox)this.Controls["Tytuł_pracy_po_angielskutextBox"]).Text = karta_Tematu.tytuł_po_ang;
                        ((TextBox)this.Controls["Dane_wejściowetextBox"]).Text = karta_Tematu.dane_wejściowe;
                        ((TextBox)this.Controls["Zakres_pracytextBox"]).Text = karta_Tematu.zakres_pracy;
                        ((TextBox)this.Controls["Termin_oddaniatextBox"]).Text = karta_Tematu.termin_oddania;
                        ((TextBox)this.Controls["PromotortextBox"]).Text = karta_Tematu.promotor;
                        ((TextBox)this.Controls["Jednostka_organizacyjna_promotoratextBox"]).Text = karta_Tematu.jedn_org_promotora;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie ma takiego pliku!");
                    }

                    break;
                case "Opinia Promotora - praca inżynierska":
                    Opinia opinia_p = new Opinia();

                    try
                    {
                        xmlSerializer = new XmlSerializer(typeof(Opinia));
                        using (var reader = new StreamReader("Opinia_promotora.xml"))
                        {
                            opinia_p = (Formularz.Opinia)xmlSerializer.Deserialize(reader);
                            MessageBox.Show("Wczytano plik Opinia_promotora.xml");

                        }

                        ((TextBox)this.Controls["KierunektextBox"]).Text = opinia_p.kierunek;
                        ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text = opinia_p.studia_w_zakresie;
                        ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text = opinia_p.tytuł_pracy;
                        ((TextBox)this.Controls["Imię_i_nazwisko_dyplomantatextBox"]).Text = opinia_p.imie_nazwisko;
                        ((TextBox)this.Controls["Imię_i_nazwisko_promotoratextBox"]).Text = opinia_p.r_lub_p;
                        ((TextBox)this.Controls["Jednostka_organizacyjna_promotoratextBox"]).Text = opinia_p.jednostka;
                        ((TextBox)this.Controls["Ocena_słownatextBox"]).Text = opinia_p.ocena_słowo;
                        ((TextBox)this.Controls["Ocena_liczbowatextBox"]).Text = opinia_p.ocena_liczba;
                        ((TextBox)this.Controls["Numer_albumutextBox"]).Text = opinia_p.nr_albumu;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie ma takiego pliku!");
                    }

                    break;
                case "Opinia Recenzenta - praca inżynierska":
                    Opinia opinia_r = new Opinia();
                    try
                    {
                        xmlSerializer = new XmlSerializer(typeof(Opinia));
                        using (var reader = new StreamReader("Opinia_recenzenta.xml"))
                        {
                            opinia_r = (Formularz.Opinia)xmlSerializer.Deserialize(reader);
                            MessageBox.Show("Wczytano plik Opinia_recenzenta.xml");

                        }

                        ((TextBox)this.Controls["KierunektextBox"]).Text = opinia_r.kierunek;
                        ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text = opinia_r.studia_w_zakresie;
                        ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text = opinia_r.tytuł_pracy;
                        ((TextBox)this.Controls["Imię_i_nazwisko_dyplomantatextBox"]).Text = opinia_r.imie_nazwisko;
                        ((TextBox)this.Controls["Imię_i_nazwisko_recenzentatextBox"]).Text = opinia_r.r_lub_p;
                        ((TextBox)this.Controls["Jednostka_organizacyjna_promotoratextBox"]).Text = opinia_r.jednostka;
                        ((TextBox)this.Controls["Ocena_słownatextBox"]).Text = opinia_r.ocena_słowo;
                        ((TextBox)this.Controls["Ocena_liczbowatextBox"]).Text = opinia_r.ocena_liczba;
                        ((TextBox)this.Controls["Numer_albumutextBox"]).Text = opinia_r.nr_albumu;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Nie ma takiego pliku!");
                    }

                    break;

                case "Protokół komisji egzaminu dyplomowego inżynierskiego":
                    Formularz_protokołu formularz_Protokołu = new Formularz_protokołu();
                    try
                    {
                        xmlSerializer = new XmlSerializer(typeof(Formularz_protokołu));
                        using (var reader = new StreamReader("Formularz_protokołu.xml"))
                        {
                            formularz_Protokołu = (Formularz.Formularz_protokołu)xmlSerializer.Deserialize(reader);
                            MessageBox.Show("Wczytano plik Opinia.xml");

                        }

                        ((TextBox)this.Controls["KierunektextBox"]).Text = formularz_Protokołu.kierunek;
                        ((TextBox)this.Controls["Studia_w_zakresietextBox"]).Text = formularz_Protokołu.studia_w_zakresie;
                        ((TextBox)this.Controls["Tytuł_pracy_inżynierskiejtextBox"]).Text = formularz_Protokołu.tytuł_pracy;
                        ((TextBox)this.Controls["Imię_i_nazwisko_dyplomantatextBox"]).Text = formularz_Protokołu.imie_nazwisko;
                        ((TextBox)this.Controls["Data_narodzin_dyplomantatextBox"]).Text = formularz_Protokołu.data_narodzin;
                        ((TextBox)this.Controls["Miejsce_narodzin_dyplomantatextBox"]).Text = formularz_Protokołu.miejsce_narodzin;
                        ((TextBox)this.Controls["Data_przeprowadzenia_egzaminutextBox"]).Text = formularz_Protokołu.data_egz;
                        ((TextBox)this.Controls["Numer_albumutextBox"]).Text = formularz_Protokołu.nr_albumu;
                        ((TextBox)this.Controls["Profil_studiówtextBox"]).Text = formularz_Protokołu.profil;
                        ((TextBox)this.Controls["Forma_studiówtextBox"]).Text = formularz_Protokołu.forma;
                        ((TextBox)this.Controls["Poziom_studiówtextBox"]).Text = formularz_Protokołu.poziom;
                        ((TextBox)this.Controls["Data_rozpoczęcia_studiówtextBox"]).Text = formularz_Protokołu.data_rozp;
                        ((TextBox)this.Controls["Ocena_pracytextBox"]).Text = formularz_Protokołu.ocena_pracy;
                        ((TextBox)this.Controls["Ocena_odpowiedzi_ustnejtextBox"]).Text = formularz_Protokołu.ocena_mowy;
                        ((TextBox)this.Controls["Ocena_poprawności_odpowiedzi_na_zadane_pytaniatextBox"]).Text = formularz_Protokołu.ocena_pytań;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie ma takiego pliku!");
                    }

                    break;
            }
        }


    }
}
