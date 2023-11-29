using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    internal class Zrakoplov
    {
        string Naziv;
        double SnagaMotora;
        int DosegLeta;

        public void setNaziv(string Naziv)
        {
            this.Naziv = Naziv;
        }

        public string getNaziv()
        {
            return Naziv;   
        }
        public void getSnagaMotora(double SnagaMotora)
        {
            this.SnagaMotora = SnagaMotora;
        }

        public double getSnagaMotora()
        {
            return SnagaMotora;
        }
        public void getDosegLeta(int DosegLeta)
        {
            this.DosegLeta = DosegLeta; 
        }

        public int getDosegLeta()
        {
            return DosegLeta;
        }

        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            Naziv = naziv;
            SnagaMotora = snagaMotora;
            DosegLeta = dosegLeta;
        }
        public override string ToString()
        {
            string ispis = "Naziv " + getNaziv() + " Snaga Motora: " + getSnagaMotora() + " Doseg Leta: " + getDosegLeta();
            return ispis;
        }
    }
}
