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
    public partial class Ucenici : Form
    {
        PodatkovniKontekst kontekst;
        public Ucenici(PodatkovniKontekst kontekst)
        {
            InitializeComponent();
            this.kontekst = kontekst;
        }

        private void Ucenici_Load(object sender, EventArgs e)
        {

            OsvjeziUcenike();
        }

        private void OsvjeziUcenike()
        {
            Helper.PrikaziListuUListBoxu<Ucenik>(this.kontekst.Ucenici, lbUcenici);


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DetaljiUcenika detaljiUcenika = new DetaljiUcenika();

            if (detaljiUcenika.ShowDialog() == DialogResult.OK)
            {
                this.kontekst.DodajUcenika(detaljiUcenika.Ucenik);
                OsvjeziUcenike();
            }
        }
    }
}
