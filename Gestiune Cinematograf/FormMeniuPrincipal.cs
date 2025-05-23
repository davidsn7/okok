using System;
using System.Windows.Forms;

namespace Gestiune_Cinematograf
{
    public partial class FormMeniuPrincipal : Form
    {
        private bool esteAdmin = false;

        public FormMeniuPrincipal()
        {
            InitializeComponent();

            
            btnFilme.Visible = false;
            btnSali.Visible = false;
            btnProiectii.Visible = false;
            btnRezervari.Visible = false;
            btnIesire.Visible = false;
        }

        private void btnAlegeAdmin_Click(object sender, EventArgs e)
        {
            esteAdmin = true;
            AfiseazaMeniuAdmin();
        }

        private void btnAlegeUtilizator_Click(object sender, EventArgs e)
        {
            esteAdmin = false;
            AfiseazaMeniuUtilizator();
        }

        private void AfiseazaMeniuAdmin()
        {
            btnAlegeAdmin.Visible = false;
            btnAlegeUtilizator.Visible = false;

            btnFilme.Text = "Gestionare Filme";
            btnFilme.Visible = true;
            btnSali.Visible = true;
            btnProiectii.Visible = true;
            btnRezervari.Visible = false;
            btnIesire.Visible = true;
        }

        private void AfiseazaMeniuUtilizator()
        {
            btnAlegeAdmin.Visible = false;
            btnAlegeUtilizator.Visible = false;

            btnFilme.Text = "Vezi Filme și Proiectii";
            btnFilme.Visible = true;
            btnSali.Visible = false;
            btnProiectii.Visible = false;
            btnRezervari.Visible = false;
            btnIesire.Visible = true;
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            if (esteAdmin)
                new FormAfisareFilme().ShowDialog();
            else
                new FormAfisareProiectiiUtilizator().ShowDialog();
        }

        private void btnSali_Click(object sender, EventArgs e)
        {
            new FormAfisareSali().ShowDialog();
        }

        private void btnProiectii_Click(object sender, EventArgs e)
        {
            new FormAfisareProiectiiAdmin().ShowDialog();
        }

        private void btnRezervari_Click(object sender, EventArgs e)
        {
            new FormRezervare().ShowDialog();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
