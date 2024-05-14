using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KnjiznicaFR.Model
{
    public class PodatkovniKontekst
    {
        public List<Ucenik> Ucenici;
        public List<Knjiga> Knjige;
        public List<Posudba> Posudbe;

        private string datUcenici = "ucenici.txt";
        private string datKnjige = "knjige.txt";
        public PodatkovniKontekst()
        {
            Ucenici = UcitajUcenike();
            Knjige = UcitajKnjige();
        }

        public void DodajKnjigu(Knjiga knjiga)
        {
            this.Knjige.Add(knjiga);
            SpremiKnjige();
        }

        public void BrisiKnjigu(Knjiga knjiga)
        {
            this.Knjige.Remove(knjiga);
            SpremiKnjige();
        }

        public void DodajUcenika(Ucenik ucenik)
        {
            this.Ucenici.Add(ucenik);
            SpremiUcenike();
        }

        public void ObrisiUcenika(Ucenik ucenik)
        {
            this.Ucenici.Remove(ucenik);
            SpremiUcenike();
        }

        public List<Knjiga> UcitajKnjige()
        {
            List<Knjiga> rezultat = new List<Knjiga>();

            if (File.Exists(datKnjige))
            {
                using (StreamReader sr = new StreamReader(datKnjige))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        Knjiga trenutnaKnjiga = new Knjiga();
                        string[] polja = linija.Split('|');
                        trenutnaKnjiga.ISBN = polja[0];
                        trenutnaKnjiga.Autor = polja[1];
                        trenutnaKnjiga.Naslov = polja[2];
                        trenutnaKnjiga.GodinaIzdanja = int.Parse(polja[3]);
                        trenutnaKnjiga.BrojPrimjeraka = int.Parse(polja[4]);

                        rezultat.Add(trenutnaKnjiga);
                    }
                }
            }
            return rezultat;
        }
        public void SpremiKnjige()
        {
            using (StreamWriter sw = new StreamWriter(datKnjige))
            {
                foreach (Knjiga k in this.Knjige)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}", k.ISBN, k.Autor,
                        k.Naslov, k.GodinaIzdanja, k.BrojPrimjeraka);
                }
            }
        }

        public List<Ucenik> UcitajUcenike()
        {
            List<Ucenik> rezultat = new List<Ucenik>();

            if (File.Exists(datUcenici))
            {
                using(StreamReader sr = new StreamReader(datUcenici))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        Ucenik trenutniUcenik = new Ucenik();
                        string[] polja = linija.Split('|');
                        trenutniUcenik.OIB = polja[0];
                        trenutniUcenik.Ime = polja[1];
                        trenutniUcenik.Prezime = polja[2];
                        trenutniUcenik.Adresa = polja[3];
                        trenutniUcenik.Telefon = polja[4];
                        trenutniUcenik.Razred = int.Parse(polja[5]);

                        rezultat.Add(trenutniUcenik);
                    }
                }
            }
            return rezultat;
        }
        public void SpremiUcenike()
        {
            using(StreamWriter sw = new StreamWriter(datUcenici))
            {
                foreach (Ucenik trenutniUcenik in this.Ucenici)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", trenutniUcenik.OIB, trenutniUcenik.Ime,
                        trenutniUcenik.Prezime, trenutniUcenik.Adresa, trenutniUcenik.Telefon,
                        trenutniUcenik.Razred);
                }
            }
        }
    }
}
