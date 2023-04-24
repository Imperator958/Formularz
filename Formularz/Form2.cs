using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form2)
        {
            InitializeComponent();
            this.form1 = form2;
            switch (form1.What_in_comboBox())
            {
                case "Karta tematu pracy dyplomowej inżynierskiej":
                    break;
                case "Opinia Promotora - praca inżynierska":
                    break;
                case "Opinia Recenzenta - praca inżynierska":
                    break;
                case "Protokół komisji egzaminu dyplomowego inżynierskiego":
                    break;
                default:
                    MessageBox.Show("Nie wybrano formularza");
                    form1.Close();
                    break;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
