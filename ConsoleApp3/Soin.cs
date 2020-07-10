using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soin
    {
        private int code;
        private string libelle;
        private int codeTarif;
        public static int PointTarif = 12;

        public int Code
        {
            get
            { return this.code; }
            set
            { this.code = value; }
        }
        public string Libelle
        {
            get
            { return this.libelle; }
            set
            { this.libelle = value; }
        }
        public int CodeTarif
        {
            get
            { return this.codeTarif; }
            set
            { this.codeTarif = value; }
        }
        //constructeur  
        public Soin(int leCode, string leLibelle, int leCodeTarif)
        {
            this.code = leCode;
            this.libelle = leLibelle;
            this.codeTarif = leCodeTarif;
        }
        //calcul du coût de base du soin
        public virtual  double Couter()
        {
            Console.WriteLine("couter de soin");
            return this.CodeTarif * Soin.PointTarif; }
        //  
        public override string ToString()
        {
            return "Code du soin : " + this.code + ", " + this.libelle + " avec le code tarif: " + this.codeTarif + " avec un coût de point de " + Soin.PointTarif;
        }
    }
}
