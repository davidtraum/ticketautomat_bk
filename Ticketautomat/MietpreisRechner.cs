using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketautomat
{
    class MietpreisRechner
    {
        private double preisTag, preisKm,tage,km;
        public MietpreisRechner()
        {
        }

        public void setzePreisProTag(double pPreis)
        {
            this.preisTag = pPreis;
        }

        public void setzePreisProKm(double pPreis)
        {
            this.preisKm = pPreis;
        }

        public void setzeTage(double pTage)
        {
            this.tage = pTage;
        }

        public void setzeKm(double pKm)
        {
            this.km = pKm;
            
        }

        public double berechnePreis()
        {
            return this.tage * this.preisTag + this.km * this.preisKm;
        }
    }
}
