using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketautomat
{
    class ProvisionRechner
    {
        private double[] limits = { 20000, 10000, 5000 };
        private double[] provisions = { 0.05, 0.03, 0.01 };

        public double berechneProvision(double betrag)
        {
            int index = 0;
            foreach(double limit in limits)
            {
                if(betrag >= limit)
                {
                    return betrag + betrag * provisions[index]; 
                }
                index++;
            }
            return betrag;
        }
    }
}
