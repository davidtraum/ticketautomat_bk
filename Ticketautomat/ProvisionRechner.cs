using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketautomat
{
    class ProvisionRechner
    {
        public ProvisionRechner()
        {

        }

        public double berechneProvision(double betrag)
        {
            if(betrag >= 20000)
            {
                return betrag + betrag * 0.05;
            } else if(betrag >= 10000)
            {
                return betrag + betrag * 0.02;
            } else if(betrag >= 5000)
            {
                return betrag + betrag * 0.01;
            }
            return betrag;
        }
    }
}
