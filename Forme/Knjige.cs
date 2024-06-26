﻿using KnjiznicaFR.Model;
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
    public partial class Knjige : Form
    {

        public PodatkovniKontekst kontekst;
        public Knjige(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if(lbKnjige.SelectedItem == null)
            {
                MessageBox.Show("Select a book");
            }
            else
            {
                DetaljiKnjige detaljiKnjige = new DetaljiKnjige();
                detaljiKnjige.Knjiga = (Knjiga)lbKnjige.SelectedItem;
                if (detaljiKnjige.ShowDialog() == DialogResult.OK)
                {
                    this.kontekst.SpremiKnjige();
                    OsvjeziKnjige();
                }
            }
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            OsvjeziKnjige();
        }

        private void OsvjeziKnjige()
        {
            Helper.PrikaziListuUListBoxu<Knjiga>(this.kontekst.Knjige, lbKnjige);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DetaljiKnjige detaljiKnjige = new DetaljiKnjige();
            if(detaljiKnjige.ShowDialog() == DialogResult.OK)
            {
                this.kontekst.DodajKnjigu(detaljiKnjige.Knjiga);
                OsvjeziKnjige();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbKnjige.SelectedItem == null)
            {
                MessageBox.Show("Select a book");
            }
            else
            {
                this.kontekst.BrisiKnjigu((Knjiga)lbKnjige.SelectedItem);
                OsvjeziKnjige();
            }
        }
    }
}
