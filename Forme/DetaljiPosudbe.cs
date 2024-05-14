using KnjiznicaFR.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnjiznicaFR.Forme
{
    public partial class DetaljiPosudbe : Form
    {

        public PodatkovniKontekst kontekst;
        public Posudba Posudba;
        public DetaljiPosudbe(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DetaljiPosudbe_Load(object sender, EventArgs e)
        {
            OsvjeziUcenike();
            OsvjeziKnjige();


            if(this.Posudba != null)
            {
                lbUcenici.SelectedItem = this.Posudba.Ucenik;
                lbKnjige.SelectedItem = this.Posudba.Knjiga;
                dtpDatum.Value = this.Posudba.DatumPosudbe;
                nudBrojDana.Value = this.Posudba.BrojDana;
                
            }
        }
        private void OsvjeziUcenike()
        {
            Helper.PrikaziListuUListBoxu<Ucenik>(this.kontekst.Ucenici, lbUcenici);

        }

        private void OsvjeziKnjige()
        {
            Helper.PrikaziListuUListBoxu<Knjiga>(this.kontekst.Knjige, lbKnjige);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lbUcenici.SelectedItem == null || lbKnjige.SelectedItem == null)
            {
                MessageBox.Show("Please select a student and a book ");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if(this.Posudba == null)
                {
                    this.Posudba = new Posudba();
                }
                this.Posudba.Ucenik = (Ucenik)lbUcenici.SelectedItem;
                this.Posudba.Knjiga = (Knjiga)lbKnjige.SelectedItem;
                this.Posudba.DatumPosudbe = dtpDatum.Value;
                this.Posudba.BrojDana = (int)nudBrojDana.Value;

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
