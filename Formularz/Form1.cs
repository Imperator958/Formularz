namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Wyb�r.Items.Add("Karta tematu pracy dyplomowej in�ynierskiej");
            Wyb�r.Items.Add("Opinia Promotora - praca in�ynierska");
            Wyb�r.Items.Add("Opinia Recenzenta - praca in�ynierska");
            Wyb�r.Items.Add("Protok� komisji egzaminu dyplomowego in�ynierskiego");
        }

        private void Forma_Click(object sender, EventArgs e)
        {
         
        }

        private void Zatwierd�_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public string What_in_comboBox()
        {
            return Wyb�r.Text;
        }
    }
}