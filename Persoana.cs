using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LabOriginal2
{
    [DefaultPropertyAttribute("Nume")]
    class Persoana
    {
        private int index;
        private string nume;
        private DateTime dataNasteri;
        private string telefon;
        private string adresa;
        private Categorie categorie;

        public Persoana(int index,string nume, DateTime dataNasteri,string telefon, string adresa, Categorie categorie)
        {
            this.index = index;
            this.nume = nume;
            this.dataNasteri = dataNasteri;
            this.telefon = telefon;
            this.adresa = adresa;  
            this.categorie = categorie;
        }
        [Description("Index"),Browsable(false)]
        public int Index { get { return index; } }
        [Description("Nume complet al persoanei"), Category("date personale")]
        public string Nume { get { return nume; } }

        [Description("Data nasteri"), Category("date personale")]
        public string DataNasteri { get { return dataNasteri.ToString("dd.MM.yyyy"); } }

        [Description("Cateogrie de incadrare"),Category("date personale")]
        public Categorie Categorie { 
            set { categorie = value; } 
            get { return categorie; } 
        }

        [Description("Numar de telefon"), Category("date de contact")]
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        [Description("Adresa "), Category("date de contact")]
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
    }

    enum Categorie : int
    {
        Prieteni,
        Colegi,
        Rude,
        Diversi
    }
}
