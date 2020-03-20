using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Loto_7_39
{
    public partial class FormLoto : Form
    {
        private Loto loto;

        public FormLoto()
        {
            InitializeComponent();
            loto = new Loto();
        }
        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtBroj1.Text);
            vrijednosti.Add(txtBroj2.Text);
            vrijednosti.Add(txtBroj3.Text);
            vrijednosti.Add(txtBroj4.Text);
            vrijednosti.Add(txtBroj5.Text);
            vrijednosti.Add(txtBroj6.Text);
            vrijednosti.Add(txtBroj7.Text);

            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
                btnOdigraj.Enabled = true;
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Kombinacija uplacenih brojeva nije ispravna!");
            }
                   



        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();

            txtDob1.Text = loto.DobitniBrojevi[0].ToString();
            txtDob2.Text = loto.DobitniBrojevi[1].ToString();
            txtDob3.Text = loto.DobitniBrojevi[2].ToString();
            txtDob4.Text = loto.DobitniBrojevi[3].ToString();
            txtDob5.Text = loto.DobitniBrojevi[4].ToString();
            txtDob6.Text = loto.DobitniBrojevi[5].ToString();
            txtDob7.Text = loto.DobitniBrojevi[6].ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();

        }


    }
}
