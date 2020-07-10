using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Sébastien", "Patrick");
            Soin soin1 = new Soin(1, "Soin des jambes", 15);
            SoinTherapeutique soin2 = new SoinTherapeutique(2, "piqure", 15,3);
            SoinEsthetique soin3 = new SoinEsthetique(3, "Soin des mains", 12, "les mains",0.5);

            patient1.AjouterSoin(soin1);
            patient1.AjouterSoin(soin2);
            patient1.AjouterSoin(soin3);
            Console.WriteLine(patient1+" "+patient1.Facturer());
            patient1.Afficher();
            Console.ReadLine();
        }
    }
}
