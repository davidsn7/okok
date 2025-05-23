using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestiune_Cinematograf
{
    public partial class FormAfisareFilme : Form
    {
        private AdministrareFilme adminFilme;

        public FormAfisareFilme()
        {
            InitializeComponent();

            adminFilme = new AdministrareFilme("filme.txt");

            cmbLimba.DataSource = Enum.GetValues(typeof(Limba));
            cmbLimba.DropDownStyle = ComboBoxStyle.DropDownList;

            clbOptiuni.Items.Clear();
            foreach (var optiune in Enum.GetValues(typeof(OptiuniFilm)))
            {
                clbOptiuni.Items.Add(optiune);
            }

            rb2D.Checked = true; 

            AfiseazaFilme(adminFilme.GetListaFilme());
        }

        private class FilmAfisat
        {
            public int ID { get; set; }
            public string Titlu { get; set; }
            public int Durata { get; set; }
            public string Gen { get; set; }
            public string Descriere { get; set; }
            public string Regizor { get; set; }
            public string Limba { get; set; }
            public string Optiuni { get; set; }
            public string Format { get; set; }
        }

        private bool ValidareCampuriFilm(out int durata)
        {
            bool valid = true;
            durata = 0;

            
            ResetareErori();

            if (string.IsNullOrWhiteSpace(txtTitlu.Text))
            {
                txtTitlu.BackColor = Color.Red;
                lblEroareTitlu.Text = "Titlul este obligatoriu.";
                lblEroareTitlu.Visible = true;
                valid = false;
            }

            if (!int.TryParse(txtDurata.Text.Trim(), out durata))
            {
                txtDurata.BackColor = Color.Red;
                lblEroareDurata.Text = "Durata trebuie sa fie un numar intreg.";
                lblEroareDurata.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtRegizor.Text))
            {
                txtRegizor.BackColor = Color.Red;
                lblEroareRegizor.Text = "Regizorul este obligatoriu.";
                lblEroareRegizor.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtGen.Text))
            {
                txtGen.BackColor = Color.Red;
                lblEroareGen.Text = "Genul este obligatoriu.";
                lblEroareGen.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescriere.Text))
            {
                txtDescriere.BackColor = Color.Red;
                lblEroareDescriere.Text = "Descrierea este obligatorie.";
                lblEroareDescriere.Visible = true;
                valid = false;
            }

            return valid;
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            pnlAdaugare.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AfiseazaFilme(adminFilme.GetListaFilme());
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string regizor = txtCauta.Text.Trim();
            var rezultate = adminFilme.CautaFilmDupaRegizor(regizor);
            AfiseazaFilme(rezultate);
        }

        private void btnAdauga1_Click(object sender, EventArgs e)
        {
            if (!ValidareCampuriFilm(out int durata))
                return;

            int id = adminFilme.GetListaFilme().Count + 1;
            string titlu = txtTitlu.Text.Trim();
            string regizor = txtRegizor.Text.Trim();
            string gen = txtGen.Text.Trim();
            string descriere = txtDescriere.Text.Trim();
            Limba limba = (Limba)cmbLimba.SelectedItem;

            OptiuniFilm optiuni = OptiuniFilm.Fara_optiuni;
            foreach (var item in clbOptiuni.CheckedItems)
            {
                optiuni |= (OptiuniFilm)item;
            }

            FormatFilm format = rb2D.Checked ? FormatFilm.D2 : FormatFilm.D3;

            Film filmNou = new Film(id, titlu, durata, regizor, gen, descriere, limba, optiuni, format);
            adminFilme.AdaugaFilm(filmNou);

            MessageBox.Show("Filmul a fost adaugat!");

            txtTitlu.Clear();
            txtRegizor.Clear();
            txtDurata.Clear();
            txtGen.Clear();
            txtDescriere.Clear();
            cmbLimba.SelectedIndex = 0;
            for (int i = 0; i < clbOptiuni.Items.Count; i++)
                clbOptiuni.SetItemChecked(i, false);
            rb2D.Checked = true;

            pnlAdaugare.Visible = false;
            AfiseazaFilme(adminFilme.GetListaFilme());

        }


        private void AfiseazaFilme(List<Film> filme)
        {
            var listaAfisata = new List<FilmAfisat>();

            foreach (var f in filme)
            {
                listaAfisata.Add(new FilmAfisat
                {
                    ID = f.Id,
                    Titlu = f.Titlu,
                    Durata = f.Durata,
                    Gen = f.Gen,
                    Descriere = f.DescriereFilm,
                    Regizor = f.Regizor,
                    Limba = f.Limba.ToString(),
                    Optiuni = f.Optiuni.ToString(),
                    Format = f.Format.ToString()
                });
            }

            dgvFilme.DataSource = null;
            dgvFilme.DataSource = listaAfisata;
        
        }
        

        private void btnModificaFilm_Click(object sender, EventArgs e)
        {
            if (dgvFilme.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza un film din tabel.");
                return;
            }

            if (!ValidareCampuriFilm(out int durata))
                return;

            int id = Convert.ToInt32(dgvFilme.SelectedRows[0].Cells["ID"].Value);

            string titlu = txtTitlu.Text.Trim();
            string regizor = txtRegizor.Text.Trim();
            string gen = txtGen.Text.Trim();
            string descriere = txtDescriere.Text.Trim();
            Limba limba = (Limba)cmbLimba.SelectedItem;

            OptiuniFilm optiuni = OptiuniFilm.Fara_optiuni;
            foreach (var opt in clbOptiuni.CheckedItems)
                optiuni |= (OptiuniFilm)opt;

            FormatFilm format = rb2D.Checked ? FormatFilm.D2 : FormatFilm.D3;

            Film filmModificat = new Film(id, titlu, durata, regizor, gen, descriere, limba, optiuni, format);
            adminFilme.ActualizeazaFilm(filmModificat);

            AfiseazaFilme(adminFilme.GetListaFilme());
            MessageBox.Show("Filmul a fost actualizat.");
            pnlAdaugare.Visible = false;
        }


        
        

        private void dgvFilme_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilme.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvFilme.SelectedRows[0];

            txtTitlu.Text = row.Cells["Titlu"].Value.ToString();
            txtDurata.Text = row.Cells["Durata"].Value.ToString();
            txtGen.Text = row.Cells["Gen"].Value.ToString();
            txtDescriere.Text = row.Cells["Descriere"].Value.ToString();
            txtRegizor.Text = row.Cells["Regizor"].Value.ToString();

            cmbLimba.SelectedItem = Enum.Parse(typeof(Limba), row.Cells["Limba"].Value.ToString());

            for (int i = 0; i < clbOptiuni.Items.Count; i++)
                clbOptiuni.SetItemChecked(i, false);

            string[] optiuniSelectate = row.Cells["Optiuni"].Value.ToString().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string optiune in optiuniSelectate)
            {
                for (int i = 0; i < clbOptiuni.Items.Count; i++)
                {
                    if (clbOptiuni.Items[i].ToString() == optiune)
                        clbOptiuni.SetItemChecked(i, true);
                }
            }

            if (row.Cells["Format"].Value.ToString() == "D2")
                rb2D.Checked = true;
            else
                rb3D.Checked = true;

            pnlAdaugare.Visible = true;
        }

        private void ResetareErori()
        {

            txtTitlu.BackColor = SystemColors.Window;
            txtDurata.BackColor = SystemColors.Window;
            txtRegizor.BackColor = SystemColors.Window;
            txtGen.BackColor = SystemColors.Window;
            txtDescriere.BackColor = SystemColors.Window;


            lblEroareTitlu.Visible = false;
            lblEroareDurata.Visible = false;
            lblEroareRegizor.Visible = false;
            lblEroareGen.Visible = false;
            lblEroareDescriere.Visible = false;
        }
    }
}
