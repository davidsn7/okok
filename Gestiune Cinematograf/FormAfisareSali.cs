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

        public FormAfisareSali()
        {
            InitializeComponent();

            adminSali = new AdministrareSali("sali.txt");

            
            cmbTipSala.DataSource = Enum.GetValues(typeof(TipSala));
            cmbTipSala.DropDownStyle = ComboBoxStyle.DropDownList;

            
            clbDotari.Items.Clear();
            foreach (var dotare in Enum.GetValues(typeof(DotariSala)))
                clbDotari.Items.Add(dotare);

            
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
            lvSali.Items.Clear();
            lvSali.Columns.Clear();

            lvSali.Columns.Add("ID", 40);
            lvSali.Columns.Add("Denumire", 120);
            lvSali.Columns.Add("Capacitate", 80);
            lvSali.Columns.Add("Tip", 80);
            lvSali.Columns.Add("Dotari", 150);

            foreach (var sala in sali)
            {
                ListViewItem item = new ListViewItem(sala.Id.ToString());
                item.SubItems.Add(sala.Denumire);
                item.SubItems.Add(sala.Capacitate.ToString());
                item.SubItems.Add(sala.Tip.ToString());
                item.SubItems.Add(sala.Dotari.ToString());

                lvSali.Items.Add(item);
            }
        }
    }
}
