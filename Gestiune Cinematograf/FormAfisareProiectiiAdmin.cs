using NivelStocareDate;
using System;
using LibrarieModele;
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
    public partial class FormAfisareProiectiiAdmin: Form
    {
        private AdministrareProiectii adminProiectii;
        private List<Film> filme;
        private List<Sala> sali;

        public FormAfisareProiectiiAdmin()
        {
            InitializeComponent();

            filme = new AdministrareFilme("filme.txt").GetListaFilme();
            sali = new AdministrareSali("sali.txt").GetListaSali();
            adminProiectii = new AdministrareProiectii("proiectii.txt", filme, sali);

            cmbFilme.DataSource = filme;
            cmbFilme.DisplayMember = "Titlu";

            cmbSali.DataSource = sali;
            cmbSali.DisplayMember = "Denumire";

            cmbZi.DataSource = Enum.GetValues(typeof(ZiuaSaptamanii));
            cmbZi.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpOraProiectiei.Format = DateTimePickerFormat.Time;
            dtpOraProiectiei.ShowUpDown = true;

            AfiseazaProiectii(adminProiectii.GetListaProiectii());
        }

        private void btnAdaugaProiectie_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPret.Text.Trim(), out double pret) || pret <= 0)
            {
                MessageBox.Show("Pretul introdus nu este valid.");
                return;
            }

            Film film = (Film)cmbFilme.SelectedItem;
            Sala sala = (Sala)cmbSali.SelectedItem;
            ZiuaSaptamanii zi = (ZiuaSaptamanii)cmbZi.SelectedItem;
            string ora = dtpOraProiectiei.Value.ToString("HH:mm");

            foreach (var p in adminProiectii.GetListaProiectii())
            {
                if (p.Sala.Id == sala.Id && p.Zi == zi)
                {
                    TimeSpan oraNoua = TimeSpan.Parse(ora);
                    TimeSpan oraExistenta = TimeSpan.Parse(p.OraProiectiei);
                    int durataFilm = film.Durata;

                    if (Math.Abs((oraNoua - oraExistenta).TotalMinutes) < durataFilm)
                    {
                        MessageBox.Show("In acea sala ruleaza deja un film la acea ora sau in intervalul apropiat.");
                        return;
                    }
                }

            }

            int idNou = adminProiectii.GetListaProiectii().Count + 1;
            var proiectieNoua = new Proiectie(idNou, film, sala, ora, zi, TipAccesProiectie.Nimic, pret);
            adminProiectii.AdaugaProiectie(proiectieNoua);
            MessageBox.Show("Proiectia a fost adaugata cu succes!");

            AfiseazaProiectii(adminProiectii.GetListaProiectii());

            cmbFilme.SelectedIndex = 0;
            cmbSali.SelectedIndex = 0;
            cmbZi.SelectedIndex = 0;
            txtPret.Clear();
        }

        private void AfiseazaProiectii(List<Proiectie> proiectii)
        {
            dgvProiectii.DataSource = null;

            var proiectiiAfisate = proiectii.Select(p => new
            {
                ID = p.Id,
                Film = p.Film.Titlu,
                Sala = p.Sala.Denumire,
                Ora = p.OraProiectiei,
                Zi = p.Zi.ToString(),
                Pret = p.PretBilet.ToString("0.00") + " lei"
            }).ToList();

            dgvProiectii.DataSource = proiectiiAfisate;
        }
    }
}



