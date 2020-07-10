using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Patient
    {
        private string nom;
        private string prenom;
        private int num;
        public static int numListe = 0;
        private List<Soin> collLesSoins = new List<Soin>();
        //a compléter  ??!!??


        //accesseurs à compléter !!??? pour num seulement le Guetter, l'accesseur
        public string Nom
        {
            get
            { return this.nom; }
            set
            { this.nom = value; }
        }
        public string Prenom
        {
            get
            { return this.prenom; }
            set
            { this.prenom = value; }
        }
        public int Num
        {
            get
            { return this.num; }
            set
            { this.num = value; }
        }
        //constructeur à compléter !!???
        public Patient(string unNom, string unPrenom)
        {
            nom = unNom;
            prenom = unPrenom;
            num = numListe;
            numListe++;
        }
        // ajouter un soin à la liste des soins

        public void AjouterSoin(Soin leSoin)
        {
            collLesSoins.Add(leSoin);
        }
        //calcul du montant total des soins à payer par le patient
        // a completer
        public double Facturer()
        {
            double total = 0;
            foreach (Soin ssoin in collLesSoins)
            {
                total += ssoin.Couter();
            }
            return total;
        }
        // A compléter
        public override string ToString()
        {
            return nom + " " + prenom + " de numero à recu : " + collLesSoins.Count + " de soins.";
        }
        public void Afficher()
        {
            foreach (Soin afficher_soin in collLesSoins)
            {
                Console.WriteLine(afficher_soin);
            }
        }
    }
}

