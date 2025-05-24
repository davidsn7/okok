using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestiune_Cinematograf
{
    public partial class FormAfisareSali : Form
    {
        private AdministrareSali adminSali;

        private class SalaAfisata
        {
            public int ID { get; set; }
            public string Denumire { get; set; }
            public int Capacitate { get; set; }
            public string Tip { get; set; }
            public string Dotari { get; set; }
        }

        public FormAfisareSali()
        {
            InitializeComponent();

            adminSali = new AdministrareSali("sali.txt");


            cmbTipSala.DataSource = Enum.GetValues(typeof(TipSala));
            cmbTipSala.DropDownStyle = ComboBoxStyle.DropDownList;


            clbDotari.Items.Clear();
            foreach (var dotare in Enum.GetValues(typeof(DotariSala)))
                clbDotari.Items.Add(dotare);

            dgvSali.ReadOnly = true;
            dgvSali.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSali.AllowUserToAddRows = false;


            AfiseazaSali(adminSali.GetListaSali());
        }

        private void btnAdaugaSala_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                MessageBox.Show("Introduceti denumirea salii.");
                return;
            }

            if (!int.TryParse(txtCapacitate.Text.Trim(), out int capacitate) || capacitate <= 0)
            {
                MessageBox.Show("Capacitatea trebuie sa fie un numar intreg pozitiv.");
                return;
            }

            TipSala tip = (TipSala)cmbTipSala.SelectedItem;

            DotariSala dotari = DotariSala.Nimic;
            foreach (var item in clbDotari.CheckedItems)
                dotari |= (DotariSala)item;

            int id = adminSali.GetListaSali().Count + 1;
            Sala salaNoua = new Sala(id, txtDenumire.Text.Trim(), capacitate, tip, dotari);

            adminSali.AdaugaSala(salaNoua);
            MessageBox.Show("Sala a fost adaugata.");

            AfiseazaSali(adminSali.GetListaSali());

            txtDenumire.Clear();
            txtCapacitate.Clear();
            cmbTipSala.SelectedIndex = 0;
            for (int i = 0; i < clbDotari.Items.Count; i++)
                clbDotari.SetItemChecked(i, false);
        }

        private void AfiseazaSali(List<Sala> sali)
        {
            dgvSali.DataSource = null;

            List<SalaAfisata> saliAfisate = new List<SalaAfisata>();

            foreach (var s in sali)
            {
                SalaAfisata afisata = new SalaAfisata
                {
                    ID = s.Id,
                    Denumire = s.Denumire,
                    Capacitate = s.Capacitate,
                    Tip = s.Tip.ToString(),
                    Dotari = s.Dotari.ToString()
                };

                saliAfisate.Add(afisata);
            }

            dgvSali.DataSource = saliAfisate;
        }
    }
}
