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
    public partial class FormAfisareProiectiiUtilizator: Form
    {
        private AdministrareProiectii adminProiectii;
        private AdministrareRezervari adminRezervari;
        private List<Proiectie> toateProiectiile;


        public FormAfisareProiectiiUtilizator()
        {
            InitializeComponent();

            var filme = new AdministrareFilme("filme.txt").GetListaFilme();
            var sali = new AdministrareSali("sali.txt").GetListaSali();

            adminProiectii = new AdministrareProiectii("proiectii.txt", filme, sali);
            adminRezervari = new AdministrareRezervari("rezervari.txt", adminProiectii.GetListaProiectii());

            cmbCategorieSociala.DataSource = Enum.GetValues(typeof(CategorieSociala));

            toateProiectiile = adminProiectii.GetListaProiectii();
            AfiseazaProiectii(toateProiectiile);
        }

        private void AfiseazaProiectii(List<Proiectie> proiectii)
        {
            lvProiectii.Items.Clear();
            lvProiectii.Columns.Clear();

            lvProiectii.Columns.Add("ID", 40);
            lvProiectii.Columns.Add("Titlu", 120);
            lvProiectii.Columns.Add("Regizor", 100);
            lvProiectii.Columns.Add("Sala", 80);
            lvProiectii.Columns.Add("Ora", 60);
            lvProiectii.Columns.Add("Zi", 80);
            lvProiectii.Columns.Add("Locuri", 100);
            lvProiectii.Columns.Add("Pret", 60);

            foreach (Proiectie p in proiectii)
            {
                int locuriOcupate = 0;
                foreach (Rezervare r in adminRezervari.GetListaRezervari())
                {
                    if (r.Proiectie.Id == p.Id)
                        locuriOcupate++;
                }

                ListViewItem item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.Film.Titlu);
                item.SubItems.Add(p.Film.Regizor);
                item.SubItems.Add(p.Sala.Denumire);
                item.SubItems.Add(p.OraProiectiei);
                item.SubItems.Add(p.Zi.ToString());
                item.SubItems.Add(locuriOcupate + "/" + p.Sala.Capacitate);
                item.SubItems.Add(p.PretBilet.ToString("0.00") + " lei");

                item.Tag = p;
                lvProiectii.Items.Add(item);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string titlu = txtCautaTitlu.Text.Trim().ToLower();
            string regizor = txtCautaRegizor.Text.Trim().ToLower();

            List<Proiectie> rezultate = new List<Proiectie>();

            foreach (Proiectie p in toateProiectiile)
            {
                if (p.Film.Titlu.ToLower().Contains(titlu) &&
                    p.Film.Regizor.ToLower().Contains(regizor))
                {
                    rezultate.Add(p);
                }
            }

            AfiseazaProiectii(rezultate);
        }

        

        private void btnRezerva_Click(object sender, EventArgs e)
        {
            if (lvProiectii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectează o proiecție.");
                return;
            }

            Proiectie p = (Proiectie)lvProiectii.SelectedItems[0].Tag;
            CategorieSociala categorie = (CategorieSociala)cmbCategorieSociala.SelectedItem;

            FormRezervare f = new FormRezervare(p, categorie, adminRezervari);
            f.ShowDialog();

            AfiseazaProiectii(toateProiectiile);

        }

        private void lvProiectii_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategorieSociala_SelectedIndexChanged(sender, e);
        }

        private void cmbCategorieSociala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProiectii.SelectedItems.Count == 0)
            {
                lblPretFinal.Text = "Pret final: —";
                return;
            }

            Proiectie p = (Proiectie)lvProiectii.SelectedItems[0].Tag;
            CategorieSociala categorie = (CategorieSociala)cmbCategorieSociala.SelectedItem;

            double pretFinal = Rezervare.CalculeazaReducere(p.PretBilet, categorie);
            lblPretFinal.Text = "Pret final: " + pretFinal.ToString("0.00") + " lei";
        }
        }

        
}

