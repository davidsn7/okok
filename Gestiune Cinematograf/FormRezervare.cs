using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Cinematograf
{
    public partial class FormRezervare: Form
    {
        private Proiectie proiectie;
        private CategorieSociala categorie;
        private AdministrareRezervari adminRezervari;

        public FormRezervare(Proiectie p, CategorieSociala c, AdministrareRezervari admin)
        {
            InitializeComponent();
            proiectie = p;
            categorie = c;
            adminRezervari = admin;

            AfiseazaDetaliiProiectie();
            IncarcaLocuriDisponibile();
        }

        public FormRezervare() : this(null, CategorieSociala.Niciuna, null)
        {
        }


        private void AfiseazaDetaliiProiectie()
        {
            lblFilm.Text = "Film: " + proiectie.Film.Titlu;
            lblSala.Text = "Sala: " + proiectie.Sala.Denumire;
            lblOra.Text = "Ora: " + proiectie.OraProiectiei;
            lblZi.Text = "Ziua: " + proiectie.Zi.ToString();

            double pretFinal = LibrarieModele.Rezervare.CalculeazaReducere(proiectie.PretBilet, categorie);
            lblPretFinal.Text = "Pret final: " + pretFinal.ToString("0.00") + " lei";
        }

        private void IncarcaLocuriDisponibile()
        {
            List<int> locuriOcupate = new List<int>();
            foreach (var r in adminRezervari.GetListaRezervari())
            {
                if (r.Proiectie.Id == proiectie.Id)
                    locuriOcupate.Add(r.Loc);
            }

            cmbLoc.Items.Clear();
            for (int i = 1; i <= proiectie.Sala.Capacitate; i++)
            {
                if (!locuriOcupate.Contains(i))
                    cmbLoc.Items.Add(i);
            }

            if (cmbLoc.Items.Count > 0)
                cmbLoc.SelectedIndex = 0;
            else
            {
                MessageBox.Show("Toate locurile sunt ocupate.");
                this.Close();
            }
        }



        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtNume.Text.Trim() == "")
            {
                MessageBox.Show("Introdu numele clientului.");
                return;
            }

            if (cmbLoc.SelectedItem == null)
            {
                MessageBox.Show("Selectează un loc.");
                return;
            }

            int loc = (int)cmbLoc.SelectedItem;
            var preferinte = PreferinteClient.Nimic;

            if (cbEcran.Checked) preferinte |= PreferinteClient.AproapeDeEcran;
            if (cbMijloc.Checked) preferinte |= PreferinteClient.RandMijloc;
            if (cbAlee.Checked) preferinte |= PreferinteClient.AleeLaterala;
            if (cbIzolat.Checked) preferinte |= PreferinteClient.ScaunIzolat;

            int idNou = adminRezervari.GetListaRezervari().Count + 1;

            var rezervare = new LibrarieModele.Rezervare(
                idNou,
                proiectie,
                txtNume.Text.Trim(),
                loc,
                StatusRezervare.Confirmata,
                preferinte,
                categorie
            );

            adminRezervari.AdaugaRezervare(rezervare);

            MessageBox.Show("Rezervarea a fost realizata cu succes!");
            this.Close();

        }
    }
}
