using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketautomat_Test
{
    class Ticket
    {
        private string description;
        private double price;
        private int ticketNumber;
        private double paid = 0;

        public Ticket(int pTicketNumber, double pPrice, string pDescription)
        {
            this.ticketNumber = pTicketNumber;
            this.price = pPrice;
            this.description = pDescription;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string pDescription)
        {
            this.description = pDescription;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public int getTicketNumber()
        {
            return this.ticketNumber;
        }

        public void pay(double amount)
        {
            this.paid += amount;
        }

        public double getPaid()
        {
            return this.paid;
        }
    }
}
