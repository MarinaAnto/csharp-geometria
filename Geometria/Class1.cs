using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        //Attributi
        private int baseRettangolo;
        private int altezzaRettangolo;
        //Costruttore
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }
        //Metodi
        public int CalcolaArea()
        {
            int risultato = baseRettangolo * altezzaRettangolo;
            return risultato;
        }
        public int CalcolaPerimetro()
        {
            int ris = 2 * (baseRettangolo + altezzaRettangolo);
            return ris;
        }
        public void Stampa(int baseRettangolo,int altezzaRettangolo)
        {
           Console.WriteLine("Base: " + baseRettangolo+" cm" + "\nAltezza: " + altezzaRettangolo+" cm"+ "\nArea: " + CalcolaArea()+" cm^2" + "\nPerimetro: " +CalcolaPerimetro()+" cm");
        }
    }
}



