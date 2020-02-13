using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenProvjeraZnanjaZadatak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DodajNovogStudenta.ActiveForm.Activate();
        }

        private void ButtonObrisi_Click(object sender, EventArgs e)
        {
            listBoxNovi.ClearSelected();
        }

        private void ButtonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxNovi.ClearSelected();
        }
    }
}
