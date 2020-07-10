using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class SoinEsthetique : Soin
    {
        private string zoneCorps;
        private double duree;//en heures

        //accesseurs à compléter

        public string ZoneCorps
        {
            get
            { return this.zoneCorps; }
            set
            { this.zoneCorps = value; }
        }
        public double Duree
        {
            get
            { return this.duree; }
            set
            { this.duree = value; }
        }
        //constructeur à compléter
        public SoinEsthetique(int leCode, string leLibelle, int leCodeTarif, string laZoneCorps, double laDuree) : base(leCode, leLibelle, leCodeTarif)
        {
            this.zoneCorps = laZoneCorps;
            this.duree = laDuree;
        }
        //calcul du coût de base du soin
        public override double Couter()
        {
            Console.WriteLine("couter de soinEsthetique");
            return base.Couter() + (0.2 * this.duree * Soin.PointTarif); }
        //  
        public override string ToString()
        {
            return base.ToString() + " pour la zone du corps " + this.zoneCorps + " durant " + this.duree + " heure";
        }
    }
}
