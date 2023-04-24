namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Wybór.Items.Add("Karta tematu pracy dyplomowej in¿ynierskiej");
            Wybór.Items.Add("Opinia Promotora - praca in¿ynierska");
            Wybór.Items.Add("Opinia Recenzenta - praca in¿ynierska");
            Wybór.Items.Add("Protokó³ komisji egzaminu dyplomowego in¿ynierskiego");
        }

        private void Forma_Click(object sender, EventArgs e)
        {
         
        }

        private void ZatwierdŸ_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public string What_in_comboBox()
        {
            return Wybór.Text;
        }
    }
}